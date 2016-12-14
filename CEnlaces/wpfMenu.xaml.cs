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
using CEnlaces.funciones;
using System.Collections;
using System.Data;

namespace CEnlaces
{
    /// <summary>
    /// Interaction logic for wpfMenu.xaml
    /// </summary>
    public partial class wpfMenu : Window
    {
       

        //List<equipos> _listar = new List<equipos>();

        //private static DataTable dtEquipos;
        public wpfMenu()
        {
            InitializeComponent();
          
          
        }

        private void Canvas_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MenuSistema objMenuSistema = new MenuSistema();
            Close();
            objMenuSistema.Show();
        }
        // se valida que los campos de texto no esten vacios 
        public bool ValidacionCampos()
        {
            
            try
            {
                if (txtNombreEquipo.Text == "")
                {
                    lblNombreEquipo.Content = "Ingresar *";
                    return false;
                }
                if (txtWatssPorHora.Text == "")
                {
                    lblWattsHora.Content = "Ingresar *";
                    return false;
                }
                if (txtCantidad.Text == "")
                {
                    lblCantidadEquipos.Content = "Ingresar *";
                    return false;
                }
                if(txtHorasFuncionEquipo.Text=="")
                     {
                    lblHorasFuncionamiento.Content="Ingresar *";
                    return false;
                     }
               
               
              
            }
            catch (Exception)
            {

                MessageBox.Show("A ocurrido una exepción");
            }
            return true;
            
        }
        public void agregarEquipo()
          {
            
              //variable de cantidad de productos 
              Decimal sumaCantidad = 1;

            //  //variable de wastts hora del uso del equipo
            //  Decimal sumaWatts =0;
            ////variable de las horas de funcionamiento de los equipos 
            //  Decimal sumaHorasEquipos = 0;
            //variable que calcula el total de el gasto de energia 
              Decimal TotalEnergia = 0;
              //Decimal SumaTotal = 0;
              //Decimal subTotal = 0;
              lblCantidad.Items.Add(txtCantidad.Text);
              lblCantidad.Items.Add(txtWatssPorHora.Text);
              lblCantidad.Items.Add(txtHorasFuncionEquipo.Text);
          
            
              foreach (String i in lblCantidad.Items)
              {
                  if (lblCantidad.Items.Count > 3)
                  {
                      lblCantidad.Items.Clear();
                
                      sumaCantidad = sumaCantidad * Decimal.Parse(i.ToString());
                      
                  }
                  else
                  {

                      sumaCantidad = sumaCantidad * Decimal.Parse(i.ToString());
                     
                  }      
              }
              lbSubtotal.Items.Add(sumaCantidad.ToString());
                foreach (String i in lbSubtotal.Items)
              {
                 
              
                      TotalEnergia = TotalEnergia + Decimal.Parse(i.ToString());
                     
              }

                if (lblCantidad.Items.Count < 3)
                {

                }
                else
                {
                    lbEquipos.Items.Add(txtNombreEquipo.Text);

                }
              lblTotal.Content = "Total: " + TotalEnergia.ToString()+" Watts Hora/Dia";
              txtA1CargaTotalDiaria.Text = TotalEnergia.ToString();
              int TotalConsumo = int.Parse(Math.Round(TotalEnergia).ToString());
              if (TotalConsumo > 700)
              {
                  btnConsumoTotal.Width = 700;
                  totalConsumoEnergia.Content = Decimal.Round(TotalEnergia).ToString() + " Watts Hora/Dia";
              }
              else
              {
                  btnConsumoTotal.Width = TotalConsumo;
                  totalConsumoEnergia.Content = Decimal.Round(TotalEnergia).ToString() + " Watts Hora/Dia";
              }
               
              
            
              
          }
        private void btnAgregarEquipo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(ValidacionCampos()==true)
                {
                    agregarEquipo();

                    
                }
                    
            }
            catch (Exception)
            {
                
               
            }

          
            

        }

        private void btnCancelar_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                txtCantidad.Clear();
                txtHorasFuncionEquipo.Clear();
                txtNombreEquipo.Clear();
                txtWatssPorHora.Clear();
                lblCantidad.Items.Clear();
                lbEquipos.Items.Clear();
                lbSubtotal.Items.Clear();
                lblTotal.Content = "Total";
                MessageBox.Show("Su calculo ha sido cancelado con exito");
            }
            catch (Exception)
            {
                
              
                MessageBox.Show("A ocurrido una exepción");
            }
        }
        public bool validarCamposAmperaje()
        {
            try
            {
                //if(txtHorasDeSol.Text=="")
                //{
                //    mensajeHorasSol.Content = "Ingresar *";
                //    return false;
                //}
                //if (txtHorasDeReserva.Text == "")
                //{
                //    mensajeHorasReserva.Content = "Ingresar *";
                //    return false;
                //}
                // if ( txtAmperajePanel.Text== "")
                //{
                //     mensajeAmperajePanel.Content= "Ingresar *";
                //    return false;
                //}
               
                //if (txtCargaNominaBateria.Text =="")
                //{
                //    mensajeCargaNominalBateria.Content = "Ingresar *";
                //    return false;
                //}
                 if (txtA1CargaTotalDiaria.Text == "")
                {
                    mensajeA1.Content = "Ingresar *";
                    return false;
                }
                 if (txtA2TensionCorrienteDirecta.Text == "")
                {
                     mensajeA2.Content= "Ingresar *";
                    return false;
                }
                // if ( txtA3CargaDiariaCorriente.Text== "")
                //{
                //     mensajeA3.Content= "Ingresar *";
                //    return false;
                //}
                 if ( txtA4FactorSeguridadBaterias.Text== "")
                {
                    mensajeA4.Content = "Ingresar *";
                    return false;
                }
                // if ( txtA5CargaCorrienteDirigida.Text== "")
                //{
                //     mensajeA5.Content= "Ingresar *";
                //    return false;
                //}
                 if ( txtA6PromedioHorasDia.Text== "")
                {
                    mensajeA6.Content = "Ingresar *";
                    return false;
                }
               
            
            }
            catch (Exception)
            {

                MessageBox.Show("A ucurrido una exepcion Vuelva a intertarlo mas tarde");
            }
            return true;
        }
        //publicacion de propiedades publicas
        public Decimal @A1=0;
        public Decimal @A2=0;
        public Decimal @A3=0;
        public Decimal @A4=0;
        public Decimal @A5=0;
        public Decimal @A6=0;
        public Decimal @A7=0;
        public Decimal @B2 = 0;


        public void CalcularAmperaje()
        {
            try
            {
                //Decimal @horasSol =Decimal.Parse(txtHorasDeSol.Text.ToString());
                //Decimal @NumeroHorasReserva = Decimal.Parse(txtHorasDeReserva.Text.ToString());
                //Decimal @AmperajePanel=Decimal.Parse(txtAmperajePanel.Text.ToString());
                //Decimal @CargaNominalBateria=Decimal.Parse(txtCargaNominaBateria.Text.ToString());
                 @A1=Decimal.Parse(txtA1CargaTotalDiaria.Text.ToString());
                 @A2=Decimal.Parse(txtA2TensionCorrienteDirecta.Text.ToString());
                 @A3=A1/A2;
                 txtA3CargaDiariaCorriente.Text =@A3.ToString();
                 @A4=Decimal.Parse(txtA4FactorSeguridadBaterias.Text.ToString());
                 @A5=A3*A4;
                 txtA5CargaCorrienteDirigida.Text = @A5.ToString();
                 txtC1.Text = @A5.ToString();
                 @A6=Decimal.Parse(txtA6PromedioHorasDia.Text.ToString());
                 @A7 = A5 / A6;
                 MensajeA7.Content =@A7.ToString()+" Amperes";

                 int numeroAmperaje = int.Parse(Math.Round(@A7).ToString());
                 if (numeroAmperaje > 700)
                 {
                     consumoTotalAmperes.Width = 700;
                     TotalAmperes.Content = Decimal.Round(A7).ToString() + " Amperes";
                 }
                 else
                 {
                     consumoTotalAmperes.Width = numeroAmperaje;
                     TotalAmperes.Content = Decimal.Round(A7).ToString() + " Amperes";
                 }
               
               
                
            }
            catch (Exception)
            {
                
             MessageBox.Show("Usted debe ingresar datos para poder hacer el calculo");

            }
        }

        private void btnCalcularAmperaje_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                validarCamposAmperaje();
                CalcularAmperaje();
            }
            catch (Exception)
            {
              MessageBox.Show("A ucurrido una exepcion Vuelva a intertanlo mas tarde");

            }
        }
        public bool validarCajasPaneles()
        {
            try
            {
                if (txtB1AmperajeMaximoModuloSolar.Text=="")
                {
                    mensajeAmperajeMaximoModuloSolar.Content = "Ingresar *";
                    return false;
                }
                if (txtB2NumeroDePanelesNecesarios.Text == "")
                {
                    if (txtA5CargaCorrienteDirigida.Text == "")
                    {
                        MessageBox.Show("Usted debe de realizar los calculos anteriores para poder conseguir este dato");
                        tbCAlcularAmperaje.Focus();
                        return false;
                    }
                    if (txtA6PromedioHorasDia.Text == "")
                    {
                        MessageBox.Show("Usted debe de realizar los calculos anteriores para poder conseguir este dato");
                        tbCAlcularAmperaje.Focus();
                        return false;
                    }
                    Decimal @A7 = Decimal.Parse(txtA5CargaCorrienteDirigida.Text.ToString()) / Decimal.Parse(txtA6PromedioHorasDia.Text.ToString());
                    
                    Decimal @B2 = @A7 / Decimal.Parse(txtB1AmperajeMaximoModuloSolar.Text.ToString());
                    txtB2NumeroDePanelesNecesarios.Text = @B2.ToString();
                    lblNumeroPaneles.Content = Math.Round(@B2) + " Paneles";
                    //codigo para dibujar el tamaño de un elemento con datos dinamicos obtenidos de los calculos de las variables
                    int numeroPanel = int.Parse(Math.Round(@B2).ToString());
                    if (numeroPanel > 700)
                    {
                        ResultadoTotalPaneles.Width = 700;
                        TotalPanelesSolares.Content = Math.Round(@B2) + " Paneles";
                    }
                    else
                    {
                        ResultadoTotalPaneles.Width = numeroPanel;
                        TotalPanelesSolares.Content = Math.Round(@B2) + " Paneles";
                    }
                }
                else
                {
                    Decimal @A7 = Decimal.Parse(txtA5CargaCorrienteDirigida.Text.ToString()) / Decimal.Parse(txtA6PromedioHorasDia.Text.ToString());
                    Decimal @B2 = @A7 / Decimal.Parse(txtB1AmperajeMaximoModuloSolar.Text.ToString());
                    txtB2NumeroDePanelesNecesarios.Text = @B2.ToString();
                    lblNumeroPaneles.Content = Math.Round(@B2) + " Paneles";
                    //codigo para dibujar el tamaño de un elemento con datos dinamicos obtenidos de los calculos de las variables
                    //int numeroPanel = int.Parse(Math.Round(@B2).ToString());
                    //txtB2NumeroDePanelesNecesarios.Width =numeroPanel ;
                  
                         int numeroPanel = int.Parse(Math.Round(@B2).ToString());
                         if (numeroPanel > 700)
                         {
                             ResultadoTotalPaneles.Width = 700;
                             TotalPanelesSolares.Content = Math.Round(@B2) + " Paneles";
                         }
                         else
                         {
                             ResultadoTotalPaneles.Width = numeroPanel;
                             TotalPanelesSolares.Content = Math.Round(@B2) + " Paneles";
                         }
                        //for (int i=1; i <= numeroPanel; i++)
                        //{
                        //    DibujaPaneles.Items.Add(i);

                        //}
                   
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Usted debe de ingresar Caracteres Validos en el sistema\n los datos aceptados son solo numeros y comas ", "Mensaje del sistema ");
               
            }
            return true;
        }
        private void btnCalcularPaneles_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                validarCajasPaneles();
               
            }
            catch (Exception)
            {

                MessageBox.Show("Seguridad del sistema","A ocurrido un error vuelva a intentarlo mas tarde");
            }
        }

        private void btnCancelarPaneles_Click_1(object sender, RoutedEventArgs e)
        {
            txtB1AmperajeMaximoModuloSolar.Clear();
            txtB2NumeroDePanelesNecesarios.Clear();
            lblNumeroPaneles.Content = "";
        }

        private void btnLimpiar_Click_1(object sender, RoutedEventArgs e)
        {
            txtCantidad.Clear();
            txtHorasFuncionEquipo.Clear();
            txtNombreEquipo.Clear();
            txtWatssPorHora.Clear();
        }

        public bool calcularBaterias()
        {
            try
            {
                Decimal @C1=0;
                Decimal @C2=0;
                Decimal @C3=0;
                Decimal @C4=0;
                Decimal @C5=0;
                Decimal @C6=0;
                Decimal @C7=0;
                Decimal @C8=0;
                if(txtA5CargaCorrienteDirigida.Text=="")
                {
                    MessageBox.Show(" Para poder realizar esta operacion es necesario \n Realizar los calculos anteriores","Mensaje del sistema");
                tbCAlcularAmperaje.Focus();
                return false;
                }
               
                 @C1 = Decimal.Parse(txtA5CargaCorrienteDirigida.Text.ToString());
                
                if (txtC2.Text == "")
                {
                    MessageBox.Show("Usted debe ingresar Los dias de reserva de sol");
                    return false;
                }
                @C2 = Decimal.Parse(txtC2.Text.ToString()); 

                @C3 = @C1 * C2;
                txtC3.Text = @C3.ToString();
                if (txtC4.Text == "")
                {
                    MessageBox.Show("Usted debe ingresar el factor de\n Profundidad de descarga de las baterias ");
                    return false;
                }
                @C4=Decimal.Parse(txtC4.Text.ToString());
             
                @C5 = @C3 / @C4;
                @txtC5.Text = @C5.ToString();
                if (txtC6.Text == "")
                {
                    MessageBox.Show("Usted debe de ingresar la Capacidad\n Nominal de la Bateria en uso");
                    return false;
                }
                @C6 = Decimal.Parse(txtC6.Text.ToString());
                @C7 = @C5 / @C6;
                @C8 = Math.Round(@C7);
                lblTotalBaterias.Content = @C7.ToString() + " Baterias";
                lblTotalBateriasRedondeado.Content = @C8.ToString() + " Baterias";
                int TotalBateriasGrafica = int.Parse(@C8.ToString());
                if (TotalBateriasGrafica > 700)
                {
                    btnTotalBaterias.Width = 700;
                    TotalBaterias.Content = TotalBateriasGrafica.ToString() + " Baterias";
                }
                else
                {
                    btnTotalBaterias.Width = TotalBateriasGrafica;
                    TotalBaterias.Content = TotalBateriasGrafica.ToString() + " Baterias";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("A ocurrido un error \n Vuelva a intentarlo mas tarde","Mensaje del sistema");

            }
            return true;
        }
        private void btnCalcularBaterias_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                calcularBaterias();
            }
            catch (Exception)
            {
                MessageBox.Show("A ocurrido un error \n Vuelva a intentarlo mas tarde","Mensaje del sistema");
            }
        }

        private void btnCancelarBaterias_Click_1(object sender, RoutedEventArgs e)
        {
            txtC1.Clear();
            txtC2.Clear();
            txtC3.Clear();
            txtC4.Clear();
            txtC5.Clear();
            txtC6.Clear();
            lblTotalBaterias.Content = "";
            MessageBox.Show("Su calculo ha sido cancelado con exito\n","Mensaje del sistema");
        }

        private void btnCancelarAmperaje_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                txtA1CargaTotalDiaria.Clear();
                txtA2TensionCorrienteDirecta.Clear();
                txtA3CargaDiariaCorriente.Clear();
                txtA4FactorSeguridadBaterias.Clear();
                txtA5CargaCorrienteDirigida.Clear();
                txtA6PromedioHorasDia.Clear();
                MessageBox.Show("Su Calculo ha sido cancelado con exito","Mensaje del sistema");
            }
            catch (Exception)
            {
                
               
            }
        }
     
     
      
    }
}
