using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Threading;

namespace tienditaLeito
{
    public partial class Caja : Form
    {
        private List<Producto> productos;
        private List<Cliente> clientes;
        private decimal sumaTotal;
        private bool nuevoCliente;
        private bool clienteEncontrado;
        private string rutaArchivoClientes;
        private string rutaArchivoProductos;

        public Caja()
        {
            InitializeComponent();

            dataGridViewProductos.ReadOnly = true;
            clientes = new List<Cliente>();
            productos = new List<Producto>();
            sumaTotal = 0;
            nuevoCliente = false;
            clienteEncontrado = false;

            try
            {
                // Lee el contenido del archivo de texto
                rutaArchivoClientes = File.ReadAllText(@"C:\Users\ojito\OneDrive\Documents\Leo Files\rutaClientes.txt").TrimEnd();
                rutaArchivoProductos = File.ReadAllText(@"C:\Users\ojito\OneDrive\Documents\Leo Files\rutaProductos.txt").TrimEnd();
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir al leer el archivo
                Console.WriteLine($"Error al leer el archivo: {ex.Message}");
            }

         
            
                string[] lineasClientes = File.ReadAllLines(rutaArchivoClientes);
              
         
                foreach (string linea in lineasClientes.Skip(1))
                {
                if (linea != "")
                {
                    string[] valores = linea.Split(',');
                    Cliente cliente = new Cliente();
                    cliente.Cedula = valores[0];
                    cliente.Nombre = valores[1];
                    cliente.Telefono = valores[2];
                    clientes.Add(cliente);
                }
                }




            string[] lineasProductos = File.ReadAllLines(rutaArchivoProductos);

                foreach (string linea in lineasProductos.Skip(1))
                {
                    string[] valores = linea.Split(',');
                    Producto producto = new Producto();

                    producto.Nombre = valores[0];
                    producto.Cantidad = int.Parse(valores[1]);
                    producto.PrecioUnitario = decimal.Parse(valores[2]);
                    producto.Iva = bool.Parse(valores[3]);
                    producto.Codigo = valores[4];

                    productos.Add(producto);
                }
        }

