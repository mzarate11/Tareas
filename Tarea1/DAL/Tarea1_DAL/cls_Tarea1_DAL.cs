using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Tarea1_DAL
{
    public class cls_Tarea1_DAL
    {
        private float _fdigito1, _fdigito2, _fresultado1;
        private char _cbnd;

        #region Variables Públicas
        public float fdigito1
        {
            get
            {
                return _fdigito1;
            }

            set
            {
                _fdigito1 = value;
            }
        }

        public float fdigito2
        {
            get
            {
                return _fdigito2;
            }

            set
            {
                _fdigito2 = value;
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

        public char cbnd
        {
            get
            {
                return _cbnd;
            }

            set
            {
                _cbnd = value;
            }
        }

        #endregion
   }
}
