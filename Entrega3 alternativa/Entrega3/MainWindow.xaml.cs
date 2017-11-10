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
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;



namespace Entrega3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : INotifyPropertyChanged
    {
        private List<Pisos> pisos;
        private int Nropiso = 1;
       
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string name)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public int _Nropiso
        {
            get { return Nropiso; }
            set {
                if(Nropiso != value)
                {
                    Nropiso = value;
                    OnPropertyChanged("_NroPiso");
                }
            }
        }

        public MainWindow()
        {
            DataContext = this;
            pisos = new List<Pisos>();
            InitializeComponent();

        }

        public void updateDataGrid()
        {
            ObservableCollection<Pisos> obsC = new ObservableCollection<Pisos>(pisos);
            dataGrid.ItemsSource = obsC;
        }

        private void Boton_Finalizar_Click(object sender, RoutedEventArgs e)
        {
            // Comprobar pisos y dimensiones...
            Ventana1 vt = new Ventana1(pisos);
            this.Close();
            vt.Show();
        }

        private void agregarPiso(Pisos nuevo)
        {
            pisos.Add(nuevo);
            updateDataGrid();
        }

        private void Boton_Agregar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (textBox_area.Text != null && Convert.ToInt32(textBox_area.Text) < 1000000 && Convert.ToInt32(textBox_area.Text) >= 0)
                {
                    agregarPiso(new Pisos(Nropiso, Convert.ToInt32(textBox_area.Text)));
                    
                    Nropiso++;
                    OnPropertyChanged("_NroPiso");
                }

            }
            catch (FormatException)
            {

            }
            
        }
    }
}
