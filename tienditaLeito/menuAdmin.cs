using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tienditaLeito
{
    public partial class menuAdmin : Form
    {
        private string rutaArchivo;
        public menuAdmin()
        {
            InitializeComponent();
            rutaArchivo = @"C:\Users\ojito\OneDrive\Documents\Leo Files\rutaProductos.txt";

        }

        private void usuariosButton_Click(object sender, EventArgs e)
        {
            controlUsuarios controlUsuarios = new controlUsuarios();
            this.Hide();
            controlUsuarios.ShowDialog();
            this.Show();
        }

        private void inventarioButton_Click(object sender, EventArgs e)
        {
            inventario inventario = new inventario();
            this.Hide();
            inventario.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Crea un cuadro de diálogo para seleccionar la nueva ruta
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Seleccione el archivo de inventario";
            openFileDialog.Filter = "Archivos CSV|*.csv|Todos los archivos|*.*";

            // Muestra el cuadro de diálogo y verifica si el usuario hizo clic en "Aceptar"
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtiene la nueva ruta seleccionada por el usuario
                string nuevaRutaInventario = openFileDialog.FileName;
                GuardarNuevaRutaEnTxt(nuevaRutaInventario);
            }

            else
            {
                MessageBox.Show("El usuario canceló la selección de archivo.");
            }
        }

        private void GuardarNuevaRutaEnTxt(string nuevaRuta)
        {
            // Ruta del archivo txt donde guardar la nueva ruta
           

            // Escribe la nueva ruta en el archivo txt
            using (StreamWriter sw = new StreamWriter(rutaArchivo))
            {
                sw.WriteLine(nuevaRuta);
            }

            MessageBox.Show("Nueva ruta guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "Seleccione la carpeta de destino para exportar el CSV";
            rutaArchivo = File.ReadAllText(@"C:\Users\ojito\OneDrive\Documents\Leo Files\rutaProductos.txt").TrimEnd();

            // Muestra el cuadro de diálogo y verifica si el usuario hizo clic en "Aceptar"
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtiene la ruta de la carpeta seleccionada por el usuario
                string carpetaDestino = folderBrowserDialog.SelectedPath;

                // Concatena el nombre del archivo CSV al final de la ruta de la carpeta
                string rutaDestinoCSV = Path.Combine(carpetaDestino, "productos.csv");

                try
                {
                    // Copia el archivo CSV a la carpeta de destino
                    File.Copy(rutaArchivo, rutaDestinoCSV, true);

                    MessageBox.Show("CSV exportado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al exportar CSV: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El usuario canceló la selección de carpeta.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
