using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace SolicitudDeMateriales.Registro
{
    public partial class RegistroMateriales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
               
                GridView1.DataBind();
            }
        }


        protected void ButtonGuardar_Click1(object sender, EventArgs e)
        {
            Materiales materiales = new Materiales();

            materiales.Razon = TextBoxRazon.Text;
            materiales.MaterialesId = Convert.ToInt32(TextBoxId.Text);

            if (materiales.Insertar())
            {
                TextBoxId.Text = materiales.MaterialesId.ToString();
                TextBoxRazon.Text = materiales.Razon.ToString();
                Limpiar();
                Response.Write("se guardo correctamente");
                
            }

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
           Materiales materiale;
             if (Session["Materiales"] == null)
                 Session["Materiales"] = new Materiales();
            materiale = (Materiales)Session["Materiales"];

            MaterialesDetalles md = new MaterialesDetalles();

            md.Material = TextBoxMaterial.Text;
            md.Cantidad = Convert.ToInt32(TextBoxCantidad.Text);

            materiale.AgregarMateriales(md.Material, md.Cantidad);


            Session["Materiales"] = materiale;

            GridView1.DataSource = materiale.Tipo;
            GridView1.DataBind();
           
           
        }

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {
            Materiales materiale = new Materiales();
            materiale.MaterialesId = Convert.ToInt32(TextBoxId.Text);
            if (materiale.Eliminar())
            {
                Response.Write("se elimino correctamente");
                Limpiar();
            }
        }

        protected void ButtonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

       public void Limpiar()
        {
            TextBoxId.Text = string.Empty;
            TextBoxCantidad.Text = string.Empty;
            TextBoxRazon.Text = string.Empty;
            TextBoxMaterial.Text = string.Empty;
        }
    }
}
