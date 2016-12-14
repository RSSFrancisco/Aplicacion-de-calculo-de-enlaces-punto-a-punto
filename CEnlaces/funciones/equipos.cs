using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEnlaces.funciones
{
   public class equipos
    {
       string _nombre =string.Empty;
       int _cantidad = 0;
       decimal _wattsHora =0;
       decimal _horasEquipo =0;
       decimal _subtotal = 0;
       decimal _total = 0;

       public string Nombre { set { _nombre = value; } get { return _nombre; } }
       public int Cantidad { set { _cantidad = value; } get { return _cantidad; } }
       public decimal WattsHora { set { _wattsHora = value; } get { return _wattsHora; } }
       public decimal HorasEquipo { set { _horasEquipo = value; } get { return _horasEquipo; } }
       //public decimal Subtotal { set { _subtotal = value; } get { return _subtotal; } }
       //public decimal Total { set { _total = value; } get { return _total; } }

       //public equipos(string nombre, int cantidad,
       //    decimal wattsHora, decimal horasEquipo)
       //    //decimal subtotal, decimal total)
       //{
       //    this._nombre = nombre;
       //    this._cantidad = cantidad;
       //    this._wattsHora = wattsHora;
       //    this._horasEquipo = horasEquipo;
       //    //this._subtotal = subtotal;
       //    //this._total = total;

       //}
       public equipos()
       { }
      

    }
}
