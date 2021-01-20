using System;
using System.Collections.Generic;
using System.Text;

namespace Werkstatt
{
    public class Bohrer
    {
        #region Attributes
        private int _groesse;
        #endregion
        #region Properties
        public int Groesse { get => _groesse; set => _groesse = value; }
        #endregion
        #region Constructor
        public Bohrer()
        {

        }
        public Bohrer(int groesse)
        {
            Groesse = groesse;
        }
        #endregion
        #region Methods
        public override string ToString() 
        {
            return $"Bohrergröße: {Groesse}";
        }
        #endregion
    }
}
