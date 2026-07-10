using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Program
    {
        static string[,] vehiculos = new string[10, 3];
        static void Main(string[] args)
        {
            int opcion = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("===== MENU =====");
                Console.WriteLine("1. Registrar vehiculo");
                Console.WriteLine("2. Mostrar vehiculos");
                Console.WriteLine("3. Buscar vehiculo");
                Console.WriteLine("4. Actualizar vehiculo");
                Console.WriteLine("5. Eliminar vehiculo");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opcion: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Registrar();
                        Pausa();
                        break;

                    case 2:
                        Mostrar();
                        Pausa();
                        break;

                    case 3:
                        Buscar();
                        Pausa();
                        break;

                    case 4:
                        Actualizar();
                        Pausa();
                        break;

                    case 5:
                        Eliminar();
                        Pausa();
                        break;

                    case 6:
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("Opcion invalida.");
                        Pausa();
                        break;
                }

            } while (opcion != 6);
        }

        static void Registrar()
        {
            bool registrado = false;

            for (int i = 0; i < 10; i++)
            {
                if (vehiculos[i, 0] == null || vehiculos[i, 0] == "")
                {
                    Console.Write("Numero de placa: ");
                    vehiculos[i, 0] = Console.ReadLine();

                    Console.Write("Nombre del propietario: ");
                    vehiculos[i, 1] = Console.ReadLine();

                    Console.Write("Marca del vehiculo: ");
                    vehiculos[i, 2] = Console.ReadLine();

                    Console.WriteLine("Vehiculo registrado correctamente.");
                    registrado = true;
                    break;
                }
            }

            if (registrado == false)
            {
                Console.WriteLine("No hay espacios disponibles.");
            }
        }

        static void Mostrar()
        {
            Console.WriteLine("PLACA\tPROPIETARIO\tMARCA");

            for (int i = 0; i < 10; i++)
            {
                if (vehiculos[i, 0] != null && vehiculos[i, 0] != "")
                {
                    Console.WriteLine(vehiculos[i, 0] + "\t" + vehiculos[i, 1] + "\t" + vehiculos[i, 2]);
                }
            }
        }

        static void Buscar()
        {
            string placa;
            bool encontrado = false;

            Console.Write("Ingrese la placa a buscar: ");
            placa = Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                if (vehiculos[i, 0] == placa)
                {
                    Console.WriteLine("Vehiculo encontrado:");
                    Console.WriteLine("Placa: " + vehiculos[i, 0]);
                    Console.WriteLine("Propietario: " + vehiculos[i, 1]);
                    Console.WriteLine("Marca: " + vehiculos[i, 2]);
                    encontrado = true;
                    break;
                }
            }

            if (encontrado == false)
            {
                Console.WriteLine("Vehiculo no encontrado.");
            }
        }

        static void Actualizar()
        {
            string placa;
            bool encontrado = false;

            Console.Write("Ingrese la placa a actualizar: ");
            placa = Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                if (vehiculos[i, 0] == placa)
                {
                    Console.Write("Nuevo propietario: ");
                    vehiculos[i, 1] = Console.ReadLine();

                    Console.Write("Nueva marca: ");
                    vehiculos[i, 2] = Console.ReadLine();

                    Console.WriteLine("Registro actualizado correctamente.");
                    encontrado = true;
                    break;
                }
            }

            if (encontrado == false)
            {
                Console.WriteLine("Vehiculo no encontrado.");
            }
        }

        static void Eliminar()
        {
            string placa;
            bool encontrado = false;

            Console.Write("Ingrese la placa a eliminar: ");
            placa = Console.ReadLine();

            for (int i = 0; i < 10; i++)
            {
                if (vehiculos[i, 0] == placa)
                {
                    vehiculos[i, 0] = "";
                    vehiculos[i, 1] = "";
                    vehiculos[i, 2] = "";

                    Console.WriteLine("Vehiculo eliminado correctamente.");
                    encontrado = true;
                    break;
                }
            }

            if (encontrado == false)
            {
                Console.WriteLine("Vehiculo no encontrado.");
            }
        }

        static void Pausa()
        {
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
