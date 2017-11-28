using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Collections.ObjectModel;

namespace Entrega_04
{
    public partial class Ventana1 : Window
    {
        public event agregarMall MallAgregado;
        private int cosa;
        private Tiendas seleccionada;

        // -------------------------- //
        Mall nuevoMall;
        Pisos nuevoPiso;
        Tiendas nuevaTienda;
        int pisos;
        int pisoActual;
        int areaPiso;
        int area_Total_Tiendas;
        int PisoInferior;
        int nro_tiendas;
        int tienda_numero;
        string categoria;

        public Ventana1(agregarMall Mall)
        {
            MallAgregado += Mall;
            InitializeComponent();
            this.Show();          
            //------------------------------------------------------------//
        }

        private void CrearMall_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                pisoActual = 1;     // piso de inicio
                pisos = int.Parse(textBox_pisos.Text);
                int horas = int.Parse(textBox_horas.Text);
                int dinero = int.Parse(textBox_dinero.Text);
                int arriendo = int.Parse(textBox_arriendo.Text);

                if ( horas < 0 || 20 < horas)
                {
                    textBox_horas.BorderBrush = Brushes.Red;
                }
                else if (0 > pisos)
                {
                    textBox_pisos.BorderBrush = Brushes.Red;
                }
                else if  (0 > dinero)
                {
                    textBox_dinero.BorderBrush = Brushes.Red;
                }
                else if (0 > arriendo)
                {
                    textBox_arriendo.BorderBrush = Brushes.Red;
                }
                else
                {
                    nuevoMall = new Mall(pisos, horas, dinero, textBox_nombre.Text,arriendo);
                    //------------------------------------------------------------//

                    Borrar_NuevoMall();
                    Iniciar_NuevoPiso();
                    textBox_horas.BorderBrush = null;
                    textBox_pisos.BorderBrush = null;
                    textBox_dinero.BorderBrush = null;
                    textBox_arriendo.BorderBrush = null;
                }
            }

