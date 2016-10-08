using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class MaterialesDetalles
    {
        public string Material { get; set; } 
        public int Cantidad { get; set; }

        public MaterialesDetalles()
        {
            this.Material = "";
            this.Cantidad=0;
        }

        public MaterialesDetalles(string material, int cantidad)
        {
            Material = material;
            Cantidad = cantidad;
        }
    }
   
}
