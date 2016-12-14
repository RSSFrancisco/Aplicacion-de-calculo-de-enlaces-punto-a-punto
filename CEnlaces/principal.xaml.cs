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
    /// Lógica de interacción para principal.xaml
    /// </summary>
    public partial class principal : Window
    {
        public principal()
        {
            InitializeComponent();
        }

        private void btnCalcularPIRE_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double ptx=double.Parse(txtPotenciaTx.Text.ToString());
                double perdidaCable = double.Parse(txtPerdidaCables.Text.ToString());
                double perdidaConector =double.Parse( txtPerdidaConectoresTx.Text.ToString());
                double gtx =double.Parse( txtGananciaTx.Text.ToString());
               
                double calculo=ptx + (-perdidaCable) + (-perdidaConector) + gtx;


                lblMensajePIRE.Content = "El PIRE es de : " + calculo +" dBi";
                MessageBox.Show( "La potencia de radiacion Isotropica es de: " + calculo+ " dBi");
                txtPIRE.Text = calculo.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Usted no ha llenado los campos necesarios para realizar este calculo");
            }
        }


        private void btnCalcularFSL_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double contante1 = 32.4;
                double constante2 = 20;
                double distancia = double.Parse(txtDistancia.Text);
                double frecuencia = double.Parse(txtFrecuencia.Text);

                double resultado = contante1 + constante2 * Math.Log10(distancia) + constante2 * Math.Log10(frecuencia);
                lblMensajeFSL.Content = "La perdida en el espacio libre es de: " + resultado+" dBi";
                MessageBox.Show("La perdida en el espacio libre es de: " + resultado + " dBi");
                txtFSL.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Usted no ha llenado los campos necesarios para realizar este calculo");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
                {

            double PIRE = double.Parse(txtPIRE.Text);
            double FSL = double.Parse(txtFSL.Text);
            double perdidaCab = double.Parse(txtPerdidadCablesRSL.Text);
            double perdidaCon = double.Parse(txtPerdidaconectoresRSL.Text);
            double gananciaGRX = double.Parse(GRX.Text);
            double resultadoRSL = PIRE + (-FSL) + (-perdidaCab) + (-perdidaCon) + gananciaGRX;
            lblMensajeRSL.Content = "El nivel de señal recibida es de : " + resultadoRSL + " dBi";
            MessageBox.Show("El nivel de señal recibida es de : " + resultadoRSL + "dBi");
               }
            catch(Exception ex)
            {

                MessageBox.Show("Usted no ha llenado los campos necesarios para realizar este calculo");
            }
        }

        private void btnCalcularMD_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float consigueRSL = float.Parse(txtMDRSL.Text);
                float sensibilidadReceptor = float.Parse(txtSensibilidadReceptor.Text);
                float resultadoMD = consigueRSL - (sensibilidadReceptor);
                lblMensajeMD.Content = "El margen de desvanecimiento es : " + resultadoMD + "dBi";
                MessageBox.Show("El margen de desvanecimiento es : " + resultadoMD + " dBi");
                if(resultadoMD>10)
                    {
                    if(resultadoMD<=15)
                        {
                            MessageBox.Show("El margen de desvanecimiento es satisfactorio ya que esta en: "+resultadoMD+" dBi");
                        }
                    }
                if (resultadoMD > 15)
                {
                    if (resultadoMD <= 20)
                    {
                        MessageBox.Show("El margen de desvanecimiento es bueno ya que esta en: " + resultadoMD + " dBi");
                    }
                }
                if (resultadoMD > 20)
                {
                    
                        MessageBox.Show("El margen de desvanecimiento es exelente ya que esta en: " + resultadoMD + " dBi");
                    
                }
                if (resultadoMD < 10)
                {
                    
                        MessageBox.Show("El margen de desvanecimiento no es factible ya que esta en: " + resultadoMD + " dBi");
                    
                }
                
            }
            catch (Exception)
            {
                
                 MessageBox.Show("Usted no ha llenado los campos necesarios para realizar este calculo");
            }
        }

        private void btnCancelarMD_Click(object sender, RoutedEventArgs e)
        {
            txtMDRSL.Clear();
            txtSensibilidadReceptor.Clear();
            MessageBox.Show("Cancelación exitosa");
        }

        private void btnCalcularFresnel_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double distancia1 = double.Parse(txtDistancia1Fresnel.Text);
                double distancia2 = double.Parse(txtDistancia2Fresnel.Text);
                double distanciad = double.Parse(txtDistanciaDFresnel.Text);
                double frecuenciaFresnel=double.Parse(txtFrecuenciaFresnel.Text);
                double resultadoFresnel = 17.32 * Math.Sqrt((distancia1 * distancia2)/(frecuenciaFresnel*distanciad));
                lblMensajeFresnel.Content = "La zona de fresnel es de: "+resultadoFresnel+" Metros";
                MessageBox.Show("La zona de fresnel es de: " + resultadoFresnel + " Metros");

            }
            catch (Exception)
            {
                 MessageBox.Show("Usted no ha llenado los campos necesarios para realizar este calculo");
                
            }
        }

        private void btnCancelarFresnel_Click(object sender, RoutedEventArgs e)
        {
            txtDistancia1Fresnel.Clear();
            txtDistancia2Fresnel.Clear();
            txtDistanciaDFresnel.Clear();
            txtFrecuenciaFresnel.Clear();
            MessageBox.Show("Cancelación exitosa");

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtPotenciaTx.Clear();
            txtPerdidaCables.Clear();
            txtPerdidaConectoresTx.Clear();
            txtGananciaTx.Clear();
            MessageBox.Show("Cancelación exitosa");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            txtDistancia.Clear();
            txtFrecuencia.Clear();
            MessageBox.Show("Cancelación exitosa");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            txtPIRE.Clear();
            txtFSL.Clear();
            txtPerdidaconectoresRSL.Clear();
            txtPerdidadCablesRSL.Clear();
            GRX.Clear();
            MessageBox.Show("Cancelación exitosa");

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            acerca acercade = new acerca();
            acercade.ShowDialog();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void Canvas_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MenuSistema objMenuSistema = new MenuSistema();
            Close();
            objMenuSistema.Show();
        }

        //private void Window_Closing_1(object sender, System.ComponentModel.CancelEventArgs e)
        //{
        //    try
        //    {

        //        MessageBoxResult resultado = MessageBox.Show("¿Desea salir del sistema CEnlaces?", "Seguridad del sistema ", MessageBoxButton.YesNo, MessageBoxImage.Question);
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
