using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppRegistro89
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, ingrese la cantidad de equipos.");
            int equiposQty = Int32.Parse(Console.ReadLine());
            // string[,] equipos = new string[2, equiposQty];
            string[,] equipos = new string[equiposQty, 2];
            string[] equiposs = new string[equiposQty];
            // inicio carga de equipos
            if (equiposQty > 0)
            {


                for (long i = 0; i < equiposQty; i++)
                {
                    Console.WriteLine("Ingrese el nombre del equipo nº" + (i + 1));
                    // equipos[0, i] = Console.ReadLine();
                    equiposs[i] = Console.ReadLine();
                }
            }
            Console.WriteLine("La carga de equipos ha sido realizada correctamente.");

            Console.WriteLine("Partidos del torneo \n");



            List<string> listapartidos = new List<string> { };

            foreach (List<string> i in Combinacion(equiposs, 2))  // Sacamos la combinatoria para saber cuantos partidos.
            {

                Console.WriteLine(string.Join(" vs ", i));  //Listamos los partidos

                listapartidos.AddRange(i);



            }



            // Pedimos los resultados
            int cantidadpartidos = listapartidos.Count();
            string[] partidos = listapartidos.ToArray();
            int[] golesLocal = new int[20];
            int[] golesVisitante = new int[20];
            for (int i = 0; i < cantidadpartidos; i++)
            {
                Console.WriteLine("Ingrese goles del local del partido N° " + (i + 1));
                golesLocal[i] = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese goles del visitante del partido N° " + (i + 1));
                golesVisitante[i + 1] = Int32.Parse(Console.ReadLine());

                if (golesLocal[i] == golesVisitante[i + 1])
                {
                    Console.WriteLine("EL equipo: " + partidos[i] + " empató con " + partidos[i + 1]);

                }
            }






            Console.ReadLine();
        }
        static bool siguienteCombinatoria(int[] num, int n, int k)
        {
            bool finalizado, cambiado;

            cambiado = finalizado = false;

            if (k > 0)
            {
                for (int i = k - 1; !finalizado && !cambiado; i--)
                {
                    if (num[i] < (n - 1) - (k - 1) + i)
                    {
                        num[i]++;
                        if (i < k - 1)
                        {
                            for (int j = i + 1; j < k; j++)
                            {
                                num[j] = num[j - 1] + 1;
                            }
                        }
                        cambiado = true;
                    }
                    finalizado = (i == 0);
                }
            }

            return cambiado;
        }

        static IEnumerable Combinacion<T>(IEnumerable<T> nroEquipos, int k)
        {
            T[] elem = nroEquipos.ToArray();
            int tamanio = elem.Length;

            if (k <= tamanio)
            {
                int[] numeros = new int[k];
                for (int i = 0; i < k; i++)
                {
                    numeros[i] = i;
                }

                do
                {

                    yield return numeros.Select(n => elem[n]).ToList();
                }
                while (siguienteCombinatoria(numeros, tamanio, k));
            }
        }
    }
}
