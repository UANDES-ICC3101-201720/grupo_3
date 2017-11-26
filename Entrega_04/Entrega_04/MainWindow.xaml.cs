using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.Win32;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Xml;

namespace Entrega_04
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    /// 
    public delegate void agregarMall(Mall mall);

    public partial class MainWindow : Window
    {
        private List<Mall> ListaMall;
        private agregarMall AgregarNuevo;

        private int cosa;
        private Mall Mallseleccionado;
        private TiendasSimuladas seleccionada;
        private int cosa_mall;
        private List<TiendasSimuladas> ListaSimulacion;
        TiendasSimuladas valorTienda;
        bool Seguir;

        public MainWindow()
        {
            AgregarNuevo = new agregarMall(AgregarMall);
            ListaMall = new List<Mall>();
            ListaSimulacion = new List<TiendasSimuladas>();

            InitializeComponent();
        }


        private void Crear_Click(object sender, RoutedEventArgs e)
        {
            Window creador = new Ventana1(AgregarNuevo);
        }

        private void Simulacion_Click(object sender, RoutedEventArgs e)
        { 
            if (Mallseleccionado == null)
            {

            }
            else
            {
                label_valorNombre.Content = Mallseleccionado.nombre;
                int arriendo=Mallseleccionado.Arriendo;
                foreach (Pisos piso in Mallseleccionado.pisos)
                {
                    List<Tiendas> listatiendas = piso.TomarTiendas;
                    foreach (Tiendas tienda in listatiendas)
                    {
                        int ventas = 0;
                        int gananciasdia = 0;
                        int gananciasacumuladas = 0;
                        valorTienda = new TiendasSimuladas(tienda.nombre, tienda.nroempleados, tienda.categoria, tienda.nropiso, tienda.area, tienda.preciomin, tienda.preciomax, tienda.sueldo, ventas, gananciasdia, gananciasacumuladas,arriendo);
                        ListaSimulacion.Add(valorTienda);
                        updateDataGrid_Simualcion();
                    }
                }

                Borrar_Inicio();
                Iniciar_Simulacion();
            }
        }

        private void Iniciar_Click(object sender, RoutedEventArgs e)
        {
            Seguir = true;
            int dia = 0;
            while (dia < 10 && Seguir == true)
            {
                SimularDia();
                updateDataGrid_Simualcion();
                dia += 1;
            }
        }

        private void Detener_Click(object sender, RoutedEventArgs e)
        {
            ListaSimulacion = new List<TiendasSimuladas>();
            label_nrodia.Content = "0";
            Seguir = false;

            // ----------- Borrar cuando Funcione -----------//
            Borrar_Simulacion();
            Iniciar_Inicio();
            //----------------------------------------------//
        }

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SaveFileDialog buscar = new SaveFileDialog();
                buscar.ShowDialog();
                string direccion = buscar.FileName;
                GuardarSimulacion(ListaSimulacion, direccion);
            }
            catch
            {

            }
        }

        private void Cargar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog buscar = new OpenFileDialog();
                buscar.ShowDialog();
                string direccion = buscar.FileName;
                ListaSimulacion = CargarSimulacion(direccion);
                updateDataGrid_Simualcion();
            }
            catch
            {

            }
        }

        private void GuardarMall_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SaveFileDialog buscar = new SaveFileDialog();
                buscar.ShowDialog();
                string direccion = buscar.FileName;
                GuardarMall(ListaMall, direccion);
            }
            catch
            {

            }
        }

        private void CargarMall_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog buscar = new OpenFileDialog();
                buscar.ShowDialog();
                string direccion = buscar.FileName;
                ListaMall = CargarMall(direccion);
                updateDataGrid();
            }
            catch
            {

            }
        }

        private void CargarSimulacion_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog buscar = new OpenFileDialog();
                buscar.ShowDialog();
                string direccion = buscar.FileName;
                ListaSimulacion = CargarSimulacion(direccion);
                updateDataGrid_Simualcion();
                Borrar_Inicio();
                Iniciar_Simulacion();
            }
            catch
            {

            }
        }

        public void updateDataGrid_Simualcion()
        {
            ObservableCollection<TiendasSimuladas> obsC = new ObservableCollection<TiendasSimuladas>(ListaSimulacion);
            dataGrid_1.ItemsSource = obsC;
        }

        private void dataGrid_1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            seleccionada = (TiendasSimuladas)dataGrid_1.SelectedItem;
            cosa = ListaSimulacion.IndexOf(seleccionada);
        }

        private void dataGrid_1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (seleccionada != null)
            {
                seleccionada = (TiendasSimuladas)dataGrid_1.SelectedItem;
                cosa = ListaSimulacion.IndexOf(seleccionada);
            }
        }

        public void updateDataGrid()
        {
            ObservableCollection<Mall> obsC = new ObservableCollection<Mall>(ListaMall);
            dataGrid.ItemsSource = obsC;
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Mallseleccionado = (Mall)dataGrid.SelectedItem;
            cosa_mall = ListaMall.IndexOf(Mallseleccionado);
            
        }

        private void dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (seleccionada != null)
            {
                Mallseleccionado = (Mall)dataGrid.SelectedItem;
                cosa_mall = ListaMall.IndexOf(Mallseleccionado);
            }
        }

        public void SimularDia()
        {
            int dia=0;
            foreach (TiendasSimuladas tienda in ListaSimulacion)
            {
                Random rnd = new Random();
                int promedio = (((tienda.Preciomax + tienda.Preciomin) / 2) * 100) / tienda.Preciomax;
                int cmax = tienda.Clientespasados + ((tienda.Area / 10) * Math.Max(0, 100 - promedio) * tienda.Nroempleados) / 100;
                int clientesdia = rnd.Next(0, cmax);
                int ventadiaria = rnd.Next(tienda.Preciomin, tienda.Preciomax);
                int ganancias = ventadiaria * tienda.Clientespasados - ((tienda.Nroempleados * tienda.Sueldos) + tienda.Arriendo);

                tienda.Clientespasados = clientesdia;
                tienda.Ventas = ventadiaria;
                tienda.Gananciasdia = ganancias;
                tienda.Gananciasacumuladas += ganancias;
                tienda.Dia += 1;
                dia = tienda.Dia;
            }
            label_nrodia.Content = Convert.ToString(dia);
        }

        public void Iniciar_Inicio()
        {
            Titulo.Content = "Sim Mall ";
            Button_Crear.Visibility = Visibility.Visible;
            Button_Simualar.Visibility = Visibility.Visible;
            Button_CargarMall.Visibility = Visibility.Visible;
            Button_GuardarMall.Visibility = Visibility.Visible;
            Button_SimualarGuardado.Visibility = Visibility.Visible;
            dataGrid.Visibility = Visibility.Visible;
        }

        public void Borrar_Inicio()
        {
            Button_Crear.Visibility = Visibility.Hidden;
            Button_Simualar.Visibility = Visibility.Hidden;
            Button_CargarMall.Visibility = Visibility.Hidden;
            Button_GuardarMall.Visibility = Visibility.Hidden;
            Button_SimualarGuardado.Visibility = Visibility.Hidden;
            dataGrid.Visibility = Visibility.Hidden;
        }

        public void Iniciar_Simulacion()
        {
            Titulo.Content = "Simulador ";
            Button_Iniciar.Visibility = Visibility.Visible;
            Button_Detener.Visibility = Visibility.Visible;
            Button_Cargar.Visibility = Visibility.Visible;
            Button_Guardar.Visibility = Visibility.Visible;
            dataGrid_1.Visibility = Visibility.Visible;
            label_dia.Visibility = Visibility.Visible;
            label_nrodia.Visibility = Visibility.Visible;
            label_nombreMall.Visibility = Visibility.Visible;
            label_valorNombre.Visibility = Visibility.Visible;
        }

        public void Borrar_Simulacion()
        {
            Button_Iniciar.Visibility = Visibility.Hidden;
            Button_Detener.Visibility = Visibility.Hidden;
            Button_Cargar.Visibility = Visibility.Hidden;
            Button_Guardar.Visibility = Visibility.Hidden;
            dataGrid_1.Visibility = Visibility.Hidden;
            label_dia.Visibility = Visibility.Hidden;
            label_nrodia.Visibility = Visibility.Hidden;
            label_nombreMall.Visibility = Visibility.Hidden;
            label_valorNombre.Visibility = Visibility.Hidden;
        }

        public void AgregarMall(Mall nuevo)
        {
            ListaMall.Add(nuevo);
            updateDataGrid();
        }

        private static void GuardarSimulacion(List<TiendasSimuladas> simulacion, string direccion)
        {
            FileStream fs = new FileStream(direccion, FileMode.Create);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, simulacion);
            fs.Close();
        }        private static List<TiendasSimuladas> CargarSimulacion(string direccion)
        {
            FileStream fs = new FileStream(direccion, FileMode.Open);
            IFormatter formatter = new BinaryFormatter();
            List<TiendasSimuladas> simulacion = formatter.Deserialize(fs) as List<TiendasSimuladas>;
            fs.Close();
            return simulacion;
        }

        private static void GuardarMall(List<Mall> simulacion, string direccion)
        {
            FileStream fs = new FileStream(direccion, FileMode.Create);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, simulacion);
            fs.Close();
        }        private static List<Mall> CargarMall(string direccion)
        {
            FileStream fs = new FileStream(direccion, FileMode.Open);
            IFormatter formatter = new BinaryFormatter();
            List<Mall> simulacion = formatter.Deserialize(fs) as List<Mall>;
            fs.Close();
            return simulacion;
        }

    }
}