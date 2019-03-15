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
    public interface Idesencriptar
    {
        [OperationContract]
        string desencript(string sCadena, byte[] bEncript);
    }
}
