using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Tarea1_DAL;
using BLL.Tarea1_BLL;

namespace PL_Tarea1.Tarea1_PL
{
    public partial class wfrm_Tarea1_PL : System.Web.UI.Page
    {
        cls_Tarea1_DAL ObjDAL = new cls_Tarea1_DAL();
        cls_Tarea1_BLL ObjBLL = new cls_Tarea1_BLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bttn_Calclular_Click(object sender, EventArgs e)
        {
            if (txt_Digito1.Text == "" || txt_Digito2.Text == "")
            {
                Response.Write("<script>window.alert('Debe llenar ambos espacios');</script>");
            }
            else
            {
                if (dld_Opciones.SelectedValue == "Sumar")
                {
                    ObjDAL.iDigito1 = Convert.ToInt32(txt_Digito1.Text);
                    ObjDAL.iDigito2 = Convert.ToInt32(txt_Digito2.Text);
                    ObjBLL.Sumar(ref ObjDAL);
                    txt_Resultado.Text = ObjDAL.iResultado.ToString();
                }
                else if (dld_Opciones.SelectedValue == "Restar")
                {
                    ObjDAL.iDigito1 = Convert.ToInt32(txt_Digito1.Text);
                    ObjDAL.iDigito2 = Convert.ToInt32(txt_Digito2.Text);
                    ObjBLL.Restar(ref ObjDAL);
                    txt_Resultado.Text = ObjDAL.iResultado.ToString();
                }
                else if (dld_Opciones.SelectedValue == "Multiplicar")
                {
                    ObjDAL.iDigito1 = Convert.ToInt32(txt_Digito1.Text);
                    ObjDAL.iDigito2 = Convert.ToInt32(txt_Digito2.Text);
                    ObjBLL.Multiplicar(ref ObjDAL);
                    txt_Resultado.Text = ObjDAL.iResultado.ToString();
                }
                else if (dld_Opciones.SelectedValue == "Dividir")
                {
                    ObjDAL.iDigito1 = Convert.ToInt32(txt_Digito1.Text);
                    ObjDAL.iDigito2 = Convert.ToInt32(txt_Digito2.Text);
                    ObjBLL.Dividir(ref ObjDAL);
                    if (ObjDAL.cBnd == 'M')
                    {
                        Response.Write("<script>window.alert('La división entre 0 no está dentro del conjunto de los números Reales');</script>");
                    }
                    else
                    {
                        txt_Resultado.Text = ObjDAL.iResultado.ToString();
                    }
                }
            }
        }

        protected void bttn_limpiar_Click(object sender, EventArgs e)
        {
            if (txt_Digito1.Text == "" && txt_Digito2.Text == "")
            {
                Response.Write("<script>window.alert('No Hay Datos que borrar');</script>");
            }
            else
            {
                txt_Digito1.Text = "";
                txt_Digito2.Text = "";
                txt_Resultado.Text = "";

            }
        }
    }
}