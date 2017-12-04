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
using System.Windows.Shapes;

namespace Entrega_04
{
    /// <summary>
    /// Lógica de interacción para Ayuda.xaml
    /// </summary>
    public partial class Ayuda : Window
    {
        public Ayuda()
        {
            InitializeComponent();
            this.Show();
        }

        private void CGSimulacion_Click(object sender, RoutedEventArgs e)
        {
            Ocultar();
            Mostrar_CGSimulacion();
            SeleccionarMenu();
            Button_Simular.Background = new SolidColorBrush(Color.FromArgb(255, 13, 255, 255));
        }

        private void CGSimulacion_Click_2(object sender, RoutedEventArgs e)
        {
            Ocultar();
            Mostrar_CGSimulacion_2();
            SeleccionarMenu();
            Button_Simular.Background = new SolidColorBrush(Color.FromArgb(255, 13, 255, 255));
        }

        private void CGMall_Click(object sender, RoutedEventArgs e)
        {
            Ocultar();
            Mostrar_CGMall();
            SeleccionarMenu();
            Button_mall.Background = new SolidColorBrush(Color.FromArgb(255, 13, 255, 255));
        }

        private void ManejoSimulacion_Click(object sender, RoutedEventArgs e)
        {
            Ocultar();
            Mostrar_ManejoSimulacion();
            SeleccionarMenu();
            Button_manejoSimul.Background = new SolidColorBrush(Color.FromArgb(255, 13, 255, 255));
        }

        private void ManejoSimulacion_Click_2(object sender, RoutedEventArgs e)
        {
            Ocultar();
            Mostrar_ManejoSimulacion_2();
            SeleccionarMenu();
            Button_manejoSimul.Background = new SolidColorBrush(Color.FromArgb(255, 13, 255, 255));
        }

        private void ManejoMall_Click(object sender, RoutedEventArgs e)
        {
            Ocultar();
            Mostrar_ManejoMall();
            SeleccionarMenu();
            Button_manejoMall.Background = new SolidColorBrush(Color.FromArgb(255, 13, 255, 255));
        }

        private void ManejoMall_Click_2(object sender, RoutedEventArgs e)
        {
            Ocultar();
            Mostrar_ManejoMall_2();
            SeleccionarMenu();
            Button_manejoMall.Background = new SolidColorBrush(Color.FromArgb(255, 13, 255, 255));
        }

        public void Ocultar()
        {
            CargarMall.Visibility = Visibility.Hidden;
            CargarSimulacion.Visibility = Visibility.Hidden;
            CargarSimulacion_VentMall.Visibility = Visibility.Hidden;
            Editar.Visibility = Visibility.Hidden;
            GuardarrMall.Visibility = Visibility.Hidden;
            GuardarSimulacion.Visibility = Visibility.Hidden;
            IniciarSimulacion.Visibility = Visibility.Hidden;
            SeleccionEditar.Visibility = Visibility.Hidden;
            SimularMall.Visibility = Visibility.Hidden;
            CrearMall.Visibility = Visibility.Hidden;
            CrearPiso.Visibility = Visibility.Hidden;
            CrearTienda.Visibility = Visibility.Hidden;
            EditarMall.Visibility = Visibility.Hidden;
            textBlock1.Visibility = Visibility.Hidden;
            textBlock2.Visibility = Visibility.Hidden;
            textBlock3.Visibility = Visibility.Hidden;
            textBlock4.Visibility = Visibility.Hidden;
            textBlock5.Visibility = Visibility.Hidden;
            textBlock6.Visibility = Visibility.Hidden;
            textBlock7.Visibility = Visibility.Hidden;
            textBlock8.Visibility = Visibility.Hidden;
            textBlock9.Visibility = Visibility.Hidden;
            textBlock10.Visibility = Visibility.Hidden;
            textBlock11.Visibility = Visibility.Hidden;
            textBlock12.Visibility = Visibility.Hidden;
            textBlock13.Visibility = Visibility.Hidden;
            Siguiente_CGSimulacion.Visibility = Visibility.Hidden;
            Anterior_CGSimulacion.Visibility = Visibility.Hidden;
            Siguiente_ManejoSimulacion.Visibility = Visibility.Hidden;
            Anterior_ManejoSimulacion.Visibility = Visibility.Hidden;
            Siguiente_ManejoMall.Visibility = Visibility.Hidden;
            Anterior_ManejoMall.Visibility = Visibility.Hidden;
        }
        public void Mostrar_CGMall()
        {
            GuardarrMall.Visibility = Visibility.Visible;
            CargarMall.Visibility = Visibility.Visible;
            textBlock1.Visibility = Visibility.Visible;
            textBlock2.Visibility = Visibility.Visible;
        }

