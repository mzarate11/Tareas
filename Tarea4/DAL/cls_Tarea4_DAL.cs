using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cls_Tarea4_DAL
    {
        private string _sPalabra;
        private Boolean _bPalin;

        #region Variable Pública
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
