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

namespace ProjectTestBibliotk.Interfaces
{
    public partial class Ventana1 : Window
    {
        public Ventana1()
        {
            InitializeComponent();
        }

        private void AbrirVentana2_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();

            try
            {
                Ventana2 ventana2 = new Ventana2();
                ventana2.Closed -= Ventana2_Closed;
                ventana2.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Ventana2_Closed(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
