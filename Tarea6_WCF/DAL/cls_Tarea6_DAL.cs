using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cls_Tarea6_DAL
    {
        #region Encriptado y desencriptado
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

        #region Fibonacci

        #region Variables Privadas
        private int _iLimite, _ifactor1, _iFactor2, _iAux, _iFor;
        private int[] _aFibo;
        private string _sResultadof;
        
        #endregion

        #region Variables públicas
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

        public int ifactor1
        {
            get
            {
                return _ifactor1;
            }

            set
            {
                _ifactor1 = value;
            }
        }

        public int iFactor2
        {
            get
            {
                return _iFactor2;
            }

            set
            {
                _iFactor2 = value;
            }
        }

        public int iAux
        {
            get
            {
                return _iAux;
            }

            set
            {
                _iAux = value;
            }
        }

        public int iFor
        {
            get
            {
                return _iFor;
            }

            set
            {
                _iFor = value;
            }
        }

        public int[] aFibo
        {
            get
            {
                return _aFibo;
            }

            set
            {
                _aFibo = value;
            }
        }

        public string sResultadof
        {
            get
            {
                return sResultadof;
            }

            set
            {
                sResultadof = value;
            }
        }
        #endregion


        #endregion

    }
}
