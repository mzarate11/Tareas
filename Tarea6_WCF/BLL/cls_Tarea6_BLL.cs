using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class cls_Tarea6_BLL
    {
        cls_Tarea6_DAL Obj_DAL = new cls_Tarea6_DAL();

        public void Encriptar()
        {
            Obj_DAL.bEncript = System.Text.Encoding.Unicode.GetBytes(Obj_DAL.sCadena);

            Obj_DAL.sResultado = Convert.ToBase64String(Obj_DAL.bEncript);
        }

        public void Desencriptar()
        {
            Obj_DAL.bEncript = Convert.FromBase64String(Obj_DAL.sCadena);

            Obj_DAL.sResultado = System.Text.Encoding.Unicode.GetString(Obj_DAL.bEncript);

        }
    }
}
