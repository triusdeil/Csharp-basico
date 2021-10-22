using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int pisos = 0;
            int[] arreglo = new int [1];
            //se envia un mensaje y se captura el dato enviado por la consola
            Console.WriteLine("Ingrese el numero de pisos");
            pisos = Convert.ToInt16(Console.ReadLine());

            /*se declara el primer ciclo for que va a recorrer dependiendo el 
            dato ingresado que esta almacenado en la variable pisos*/

            for (int i = 1; i <= pisos; i++)
            {
                /*colocamos un arreglo y colocamos la variable i del ciclo for
                 que sera el tamaño que tendra el arreglo cada vez que el ciclo for
                se ejecute*/
                int[] pascal = new int[i];
                //Ciclo for que decrementa para formar el triangulo
                for (int j = pisos; j < i; j--)
                {
                    Console.WriteLine(" ");
                }
                //Ciclo for que genera la sumas de las cifras
                for (int k = 0; k < i; k++)
                {
                    //condicion que evalua la variable del ciclo for
                    if(k == 0 || k == (i - 1))
                    {
                        pascal[k]=1;
                    }
                    else
                    {
                        //Sumamos los numeros que estan en cada posicion
                        //del arreglo para formar el triangulo
                        pascal[k] = arreglo[k] + arreglo[k - 1];
                    }
                    Console.Write("["+ pascal[k] + "]");
                }
                arreglo = pascal;
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }
    }
}
