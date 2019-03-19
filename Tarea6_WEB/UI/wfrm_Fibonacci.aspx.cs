using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using BLL;

namespace UI
{
    public partial class wfrm_Fibonacci : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void bttn_F_Click(object sender, EventArgs e)
        {
            cls_Tarea6_DAL Obj_DAL = new cls_Tarea6_DAL();
            cls_Tarea6_BLL Obj_BLL = new cls_Tarea6_BLL();

            Obj_DAL.iLimite = Convert.ToInt32(txt_F.Value);
            Obj_BLL.Fibonacci(ref Obj_DAL);

            txt_R.Value = Obj_DAL.sResultadof.ToString();

        }
    }
}