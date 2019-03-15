using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BLL;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace SVC.Contracts
{
    public class cls_desencriptar_SVC : Interfaces.Idesencriptar
    {
        public string desencript(string sCadena, byte[] bEncript)
        {
            string sResultado;
            cls_Tarea6_DAL Obj_DAL = new cls_Tarea6_DAL();
            cls_Tarea6_BLL Obj_BLL = new cls_Tarea6_BLL();

            Obj_DAL.sCadena = sCadena;
            Obj_DAL.bEncript = bEncript;

            Obj_BLL.Desencriptar(ref Obj_DAL);
            sResultado = Obj_DAL.sResultado;

            return sResultado;
        }

    }
}
