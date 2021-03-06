﻿using System;
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
        public List<MaterialesDetalles> Tipo { get; set; }

        public Materiales()
        {
            this.MaterialesId = 0;
            this.Razon = "";
            Tipo = new List<MaterialesDetalles>();
        }



        public override bool Insertar()
        {
            ConexionDb conexion = new ConexionDb();
            MaterialesDetalles md = new MaterialesDetalles();
            bool retorno = false;
            try
            {
                conexion.ObtenerDatos(string.Format("Insert Into Materiales(MaterialesId,Razon) values('"+this.MaterialesId+"','" +this.Razon+"') select @@Identity"));
                
                foreach(MaterialesDetalles item in Tipo){
                    conexion.Ejecutar(string.Format("Insert Into MaterialesDetalles(MaterialesId,TiposMateriales,Cantidad) Values('" + md.Material + "','" + md.Cantidad +"')", retorno, (string)item.Material, (int)item.Cantidad));
                    
                   }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retorno;
        }

        public void AgregarMateriales(string material, int cantidad)
        {
            Tipo.Add(new MaterialesDetalles(material,cantidad));
        }

        public override bool Eliminar()
        {
            ConexionDb conexion = new ConexionDb();
            bool retorno = false;
           
                conexion.Ejecutar(string.Format("Delete from Materiales where MaterialesId =", this.MaterialesId));

                if (retorno) { 
                    conexion.Ejecutar("Delete from MaterialesDetalles Where MaterialesId =" + this.MaterialesId.ToString());
            }
           
            return retorno;

        }
    }
}
