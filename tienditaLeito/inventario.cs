using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace tienditaLeito
{
    public partial class inventario : Form
    {
        List<Producto> productos;
        private string rutaArchivo;

        public inventario()
        {
            InitializeComponent();
            inventarioDGB.RowHeadersVisible = false;
            productos = new List<Producto>();

            try
            {
                // Lee el contenido del archivo de texto
                rutaArchivo = File.ReadAllText(@"C:\Users\ojito\OneDrive\Documents\Leo Files\rutaProductos.txt").TrimEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show("didnt work");
                // Maneja cualquier excepción que pueda ocurrir al leer el archivo
                
            }

            try
            {
                string[] lineasProductos = File.ReadAllLines(rutaArchivo);
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

                foreach (Producto producto in productos)
                {
                    inventarioDGB.Rows.Add(
                        producto.Nombre,
                        producto.PrecioUnitario,
                        producto.Cantidad,
                        producto.Iva,
                        producto.Codigo
                    );
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(rutaArchivo);
            }
        }

        private void inventarioDGB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == inventarioDGB.Columns["eliminarImage"].Index)
            {
                // Obtén la fila que se va a eliminar
                DataGridViewRow row = inventarioDGB.Rows[e.RowIndex];

                // Verifica si la fila no está vacía y no es la fila nueva sin confirmar
                if (row != null && !row.IsNewRow)
                {
                    // Elimina la fila
                    inventarioDGB.Rows.RemoveAt(e.RowIndex);                    
                }
            }
        }

        private void actualizarButton_Click(object sender, EventArgs e)
        {
            // Limpiar la lista de productos
            productos.Clear();

            // Recorrer las filas del DataGridView y agregar cada producto a la lista
            foreach (DataGridViewRow row in inventarioDGB.Rows)
            {
                if (!row.IsNewRow)
                {
                    Producto producto = new Producto
                    {
                        Nombre = row.Cells["nombreColumn"].Value.ToString(),
                        PrecioUnitario = decimal.Parse(row.Cells["precioColumn"].Value.ToString()),
                        Cantidad = int.Parse(row.Cells["cantidadColumn"].Value.ToString()),
                        Iva = Convert.ToBoolean(row.Cells["ivaCheck"].Value),
                        Codigo = row.Cells["codigoColumn"].Value.ToString()
                    };

                    productos.Add(producto);
                }
            }

            // Guardar la lista de productos en el archivo CSV
            try
            {
                // Escribir la información actualizada de productos al archivo CSV
                using (StreamWriter sw = new StreamWriter(rutaArchivo))
                {
                    // Escribir encabezados al archivo CSV
                    sw.WriteLine("Nombre,Precio,Cantidad,Iva,Codigo");

                    // Escribir información actualizada de productos al archivo CSV
                    foreach (Producto producto in productos)
                    {
                        sw.WriteLine($"{producto.Nombre},{producto.PrecioUnitario},{producto.Cantidad},{producto.Iva},{producto.Codigo}");
                    }
                }

                MessageBox.Show("Productos guardados correctamente en el archivo CSV.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar productos en el archivo CSV: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
