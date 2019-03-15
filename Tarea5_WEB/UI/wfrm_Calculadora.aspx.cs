using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using BLL;
using UI.SVC_service;

namespace UI
{
    public partial class wfrm_Calculadora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bttn_c_Click(object sender, EventArgs e)
        {
            SVC_service.IserviceClient ObjSVC = new SVC_service.IserviceClient();
            cls_DatosW_DAL ObjDAL = new cls_DatosW_DAL();
            cls_LogicaW_BLL ObjBLL = new cls_LogicaW_BLL();
            ObjDAL.idigito1 = Convert.ToInt32(txt_dg1);
            ObjDAL.idigito2 = Convert.ToInt32(txt_dg2);
            ObjDAL.cSimbolo = '+';
           // if (suma.Checked)
           //   {
           //     ObjDAL.cSimbolo = '+';
           //}
           //else if (resta.Checked)
           //{
           //    ObjDAL.cSimbolo = '-';
           //}
           //else if (multi.Checked)
           //{
           //    ObjDAL.cSimbolo = '*';
           //}
           //else if (divide.Checked)
           //{
           //    ObjDAL.cSimbolo = '/';
           //}
           //ObjBLL.Calcu(ref ObjDAL);
            ObjDAL.fresultado = Convert.ToSingle(ObjSVC.Calculador(ObjDAL.idigito1, ObjDAL.idigito2, ObjDAL.cSimbolo));

        
        txt.Text = ObjDAL.fresultado.ToString().Trim();
        }
    }
}