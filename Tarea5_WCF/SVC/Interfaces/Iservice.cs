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
    public interface Iservice
    {
        [OperationContract]
        string Calculador(int idigito1, int idigito2, char cSimbolo);

        [OperationContract]
        bool Palindromo(string sPalabra, bool bPalin);
    }
}
