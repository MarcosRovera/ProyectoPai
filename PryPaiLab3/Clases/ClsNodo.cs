using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryPaiLab3.Clases
{
    internal class ClsNodo
    {
        private int idProd;
        private string nom;
        private int cant;
        private decimal precio;
        private decimal subt;
        private ClsNodo sig;

        public int IdProducto
        {
            get { return idProd; }
            set { idProd = value; }
        }

        public string Nombre
        {
            get { return nom; }
            set { nom = value; }
        }

        public int Cantidad
        {
            get { return cant; }
            set { cant = value; }
        }

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public decimal Subtotal
        {
            get { return subt; }
            set { subt = value; }
        }

        public ClsNodo Siguiente
        {
            get { return sig; }
            set { sig = value; }
        }
    }
}
