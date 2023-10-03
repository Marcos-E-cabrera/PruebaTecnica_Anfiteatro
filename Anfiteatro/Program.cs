using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Anfiteatro
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char[,] asientos = new char[10,10];
            string input;
            int fila = 0; 
            int asiento = 0;
            int option = 0;
            int salirDeReserva = 1;

            for ( int f = 0; f < 10 ; f++ ) 
            {
                for ( int c = 0;  c < 10 ; c++ ) 
                {
                    asientos[f,c] = 'L';
                }
            }
            
            Console.WriteLine("> SISTEMA DE RESERVAS ");
            Console.WriteLine("=====================================");

            while (option != 3)
            {
                // MENU
                Console.WriteLine("[ 1 ] Rerservar Asiento.");
                Console.WriteLine("[ 2 ] Ver Asientos.");
                Console.WriteLine("[ 3 ] Salir.");

                Console.Write("> Ingresar Operacion: ");
                input = Console.ReadLine();

                while ( int.TryParse(input, out option) == false)
                {
                    Console.WriteLine("< ! > Error, Ingresar Operacion: ");
                    input = Console.ReadLine();
                }

                while (option < 0 || option > 3)
                {
                    Console.Write("< ! > Error, Numero invalido.\n" +
                                  "> Ingrese Respuesta: ");
                    input = Console.ReadLine();

                    while (int.TryParse(input, out option) == false)
                    {
                        Console.Write("< ! > Error, Solo numeros.\n" +
                                 "> Ingrese Respuesta: ");
                        input = Console.ReadLine();
                    }
                }


                Console.WriteLine("=====================================");

                // SELECCION DEL MENU
                switch (option)
                {
                    case 1: // REGISTRAR
                        do
                        {
                            Console.WriteLine("> Ingrese una Fila y un Asiento para reservar");
                            Console.Write("> Fila (entre 0 al 9): ");
                            input = Console.ReadLine();

                            while (int.TryParse(input, out fila) == false)
                            {
                                Console.WriteLine("< ! > Error, Solo ingrese Numeros.");
                                Console.Write("> Fila: ");
                                input = Console.ReadLine();

                            }

                            while (fila < 0 || fila > 9)
                            {
                                Console.WriteLine("< ! > Error, Ingrese un numero (entre 0 al 9).");
                                Console.Write("> Fila (entre 0 al 9): ");
                                input = Console.ReadLine();

                                while (int.TryParse(input, out fila) == false)
                                {
                                    Console.WriteLine("< ! > Error, Solo ingrese Numeros.");
                                    Console.Write("> Fila (entre 0 al 9): ");
                                    input = Console.ReadLine();

                                }
                            }

                            Console.Write("> Asiento (entre 0 al 9): ");
                            input = Console.ReadLine();

                            while (int.TryParse(input, out asiento) == false)
                            {
                                Console.WriteLine("< ! > Error, Solo ingrese Numeros.");
                                Console.Write("> Asiento: ");
                                input = Console.ReadLine();

                            }

                            while (asiento < 0 || asiento > 9)
                            {
                                Console.WriteLine("< ! > Error, Ingrese un numero (entre 0 al 9).");
                                Console.Write("> Asiento (entre 0 al 9): ");
                                input = Console.ReadLine();

                                while (int.TryParse(input, out asiento) == false)
                                {
                                    Console.WriteLine("< ! > Error, Solo ingrese Numeros.");
                                    Console.Write("> Asiento (entre 0 al 9): ");
                                    input = Console.ReadLine();

                                }
                            }

                            Console.WriteLine("=====================================");
                            Console.WriteLine($"> Se Selecciono la Fila [{fila}] y el Asiento [{asiento}].\n");

                            // VERIIFICACION DE LUGAR
                            if (asientos[fila, asiento] == 'L')
                            {
                                asientos[fila, asiento] = 'X';
                                Console.WriteLine("> El Asiento fue Registrado Correctamente");
                            }
                            else
                            {
                                Console.WriteLine("< ! > El Asiento ya fue Reservado, Seleccione otro.");
                            }


                            Console.Write("> Quieres Seguir Reservando? \n" +
                                            "> [ 1 ] SI\n" +
                                            "> [ 0 ] NO\n" +
                                            "> Ingrese Respuesta: ");
                            input = Console.ReadLine();

                            while (int.TryParse(input, out salirDeReserva) == false)
                            {
                                Console.Write("> Error, Quieres Seguir Reservando? \n" +
                                            "> [ 1 ] SI\n" +
                                            "> [ 0 ] NO\n" +
                                            "> Ingrese Respuesta: ");
                                input = Console.ReadLine();
                            }

                            while (salirDeReserva < 0 || salirDeReserva > 1)
                            {
                                Console.Write("< ! > Error, Seleccione [ 1 ] o [ 0 ]\n" +
                                            "> Ingrese Respuesta: ");
                                input = Console.ReadLine();

                                while (int.TryParse(input, out salirDeReserva) == false)
                                {
                                    Console.Write("> Error, Quieres Seguir Reservando? \n" +
                                            "> [ 1 ] SI\n" +
                                            "> [ 0 ] NO\n" +
                                            "> Ingrese Respuesta: ");
                                    input = Console.ReadLine();
                                }
                            }

                            Console.WriteLine("=====================================");

                        } while (salirDeReserva != 0) ;
                        break;
                    case 2:

                        for (int i = 0; i < 10; i++)
                        {
                            Console.Write("   " + i);
                        }
                        
                        Console.WriteLine();

                        for (int f = 0; f < 10; f++)
                        {
                            Console.Write(f+" ");

                            for (int c = 0; c < 10; c++)
                            {
                                Console.Write($"[{asientos[f, c]}] ");
                            }

                            Console.WriteLine();
                        }

                  
                        Console.WriteLine("\n");

                        break;
                    case 3:
                        option = 3;
                        break;
                }
            } 
        }

       
    }
}