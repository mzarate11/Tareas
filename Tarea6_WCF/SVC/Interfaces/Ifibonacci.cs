using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace SVC.Interfaces
{
    [ServiceContract]
    public interface Ifibonacci
    {
        [OperationContract]
        string Fibo(int iLimite, string sResultadof, int ifactor1, int ifactor2, int iAux, int[] aFibo);
    }
}
