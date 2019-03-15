using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BLL;

namespace SVC.Contracts
{
    public class service : Interfaces.Iservice
    {
        #region Metodo Calcu
        public string Calculador(int idigito1, int idigito2, char cSimbolo) //se crean variables aque serán llemnadas del objeto DAL
        {
            string sResultado = string.Empty;
            cls_Datos_DAL ObjDAL = new cls_Datos_DAL(); //instancias
            cls_Logica_BLL ObjBLL = new cls_Logica_BLL();

            ObjDAL.idigito1 = idigito1; // Izquierda: objeto DAL
            ObjDAL.idigito2 = idigito2; // Derecha: 

            switch (cSimbolo)
            {
                case '+':
                    {
                        ObjBLL.Sumar(ref ObjDAL);
                        sResultado = ObjDAL.fresultado.ToString("f2");
                        break;

                    }
                case '-':
                    {
                        ObjBLL.Restar(ref ObjDAL);
                        sResultado = ObjDAL.fresultado.ToString("f2");
                        break;
                    }
                case '*':
                    {
                        ObjBLL.Multiplicar(ref ObjDAL);
                        sResultado = ObjDAL.fresultado.ToString("f2");
                        break;
                    }
                case '/':
                    {
                        ObjBLL.Dividir(ref ObjDAL);
                        sResultado = ObjDAL.fresultado.ToString("f2");
                        break;
                    }
                default:
                    {
                        sResultado = "Operación Inválida";
                        break;
                    }
            }


            return sResultado;
        }
        #endregion

        #region Metodo Palin
        public bool Palindromo(string sPalabra, bool bPalin)
        {

            if ((sPalabra == null) || (sPalabra == string.Empty))
            {
                return false;
            }
            else
            {
                cls_Datos_DAL ObjDAL = new cls_Datos_DAL();
                cls_Logica_BLL ObjBLL = new cls_Logica_BLL();

                ObjDAL.sPalabra = sPalabra;
                ObjDAL.bPalin = bPalin;

                ObjBLL.VerifPalin(ref ObjDAL);

                return ObjDAL.bPalin;
            }
        }
        #endregion
    }
}
