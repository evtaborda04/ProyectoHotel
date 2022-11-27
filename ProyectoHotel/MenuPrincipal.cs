using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHotel
{
    public class MenuPrincipal
    {

        public void EjecutarMenuPrincipal()
        {
            int opcionSeleccionada = 0;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("┌--------------------------┐");
                Console.WriteLine("|    [HOTEL LA RELIQUIA]   |");
                Console.WriteLine("|--------------------------|");
                Console.WriteLine("| OPCIONES DE CONTACTO:    |");
                Console.WriteLine("| 1. GESTIONAR CLIENTE     |");
                Console.WriteLine("| 2. GESTIONAR HABITACIONES|");
                Console.WriteLine("| 3. RENTAR HABITACIONES   |");
                Console.WriteLine("| 4. ELIMINAR              |");
                Console.WriteLine("|--------------------------|");
                Console.WriteLine("| 5. SALIR                 |");
                Console.WriteLine("└--------------------------┘\n");

                Console.Write("INGRESE UNA OPCIÓN: ");
                opcionSeleccionada = int.Parse(Console.ReadLine());

                switch (opcionSeleccionada)
                {
                    case 1:
                      new  PresentacionCliente().MenuClientes();
                        break;
                    case 2:
                        new PresentacionHabitaciones().MenuHabitaciones();
                        break;
                    case 3:
                        //PresentacionCliente.EditarContacto();
                        break;
                    case 4:
                        //PresentacionCliente.EliminarContacto();
                        break;
                    case 5:
                        Console.WriteLine("\nSISTEMA FINALIZADO");
                        Console.Write("PRESIONE CUALQUIER TECLA PARA CERRAR ESTA VENTANA...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine($"\nERROR: LA OPCIÓN INGRESADA ({opcionSeleccionada}) NO EXISTE.");
                        Console.Write("PRESIONE CUALQUIER TECLA PARA INTENTARLO NUEVAMENTE...");
                        Console.ReadKey();
                        break;
                }
            } while (opcionSeleccionada != 5);
        }
    }
}
