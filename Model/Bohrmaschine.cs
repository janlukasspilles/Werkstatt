using System;
using System.Collections.Generic;
using System.Text;

namespace Werkstatt
{
    public class Bohrmaschine
    {
        #region Attributes
        private Bohrer _bohrer;
        #endregion
        #region Properties
        public Bohrer Bohrer { get => _bohrer; set => _bohrer = value; }
        #endregion
        #region Constructor
        public Bohrmaschine()
        {

        }
        public Bohrmaschine(Bohrer b)
        {
            Bohrer = b;
        }
        #endregion
        #region Methods
        public void BohrerEinsetzen(Bohrer b)
        {
            if (Bohrer != null)
                throw new Exception("Es befindet sich bereits ein Bohrer in der Bohrmaschine!");

            Bohrer = b;
        }

        public Bohrer BohrerEntfernen()
        {
            Bohrer tmp = Bohrer;
            Bohrer = null;
            return tmp;
        }
        #endregion
    }
}
