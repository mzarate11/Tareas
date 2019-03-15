using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace SVC.Interfaces
{
    [ServiceContract]
    public interface Iencriptar
    {
        [OperationContract]
        string Encript(string sCadena, byte[] bEncript, string sResultado);

    }
}
