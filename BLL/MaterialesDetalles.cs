using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class MaterialesDetalles
    {
        private TiposMateriales tipo;
        private string cantidad;

        public TiposMateriales Materiale { get; set; } 
        public int Cantidad { get; set; }

        public string Tipo
        {
            get { return this.Materiale.ToString(); }
        }

        public MaterialesDetalles(TiposMateriales tipo, int cantidad)
        {
            this.Materiale = tipo;
            this.Cantidad=cantidad;
        }

        public MaterialesDetalles(TiposMateriales tipo, string cantidad)
        {
            this.tipo = tipo;
            this.cantidad = cantidad;
        }
    }
   
}
