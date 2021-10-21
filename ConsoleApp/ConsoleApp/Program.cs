using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
        class Program
    {
        static void Main(string[] args)
        {
            /*
            int year = 1997;
            int datos = Convert.ToInt16("12");//podemos convertir datos de tipo entero a string
            bool valor = false;
            bool valor2 = true;
            double doble = 1.5;
            string nombre = "Luis";
            String nombres = "Luis Eduardo";
            decimal decimals = 2.07M;
            float flotante = 2.0F;
            char letra = 'a';//solo puede almacenar 1 solo caracter
            Decimal de = 26.5M;
            Console.WriteLine(nombres + " {0} {1} {2} {3} {4} {5}", year, doble,decimals,flotante, valor, valor2);
            Console.ReadLine();
            // float 7 digitos 32 bits
            // double 15-16 digitos de 64bits
            //decimal 28-29 digitos de 128bits
            */
            /*int valor1 = 4;
            int valor2 = 4;
            var data = valor1 != valor2;
            string name;
            if (data)
            {
                name = "alex";
            }
            else
            {
                name = "luis";
            }

            name = data ? "Alex" : "luis";
            Console.WriteLine("{0}",name);
                Console.ReadLine();*/
            //Array
            string[] cadenas = new string[4];
            cadenas[0] = "Luis";
            cadenas[1] = "Eduardo";
            cadenas[2] = "Ascanio";
            cadenas[3] = "Jimenez";
            string[] name = { "Luis", "Eduardo", "Ascanio", "Jimenez" };
            Console.WriteLine("el resultado es de: {0} {1} {2} {3}", cadenas[0],cadenas[1], cadenas[2], cadenas[3]);
            Console.ReadLine();
        }
    }
}
