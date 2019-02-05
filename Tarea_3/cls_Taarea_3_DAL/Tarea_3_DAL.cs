using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cls_Tarea_3_DAL
{
    public class Tarea_3_DAL
    {
        private string _sPalabra;
        private Boolean _bPalin;

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
    }
}
