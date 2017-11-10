using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using System.Media;
using System.IO;


namespace Entrega_03
{

    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Mall nuevo_mall;
        int nro = 0;
        string outputPath = "archivo.txt";
        /// File.AppendAllText(outputPath,  str line);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Crear_Click(object sender, RoutedEventArgs e)
        {
            int pisos = int.Parse(textBox_pisos.Text);
            int horas = int.Parse(textBox_horas.Text);
            nuevo_mall = new Mall(pisos, horas, textBox_nombre.Text);

            while (nro < pisos)
            {
                Window creador = new Ventana1(nro,nuevo_mall);
                nro += 1;
            }

            Titulo.Content = "Simulacion";
            label_nombre.Visibility = Visibility.Hidden;
            label_pisos.Visibility = Visibility.Hidden;
            label_horas.Visibility = Visibility.Hidden;
            label_dinero.Visibility = Visibility.Hidden;
            textBox_nombre.Visibility = Visibility.Hidden;
            textBox_pisos.Visibility = Visibility.Hidden;
            textBox_horas.Visibility = Visibility.Hidden;
            textBox_dinero.Visibility = Visibility.Hidden;
            Button_Crea.Visibility = Visibility.Hidden;
            Button_Iniciar.Visibility = Visibility.Visible;
            
        }


        private void Simulacion_Click(object sender, RoutedEventArgs e)
        {
            /*
            int ganancia = 0;
            int totalclientes = 0;
            int gananciatotal = 0;
            int totaltiendas = 0;
            int clientes = 0;
            int dias = 0;
            Random r = new Random();

            while (dias < 10)
            {
                // DIAS++:
                File.AppendAllText(outputPath, "\n<<Dia numero {0}...>>\n" + (dias + 1));
                int contador = 1;
                int contador1 = 1;
                while (contador <= nuevo_mall.pisos.Count())
                {
                    while (contador1 <= nuevo_mall.pisos[contador - 1].tiendas.Count())
                    {
                        clientes = nuevo_mall.pisos[contador - 1].tiendas[contador1 - 1].ClientesRecepcionados(nuevo_mall.pisos[contador - 1].tiendas[contador1 - 1].clientesayer);
                        ganancia = r.Next(nuevo_mall.pisos[contador - 1].tiendas[contador1 - 1].preciomin, nuevo_mall.pisos[contador - 1].tiendas[contador1 - 1].preciomax) * clientes - (nuevo_mall.pisos[contador - 1].tiendas[contador1 - 1].nroempleados) - nuevo_mall.pisos[contador - 1].tiendas[contador1 - 1].area;
                        Console.WriteLine("La tienda {0} del piso {1} recibio {2} clientes y obtuvo una ganancia de {3}", nuevo_mall.pisos[contador - 1].tiendas[contador1 - 1].nombre, contador, clientes, ganancia);
                        contador1++;
                        gananciatotal += ganancia;
                        totalclientes += clientes;
                        totaltiendas++;
                    }
                    contador1 = 1;
                    contador++;
                }
                Console.WriteLine("----------------------------------------------------------------------");
                File.AppendAllText(outputPath, "Ganancia Total: " + gananciatotal);
                File.AppendAllText(outputPath, "Ganancia Promedio: " + gananciatotal / totaltiendas);
                File.AppendAllText(outputPath, "Clientes recepcionados: " + totalclientes);
                File.AppendAllText(outputPath, "Clientes promedio: " + totalclientes / totaltiendas);
                File.AppendAllText(outputPath, "----------------------------------------------------------------------");
                dias++;
                gananciatotal = 0;
                totalclientes = 0;
                totaltiendas = 0;
                Thread.Sleep(1000);
            }
            */
        }
    }
}

