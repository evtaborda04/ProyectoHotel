using Entidad;
using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoHotel
{
    public class PresentacionCliente
    {
        public void MenuClientes()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("┌--------------------------┐");
                Console.WriteLine("|       MENU   CLIENTES    |");
                Console.WriteLine("|--------------------------|");
                Console.WriteLine("| OPCIONES:                |");
                Console.WriteLine("| 1. AGREGAR   CLIENTE     |");
                Console.WriteLine("| 2. CONSULTAR CLIENTE     |");
                Console.WriteLine("| 3. MODIFICAR CLIENTE     |");
                Console.WriteLine("| 4. ELIMINAR  CLIENTE     |");
                Console.WriteLine("|--------------------------|");
                Console.WriteLine("| 0. VOLVER                |");
                Console.WriteLine("└--------------------------┘\n");
                //Console.SetCursorPosition(15, 8); Console.Write(" M E N U    C L I E N T E S");
                //Console.SetCursorPosition(20, 10); Console.Write("1. Agregar Cliente");
                //Console.SetCursorPosition(20, 12); Console.Write("2. Consultar Cliente");
                //Console.SetCursorPosition(20, 14); Console.Write("3. Modificar");
                //Console.SetCursorPosition(20, 16); Console.Write("4. Eliminar");
                //Console.SetCursorPosition(20, 20); Console.Write("0. Volver");

                //Console.SetCursorPosition(2, 8); Console.Write("Digite una opcion : ");
                //Console.SetCursorPosition(18, 15); opcion = Convert.ToInt32(Console.ReadLine());
                Console.Write("INGRESE UNA OPCIÓN: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        MenuAgregar();
                        break;
                    case 2:
                        MenuConsultar();
                        break;
                    case 3:
                        MenuModificar();
                        break;
                    case 4:
                        MenuEliminar();
                        break;
                    case 5:
                        break;
                }
            } while (opcion != 0);

        }

        public void MenuAgregar()
        {

            Entidad.Cliente cliente = new Entidad.Cliente();
            ServicioCliente servico = new Logica.ServicioCliente();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(8, 6); Console.Write(" A G R E G A R    C L I E N T E");
            Console.SetCursorPosition(8, 8); Console.Write("Id Cliente : "); cliente.IDCliente = Console.ReadLine();
            Console.SetCursorPosition(8, 10); Console.Write("Nombre cliente : "); cliente.Nom = Console.ReadLine();
            Console.SetCursorPosition(8, 12); Console.Write("Genero : "); cliente.Genero = Console.ReadLine();
            Console.WriteLine(servico.Guardar(cliente));
            Console.ReadKey();
        }
        public void MenuEliminar()
        {
            //    Entidad.Cliente cliente;
            //    string id_cliente;
            //    Logica.ServicioCliente servico = new Logica.ServicioCliente();
            //    Console.Clear();
            //    Console.ForegroundColor = ConsoleColor.Black;
            //    Console.BackgroundColor = ConsoleColor.Blue;
            //    Console.SetCursorPosition(8, 6); Console.Write(" E L I M I N A R    C L I E N T E");
            //    Console.SetCursorPosition(8, 10); Console.Write("Id Cliente : ");
            //    Console.SetCursorPosition(8, 12); Console.Write("Nombre cliente : ");

            //    Console.SetCursorPosition(21, 10); id_cliente = Console.ReadLine();

            //    cliente = servico.BuscarID(id_cliente);
            //    if (cliente == null)
            //    {
            //        Console.Clear();
            //        Console.WriteLine("cliente no existe");
            //        Console.ReadKey();
            //        return;
            //    }

            //    Console.SetCursorPosition(28, 12); Console.WriteLine(cliente.Nom);
            //    Console.SetCursorPosition(40, 19); Console.WriteLine(cliente.Genero);


            //    string op = string.Empty;
            //    Console.SetCursorPosition(8, 15); Console.WriteLine("desea eliniminar el cliente s/n ..");
            //    Console.SetCursorPosition(45, 15); op = Console.ReadLine();
            //    if (op.ToUpper() == "S")
            //    {
            //        Console.Write(servico.Eliminar(id_cliente));

            //    }
            //    else
            //    {
            //        return;
            //    }
            //    Console.ReadKey();

        }
        public void MenuConsultar()
        {
            //Entidad.Cliente cliente = new Entidad.Cliente();
            //Logica.ServicioCliente servico = new Logica.ServicioCliente();
            //int i = 0;
            //Console.Clear();
            //Console.ForegroundColor = ConsoleColor.Black;
            //Console.BackgroundColor = ConsoleColor.Blue;
            //Console.SetCursorPosition(8, 6); Console.Write("C O N S U L T A R   C L I E N T E");
            //Console.SetCursorPosition(20, 8); Console.Write("IdCliente");
            //Console.SetCursorPosition(35, 8); Console.Write("Nombre");
            //Console.SetCursorPosition(48, 8); Console.Write("Genero");
            //foreach (var item in servico.Consultar())
            //{
            //    i = i + 3;
            //    Console.SetCursorPosition(20, 8 + i); Console.Write(item.IDCliente);
            //    Console.SetCursorPosition(35, 8 + i); Console.Write(item.Nom);
            //    Console.SetCursorPosition(50, 8 + i); Console.Write(item.Genero);
            //}

            //Console.ReadKey();
        }
        public void MenuModificar()
        {
            Entidad.Cliente cliente = new Entidad.Cliente();
            Logica.ServicioCliente servicio = new Logica.ServicioCliente();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(8, 6); Console.Write(" M O D I F I C A R   C L I E N T E");
            Console.SetCursorPosition(8, 8); Console.WriteLine("Ingrese la identificacion del cliente: ");
            Console.SetCursorPosition(48, 8); string idcliente = Console.ReadLine();
            Console.SetCursorPosition(8, 10); Console.WriteLine("Ingrese el nuevo Nombre: ");
            Console.SetCursorPosition(33, 10); string nuevoNombre = Console.ReadLine();
            Console.SetCursorPosition(8, 12); Console.WriteLine("Ingrese el Genero: ");
            Console.SetCursorPosition(35, 10); string genero = Console.ReadLine();


            //Console.WriteLine(servicio.Modificar(idcliente, new Cliente(idcliente, nuevoNombre, genero)));

            Console.ReadKey();

        }

    }
}
