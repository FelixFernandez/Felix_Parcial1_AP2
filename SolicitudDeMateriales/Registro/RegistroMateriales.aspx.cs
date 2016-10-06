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

        }


        protected void ButtonGuardar_Click1(object sender, EventArgs e)
        {
          
            Materiales materiales;
            if (Session["Materiales"] == null)
                Session["Materiales"] = new Materiales();

            materiales = (Materiales)Session["Materiales"];

           materiales.MaterialesId = Convert.ToInt32(TextBoxId.Text);

            materiales.Razon = TextBoxRazon.Text;

            if (materiales.Insertar())
            {
                TextBoxId.Text = materiales.MaterialesId.ToString();
                TextBoxRazon.Text = materiales.Razon.ToString();
                Response.Write("se guardo correctamente");

            }



        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Materiales materiale;
            if (Session["Materiales"] == null)
                Session["Materiales"] = new Materiales();

            materiale = (Materiales)Session["Materiales"];



            TiposMateriales tipo;

            tipo = (TiposMateriales)Enum.Parse(typeof(TiposMateriales), DropDownListTela.SelectedValue);

            materiale.AgregarMateriales(tipo, TextBoxCantidad.Text);


            Session["Materiales"] = materiale;

            GridView1.DataSource = materiale.Materiale;
            GridView1.DataBind();

            DropDownListTela.Text = "";
        }

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {
            Materiales materiale = new Materiales();
            if (materiale.Eliminar())
            {
                Response.Write("se elimino correctamente");
                TextBoxId.Text = string.Empty;
                TextBoxCantidad.Text = string.Empty;
                TextBoxRazon.Text = string.Empty;
            }
        }

        protected void ButtonNuevo_Click(object sender, EventArgs e)
        {
            TextBoxId.Text = string.Empty;
            TextBoxCantidad.Text = string.Empty;
            TextBoxRazon.Text = string.Empty;
        }
    }
}
