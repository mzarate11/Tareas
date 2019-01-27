using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Tarea1_DAL
{
    public class cls_Tarea1_DAL
    {
        private int _iDigito1, _iDigito2, _iResultado1, _iResultado2;
        private char _cBnd;

        #region Variables Públicas
        public int iDigito1
        {
            get
            {
                return _iDigito1;
            }

            set
            {
                _iDigito1 = value;
            }
        }

        public int iDigito2
        {
            get
            {
                return _iDigito2;
            }

            set
            {
                _iDigito2 = value;
            }
        }

        public int iResultado
        {
            get
            {
                return _iResultado1;
            }

            set
            {
                _iResultado1 = value;
            }
        }

        public int iResultado2
        {
            get
            {
                return _iResultado2;
            }

            set
            {
                _iResultado2 = value;
            }
        }

        public char cBnd
        {
            get
            {
                return _cBnd;
            }

            set
            {
                _cBnd = value;
            }
        }

        #endregion
   }
}
