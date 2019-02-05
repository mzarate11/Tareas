using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cls_Tarea_3_DAL;

namespace cls_Tarea_3_BLL
{
    public class Tarea_3_BLL
    {
        public void VerifPalin(ref Tarea_3_DAL ObjDAL)
        {
            if (ObjDAL.sPalabra.ToUpper().Equals(string.Join("", ObjDAL.sPalabra.ToUpper().ToCharArray().Reverse())))
            {
                ObjDAL.bPalin = true;
            }
            else
            {
                ObjDAL.bPalin = false;
            }
        }

    }
}
