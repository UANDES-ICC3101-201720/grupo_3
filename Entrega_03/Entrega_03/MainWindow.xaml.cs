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
        int nro = 0;

        ///string outputPath = "archivo.txt";
        /// File.AppendAllText(outputPath,  str line);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Crear_Click(object sender, RoutedEventArgs e)
        {
            int pisos = int.Parse(textBox_pisos.Text);
            int horas = int.Parse(textBox_horas.Text);
            Mall nuevo_mall = new Mall(pisos, horas, textBox_nombre.Text);

            while (nro < pisos)
            {
                Window creador = new Ventana1(nro,nuevo_mall);
                nro += 1;
            }
        }
    }
}

