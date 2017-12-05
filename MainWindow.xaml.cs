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
using System.Windows.Threading;

namespace Entrega_04
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    /// 
    public delegate void agregarMall(Mall mall);
    public delegate void editarMall(Mall mall);
    public delegate void editarsim(TiendasSimuladas simu);

    public partial class MainWindow : Window
    {
        private List<Mall> ListaMall;
        private agregarMall AgregarNuevo;
        private editarMall EditarNuevo;
        private editarsim EditarSim;

        private int cosa;
        private Mall Mallseleccionado;
        private TiendasSimuladas seleccionada;
        private int cosa_mall;
        private List<TiendasSimuladas> ListaSimulacion;
        TiendasSimuladas valorTienda;
        bool Seguir;
        int detener=0;

        public MainWindow()
        {
            AgregarNuevo = new agregarMall(AgregarMall);
            EditarNuevo = new editarMall(EditarMall);
            EditarSim = new editarsim(Editar_Simulacion);
            ListaMall = new List<Mall>();
            ListaSimulacion = new List<TiendasSimuladas>();

            InitializeComponent();
        }


        private void Crear_Click(object sender, RoutedEventArgs e)
        {
            Window creador = new Ventana1(AgregarNuevo);
        }

        private void EditarMall_Click(object sender, RoutedEventArgs e)
        {
            if (Mallseleccionado == null)
            {
                MessageBox.Show("ERROR : No se a seleccionado ninigun mall");
            }
            else
            {
                Window creador = new Ventana1(EditarNuevo, Mallseleccionado);
            }
        }

        private void Eliminar_Click(object sender, RoutedEventArgs e)
        {
            if (Mallseleccionado == null)
            {
                MessageBox.Show("ERROR : No se a seleccionado ninigun mall");
            }
            else
            {
                ListaMall.Remove(Mallseleccionado);
                updateDataGrid();
            }
        }

        private void Simulacion_Click(object sender, RoutedEventArgs e)
        { 
            if (Mallseleccionado == null)
            {
                MessageBox.Show("ERROR : No se a seleccionado ninigun mall");
            }
            else
            {
                label_valorNombre.Content = Mallseleccionado.nombre;
                int arriendo = Mallseleccionado.Arriendo;
                foreach (Pisos piso in Mallseleccionado.pisos)
                {
                    List<Tiendas> listatiendas = piso.TomarTiendas;
                    foreach (Tiendas tienda in listatiendas)
                    {
                        int ventas = 0;
                        int gananciasdia = 0;
                        int gananciasacumuladas = 0;
                        valorTienda = new TiendasSimuladas(Mallseleccionado.nombre, tienda.Nombre, tienda.Nroempleados, tienda.Categoria, tienda.Nropiso, tienda.Area, tienda.Preciomin, tienda.Preciomax, tienda.Sueldo, ventas, gananciasdia, gananciasacumuladas,arriendo, Mallseleccionado.Horas);
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
            detener = 0;

            DispatcherTimer dispathcer = new DispatcherTimer();

            dispathcer.Interval = new TimeSpan(0, 0, 1);
            dispathcer.Tick += (s, a) =>
            {
                if (Seguir)
                {
                    SimularDia();
                    updateDataGrid_Simualcion();
                }
                else
                {
                    dispathcer.Stop();
                }
            };

            dispathcer.Start();
        }

        private void Detener_Click(object sender, RoutedEventArgs e)
        {
            detener += 1;
            Seguir = false;

            if (detener > 1)
            {
                detener = 0;
                ListaSimulacion = new List<TiendasSimuladas>();
                label_nrodia.Content = "0";
                Borrar_Simulacion();
                Iniciar_Inicio();
            }
        }

        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog buscar = new SaveFileDialog();
            buscar.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (buscar.ShowDialog() == false)
            {

            }
            else
            {
                string direccion = buscar.FileName;
                try
                {
                    GuardarSimulacion(ListaSimulacion, direccion);
                }
                catch
                {
                    MessageBox.Show("ERROR : No se a podido guardar");
                }
            }           
        }

        private void Cargar_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            buscar.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (buscar.ShowDialog() == false)
            {

            }
            else
            {
                string direccion = buscar.FileName;
                try
                {
                    ListaSimulacion = CargarSimulacion(direccion);
                    updateDataGrid_Simualcion();
                }
                catch
                {
                    MessageBox.Show("ERROR : El archivo seleccionado no es del tipo Simulación");
                }
            }
        }

        private void GuardarMall_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog buscar = new SaveFileDialog();
            buscar.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            
            if (buscar.ShowDialog() == false)
            {

            }
            else
            {
                string direccion = buscar.FileName;
                try
                {
                    GuardarMall(ListaMall, direccion);
                }
                catch
                {
                    MessageBox.Show("ERROR : No se a podido guardar");
                }
            }
        }

        private void CargarMall_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            buscar.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (buscar.ShowDialog() == false)
            {

            }
            else
            {
                string direccion = buscar.FileName;
                try
                {
                    ListaMall = CargarMall(direccion);
                    updateDataGrid();
                }
                catch
                {
                    MessageBox.Show("ERROR : El archivo seleccionado no es del tipo Mall");
                }
            }
        }

        private void CargarSimulacion_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            buscar.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (buscar.ShowDialog() == false)
            {

            }
            else
            {
                string direccion = buscar.FileName;
                string NombreMall = null;
                try
                {
                    ListaSimulacion = CargarSimulacion(direccion);
                    foreach (TiendasSimuladas tienda in ListaSimulacion)
                    {
                        NombreMall = tienda.NombreMall;
                        break;
                    }
                    label_valorNombre.Content = NombreMall;
                    updateDataGrid_Simualcion();
                    Borrar_Inicio();
                    Iniciar_Simulacion();
                }
                catch
                {
                    MessageBox.Show("ERROR : El archivo seleccionado no es del tipo Simulacion");
                }
            }
        }

        private void EditarSimulacio_Click(object sender, RoutedEventArgs e)
        {
            Window creador = new EditarSimulacion(EditarSim,seleccionada);
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
            Button_EditarSimulacion.Visibility = Visibility.Visible;
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
            Button_EditarSimulacion.Visibility = Visibility.Hidden;
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

        public void EditarMall(Mall nuevo)
        {
            ListaMall[cosa] = nuevo;
            updateDataGrid();
        }

        public void Editar_Simulacion(TiendasSimuladas editado)
        {
            ListaSimulacion[cosa] = editado; ;
            updateDataGrid_Simualcion();
        }

        private static void GuardarSimulacion(List<TiendasSimuladas> simulacion, string direccion)
        {
            FileStream fs = new FileStream(direccion, FileMode.Create);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, simulacion);
            fs.Close();
        }

        private static List<TiendasSimuladas> CargarSimulacion(string direccion)
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
        }

        private static List<Mall> CargarMall(string direccion)
        {
            FileStream fs = new FileStream(direccion, FileMode.Open);
            IFormatter formatter = new BinaryFormatter();
            List<Mall> simulacion = formatter.Deserialize(fs) as List<Mall>;
            fs.Close();
            return simulacion;
        }

        private void Ayuda_Click(object sender, RoutedEventArgs e)
        {
            Window creador = new Ayuda();
        }

        public void SimularDia()
        {
            int dia = 0;
            foreach (TiendasSimuladas tienda in ListaSimulacion)
            {
                Random rnd = new Random();
                double promedio = ((((tienda.Preciomax + tienda.Preciomin) / 2.0))*100)/ tienda.Preciomax;
                double CMAX = ((tienda.Area / 10.0) * Math.Max(0, 100 - promedio) * tienda.Nroempleados);
                int cmax = Convert.ToInt32(Math.Floor(CMAX));

                int clientesRecepcionados = rnd.Next(0, cmax+1);

                int ventadiaria = rnd.Next(tienda.Preciomin, tienda.Preciomax+1);
                int ganancias = ventadiaria * clientesRecepcionados - ((tienda.Nroempleados * tienda.Sueldos) + tienda.Arriendo);

                tienda.Clientespasados = clientesRecepcionados;
                tienda.Ventas = ventadiaria * clientesRecepcionados;
                tienda.Gananciasdia = ganancias;
                tienda.Gananciasacumuladas += ganancias;
                tienda.Dia += 1;
                dia = tienda.Dia;
            }
            label_nrodia.Content = Convert.ToString(dia);
        }

    }
}