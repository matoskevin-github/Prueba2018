using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_51
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[2, 2];
            matriz[0, 0] = 1;
            matriz[0, 1] = 2;
            matriz[1, 0] = 3;
            matriz[1, 1] = 4;

            int[,] matrizB = new int[2, 2]
            {
                {1,2 },{3,4 }
            };

            Console.WriteLine(matriz[1, 1]);

            string[,] matrizC = new string[3, 2]
            {
                {"valor1" ,"valor2"},
                {"valor3" ,"valor4"},
                {"valor5" ,"valor6"}
            };

           EscribirArregloBidimensionalEnPantalla(matrizC);

            Console.Read();
        }

        private static void EscribirArregloBidimensionalEnPantalla<T>(T[,] matriz)
        {
            var filas = matriz.GetLength(0);
            var columnas = matriz.GetLength(1);
            var sb = new StringBuilder();
            var tmpFila = new T[matriz.GetLength(0)];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    tmpFila[j] = matriz[i, j];
                }
                sb.AppendLine(string.Join("\t", tmpFila));
                sb.AppendLine("");
            }
            Console.WriteLine(sb.ToString());

        }
    }
}
