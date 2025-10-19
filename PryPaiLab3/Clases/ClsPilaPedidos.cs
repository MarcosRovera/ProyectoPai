using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryPaiLab3.Clases
{
    internal class ClsPilaPedidos
    {
        public ClsNodo Primero;
        public void Agregar(ClsNodo Nuevo)
        {
            Nuevo.Siguiente = Primero;
            Primero = Nuevo;
        }

        public void Eliminar()
        {
            if (Primero != null)
            {
                Primero = Primero.Siguiente;
            }
        }

        public void Recorrer(DataGridView Grilla)
        {
            ClsNodo aux = Primero;
            Grilla.Rows.Clear();

            while (aux != null)
            {
                Grilla.Rows.Add(aux.Nombre, aux.Cantidad, aux.Precio, aux.Subtotal);
                aux = aux.Siguiente;
            }
        }

        public decimal CalcularTotal()
        {
            decimal total = 0;
            ClsNodo aux = Primero;

            while (aux != null)
            {
                total += aux.Subtotal;
                aux = aux.Siguiente;
            }

            return total;
        }
    }
}