        public void Mostrar_CGSimulacion()
        {
            CargarSimulacion.Visibility = Visibility.Visible;
            CargarSimulacion_VentMall.Visibility = Visibility.Visible;
            textBlock3.Visibility = Visibility.Visible;
            textBlock4.Visibility = Visibility.Visible;
            Siguiente_CGSimulacion.Visibility = Visibility.Visible;
            Anterior_CGSimulacion.Visibility = Visibility.Visible;
        }

        public void Mostrar_CGSimulacion_2()
        {
            GuardarSimulacion.Visibility = Visibility.Visible;
            textBlock5.Visibility = Visibility.Visible;
            Siguiente_CGSimulacion.Visibility = Visibility.Visible;
            Anterior_CGSimulacion.Visibility = Visibility.Visible;
        }

        public void Mostrar_ManejoSimulacion()
        {
            IniciarSimulacion.Visibility = Visibility.Visible;
            SimularMall.Visibility = Visibility.Visible;
            textBlock6.Visibility = Visibility.Visible;
            textBlock7.Visibility = Visibility.Visible;
            Siguiente_ManejoSimulacion.Visibility = Visibility.Visible;
            Anterior_ManejoSimulacion.Visibility = Visibility.Visible;
        }
        public void Mostrar_ManejoSimulacion_2()
        {
            Editar.Visibility = Visibility.Visible;
            SeleccionEditar.Visibility = Visibility.Visible;
            textBlock8.Visibility = Visibility.Visible;
            textBlock9.Visibility = Visibility.Visible;
            Siguiente_ManejoSimulacion.Visibility = Visibility.Visible;
            Anterior_ManejoSimulacion.Visibility = Visibility.Visible;
        }

        public void Mostrar_ManejoMall()
        {

            CrearMall.Visibility = Visibility.Visible;
            CrearPiso.Visibility = Visibility.Visible;
            textBlock10.Visibility = Visibility.Visible;
            textBlock11.Visibility = Visibility.Visible;
            Siguiente_ManejoMall.Visibility = Visibility.Visible;
            Anterior_ManejoMall.Visibility = Visibility.Visible;
        }
        public void Mostrar_ManejoMall_2()
        {
            CrearTienda.Visibility = Visibility.Visible;
            EditarMall.Visibility = Visibility.Visible;
            textBlock12.Visibility = Visibility.Visible;
            textBlock13.Visibility = Visibility.Visible;
            Siguiente_ManejoMall.Visibility = Visibility.Visible;
            Anterior_ManejoMall.Visibility = Visibility.Visible;
        }

        public void SeleccionarMenu()
        {
            Button_mall.Background = new SolidColorBrush(Color.FromArgb(255, 176, 176, 176)); 
            Button_Simular.Background = new SolidColorBrush(Color.FromArgb(255, 176, 176, 176));
            Button_manejoMall.Background = new SolidColorBrush(Color.FromArgb(255, 176, 176, 176));
            Button_manejoSimul.Background = new SolidColorBrush(Color.FromArgb(255, 176, 176, 176));
        }
    }
}
