using System;

namespace ProgramaNumeros
{
    class Program
    {
        public static string InverCadena(string param, int startIndex, int length)
        {
            string result = param.Substring(startIndex, length);
            return result;
        }
        static void Main(string[] args)
        {
            /*
             //  Numeros multiplos 1 a 100 -- Descomentar y correr

             for (int i = 1; i <= 100; i++)
             {
                 if (i % 3 == 0 && i % 5 == 0)
                 {
                     Console.WriteLine("mareigua");
                 }
                 else if (i % 3 == 0)
                 {
                     Console.WriteLine("mare");
                 }
                 else if (i % 5 == 0)
                 {
                     Console.WriteLine("igua");
                 }
                 else
                 {
                     Console.WriteLine(" " + i);
                 }
             }
             */
            /* 
          // Entero mas grande en un arreglo
         int[] numeros = new int[]{24, 449, 38, 1190, 10, 34, 260, 293};
         int mayor = numeros[0];
         for (int i = 1; i < numeros.Length; i++) {
             if (numeros[i] > mayor) {
                 mayor = numeros[i];
             }
         }
             Console.WriteLine("El mayor es: " + mayor);
            */


            // Reversar Cadena-- el metodo esta comentado en la parte inicial

            string Cadena, invertida = "";
            int posicion = 0;

            Console.Write("Indica una frase: ");
            Cadena = Console.ReadLine();

            posicion = Cadena.Length;
            while (posicion > 0)
            {
                invertida = invertida + InverCadena(Cadena, posicion - 1, 1);
                posicion = posicion - 1;
            }

            Console.WriteLine("La frase invertida es: " + invertida);

        }
    }
}
