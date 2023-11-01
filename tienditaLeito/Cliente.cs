namespace tienditaLeito
{
    internal class Cliente
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        // Constructor
        public Cliente() 
        {

        }

        public Cliente(string cedula, string nombre, string telefono)
        {
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Telefono = telefono;
        }
    }
}