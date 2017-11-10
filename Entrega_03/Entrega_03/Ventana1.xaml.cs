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

namespace Entrega_03
{
    /// <summary>
    /// Lógica de interacción para Ventana1.xaml
    /// </summary>
    /// 
    public partial class Ventana1 : Window
    {
        Pisos nuevo_piso;
        Mall mall;
        Tiendas nueva_tienda;
        int nro1;
        int nropiso;
        int nro_tiendas;

        public Ventana1()
        {
            InitializeComponent();
        }

        public Ventana1(int aph, Mall mall_creado)
        {
            nropiso = aph;
            mall = mall_creado;
            this.Show();
            InitializeComponent();
        }


        private void CrearPiso_Click(object sender, RoutedEventArgs e)
        {
            nro1 = 0;
            int tamaño = int.Parse(textBox_tamaño.Text);
            nro_tiendas = int.Parse(textBox_cantidad.Text);
            nuevo_piso = new Pisos( nropiso, tamaño, nro_tiendas);
            
            label_tamaño.Visibility = Visibility.Hidden;
            label_cantidad.Visibility = Visibility.Hidden;
            textBox_tamaño.Visibility = Visibility.Hidden;
            textBox_cantidad.Visibility = Visibility.Hidden;
            Crear_piso.Visibility = Visibility.Hidden;

            label_nombreTienda.Visibility = Visibility.Visible;
            label_areaTienda.Visibility = Visibility.Visible;
            textBox_nombreTienda.Visibility = Visibility.Visible;
            textBox_areaTienda.Visibility = Visibility.Visible;
            Crear_tienda.Visibility = Visibility.Visible;

        }

        private void CrearTienda_Click(object sender, RoutedEventArgs e)
        {
            int area_tienda = int.Parse(textBox_areaTienda.Text);
            nueva_tienda = new Tiendas(area_tienda, textBox_nombreTienda.Text);
            nuevo_piso.AgregarTienda(nueva_tienda);    
            

            if (nro1 < nro_tiendas)
            {
                mall.AgregarPiso(nuevo_piso);
                this.Close();
            }

            nro1 += 1;
        }




    }
}
