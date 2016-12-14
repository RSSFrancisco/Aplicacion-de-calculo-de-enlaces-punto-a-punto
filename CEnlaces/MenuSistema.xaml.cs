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

namespace CEnlaces
{
    /// <summary>
    /// Interaction logic for MenuSistema.xaml
    /// </summary>
    public partial class MenuSistema : Window
    {
        DateTime horaSistema = DateTime.UtcNow;
        public MenuSistema()
        {
            InitializeComponent();
            btnHoraSistema.Content ="Fecha: "+DateTime.Parse(horaSistema.ToString());
            
        }

        private void btnAcercaDe_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            acerca objAcerca = new acerca();
            objAcerca.ShowDialog();
            
        }

        private void btnCalculoEnlaces_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            principal objPrincipal = new principal();
            Close();
            objPrincipal.ShowDialog();
        }

        private void canvCalculoSFotovolt_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            wpfMenu objCalculoFotovolt = new wpfMenu();
            Close();
            objCalculoFotovolt.Show();
        }

        //private void Window_Closing_1(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    try
               
        //    {

        //        MessageBoxResult resultado = MessageBox.Show("¿Desea Salir del menú Cenlaces?", "Seguridad del sistema ", MessageBoxButton.YesNo, MessageBoxImage.Question);
        //        if (resultado == MessageBoxResult.Yes)
        //        {
        //            e.Cancel = false;
        //        }
        //        else
        //        {
        //            e.Cancel = true;
        //        }
        //    }
        //    finally { }
        //}

     

     
    }
}
