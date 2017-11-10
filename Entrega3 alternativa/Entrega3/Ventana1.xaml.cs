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
using System.Collections.ObjectModel;

namespace Entrega3
{
    /// <summary>
    /// Lógica de interacción para Ventana1.xaml
    /// </summary>
    public partial class Ventana1 : Window
    {
        public Tiendas seleccionada;
        private List<Pisos> pisos;
        private List<Tiendas> tiendas;
        public Ventana1(List<Pisos> pisos)
        {
            InitializeComponent();
            this.pisos = pisos;
            tiendas = new List<Tiendas>();   
        }
        public void updateDataGrid()
        {
            ObservableCollection<Tiendas> obs = new ObservableCollection<Tiendas>(tiendas);
            dataGrid.ItemsSource = obs;
        }

        private void agregarTienda(Tiendas tienda, Pisos piso)
        {
            piso.AgregarTienda(tienda);
            updateDataGrid();
        }

        private void tiendaArray(List<Tiendas>tiendas, Tiendas tienda)
        {
            tiendas.Add(tienda);
            updateDataGrid();
        }
        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            seleccionada = (Tiendas)dataGrid.SelectedItem;
        }

        private void dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            seleccionada = (Tiendas)dataGrid.SelectedItem;
        }
        private void Boton_Agregar_Click(object sender, RoutedEventArgs e)
        {
            tiendaArray(tiendas, new Tiendas(Convert.ToInt32(textBox_area.Text), (textBox_nombre.Text), Convert.ToInt32(textBox_nropiso.Text)));
        }

        private void Boton_Eliminar_Click(object sender, RoutedEventArgs e)
        {
            tiendas.Remove(seleccionada);
            updateDataGrid();
        }
    }
}
