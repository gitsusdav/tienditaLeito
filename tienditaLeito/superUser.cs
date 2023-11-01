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


namespace tienditaLeito
{
    public partial class superUser : Form
    {
        private List<Usuario> usuarios;
        private string rutaArchivo;

        public superUser()
        {
            InitializeComponent();
            usuarios = new List<Usuario>();

            try
            {
                // Lee el contenido del archivo de texto
                rutaArchivo = @"C:\Users\ojito\OneDrive\Documents\Leo Files\usuarios.csv";
            }

            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir al leer el archivo
                MessageBox.Show($"Error al leer el archivo: {ex.Message}");
            }


            try
            {
                string[] lineas = File.ReadAllLines(rutaArchivo);

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
                    else
                    {
                        MessageBox.Show("Error en csv");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reiniciarButton_Click(object sender, EventArgs e)
        {
            foreach(var usuario in usuarios)
            {
                if (usuario.TipoDeUsuario == "Admin")
                {
                    usuario.Contrasena = "1234";
                }
            }

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

            MessageBox.Show("Clave formateada exitosamente, ahora es 1234", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
            
          }
        }
