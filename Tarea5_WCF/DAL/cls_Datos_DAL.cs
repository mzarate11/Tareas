using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cls_Datos_DAL
    {
        #region Variables calculadora
        private int _idigito1, _idigito2;
        private float _fresultado1;

        #region Variables Públicas
        public int idigito1
        {
            get
            {
                return _idigito1;
            }

            set
            {
                _idigito1 = value;
            }
        }

        public int idigito2
        {
            get
            {
                return _idigito2;
            }

            set
            {
                _idigito2 = value;
            }
        }

        public float fresultado
        {
            get
            {
                return _fresultado1;
            }

            set
            {
                _fresultado1 = value;
            }
        }
        #endregion
        #endregion

        #region Variables Palindromos
        private string _sPalabra;
        private bool _bPalin;

        #region VARIABLES PÚBLICAS
        public string sPalabra
        {
            get
            {
                return _sPalabra;
            }

            set
            {
                _sPalabra = value;
            }
        }

        public bool bPalin
        {
            get
            {
                return _bPalin;
            }

            set
            {
                _bPalin = value;
            }
        }
        #endregion
        #endregion

    }
}
