using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Mall m = new Mall();
            string opcion = null;
            string opcion1 = null;
            string nombre = null;
            int numero = 0;
            int numero1 = 0;
            int contador = 1;
            int contador1 = 1;
            Console.WriteLine("<<< Programa de simulacion de Mall >>>\n");
            Console.WriteLine("Presione 'ENTER' para continuar o 'S' para salir...");
            opcion = Console.ReadLine();
            if (opcion == "s" || opcion == "S") System.Environment.Exit(0);

            //DEFINIR NOMBRE DEL MALL:
            Console.WriteLine("<CREACION DEL MALL>");
            while (true)
            {
                if(opcion!="reingreso") Console.Write("Ingrese el nombre del Mall: ");
                nombre = Console.ReadLine();
                Console.WriteLine("\nSu Mall sera llamado '{0}'. Este nombre no podra ser cambiado en un futuro.\nPresione 'ENTER' para continuar, 'R' para renombrar o 'S' para salir...",nombre);
                opcion = Console.ReadLine();
                if (opcion == "s" || opcion == "S") System.Environment.Exit(0);
                else if (opcion == "r" || opcion == "R")
                {
                    opcion = "reingreso";
                    Console.Write("Reingrese el nombre del Mall: ");
                }
                else
                {
                    m = new Mall(nombre);
                    break;
                }     
            }

            //DEFINIR # PISOS DEL MALL:
            while (true)
            {
                if (opcion != "reingreso")
                {
                    Console.Write("\n<EDICION PISOS DEL MALL>");
                }
                if (opcion == "s" || opcion == "S") System.Environment.Exit(0);
                Console.Write("\nIngrese la cantidad de pisos que tendra el Mall '{0}': ",m.nombre);
                opcion = Console.ReadLine();
                if (int.TryParse(opcion, out numero))
                {
                    m.nropisos = numero;
                }
                else
                {
                    Console.WriteLine("EL DATO INGRESADO POSEE UN VALOR INVALIDO...\n");
                    opcion = "reingreso";
                }
                Console.WriteLine("\nEl Mall '{0}' tendra {1} pisos.\nPresione 'ENTER' para continuar, 'R' para reasignar o 'S' para salir...,", m.nombre, opcion);
                opcion = Console.ReadLine();
                if (opcion == "s" || opcion == "S") System.Environment.Exit(0);
                else if (opcion == "r" || opcion == "R")
                {
                    opcion = "reingreso";
                }
                else break;
            }

            //DEFINIR NUMERO DE HORAS DE FUNCIONAMIENTO DEL MALL:
            while (true)
            {
                if (opcion != "reingreso")
                {
                    Console.Write("\n<HORAS DE TRABAJO DEL MALL>\n");
                }
                if (opcion == "s" || opcion == "S") System.Environment.Exit(0);
                Console.Write("Ingrese la cantidad de horas de trabajo diarios en el Mall '{0}': ", m.nombre);
                opcion = Console.ReadLine();
                if (int.TryParse(opcion, out numero) && numero <= 24 && numero > 0)
                {
                    m.nrohoras = numero;
                }
                else
                {
                    Console.WriteLine("EL DATO INGRESADO POSEE UN VALOR INVALIDO...\n");
                    opcion = "reingreso";
                }
                Console.WriteLine("\nEl Mall '{0}' tendra {1} pisos y funcionara {2} horas diarias.\nPresione 'ENTER' para continuar, 'R' para reasignar o 'S' para salir...,", m.nombre, m.nropisos ,m.nrohoras);
                opcion = Console.ReadLine();
                if (opcion == "s" || opcion == "S") System.Environment.Exit(0);
                else if (opcion == "r" || opcion == "R")
                {
                    opcion = "reingreso";
                }
                else break;
            }


            //DEFINIR DINERO INICIAL DEL MALL:
            while (true)
            {
                if (opcion != "reingreso")
                {
                    Console.Write("\n<DINERO DEL MALL>");
                }
                if (opcion == "s" || opcion == "S") System.Environment.Exit(0);
                Console.Write("\nIngrese la cantidad de dinero inicial que posee el Mall '{0}': ", m.nombre);
                opcion = Console.ReadLine();
                if (int.TryParse(opcion, out numero))
                {
                    m.dineroincial = numero;
                }
                else
                {
                    Console.WriteLine("EL DATO INGRESADO POSEE UN VALOR INVALIDO...\n");
                    opcion = "reingreso";
                }
                Console.WriteLine("\nEl Mall '{0}' tendra {1} de dinero inicial.\nPresione 'ENTER' para continuar, 'R' para reasignar o 'S' para salir...,", m.nombre, m.dineroincial);
                opcion = Console.ReadLine();
                if (opcion == "s" || opcion == "S") System.Environment.Exit(0);
                else if (opcion == "r" || opcion == "R")
                {
                    opcion = "reingreso";
                }
                else break;
            }

            Console.WriteLine("MALL CREADO CON EXITO!:\nMALL {0} DE {1} PISOS, ABIERTO {2} HORAS AL DIA, Y DISPONE DE {3} DE DINERO INCIAL", m.nombre, m.nropisos, m.nrohoras,m.dineroincial);


            //EDICION DE CADA UNO DE LOS PISOS DEL MALL:
            while (contador <= m.nropisos)
            {
                while (true)
                {
                 Console.Write("\n<EDICION DEL PISO Nº {0} DE {1}>", contador, m.nropisos);
                 opcion = Console.ReadLine();
                if (opcion == "s" || opcion == "S") System.Environment.Exit(0);
                Console.Write("\nIngrese el tamaño del piso nº{0}:", contador);
                opcion = Console.ReadLine();
                Console.Write("\nIngrese el numero de tiendas que posee el piso {0}:", contador);
                opcion1 = Console.ReadLine();
                    if (int.TryParse(opcion, out numero) && int.TryParse(opcion1, out numero1))
                    {
                        Pisos p = new Pisos(contador, numero, numero1);
                        if (m.ComprobarPiso(p) && numero/10>=numero1)
                        {
                            m.AgregarPiso(p);
                        }
                        else
                        {
                            Console.WriteLine("\nSUPERFICIE DE LAS TIENDAS O DEL PISO INGRESADAS NO SON VALIDAS...\n");
                            opcion = "reingreso";
                        }
                    }
                    else
                    {
                        Console.WriteLine("EL DATO INGRESADO POSEE UN VALOR INVALIDO...\n");
                        opcion = "reingreso";
                    }

                    if(opcion != "reingreso") Console.WriteLine("\nEl Piso {0} tiene {1} metros cuadrados y cuenta con {2} tiendas.\nPresione 'ENTER' para continuar, 'R' para reasignar o 'S' para salir...,", contador,numero,numero1);
                    opcion1 = Console.ReadLine();
                    if (opcion1 == "s" || opcion1 == "S") System.Environment.Exit(0);
                    else if (opcion1 == "r" || opcion1 == "R")
                    {
                        opcion = "reingreso";
                    }
                    if(opcion != "reingreso")
                    {
                        contador++;
                        break;
                    }
                }
            }
       
            Console.WriteLine("Mall '{0}' de {1} pisos, abierto {2} horas, que dispone de {3} de dinero inicial posee:", m.nombre,m.nropisos,m.nrohoras,m.dineroincial);
            contador = 1;
            while (contador <= m.nropisos)
            {
                Console.WriteLine("Piso #{0}: {1} metros cuadrados, con {2} tiendas.", contador, m.pisos[contador - 1].area, m.pisos[contador - 1].nrotiendas);
                contador++;
            }


            contador = 1;
            while (contador <= m.nropisos)
            {
                Console.WriteLine("\n<EDICION DE TIENDAS DEL PISO Nº {0}/{1}>", contador, m.nropisos);
                contador1 = 1;
                while (contador1 <= m.pisos[contador - 1].nrotiendas)
                {
                    Console.WriteLine("\n<EDICION DE TIENDA {0}/{1} DEL PISO #{2}>", contador1, m.pisos[contador - 1].nrotiendas, contador);
                    Console.WriteLine("\nIngrese el nombre de la tienda {0}:", contador1);
                    nombre = Console.ReadLine();
                    Console.WriteLine("\nIngrese el area de la tienda {0}:",nombre);
                    opcion = Console.ReadLine();
                    Console.WriteLine("\nLa tienda {0} sera llamada '{1}' y tendra un area de {2} metros cuadrados.\nPresione 'ENTER' para continuar, 'R' para reasignar o 'S' para salir...,", contador1, nombre, opcion);
                    opcion1 = Console.ReadLine();
                    if (opcion1 == "s" || opcion1 == "S") System.Environment.Exit(0);
                    else if (opcion1 == "r" || opcion1 == "R")
                    {
                        opcion = "reingreso";
                    }
                    else
                    {
                        int.TryParse(opcion, out numero);
                        Tiendas t = new Tiendas(numero,nombre);
                        t.RandomnNumeroEmpleados();
                        t.RandomPrecios();
                        m.pisos[contador - 1].AgregarTienda(t);
                        contador1++;
                    }
                }
                contador++;
            }

            Console.WriteLine("\n<<ADVERTENCIA: El numero de empleados de cada tienda fue creado al azar y es proporcional al area de la tienda>>\n");
  


            Console.WriteLine("\n<INICIAR SIMULACION>\n\n<La simulacion puede ser pausada presionando la tecla 'P'>\n\nPresione 'ENTER' para continuar o 'S' para salir...");

            opcion = Console.ReadLine();
            if (opcion == "s" || opcion == "S") System.Environment.Exit(0);


            int ganancia=0;
            int totalclientes = 0;
            int gananciatotal = 0;
            int totaltiendas = 0;
            int clientes=0;
            int dias = 0;
            Random r = new Random();
            ConsoleKeyInfo cki = new ConsoleKeyInfo();

            while (dias < 10)
            {
                // PAUSAR PROGRAMA AL APRETAR LA 'P':
                if (Console.KeyAvailable == true)
                {
                    cki = Console.ReadKey(true);
                    if (cki.Key == ConsoleKey.P)
                    {
                        Console.WriteLine("\nSimulacion pausada, presione enter para continuar...");
                        Console.ReadLine();
                    }
                }

                // DIAS++:
                Console.WriteLine("\n<<Dia numero {0}...>>\n", dias + 1);
                contador = 1;
                contador1 = 1;
                while (contador <= m.pisos.Count())
                {
                    while (contador1 <= m.pisos[contador - 1].tiendas.Count())
                    {
                        clientes = m.pisos[contador - 1].tiendas[contador1 - 1].ClientesRecepcionados(m.pisos[contador - 1].tiendas[contador1 - 1].clientesayer);
                        ganancia = r.Next(m.pisos[contador - 1].tiendas[contador1 - 1].preciomin, m.pisos[contador - 1].tiendas[contador1 - 1].preciomax)*clientes - (m.pisos[contador - 1].tiendas[contador1 - 1].nroempleados) - m.pisos[contador - 1].tiendas[contador1 - 1].area;
                        Console.WriteLine("La tienda {0} del piso {1} recibio {2} clientes y obtuvo una ganancia de {3}", m.pisos[contador - 1].tiendas[contador1 - 1].nombre, contador, clientes, ganancia);
                        contador1++;
                        gananciatotal += ganancia;
                        totalclientes += clientes;
                        totaltiendas++;
                    }
                    contador1 = 1;
                    contador++;
                }
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine("Ganancia Total: "+gananciatotal);
                Console.WriteLine("Ganancia Promedio: " +gananciatotal/totaltiendas);
                Console.WriteLine("Clientes recepcionados: "+totalclientes);
                Console.WriteLine("Clientes promedio: " + totalclientes / totaltiendas);
                Console.WriteLine("----------------------------------------------------------------------");
                dias++;
                gananciatotal = 0;
                totalclientes = 0;
                totaltiendas = 0;
                Thread.Sleep(1000);
            }

            Console.WriteLine("Simulacion Terminada");
            Console.ReadLine();

        }
    }
}