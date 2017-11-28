using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Collections.ObjectModel;

namespace Entrega_04
{
    /// <summary>
    /// Lógica de interacción para EditarSimulacion.xaml
    /// </summary>
    public partial class EditarSimulacion : Window
    {
        public event editarsim EditarSim;
        TiendasSimuladas tienda;
        string categoria;
        int nro_categoria;

        public EditarSimulacion(editarsim editar, TiendasSimuladas tienda)
        {
            this.tienda = tienda;
            EditarSim += editar;
            InitializeComponent();
            textBox_nombreSimulacion.Text = tienda.Nombre;
            textBox_empleados.Text = Convert.ToString(tienda.Nroempleados);
            textBox_areaSimulacion.Text = Convert.ToString(tienda.Area);
            textBox_preciomax.Text = Convert.ToString(tienda.Preciomax);
            textBox_preciomin.Text = Convert.ToString(tienda.Preciomin);
            textBox_sueldo.Text = Convert.ToString(tienda.Sueldos);
            label_valorarriendo.Content=Convert.ToString(tienda.Arriendo);
            if (tienda.Categoria == "Comercial Ropa") { nro_categoria = 0; }
            else if (tienda.Categoria == "Comercial Hogar") { nro_categoria = 1; }
            else if (tienda.Categoria == "Comercial Alimento") { nro_categoria = 2; }
            else if (tienda.Categoria == "Comercial Ferreteria") { nro_categoria = 3; }
            else if (tienda.Categoria == "Comercial Tecnologia") { nro_categoria = 4; }
            else if (tienda.Categoria == "Comida Rapida") { nro_categoria = 5; }
            else if (tienda.Categoria == "Comida Restaurant") { nro_categoria = 6; }
            else if (tienda.Categoria == "Entretencion Cine") { nro_categoria = 7; }
            else if (tienda.Categoria == "Entretencion Juegos") { nro_categoria = 8; }
            else if (tienda.Categoria == "Entretencion Bowling") { nro_categoria = 9; }
            this.Show();

        }

        private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> data = new List<string>();
            data.Add("Ropa");
            data.Add("Hogar");
            data.Add("Alimento");
            data.Add("Ferreteria");
            data.Add("Tecnologia");
            data.Add("Rapida");
            data.Add("Restaurant");
            data.Add("Cine");
            data.Add("Juegos");
            data.Add("Bowling");


            var comboBox = sender as ComboBox;
            comboBox.ItemsSource = data;
            comboBox.SelectedIndex = nro_categoria;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            string value = comboBox.SelectedItem as string;
            if (value == "Ropa" || value == "Hogar" || value == "Alimento" || value == "Ferreteria" || value == "Tecnologia")
            {
                categoria = "Comercial " + value;
            }
            if (value == "Rapida" || value == "Restaurant")
            {
                categoria = "Comida " + value;
            }
            if (value == "Cine" || value == "Juegos" || value == "Bowling")
            {
                categoria = "Entretencion " + value;
            }
        }

        private void CrearTienda_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int areaTienda = int.Parse(textBox_areaSimulacion.Text);
                int nroempleados = int.Parse(textBox_empleados.Text);
                int preciomax = int.Parse(textBox_preciomax.Text);
                int preciomin = int.Parse(textBox_preciomin.Text);
                int sueldopromedio = int.Parse(textBox_sueldo.Text);
                int arriendo_M2 = tienda.Arriendo_M2;
                

                if (preciomax < preciomin)
                {
                    textBox_preciomax.BorderBrush = Brushes.Red;
                    textBox_preciomin.BorderBrush = Brushes.Red;
                    
                }
                else
                {
                    textBox_preciomax.BorderBrush = null;
                    textBox_preciomin.BorderBrush = null;
                    EditarSim(new TiendasSimuladas(textBox_nombreSimulacion.Text, nroempleados, categoria,tienda.Piso,areaTienda,preciomin,preciomax,sueldopromedio,tienda.Ventas,tienda.Gananciasdia,tienda.Gananciasacumuladas,arriendo_M2));
                    this.Close();
                }
            }
            catch
            {

            }
        }

        private void CancelarTienda_Click(object sender, RoutedEventArgs e)
        {
            textBox_nombreSimulacion.Text = tienda.Nombre;
            textBox_empleados.Text = Convert.ToString(tienda.Nroempleados);
            comboBox_categoria.Text = tienda.Categoria;
            textBox_areaSimulacion.Text = Convert.ToString(tienda.Area);
            textBox_preciomax.Text = Convert.ToString(tienda.Preciomax);
            textBox_preciomin.Text = Convert.ToString(tienda.Preciomin);
            textBox_sueldo.Text = Convert.ToString(tienda.Sueldos);
            label_valorarriendo.Content = Convert.ToString(tienda.Arriendo);
        }

        private void Ayuda_Click(object sender, RoutedEventArgs e)
        {
            Window creador = new Ayuda();
        }
    }
}
