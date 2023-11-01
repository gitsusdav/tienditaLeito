using System.Collections.Generic;

namespace tienditaLeito
{
    internal class Producto
    {
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public bool Iva { get; set; }
        public string Codigo { get; set; }

        public Producto() 
        {

        }

        public Producto(string nombre, int cantidad, decimal precioUnitario, bool iva, string codigo)
        {
            Nombre = nombre;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
            Iva = iva;
            Codigo = codigo;
        }
    }
}