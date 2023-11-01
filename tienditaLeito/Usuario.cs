namespace tienditaLeito
{
    internal class Usuario
    {
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string TipoDeUsuario { get; set; }

        public Usuario() 
        {

        }

        public Usuario(string nombreUsuario, string contrasena, string tipoDeUsuario)
        {
            NombreUsuario = nombreUsuario;
            Contrasena = contrasena;
            TipoDeUsuario = tipoDeUsuario;
        }
    }
}