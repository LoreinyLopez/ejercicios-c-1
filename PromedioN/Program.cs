namespace PromedioN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo del promedio de 5 numero");
            Console.WriteLine();

            int valor1, valor2, valor3, valor4, valor5;
            int suma;

            Console.WriteLine("Ingrese el primer valor");
            valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo valor");
            valor2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el tecer valor");
            valor3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el cuarto valor");
            valor4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el quinto valor");
            valor5 = Convert.ToInt32(Console.ReadLine());

            suma = valor1 + valor2 + valor3 + valor4 + valor5;

            double promediototal = (double)suma / 5;

            Console.WriteLine($"El promedio total es: {promediototal}");

        }
    }
}
