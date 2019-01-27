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
            ObjDAL.fresultado = ObjDAL.fdigito1 + ObjDAL.fdigito2;

        }


        public void Restar(ref cls_Tarea1_DAL ObjDAL)
        {
            ObjDAL.fresultado = ObjDAL.fdigito2 - ObjDAL.fdigito2;
        }

        public void Multiplicar(ref cls_Tarea1_DAL ObjDAL)
        {
            ObjDAL.fresultado = ObjDAL.fdigito2 * ObjDAL.fdigito2;
        }

        public void Dividir(ref cls_Tarea1_DAL ObjDAL)
        {
            ObjDAL.cbnd = 'B';
            if (ObjDAL.fdigito2 == 0)
            {
                ObjDAL.cbnd = 'M';
            }
            else
            {
                ObjDAL.fresultado = ObjDAL.fdigito1 / ObjDAL.fdigito2;
            }

        }
    }
}
