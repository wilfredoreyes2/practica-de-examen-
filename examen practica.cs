using System;

namespace examen_problema
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("bienbenido al banco FDP INVERTER");
            Console.WriteLine("ingrese banco ");
            string banco = Console.ReadLine();
            Console.WriteLine("su banco es " + banco);
            Console.WriteLine("ingrese nombre completo");
            string nombre = Console.ReadLine();
            Console.WriteLine("bienbenido :" + nombre);
            Console.WriteLine("retiro , porfavor ingrear cnatidad del retiro : ");
            double retiro = Convert.ToInt32(Console.ReadLine());
            if (retiro > 20000)
                Console.WriteLine("monto sobre pasa el limite , maximo 20000");
            else
                Console.WriteLine("espere un segundo ");



            // billetes variables 

            int biletesde1000 = 18000;
            int billetesde500 = 9500;
            int billetesde200 = 4600;
            int billetesde100 = 5000;

            double total = (biletesde1000+billetesde100+billetesde500+billetesde200);



            // salida de billetes 
            double salida;
            total = total - retiro;
            salida = retiro;




          
                if (total <= 0)
            {
                Console.WriteLine("no hay billetes suficientes ");

            }
            else Console.WriteLine("usted a retirado :"+ salida );

            






        }
    }
}
