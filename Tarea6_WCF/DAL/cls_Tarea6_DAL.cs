using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cls_Tarea6_DAL
    {
        #region Encriptado y desemcriptado
        #region Variables Privadas
        private string _sCadena, _sResultado;
        byte[] _bEncript;
        #endregion

        #region Variables Públicas
        public string sCadena
        {
            get
            {
                return _sCadena;
            }

            set
            {
                _sCadena = value;
            }
        }

        public string sResultado
        {
            get
            {
                return _sResultado;
            }

            set
            {
                _sResultado = value;
            }
        }

        public byte[] bEncript
        {
            get
            {
                return _bEncript;
            }

            set
            {
                _bEncript = value;
            }
        }
        #endregion

        #endregion
    }
}
