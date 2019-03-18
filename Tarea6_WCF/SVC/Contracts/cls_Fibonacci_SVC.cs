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
    public class cls_Fibonacci_SVC : Interfaces.Ifibonacci
    {
        public string Fibo(int iLimite, string sResultadof, int ifactor1, int ifactor2, int iAux, int[] aFibo)
        {
            string sResultado;
            cls_Tarea6_DAL Obj_DAL = new cls_Tarea6_DAL();
            cls_Tarea6_BLL OBJ_BLL = new cls_Tarea6_BLL();
            Obj_DAL.iLimite = iLimite;
            Obj_DAL.ifactor1 = ifactor1;
            Obj_DAL.iFactor2 = ifactor2;
            Obj_DAL.iAux = iAux;
            Obj_DAL.aFibo = aFibo;
            OBJ_BLL.Llenar_Fibonacci(ref Obj_DAL);
            OBJ_BLL.Mostrar_Fibonacci(ref Obj_DAL);
            sResultadof = Obj_DAL.sResultadof;

            sResultado = sResultadof;

            return sResultado;
        } 
    }
}
