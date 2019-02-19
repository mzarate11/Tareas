using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BLL;

namespace SVC.Contracts
{
    public class Palindromos : Interfaces.IPalindromos
    {
        public string Palindromo(string sPalabra, Boolean bPalin)
        {
            string sResultado = string.Empty;
            cls_Tarea4_DAL ObjDAL = new cls_Tarea4_DAL();
            cls_Tarea4_BLL ObjBLL = new cls_Tarea4_BLL();

            ObjDAL.sPalabra = sPalabra;
            ObjDAL.bPalin = bPalin;

            ObjBLL.Palindromo(ref ObjDAL);
            if (ObjDAL.bPalin == true)
            {
                sResultado = "La Palabra es un Palíndromo";
            }
            else
            {
                sResultado = "La Palabra no es un Palíndromo";
            }
            return sResultado;
        }
    }
}
