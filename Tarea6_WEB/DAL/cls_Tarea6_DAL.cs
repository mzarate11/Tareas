using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cls_Tarea6_DAL
    {
        private string _sCadena, _sResultado, _sResultadof;
        private int _iLimite;
        byte[] _bEncript;

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

        public string sResultadof
        {
            get
            {
                return _sResultadof;
            }

            set
            {
                _sResultadof = value;
            }
        }

        public int iLimite
        {
            get
            {
                return _iLimite;
            }

            set
            {
                _iLimite = value;
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
    }
}
