using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema01_Sem13
{
    internal class Program
    {
            static List<string> datosEncuesta = new List<string>();

            static void Main()
            {
                int opcion;

                do
                {
                    MostrarMenu();
                    Console.Write("Ingrese una opción: ");
                    if (int.TryParse(Console.ReadLine(), out opcion))
                    {
                        ProcesarOpcion(opcion);
                    }
                    else
                    {
                        Console.WriteLine("Por favor, ingrese un número válido.");
                    }

                } while (opcion != 5);
            }

            static void MostrarMenu()
            {
                Console.WriteLine("===============================");
                Console.WriteLine("Encuestas de Calidad");
                Console.WriteLine("===============================");
                Console.WriteLine("1: Realizar Encuesta");
                Console.WriteLine("2: Ver datos registrados");
                Console.WriteLine("3: Eliminar un dato");
                Console.WriteLine("4: Ordenar datos de menor a mayor");
                Console.WriteLine("5: Salir");
                Console.WriteLine("===============================");
            }

            static void ProcesarOpcion(int opcion)
            {
                switch (opcion)
                {
                    case 1:
                        RealizarEncuesta();
                        break;
                    case 2:
                        VerDatosRegistrados();
                        break;
                    case 3:
                        EliminarDato();
                        break;
                    case 4:
                        OrdenarDatos();
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, ingrese una opción del 1 al 5.");
                        break;
                }
            }

            static void RealizarEncuesta()
            {
                Console.Write("Ingrese su opinión: ");
                string opinion = Console.ReadLine();
                datosEncuesta.Add(opinion);
                Console.WriteLine("¡Encuesta registrada con éxito!");
            }

            static void VerDatosRegistrados()
            {
                if (datosEncuesta.Count == 0)
                {
                    Console.WriteLine("No hay datos registrados.");
                }
                else
                {
                    Console.WriteLine("Datos registrados:");
                    foreach (var dato in datosEncuesta)
                    {
                        Console.WriteLine("- " + dato);
                    }
                }
            }

            static void EliminarDato()
            {
                if (datosEncuesta.Count == 0)
                {
                    Console.WriteLine("No hay datos para eliminar.");
                }
                else
                {
                    Console.Write("Ingrese el índice del dato a eliminar: ");
                    if (int.TryParse(Console.ReadLine(), out int indice) && indice >= 0 && indice < datosEncuesta.Count)
                    {
                        datosEncuesta.RemoveAt(indice);
                        Console.WriteLine("Dato eliminado con éxito.");
                    }
                    else
                    {
                        Console.WriteLine("Índice no válido. Intente nuevamente.");
                    }
                }
            }

            static void OrdenarDatos()
            {
                if (datosEncuesta.Count == 0)
                {
                    Console.WriteLine("No hay datos para ordenar.");
                }
                else
                {
                    datosEncuesta.Sort();
                    Console.WriteLine("Datos ordenados de menor a mayor.");
                }
            }
    }
}


