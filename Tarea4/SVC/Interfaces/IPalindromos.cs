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
    public interface IPalindromos
    {
        [OperationContract]
        string Palindromo(string sPalabra, Boolean bPalin);

    }
}
