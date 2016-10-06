using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL;

namespace BLL
{
    public class Materiales : ClaseMaestra
    {
        public int MaterialesId { get; set; }
        public string Razon { get; set; }
        public List<MaterialesDetalles> Materiale { get; set; }

        public Materiales()
        {
            this.MaterialesId = 0;
            this.Razon = "";
            Materiale = new List<MaterialesDetalles>();
        }



        public override bool Insertar()
        {
            ConexionDb conexion = new ConexionDb();
            int retorno = 0;
            object identity;
            try
            {
               identity = conexion.ObtenerValor(string.Format("Insert Into Materiales(Razon) values('{0}') select @@Identity", this.Razon));
                int.TryParse(identity.ToString(), out retorno);
                this.MaterialesId = retorno;
                foreach (MaterialesDetalles item in this.Materiale)
                {
                    conexion.Ejecutar(string.Format("insert into Materiales(MaterialesDetallesId,MaterialesId,TiposMateriales,Cantidad) Values ({0},{1},'{2}')", retorno, (int)item.Materiale, (int)item.Cantidad));
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retorno > 0;
        }

        public void AgregarMateriales(TiposMateriales tipo, string Cantidad)
        {
           
            Materiale.Add(new MaterialesDetalles(tipo, Cantidad));
        }

        public override bool Eliminar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;
            try
            {
                retorno = conexion.Ejecutar(string.Format("delete from Materiales where MaterialesId=", this.MaterialesId));

                if (retorno)
                    conexion.Ejecutar("Delete from MaterialesDetalles Where MaterialeId=" + this.MaterialesId.ToString());
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return retorno;

        }
    }
}

     /*   public override bool Editar()
        {
            throw new NotImplementedException();
        }

        public override bool Buscar(int IdBuscado)
        {
            throw new NotImplementedException();
        }

        public override DataTable Listado(string Campos, string Condicion, string Orden)
        {
            throw new NotImplementedException();
        }*/

