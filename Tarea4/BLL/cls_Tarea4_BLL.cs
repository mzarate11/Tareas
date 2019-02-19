using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class cls_Tarea4_BLL
    {
        public void Palindromo(ref cls_Tarea4_DAL ObjDAL)
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
