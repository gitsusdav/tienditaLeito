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
    public partial class controlUsuarios : Form
    {
        private List<Usuario> usuarios;
        private string rutaArchivo;

        public controlUsuarios()
        {
            InitializeComponent();
            usuarios = new List<Usuario>();

            try
            {
                // Lee el contenido del archivo de texto
                rutaArchivo = File.ReadAllText($@"C:\Users\ojito\OneDrive\Documents\Leo Files\rutaUsuarios.txt");
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir al leer el archivo
                Console.WriteLine($"Error al leer el archivo: {ex.Message}");
            }

            try
            {
                string[] lineas = File.ReadAllLines($@"{rutaArchivo}");

                foreach (string linea in lineas.Skip(1))
                {
                    string[] campos = linea.Split(',');

                    if (campos.Length == 3)
                    {
                        string nombreUsuario = campos[0];
                        string contrasena = campos[1];
                        string tipoDeUsuario = campos[2];

                        Usuario nuevoUsuario = new Usuario(nombreUsuario, contrasena, tipoDeUsuario);
                        usuarios.Add(nuevoUsuario);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (Usuario usuario in usuarios)
            {
                if (usuario.TipoDeUsuario == "Cajero")
                {
                    // Agregar una nueva fila al DataGridView
                    int rowIndex = controlDGB.Rows.Add();

                    // Establecer valores en las celdas específicas
                    controlDGB.Rows[rowIndex].Cells["nombreColumn"].Value = usuario.NombreUsuario;
                    controlDGB.Rows[rowIndex].Cells["claveColumn"].Value = usuario.Contrasena;
                }
            }

            controlDGB.Columns["nombreColumn"].ReadOnly = false;
            controlDGB.Columns["claveColumn"].ReadOnly = false;

            /*
            
            controlDGB.Columns.Add("NombreUsuario", "Nombre de Usuario");
            controlDGB.Columns.Add("Contrasena", "Contraseña");
            DataGridViewColumn tipoDeUsuarioColumn = new DataGridViewTextBoxColumn();
            tipoDeUsuarioColumn.DataPropertyName = "TipoDeUsuario";
            tipoDeUsuarioColumn.Name = "TipoDeUsuario";
            tipoDeUsuarioColumn.Visible = false;  // Configura la visibilidad como false
            controlDGB.Columns.Add(tipoDeUsuarioColumn);
            
            */

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear una nueva lista para almacenar los usuarios que no son cajeros
            List<Usuario> nuevosUsuarios = new List<Usuario>();

            // Iterar sobre la lista original y agregar a la nueva lista los usuarios que no son cajeros
            foreach (var usuario in usuarios)
            {
                if (usuario.TipoDeUsuario != "Cajero")
                {
                    nuevosUsuarios.Add(usuario);
                }
            }

            // Ahora puedes agregar los nuevos usuarios al final de la lista
            foreach (DataGridViewRow row in controlDGB.Rows)
            {
                if (!row.IsNewRow)  // Evitar la fila nueva sin confirmar
                {
                    string nombreUsuario = row.Cells["nombreColumn"].Value.ToString();
                    string contrasena = row.Cells["claveColumn"].Value.ToString();

                    Usuario usuario = new Usuario(nombreUsuario, contrasena, "Cajero");
                    nuevosUsuarios.Add(usuario);
                }
            }

            // Asignar la nueva lista a la lista original
            usuarios = nuevosUsuarios;

            try
            {
                // Guardar la información actualizada en el archivo CSV
                using (StreamWriter sw = new StreamWriter(rutaArchivo))
                {
                    // Escribir encabezados al archivo CSV
                    sw.WriteLine("Nombre de usuario,Clave,Tipo de usuario");

                    // Escribir información actualizada de productos al archivo CSV
                    foreach (var usuario in usuarios)
                    {
                        sw.WriteLine($"{usuario.NombreUsuario},{usuario.Contrasena},{usuario.TipoDeUsuario}");
                    }
                }

                MessageBox.Show("Usuarios guardados correctamente en el archivo CSV, cambios se aplicaran al reiniciar el programa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar usuarios en el archivo CSV: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void controlDGB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtener la fila actual
            DataGridViewRow row = controlDGB.Rows[e.RowIndex];

            if (e.ColumnIndex == controlDGB.Columns["eliminarImage"].Index && e.RowIndex >= 0 && row !=null && !row.IsNewRow)
            {
                // Eliminar la fila
                controlDGB.Rows.Remove(row);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
