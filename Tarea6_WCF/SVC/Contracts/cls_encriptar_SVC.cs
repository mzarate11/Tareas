using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BLL;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace SVC.Contracts
{
    public class cls_encriptar_SVC : Interfaces.Iencriptar
    {
        public string Encript(string sCadena, byte[] bEncript, string sResultado)
        {
            cls_Tarea6_DAL Obj_DAL = new cls_Tarea6_DAL();
            cls_Tarea6_BLL Obj_BLL = new cls_Tarea6_BLL();

            Obj_DAL.sCadena = sCadena;
            Obj_DAL.bEncript = bEncript;
            Obj_DAL.sResultado = sResultado;

            Obj_BLL.Encriptar(ref Obj_DAL);

            return sResultado;
        }

    }
}
