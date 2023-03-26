namespace Entidades
{
    public class Productos
    {
        public string Codigo { get; set; }
        public string Descricion { get; set; }
        public int Existencia { get; set; }
        public decimal Precio { get; set; }
        public byte[] Imagen { get; set; }

        public Productos()
        {
        }

        public Productos(string codigo, string descricion, int existencia, decimal precio, byte[] imagen)
        {
            Codigo = codigo;
            Descricion = descricion;
            Existencia = existencia;
            Precio = precio;
            Imagen = imagen;
        }
    }

}
