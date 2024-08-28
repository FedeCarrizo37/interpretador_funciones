using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interpretador_funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("dame un numero: ");
            int numero = Convert.ToInt32(Console.ReadLine().ToString());

            List<int> divisores = new List<int>();
            divisores = Interprete.CalcularDivisores(numero);

            Console.WriteLine("Divisores de {0}", numero);
            foreach (int i in divisores) 
            { 
                Console.WriteLine(i);
            }
            */

            Console.WriteLine("*************************************");
            Console.Write("ahora dame un polinomio:");
            string polinomio;
            string[] terminos_del_polinomio_array;
            List<string> terminos_del_polinomio_list = new List<string>();
            polinomio = Console.ReadLine().ToString();

            terminos_del_polinomio_array = Interprete.DividirPolinomio1(polinomio);
            Console.WriteLine("division en terminos con metodologia 1: ");
            foreach (string coso in terminos_del_polinomio_array)
            {
                Console.WriteLine("=>" + coso);
            }

            Console.WriteLine("division en terminos con metodologia 2: ");
            terminos_del_polinomio_list = Interprete.DividirPolinomio2(polinomio);
            foreach (string coso in terminos_del_polinomio_list)
            {
                Console.WriteLine("=>" + coso);
            }
            Console.WriteLine("division en terminos con metodologia 2 (sacandole la X): ");
            foreach (string coso in terminos_del_polinomio_list)
            {
                Console.WriteLine("=>" + Interprete.QuitarX(coso));
            }

            Console.ReadKey();
        }
    }
}
