using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using cls_Tarea_3_DAL;
using cls_Tarea_3_BLL;

namespace UI_Tarea_3
{
    public partial class Tarea_3_UI : System.Web.UI.Page
    {
        Tarea_3_DAL ObjDAL = new Tarea_3_DAL();
        Tarea_3_BLL ObjBLL = new Tarea_3_BLL();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void bttn_preguntar_click(object sender, EventArgs e)
        {
            ObjDAL.sPalabra = txt_palabra.Value;
            ObjBLL.VerifPalin(ref ObjDAL);
            if (ObjDAL.bPalin == true)
            {
                txt_Respuesta.Value = "La Palabra es un Palíndromo";
            }
            else
            {
                txt_Respuesta.Value = "La palabra no es un Palíndromo";
            }
        }
        protected void bttn_limpiar_click(object sender, EventArgs e)
        {
            txt_palabra.Value = "";
            txt_Respuesta.Value = "";
        }

    }
}