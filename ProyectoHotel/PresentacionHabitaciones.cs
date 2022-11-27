using Entidad;
using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHotel
{
    internal class PresentacionHabitaciones
    {
        public void MenuHabitaciones()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(15, 8); Console.Write(" M E N U    H A B I T A C I O N E S");
                Console.SetCursorPosition(20, 10); Console.Write("1. Agregar Habitaciones");
                Console.SetCursorPosition(20, 12); Console.Write("2. Consultar Habitaciones");
                Console.SetCursorPosition(20, 14); Console.Write("3. Eliminar");
                Console.SetCursorPosition(20, 20); Console.Write("0. Volver");

                Console.SetCursorPosition(20, 22); Console.Write("Digite una opcion : ");
                Console.SetCursorPosition(40, 22); opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        MenuAgregar();
                        break;
                    case 2:
                        MenuConsultar();
                        break;
                    case 3:
                        MenuEliminar();
                        break;
                    case 4:
                        break;
                }
            } while (opcion != 0);

        }

        public void MenuAgregar()
        {

            Entidad.Habitacion habitacion = new Entidad.Habitacion();
            ServicioHabitacion servico = new Logica.ServicioHabitacion();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Blue;
            //Console.SetCursorPosition(8, 6); Console.Write(" A G R E G A R    H A B I T A C I O N E S");
            //Console.SetCursorPosition(8, 8); Console.Write("Id Habitacion : "); habitacion.IdHabitacion = Console.ReadLine();
            //Console.SetCursorPosition(8, 10); Console.Write("Numero pisos : "); habitacion.NumPiso = Console.ReadLine();
            // habitacion.NumCama = Convert.ToString(1);
            // habitacion.NumDuchas = Convert.ToString(1);
            //habitacion.NumAir = Convert.ToString(1);
            //habitacion.NumTv = Convert.ToString(1);
            //habitacion.NumCloset = Convert.ToString(1);
            //Console.WriteLine(servico.Guardar(habitacion));
            //Console.ReadKey();
        }
        public void MenuEliminar()
        {
            Entidad.Habitacion habitacion;
            string id_habitacion;
            Logica.ServicioHabitacion servico = new Logica.ServicioHabitacion();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(8, 8); Console.Write(" E L I M I N A R    H A B I T A C I O N E S");
            Console.SetCursorPosition(8, 10); Console.Write("Id Habitacion : ");
            Console.SetCursorPosition(8, 12); Console.Write("Numero de piso : ");
            Console.SetCursorPosition(25, 10); id_habitacion = Console.ReadLine();

            habitacion = servico.BuscarID(id_habitacion);
            if (habitacion == null)
            {
                Console.Clear();
                Console.WriteLine("La Habitacion no existe");
                Console.ReadKey();
                return;
            }

            //Console.SetCursorPosition(28, 12); Console.WriteLine(habitacion.NumPiso);
            //Console.SetCursorPosition(40, 19); Console.WriteLine(cliente.Genero);


            string op = string.Empty;
            Console.SetCursorPosition(8, 15); Console.WriteLine("desea eliniminar la Habitacion? S/N: ");
            Console.SetCursorPosition(46, 15); op = Console.ReadLine();
            if (op.ToUpper() == "S")
            {
                Console.Write(servico.Eliminar(id_habitacion));

            }
            else
            {
                return;
            }
            Console.ReadKey();
        }
        public void MenuConsultar()
        {
            Entidad.Habitacion habitacion = new Entidad.Habitacion();
            Logica.ServicioHabitacion servico = new Logica.ServicioHabitacion();
            int i = 0;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(38, 5); Console.Write(" C O N S U L T A R   H A B I T A C I O N E S");
            Console.SetCursorPosition(20, 8); Console.Write("IdHabitacion");
            Console.SetCursorPosition(35, 8); Console.Write("NumPiso");
            Console.SetCursorPosition(45, 8); Console.Write("NumCama");
            Console.SetCursorPosition(55, 8); Console.Write("NumDuchas");
            Console.SetCursorPosition(65, 8); Console.Write("NumAir");
            Console.SetCursorPosition(75, 8); Console.Write("NumTv");
            Console.SetCursorPosition(85, 8); Console.Write("NumCloset");
            foreach (var item in servico.Consultar())
            {
                i = i + 2;
                //Console.SetCursorPosition(25, 8 + i); Console.Write(item.IdHabitacion);
                //Console.SetCursorPosition(38, 8 + i); Console.Write(item.NumPiso);
                //Console.SetCursorPosition(48, 8 + i); Console.Write(item.NumCama);
                //Console.SetCursorPosition(58, 8 + i); Console.Write(item.NumDuchas);
                //Console.SetCursorPosition(68, 8 + i); Console.Write(item.NumAir);
                //Console.SetCursorPosition(78, 8 + i); Console.Write(item.NumTv);
                //Console.SetCursorPosition(88, 8 + i); Console.Write(item.NumCloset);
            }

            Console.ReadKey();
        }
        //public void MenuModificar()
        //{
        //    Entidad.Cliente cliente = new Entidad.Cliente();
        //    Logica.ServicioCliente servicio = new Logica.ServicioCliente();
        //    Console.Clear();

        //    Console.SetCursorPosition(8, 8); Console.WriteLine("Ingrese la identificacion del cliente: ");
        //    Console.SetCursorPosition(48, 8); string idcliente = Console.ReadLine();
        //    Console.SetCursorPosition(8, 10); Console.WriteLine("Ingrese el nuevo Nombre: ");
        //    Console.SetCursorPosition(33, 10); string nuevoNombre = Console.ReadLine();
        //    Console.SetCursorPosition(35, 10); string genero = Console.ReadLine();


        //    Console.WriteLine(servicio.Modificar(idcliente, new Cliente(idcliente, nuevoNombre, genero)));

        //    Console.ReadKey();

        //}
    }
}