        private void caja_Load(object sender, EventArgs e)
        {

        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            string codigoIngresado = codigoTB.Text;
            Producto productoEncontrado = null;

            // Buscar el producto en la lista por su código
            foreach (Producto producto in productos)
            {
                if (producto.Codigo == codigoIngresado && producto.Cantidad >0)
                {
                    productoEncontrado = producto;
                    break;
                }
            }

            if (productoEncontrado != null)
            {
                AgregarProductoAlGridView(productoEncontrado);
            }
            else
            {
                MessageBox.Show("Producto no disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarProductoAlGridView(Producto producto)
        {

            int cantidad = Convert.ToInt32(cantidadTB.Text);

            if (producto.Cantidad >= cantidad)
            {
                decimal precioTotal = cantidad * producto.PrecioUnitario;
                string ivaColumna = "";

                if (producto.Iva)
                {
                    precioTotal *= 1.16m; // Asumiendo un IVA del 12%
                    ivaColumna = "16%";
                }

                else
                {
                    ivaColumna = "0%";
                }

                // Agregar fila al DataGridView
                dataGridViewProductos.Rows.Add(
                    producto.Nombre,
                    cantidad,
                    producto.PrecioUnitario,
                    ivaColumna,
                    precioTotal,
                    producto.Codigo
                );

                sumaTotal += precioTotal;
                producto.Cantidad -= cantidad;

                // Actualizar el Label con la nueva suma total
                totalLabel.Text = $"Total: {sumaTotal:C}";
            }
            else
            {
                MessageBox.Show("No hay suficiente stock");
            }
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            try
            {
               
                    foreach (Cliente cliente in clientes)
                    {
                      if (cedulaTB.Text == cliente.Cedula)
                        {
                        nombreTB.Text = cliente.Nombre;
                        telefonoTB.Text = cliente.Telefono;
                        nuevoCliente = false;
                        clienteEncontrado = true;
                        break; // Terminar la búsqueda una vez que se encuentra el cliente
                        }
                    }

                    if(!clienteEncontrado)
                    {
                     AvisoCrearCliente();
                    }

                }

            catch(Exception)
            {
                MessageBox.Show("Exepcion");

            }

            
        }

        private void AvisoCrearCliente()
        {
            MessageBox.Show("Se creara un cliente nuevo");
            nuevoCliente = true;

        }

        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewProductos.Columns["eliminarImage"].Index)
            {
                DataGridViewRow row = dataGridViewProductos.Rows[e.RowIndex];

                // Verificar si la fila no está vacía antes de intentar eliminarla
                if (dataGridViewProductos.Rows[e.RowIndex].Cells != null && !row.IsNewRow)
                {
                    sumaTotal -= Convert.ToDecimal(row.Cells["precioTotalColumn"].Value);
                    string codigo = dataGridViewProductos.Rows[e.RowIndex].Cells["codigoColumn"].Value.ToString();
                    int cantidad = Convert.ToInt32(dataGridViewProductos.Rows[e.RowIndex].Cells["cantidadColumn"].Value);
                    reStock(codigo, cantidad);
                    dataGridViewProductos.Rows.RemoveAt(e.RowIndex);
                    totalLabel.Text = $"Total: {sumaTotal:C}";

                }
            }
        }

        private void reStock(string codigo, int cantidad)
        {
            foreach (Producto producto in productos)
            {
                if (codigo == producto.Codigo)
                {
                    producto.Cantidad = producto.Cantidad + cantidad;
                    break;
                }
            }
        }

        private void facturarButton_Click(object sender, EventArgs e)
        {
            if (nuevoCliente)
            {
                CrearCliente();
                AjustarProductos();
                GenerarFactura();
               
            }

            else 
            {
                ModificarCliente();
                AjustarProductos();
                GenerarFactura();
            }

            nuevoCliente = false;
            
        }

        private void ModificarCliente()
        {
            string cedulaBuscada = cedulaTB.Text;

            // Buscar el cliente en la lista por su cédula
            foreach (Cliente cliente in clientes)
            {
                if (cliente.Cedula == cedulaBuscada)
                {
                    // Modificar las propiedades del cliente
                    cliente.Nombre = nombreTB.Text;
                    cliente.Telefono = telefonoTB.Text;

                    // Mensaje de éxito
                    MessageBox.Show("Cliente modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    break;
                }
                break;
            }

            // Si el código llega aquí, significa que no se encontró el cliente
            MessageBox.Show("Cliente no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            try
            {
                // Borrar todo el contenido del archivo
                File.WriteAllText(rutaArchivoClientes, string.Empty);

                // Escribir encabezados al archivo CSV
                File.AppendAllText(rutaArchivoClientes, "Cedula,Nombre,Telefono" + Environment.NewLine);

                // Escribir información actualizada de clientes al archivo CSV
                foreach (Cliente cliente in clientes)
                {
                    File.AppendAllText(rutaArchivoClientes, $"{cliente.Cedula},{cliente.Nombre},{cliente.Telefono}" + Environment.NewLine);
                }


                MessageBox.Show("Clientes actualizados correctamente en el archivo CSV.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar clientes en el archivo CSV: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AjustarProductos()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(rutaArchivoProductos))
                {
                    // Escribir encabezados al archivo CSV
                    sw.WriteLine("Nombre,Cantidad,PrecioUnitario,Iva,Codigo");

                    // Escribir información actualizada de productos al archivo CSV
                    foreach (Producto producto in productos)
                    {
                        sw.WriteLine($"{producto.Nombre},{producto.Cantidad},{producto.PrecioUnitario},{producto.Iva},{producto.Codigo}");
                    }
                }

                MessageBox.Show("Productos guardados correctamente en el archivo CSV.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar productos en el archivo CSV: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CrearCliente()
        {
             try
        {
            // Crear el objeto Cliente
            Cliente nuevoCliente = new Cliente(cedulaTB.Text, nombreTB.Text, telefonoTB.Text);

            // Agregar el cliente al archivo 

            using (StreamWriter sw = new StreamWriter(rutaArchivoClientes, true))
            {
                sw.WriteLine($"\n{nuevoCliente.Cedula},{nuevoCliente.Nombre},{nuevoCliente.Telefono}");
            }

            // Mensaje de éxito
            MessageBox.Show("Cliente creado y agregado correctamente al archivo CSV.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error al crear y agregar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        }

        private void GenerarFactura()
        {
            // Crear el archivo PDF
            // Leer todo el contenido del archivo y almacenarlo en una cadena
            string contenidoArchivo = File.ReadAllText($@"C:\Users\ojito\OneDrive\Documents\pdfCULEO\contador.txt");
            int contador = Convert.ToInt32(contenidoArchivo);
            contador++;
            File.WriteAllText($@"C:\Users\ojito\OneDrive\Documents\pdfCULEO\contador.txt", string.Empty);
            // Pegar el número en el archivo
            File.WriteAllText($@"C:\Users\ojito\OneDrive\Documents\pdfCULEO\contador.txt", contador.ToString());

            using (FileStream fs = new FileStream($"C:/Users/ojito/OneDrive/Documents/pdfCULEO/factura{contador}.pdf", FileMode.Create))
            {
                Document doc = new Document(PageSize.LETTER, 5, 5, 7, 7);
                PdfWriter pw = PdfWriter.GetInstance(doc, fs);

                doc.Open();

                // Título y autor
                doc.AddAuthor("Leonardo");
                doc.AddTitle("PDF Generado");

                Paragraph tituloFactura = new Paragraph("FACTURA");
                tituloFactura.Alignment = Element.ALIGN_LEFT;
                doc.Add(tituloFactura);

                // Agregar el contenido del DataGridView
                PdfPTable table = new PdfPTable(dataGridViewProductos.ColumnCount);
                table.WidthPercentage = 100;


                // Agregar encabezados de columnas
                foreach (DataGridViewColumn column in dataGridViewProductos.Columns)
                {
                    table.AddCell(column.HeaderText);
                }

                // Agregar filas y celdas
                foreach (DataGridViewRow row in dataGridViewProductos.Rows)
                {
                    if (!row.IsNewRow)  // Verificar si la fila no es nueva
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            // Verificar si la celda no es null antes de intentar acceder a su valor
                            if (cell.Value != null)
                            {
                                table.AddCell(cell.Value.ToString());
                            }
                            else
                            {
                                // Puedes manejar la situación donde la celda es null, por ejemplo, agregando un valor predeterminado.
                                table.AddCell("N/A");
                            }
                        }
                    }
                }

                // Agregar la tabla al documento
                doc.Add(table);

                /*// Agregar encabezados de columnas
                foreach (DataGridViewColumn column in dataGridViewProductos.Columns)
                {
                    table.AddCell(column.HeaderText);
                }

                // Agregar filas y celdas
                foreach (DataGridViewRow row in dataGridViewProductos.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        table.AddCell(cell.Value.ToString());
                    }
                }

                // Agregar la tabla al documento
                doc.Add(table);*/

                // Otros detalles, como título, autor, fecha, etc.
                // Agregar nombre del cliente
                Paragraph nombreCliente = new Paragraph($"Nombre del Cliente: {nombreTB.Text}");
                nombreCliente.Alignment = Element.ALIGN_LEFT;
                doc.Add(nombreCliente);

                // Agregar total
                Paragraph total = new Paragraph($"{totalLabel.Text}");
                total.Alignment = Element.ALIGN_LEFT;
                doc.Add(total);

                doc.Add(new Paragraph($"Fecha de generación: {DateTime.Now}"));



                // Cerrar el documento
                doc.Close();

                MessageBox.Show("PDF generado con éxito.");
            }
        }
        

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Logo_Click_1(object sender, EventArgs e)
        {

        }
    }
}
