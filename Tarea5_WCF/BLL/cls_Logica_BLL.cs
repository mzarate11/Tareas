using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class cls_Logica_BLL
    {
        #region Metodos Calcu
        public void Sumar(ref cls_Datos_DAL ObjDAL)
        {
            ObjDAL.fresultado = ObjDAL.idigito1 + ObjDAL.idigito2;
        }
        public void Restar(ref cls_Datos_DAL ObjDAL)
        {
            ObjDAL.fresultado = ObjDAL.idigito1 - ObjDAL.idigito2;
        }
        public void Multiplicar(ref cls_Datos_DAL ObjDAL)
        {
            ObjDAL.fresultado = ObjDAL.idigito1 * ObjDAL.idigito2;
        }
        public void Dividir(ref cls_Datos_DAL ObjDAL)
        {
            ObjDAL.fresultado = ObjDAL.idigito1 / ObjDAL.idigito2;
        }
        #endregion

        #region Metodos Palin
        public void VerifPalin(ref cls_Datos_DAL ObjDAL)
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
        #endregion

    }
}
