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
    public partial class login : Form
    {
        private List<Usuario> usuarios;
        private string rutaArchivo;

        public login()
        {
            InitializeComponent();
            usuarios = new List<Usuario>();

            try
            {
                // Lee el contenido del archivo de texto
                rutaArchivo = File.ReadAllText(@"C:\Users\ojito\OneDrive\Documents\Leo Files\rutaUsuarios.txt");
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

        private void button1_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = usuarioTB.Text;
            string contrasenaIngresada = claveTB.Text;

            // Buscar el usuario de manera explícita sin usar LINQ
            

            foreach (Usuario usuario in usuarios)
            {
                if (usuario.NombreUsuario == usuarioIngresado && usuario.Contrasena == contrasenaIngresada)
                {
                    if (usuario.TipoDeUsuario == "Cajero")
                    {
                        Caja caja = new Caja();
                        this.Hide();
                        caja.ShowDialog();
                        this.Show();
                        break;
                    }

                    else if (usuario.TipoDeUsuario == "Admin")
                    {
                        menuAdmin menuAdmin = new menuAdmin();
                        this.Hide();
                        menuAdmin.ShowDialog();
                        this.Show();
                        break;
                    }
                    else if (usuario.TipoDeUsuario == "Superusuario")
                    {
                        superUser superUser = new superUser();
                        this.Hide();
                        superUser.ShowDialog();
                        this.Show();
                    }

                    else
                    {
                        // El usuario no es válido, mostrar un mensaje de error
                        MessageBox.Show("Credenciales incorrectas. Intente nuevamente.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break; // Terminar la búsqueda una vez que se encuentra el usuario válido
                }
            }

            
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
