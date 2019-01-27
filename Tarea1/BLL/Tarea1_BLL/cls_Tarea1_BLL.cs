using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Tarea1_DAL;

namespace BLL.Tarea1_BLL
{
    public class cls_Tarea1_BLL
    {
        public void Sumar(ref cls_Tarea1_DAL ObjDAL)
        {
            ObjDAL.iResultado = ObjDAL.iDigito1 + ObjDAL.iDigito2;

        }


        public void Restar(ref cls_Tarea1_DAL ObjDAL)
        {
            ObjDAL.iResultado = ObjDAL.iDigito1 - ObjDAL.iDigito2;
        }

        public void Multiplicar(ref cls_Tarea1_DAL ObjDAL)
        {
            ObjDAL.iResultado = ObjDAL.iDigito1 * ObjDAL.iDigito2;
        }

        public void Dividir(ref cls_Tarea1_DAL ObjDAL)
        {
            ObjDAL.cBnd = 'B';
            if (ObjDAL.iDigito2 == 0)
            {
                ObjDAL.cBnd = 'M';
            }
            else
            {
                ObjDAL.iResultado = ObjDAL.iDigito1 / ObjDAL.iDigito2;
            }

        }
    }
}
