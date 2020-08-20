using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideGame4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Nrandom, type;
            int left = 13;
            Random generador = new Random(); Nrandom = generador.Next(1, 10001);
            Console.WriteLine("Te quedan {0} intentos", left);
            Console.Write("Introduce un número: ");
            type = Convert.ToInt32(Console.ReadLine());
            //Bucle que se repite hasta que acierte o se quede sin intentos
            while ((type != Nrandom) && (left > 1))
            {
                left = left - 1;
                if (type < Nrandom) Console.WriteLine("¡INTENTA UN NUMERO MAS ALTO!");
                if (type > Nrandom) Console.WriteLine("¡INTENTA UN NUMERO MAS CHICO!");
                Console.WriteLine("TE QUEDAN {0} INTENTOS", left);
                Console.Write("INTRODUCE UN NUEVO NUMERO: ");
                type = Convert.ToInt32(Console.ReadLine());
                //Comprobar si gana o pierde
            }
            if (type == Nrandom) Console.WriteLine("¡¡¡GANASTE!!!");
            else
            {
                Console.WriteLine("PERDISTE UWU!"); Console.WriteLine("EL NUMERO ERA:  {0}", Nrandom);
            }

            Console.ReadKey();



        }
    }
}
