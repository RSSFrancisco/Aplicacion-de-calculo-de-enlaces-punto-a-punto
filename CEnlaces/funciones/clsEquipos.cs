using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;

namespace CEnlaces.funciones
{
   public class clsEquipos:CollectionBase
    {
       List<equipos> misEquipos;
       public List<equipos> equipos
       {
           set { misEquipos = value; }
           get { return misEquipos; }
       }
       public void calcularEnergia(string _nombre,int _cantidad)
       {
           try
           {
               Hashtable[] arregloEquipos = new Hashtable[misEquipos.Count];
               int indice = 0;
               foreach (equipos eq in misEquipos)
               {
                   Hashtable ht = new Hashtable();
                   ht.Add(_nombre,eq.Nombre);
                   ht.Add(_cantidad,int.Parse(eq.Cantidad.ToString()));
                   misEquipos.Add(eq);
               }

           }
           catch (Exception ex)
           {

               Console.Write(ex.Message);
           }
       }

       }
    }

