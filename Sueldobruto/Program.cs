using System;

namespace Sueldoenbruto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular el sueldo bruto");
            Console.WriteLine();


            int pagohoras, horastrabajadas, sueldobruto;
            const double Afp = 2.87;
            const double Sfs = 3.04;
            double sumadescuento = Afp + Sfs;



            Console.WriteLine("Ingrese el pago por hora");
            pagohoras = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese las horas trabajadas");
            horastrabajadas = Convert.ToInt32(Console.ReadLine());

            sueldobruto = pagohoras * horastrabajadas;

            double descuento = sueldobruto * (sumadescuento / 100);

            double sueldoNeto = sueldobruto - descuento;


            Console.WriteLine($"El sueldo bruto es: {sueldobruto}");
            Console.WriteLine($"El descuento total (AFP + SFS) es: {descuento}");
            Console.WriteLine($"El sueldo neto es: {sueldoNeto}");

        }
    }
}
