namespace Importe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Importe de un articulo");
            Console.WriteLine();

            double preciomonetario,importe;
            int cantidad;

            Console.WriteLine("Ingrese el precio del articulo");

            preciomonetario = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Ingrese la cantidad del articulo");


            cantidad = Convert.ToInt32(Console.ReadLine());

            importe = preciomonetario * cantidad;

            Console.WriteLine($"El importe es: {importe}");
        }
    }
}
