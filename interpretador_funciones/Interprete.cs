using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interpretador_funciones
{
    public class Interprete
    {
        public static string[] DividirPolinomio1(string polinomio)
        {
            // Dividir el string en términos individuales utilizando los delimitadores "+" y "-"
            string[] terminos = polinomio.Split(new char[] { '+', '-' },StringSplitOptions.RemoveEmptyEntries);

            // Recorrer cada término y eliminar espacios en blanco
            for (int i = 0; i < terminos.Length; i++)
            {
                terminos[i] = terminos[i].Trim();
                Console.WriteLine(terminos.Length);
            }

            return terminos;
        }

        public static List<string> DividirPolinomio2(string polinomio)
        {
            List<string> terminos = new List<string>();
            int char_inicio = 0, char_final = 0, indice_char = 0;
            foreach (char c in polinomio)
            {
                if(c == '+' || c == '-')
                {
                    char_final = indice_char;
                    if(char_inicio != char_final)
                    {
                        terminos.Add(polinomio.Substring(char_inicio, char_final-char_inicio));
                        char_inicio = char_final;
                    }
                }
                indice_char += 1;
                if (indice_char == polinomio.Length) 
                {
                    terminos.Add(polinomio.Substring(char_inicio, polinomio.Length-char_inicio));
                }
            }

            return terminos;
        }

        public static string QuitarX(string termino) 
        {
            string termino_sin_x = "";
            //esto recibe un termino con formato 4x^4 y le quita lo x^4
            if (termino.ToLower().IndexOf("x") != -1)
            {
                termino_sin_x = termino.Substring(0, termino.ToLower().IndexOf("x"));
            }
            else
            {
                termino_sin_x = termino;
            }
            return termino_sin_x;
        }

        public static List<int> CalcularDivisores(int ti)
        {
            List<int> divisores = new List<int>();

            // Calcular divisores
            for (int i = 1; i <= ti; i++)
            {
                if (ti % i == 0)
                {
                    divisores.Add(i); // Agregar el divisor positivo a la lista
                    divisores.Add(-i); // Agregar el divisor negativo a la lista
                }
            }

            return divisores;
        }
    }
}
