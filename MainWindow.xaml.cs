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

namespace ProjectTestBibliotk
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var datos = new List<MiClase>
            {
                new MiClase { ID=1, name="Bob", correo="B@gmail.com", genero="M", celular=12345},
                new MiClase { ID=2, name="Eve", correo="E@gmail.com", genero="M", celular=78965},
                new MiClase { ID=3, name="Jhon", correo="J@gmail.com", genero="M", celular=65478},
                new MiClase { ID=4, name="Steve", correo="S@gmail.com", genero="M", celular=12548},
                new MiClase { ID=5, name="Alice", correo="A@gmail.com", genero="F", celular=96325}
            };

            Tabla.ItemsSource = datos;
        }

        //TODO incluir mas detalles al Boton del diseñador XAML
        private void Hello(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hola!");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["miColor"] = new SolidColorBrush(Colors.Red);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Resources["miColor"] = new SolidColorBrush(Colors.Green);
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var selectedItem = (MiClase)Tabla.SelectedItem;
                Label1.Content = selectedItem?.name;
            }
            catch (InvalidCastException)
            {
                Label1.Content = "No puedes seleccionar varias filas a la vez";
            }
            catch (Exception ex) when (!(ex is InvalidCastException))
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    public class MiClase
    { 
        public int ID { get; set; }
        public string name { get; set; }
        public string correo { get; set; }
        public string genero { get; set; }
        public int celular { get; set; }
    }

}