            catch
            {
                limpiarMall();
            }
        }

        private void CancelarMall_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CrearPiso_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                area_Total_Tiendas = 0;
                areaPiso = int.Parse(textBox_area.Text);
                nro_tiendas = int.Parse(textBox_tiendas.Text);
                tienda_numero = 1;

                pisoActual += 1;

                if ((pisoActual-1) > pisos)
                {
                    Borrar_NuevoPiso();
                    Iniciar_NuevoMall();
                }

                else
                {
                    if ((pisoActual - 1) == 1)
                    {
                        PisoInferior = areaPiso;
                        nuevoPiso = new Pisos(pisoActual - 1, areaPiso, nro_tiendas);
                        nuevoMall.AgregarPiso(nuevoPiso);

                        Borrar_NuevoPiso();
                        Iniciar_NuevaTienda();
                    }
                    else
                    {
                        if (PisoInferior < areaPiso)
                        {
                            pisoActual -= 1;
                            textBox_area.BorderBrush = Brushes.Red;
                        }
                        else
                        {
                            textBox_area.BorderBrush = null;
                            nuevoPiso = new Pisos(pisoActual-1, areaPiso, nro_tiendas);
                            nuevoMall.AgregarPiso(nuevoPiso);

                            PisoInferior = areaPiso;
                            Borrar_NuevoPiso();
                            Iniciar_NuevaTienda();
                        }
                    }
                }
            }
            catch
            {
                limpiarPiso();
            }
        }

        private void CancelarPiso_Click(object sender, RoutedEventArgs e)
        {
            pisoActual -= 1;
            Borrar_NuevoPiso();
            Iniciar_NuevoMall();
        }

        private void CrearTienda_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int areaTienda = int.Parse(textBox_areaTienda.Text);
                int nroempleados = int.Parse(textBox_empleados.Text);
                int preciomax = int.Parse(textBox_preciomax.Text);
                int preciomin = int.Parse(textBox_preciomin.Text);
                int sueldopromedio = int.Parse(textBox_sueldo.Text);

                area_Total_Tiendas += areaTienda;

                if (areaPiso < area_Total_Tiendas || preciomax < preciomin)
                {
                    area_Total_Tiendas -= areaTienda;
                    if (areaPiso < area_Total_Tiendas)
                    {
                        area_Total_Tiendas -= areaTienda;
                        textBox_areaTienda.BorderBrush = Brushes.Red;
                    }
                    else
                    {
                        textBox_preciomax.BorderBrush = Brushes.Red;
                        textBox_preciomin.BorderBrush = Brushes.Red;
                    }
                }
                else
                {
                    textBox_areaTienda.BorderBrush = null;
                    textBox_preciomax.BorderBrush = null;
                    textBox_preciomin.BorderBrush = null;
                    if (nro_tiendas > tienda_numero)
                    {
                        tienda_numero += 1;
                        nuevaTienda = new Tiendas(areaTienda, textBox_nombreTienda.Text, pisoActual - 1, nroempleados, preciomax, preciomin, categoria, sueldopromedio);
                        nuevoPiso.AgregarTienda(nuevaTienda);
                        updateDataGrid();
                        limpiarTienda();
                    }
                    else
                    {
                        tienda_numero = 1;
                        nuevaTienda = new Tiendas(areaTienda, textBox_nombreTienda.Text, pisoActual - 1, nroempleados, preciomax, preciomin, categoria, sueldopromedio);
                        nuevoPiso.AgregarTienda(nuevaTienda);
                        updateDataGrid();
                        limpiarTienda();

                        if ((pisoActual) > pisos)
                        {
                            MallAgregado(nuevoMall);
                            this.Close();
                        }
                        else
                        {
                            Borrar_NuevaTienda();
                            Iniciar_NuevoPiso();
                        }
                    }
                }
            }
            catch
            {
                limpiarTienda();
            }
        }

        private void CancelarTienda_Click(object sender, RoutedEventArgs e)
        {
            pisoActual -= 1;
            Borrar_NuevaTienda();
            Iniciar_NuevoPiso();
        }

        public void updateDataGrid()
        {
            ObservableCollection<Tiendas> obsC = new ObservableCollection<Tiendas>((nuevoPiso.tiendas));
            dataGrid.ItemsSource = obsC;
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            seleccionada = (Tiendas)dataGrid.SelectedItem;
            cosa = (nuevoPiso.tiendas).IndexOf(seleccionada);
        }

        private void dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (seleccionada != null)
            {
                seleccionada = (Tiendas)dataGrid.SelectedItem;
                cosa = (nuevoPiso.tiendas).IndexOf(seleccionada);
            }
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
            comboBox.SelectedIndex = 0;
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

        public void Iniciar_NuevoMall()
        {
            Titulo.Content = "Nuevo Mall ";
            Mostrar.Visibility = Visibility.Hidden;
            label_nombre.Visibility = Visibility.Visible;
            textBox_nombre.Visibility = Visibility.Visible;
            label_pisos.Visibility = Visibility.Visible;
            textBox_pisos.Visibility = Visibility.Visible;
            label_horas.Visibility = Visibility.Visible;
            textBox_horas.Visibility = Visibility.Visible;
            label_dinero.Visibility = Visibility.Visible;
            textBox_dinero.Visibility = Visibility.Visible;
            label_arriendo.Visibility = Visibility.Visible;
            textBox_arriendo.Visibility = Visibility.Visible;
            Button_CancelarMall.Visibility = Visibility.Visible;
            Button_CrearMall.Visibility = Visibility.Visible;
        }

        public void Borrar_NuevoMall()
        {
            label_nombre.Visibility = Visibility.Hidden;
            textBox_nombre.Visibility = Visibility.Hidden;
            label_pisos.Visibility = Visibility.Hidden;
            textBox_pisos.Visibility = Visibility.Hidden;
            label_horas.Visibility = Visibility.Hidden;
            textBox_horas.Visibility = Visibility.Hidden;
            label_dinero.Visibility = Visibility.Hidden;
            textBox_dinero.Visibility = Visibility.Hidden;
            label_arriendo.Visibility = Visibility.Hidden;
            textBox_arriendo.Visibility = Visibility.Hidden;
            Button_CancelarMall.Visibility = Visibility.Hidden;
            Button_CrearMall.Visibility = Visibility.Hidden;
            Mostrar.Visibility = Visibility.Visible;
        }

        public void Iniciar_NuevoPiso()
        {
            Titulo.Content = "Piso Mall ";
            label_pisoActual.Visibility = Visibility.Visible;
            textBox_pisoActual.Visibility = Visibility.Visible;
            textBox_pisoActual.Text = Convert.ToString(pisoActual);
            label_area.Visibility = Visibility.Visible;
            textBox_area.Visibility = Visibility.Visible;
            label_tiendas.Visibility = Visibility.Visible;
            textBox_tiendas.Visibility = Visibility.Visible;
            Button_CancelarPiso.Visibility = Visibility.Visible;
            Button_CrearPiso.Visibility = Visibility.Visible;
        }

        public void Borrar_NuevoPiso()
        {
            label_pisoActual.Visibility = Visibility.Hidden;
            textBox_pisoActual.Visibility = Visibility.Hidden;
            label_area.Visibility = Visibility.Hidden;
            textBox_area.Visibility = Visibility.Hidden;
            label_tiendas.Visibility = Visibility.Hidden;
            textBox_tiendas.Visibility = Visibility.Hidden;
            Button_CancelarPiso.Visibility = Visibility.Hidden;
            Button_CrearPiso.Visibility = Visibility.Hidden;
        }

        public void Iniciar_NuevaTienda()
        {
            Titulo.Content = "Tienda Mall ";
            label_pisoActual.Visibility = Visibility.Visible;
            textBox_pisoActual.Visibility = Visibility.Visible;
            label_areaTienda.Visibility = Visibility.Visible;
            textBox_areaTienda.Visibility = Visibility.Visible;
            label_nombreTienda.Visibility = Visibility.Visible;
            textBox_nombreTienda.Visibility = Visibility.Visible;
            label_empleados.Visibility = Visibility.Visible;
            textBox_empleados.Visibility = Visibility.Visible;
            label_precio.Visibility = Visibility.Visible;
            textBox_preciomin.Visibility = Visibility.Visible;
            textBox_preciomax.Visibility = Visibility.Visible;
            label_categoria.Visibility = Visibility.Visible;
            comboBox_categoria.Visibility = Visibility.Visible;
            label_sueldo.Visibility = Visibility.Visible;
            textBox_sueldo.Visibility = Visibility.Visible;

            Button_CancelarTienda.Visibility = Visibility.Visible;
            Button_CrearTienda.Visibility = Visibility.Visible;
        }

        public void Borrar_NuevaTienda()
        {
            label_pisoActual.Visibility = Visibility.Hidden;
            textBox_pisoActual.Visibility = Visibility.Hidden;
            label_areaTienda.Visibility = Visibility.Hidden;
            textBox_areaTienda.Visibility = Visibility.Hidden;
            label_nombreTienda.Visibility = Visibility.Hidden;
            textBox_nombreTienda.Visibility = Visibility.Hidden;
            label_empleados.Visibility = Visibility.Hidden;
            textBox_empleados.Visibility = Visibility.Hidden;
            label_precio.Visibility = Visibility.Hidden;
            textBox_preciomin.Visibility = Visibility.Hidden;
            textBox_preciomax.Visibility = Visibility.Hidden;
            label_categoria.Visibility = Visibility.Hidden;
            comboBox_categoria.Visibility = Visibility.Hidden;
            label_sueldo.Visibility = Visibility.Hidden;
            textBox_sueldo.Visibility = Visibility.Hidden;

            Button_CancelarTienda.Visibility = Visibility.Hidden;
            Button_CrearTienda.Visibility = Visibility.Hidden;
        }

        public void limpiarTienda()
        {
            textBox_areaTienda.Text="";
            textBox_nombreTienda.Text = "";
            textBox_empleados.Text = "";
            textBox_preciomin.Text = "";
            textBox_preciomax.Text = "";
            textBox_sueldo.Text = "";
        }

        public void limpiarPiso()
        {
            textBox_area.Text = "";
            textBox_tiendas.Text = "";
        }

        public void limpiarMall()
        {
            textBox_nombre.Text = "";
            textBox_pisos.Text = "";
            textBox_horas.Text = "";
            textBox_dinero.Text = "";
            textBox_arriendo.Text = "";
        }

        private void Ayuda_Click(object sender, RoutedEventArgs e)
        {
            Window creador = new Ayuda();
        }
    }
}
