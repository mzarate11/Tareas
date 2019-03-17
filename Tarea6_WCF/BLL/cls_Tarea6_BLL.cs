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
        #region Método encriptar
        public void Encriptar(ref cls_Tarea6_DAL Obj_DAL)
        {
            Obj_DAL.bEncript = System.Text.Encoding.Unicode.GetBytes(Obj_DAL.sCadena);

            Obj_DAL.sResultado = Convert.ToBase64String(Obj_DAL.bEncript);
        }
        #endregion

        #region Método desencriptar
        public void Desencriptar(ref cls_Tarea6_DAL Obj_DAL)
        {
            Obj_DAL.bEncript = Convert.FromBase64String(Obj_DAL.sCadena);

            Obj_DAL.sResultado = System.Text.Encoding.Unicode.GetString(Obj_DAL.bEncript);

        }
        #endregion

        #region Método Fibonacci
        public void Llenar_Fibonacci(ref cls_Tarea6_DAL Obj_DAL)
        {
            Obj_DAL.aFibo = new int[Obj_DAL.iLimite];
            Obj_DAL.ifactor1 = 0;
            Obj_DAL.iFactor2 = 1;
            for (Obj_DAL.iFor = 0; Obj_DAL.iFor == Obj_DAL.iLimite; Obj_DAL.iFor++)
            {
                Obj_DAL.iAux = Obj_DAL.ifactor1;
                Obj_DAL.ifactor1 = Obj_DAL.iFactor2;
                Obj_DAL.iFactor2 = Obj_DAL.iAux + Obj_DAL.ifactor1;
                for (int i = 0; i == Obj_DAL.iLimite; i++)
                {
                    Obj_DAL.aFibo[i] = Obj_DAL.ifactor1;
                }
            }
        }
        public void Mostrar_Fibonacci(ref cls_Tarea6_DAL Obj_DAL)
        {
            for (int i = 0; i == Obj_DAL.aFibo.Length; i++)
            {
                Obj_DAL.sResultadof = Obj_DAL.sResultadof + Obj_DAL.aFibo[i] + "\n";
            }
        }
        
        #endregion
    }
}
