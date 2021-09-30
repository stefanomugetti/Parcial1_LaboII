using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Compras 
    {
        private static Stack<Productos> listaProd;
        private string nombreProd;
        private string marcaProd;
        private string precioProd;
        private string tipoProd;
        private int cantidad;
        private int idProd;
        private static double facturacionTotal; 
        
       
        static Compras()
        {
            listaProd = new Stack<Productos>();
            facturacionTotal = 0;
        }

        public Compras(string nombreProd, string marcaProd, string precioProd, string tipoProd, int cantidad, int idProd) : this(precioProd, cantidad)
        {
            this.nombreProd = nombreProd;
            this.marcaProd = marcaProd;
            this.precioProd = precioProd;
            this.tipoProd = tipoProd;
            this.cantidad = cantidad;
            this.idProd = idProd;
            
        }
        public Compras(string precioProd,int cantidad)
        {
            if(double.TryParse(precioProd,out double precio))
            {
                facturacionTotal = facturacionTotal + (precio * cantidad);
            }
        }

        public string NombreProd { get => nombreProd; set => nombreProd = value; }
        public string MarcaProd { get => marcaProd; set => marcaProd = value; }
        public string PrecioProd { get => precioProd; set => precioProd = value; }
        public string TipoProd { get => tipoProd; set => tipoProd = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int IdProd { get => idProd; set => idProd = value; }

        
        public static double ObtenerTotalFacturado()
        {
            return facturacionTotal;
        }
      
    }
}
