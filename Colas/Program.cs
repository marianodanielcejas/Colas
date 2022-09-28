using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Colas
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool verdad = true;
            string Vacio = "";
            Queue <string> cola  = new Queue <string>();
            while (verdad)
            {
                Console.WriteLine("Ingresa un dato alfanúmerico");
                string Dato = Console.ReadLine();
                if (Dato == Vacio)
                {
                    verdad = false;
                }
                else
                {
                    cola.Enqueue(Dato);
                }
            }
            while(cola.Count > 0)
            {
                string dato = cola.Dequeue();
                Console.WriteLine(dato);
            }

           
            //Queue cola = new Queue();
            //cola.Enqueue(20);
            //cola.Enqueue(10);
            //cola.Enqueue(5);

            //while(cola.Count > 0)
            //{
            //int dato = (int)cola.Dequeue();
            //El primero que entra es el primero que sale
            //Console.WriteLine(dato);
            //}
        }
    }
}
