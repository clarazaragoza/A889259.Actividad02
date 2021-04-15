using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace _889259_Actividad_2
{
    //Clase contenedora de todas las Funciones
    class Funciones
    {
        public void SaludarSistema()
        {
            Console.Clear();
            Console.WriteLine("\t\t\t***************************************************");
            Console.WriteLine("\t\t\t**Sistema de Gestión: Torneo ´Todxs contra Todxs´**");
            Console.WriteLine("\t\t\t***************************************************");
            Console.ReadKey();
        }

        //Exit:
        public void SalidaPrograma(string msjOpcion)
        {
            Console.Clear();
            Console.WriteLine(msjOpcion);
            Console.WriteLine("Muchas gracias por utilizar el Sistema. Hasta la próxima.");
            Continuar("finalizar");
            SaludarSistema();
        }

        //Menú de Opciones
        public void MenuPpal()
        {
            Console.Clear();
            SaludarSistema();
            Console.Write("Menú Principal:");
            Console.Write("\n" + "1  - Ingresar equipos participantes.");
            Console.Write("\n" + "2  - Listar los partidos a jugar.");
            Console.Write("\n" + "3  - Ingresar resultados de partidos jugados.");
            Console.Write("\n" + "4  - Listar el puntaje obtenido por cada equipo.");
            Console.Write("\n" + "0  - Salir del Sistema." + "\n");
            Console.Write("\n" + "Qué opción desea utilizar?");
            Continuar("ingresarla");
        }


        //Valida Nros ingresados:
        public long ValidarNumero(long min, long max, string msj)
        {
            long resultado;
            do
            {
                Console.Clear();
                Console.WriteLine(msj);
                Console.WriteLine("Recuerde que debe ser un número entre " + min + " y " + max + ".");

                if (!long.TryParse(Console.ReadLine(), out resultado))
                {
                    Console.WriteLine("Ingrese un número, por favor.");
                    resultado = -1;
                }

            } while (resultado < min || resultado > max);

            return resultado;
        }

        //Valida Textos ingresados:
        public string ValidarTexto(string msj)
        {
            string resultado;
            do
            {
                Console.Clear();
                Console.WriteLine(msj);
                resultado = Console.ReadLine();

            } while (resultado == "");

            return resultado;
        }

        public void Continuar(string mensaje)
        {
            Console.WriteLine("\n" + "Presione cualquier tecla para " + mensaje + "...");
            Console.ReadKey();
        }



        //Comienza el desarrollo de funciones:
        public void IngresarEquipos(string msjOpcion, long equiposQty)
        {
            Console.Clear();
            Console.WriteLine(msjOpcion);

            //long equiposQty = ValidarNumero(0, 20, "Por favor, ingrese la cantidad de equipos (Máximo 20 equipos).");


            if (equiposQty > 0)
            {
                string[,] equipos = new string[2, equiposQty];

                for (long i = 0; i < equiposQty; i++)
                {
                    equipos[0, i] = ValidarTexto("Ingrese el nombre del equipo nº" + (i + 1));
                }

                Console.Clear();
                Console.WriteLine("La carga de equipos ha sido realizada correctamente.");

                Continuar("volver al Menú");
            }
        }

        public void ListarPartidos(string msjOpcion, long equiposQty, string[,] equipos, long[] partidos, int totalPartidos)
        {
            Console.Clear();
            Console.WriteLine(msjOpcion);
            int contadorPartidos = 1;

            // ACA PODRIA AGREGAR LOS NOMBRES DE LOS RESPECTIVOS EQUIPOS ASI QUEDA MEJOR. 
            for (long i = 0; i < equiposQty - 1; i++)
            {
                Console.WriteLine("\n" + "Equipo Nro. " + (i + 1));

                for (long j = 1; j < equiposQty; j++)
                {
                    if (j > i)
                    {
                        Console.WriteLine("\t" + " - vs. - Equipo Nro. " + (j + 1));
                        Console.WriteLine("\t\t\t\t" + " ---> Partido Nro. " + contadorPartidos);
                        Console.ReadKey();
                        contadorPartidos++;
                        partidos[i] = contadorPartidos;
                        totalPartidos = contadorPartidos;

                    }
                }

                Console.WriteLine("");
            }

            Continuar("volver al Menú");
        }

        public void IngresarResultados(string msjOpcion, long[] partidos, long[] resultadosPartidos, int totalPartidos)
        {
            Console.Clear();
            Console.WriteLine(msjOpcion);

            int contadorPartidos = 1;

            //QUE PONEMOS ACA?
            for (long i = 1; i < totalPartidos; i++)
            {

                Console.WriteLine("Por favor ingrese el resultado del partido nro. " + partidos[i]);
                resultadosPartidos[i] = ValidarNumero(0, 20, "Por favor, ingrese un resultado válido.");

                contadorPartidos++;

            }

            Continuar("volver al Menú");
        }

        public void ListarPuntaje(string msjOpcion)

        {
            Console.Clear();
            Console.WriteLine(msjOpcion);


            Continuar("volver al Menú");
        }

    }
}
*/
