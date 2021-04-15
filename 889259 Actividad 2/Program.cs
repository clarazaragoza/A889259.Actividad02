using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 /*
namespace _889259_Actividad_2
{
    /**************************************************             
     *            Nombre: Clara Zaragoza              *     
     *            Registro: 889258                    *     
     *            Actividad N.2                       *     
     **************************************************
    class Program : Funciones
    {
        static void Main(string[] args)
        {
            Funciones funciones = new Funciones();

            funciones.SaludarSistema();

            long equiposQty = funciones.ValidarNumero(0, 20, "Por favor, ingrese la cantidad de equipos (Máximo 20 equipos).");
            if (equiposQty > 0)
            {
                string[,] equipos = new string[2, equiposQty];

                long[] partidos = new long[equiposQty];

                int totalPartidos = 0;

                long[] resultadosPartidos = new long[equiposQty]; //corregir el tamaño del array!!


                // CREAR UNA LISTA PARA LOS PARTIDOS? var partidos = new List<int> { "<1>" };

                bool menufunciona = true;
                do
                {
                    //Opciones Menú Principal                    
                    funciones.MenuPpal();
                    long menuppal = funciones.ValidarNumero(0, 4, "Elija una opción válida.");

                    switch (menuppal)
                    {
                        case 1:
                            funciones.IngresarEquipos("1 - Ingresar equipos participantes:", equiposQty);
                            break;

                        case 2:
                            funciones.ListarPartidos("2 - Listar los partidos a jugar:", equiposQty, equipos, partidos, totalPartidos); //string msjOpcion, long equiposQty, string[,] equipos
                            break;

                        case 3:
                            funciones.IngresarResultados("3 - Ingresar resultados de partidos jugados:", partidos, resultadosPartidos, totalPartidos);
                            break;

                        case 4:
                            funciones.ListarPuntaje("4 - Listar el puntaje obtenido por cada equipo:");
                            break;

                        case 0:
                            funciones.SalidaPrograma("0 - Salida del Sistema:");
                            menufunciona = false;
                            break;
                    }

                } while (menufunciona);
            }


            else
            {
                Console.Clear();
                Console.WriteLine("No hay equipos inscriptos.");
                Console.WriteLine("Debe ingresar la información correspondiente para poder utilizar el Menú de opciones.");
                funciones.SalidaPrograma("Salida del Sistema: ");
            }


        }
    }


}

    */