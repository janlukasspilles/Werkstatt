using System;
using System.Collections.Generic;
using System.Text;

namespace Werkstatt
{
    public class Werkzeugschrank
    {
        #region Attributes
        private Bohrer[] _bohrer;
        #endregion
        #region Properties
        public Bohrer[] Bohrer { get => _bohrer; set => _bohrer = value; }
        #endregion
        #region Constructor
        public Werkzeugschrank()
        {
            Bohrer = new Bohrer[10];
            for (int zaehler = 0; zaehler < Bohrer.Length; zaehler++)
            {
                Bohrer[zaehler] = new Bohrer(zaehler + 1);
            }
        }

        public Werkzeugschrank(int anzahlBohrer)
        {
            Bohrer = new Bohrer[anzahlBohrer];
            for (int zaehler = 0; zaehler < Bohrer.Length; zaehler++)
            {
                Bohrer[zaehler] = new Bohrer(zaehler + 1);
            }
        }
        #endregion
        #region Methods
        public Bohrer BohrerNehmen(int groesse)
        {
            for (int zaehler = 0; zaehler < Bohrer.Length; zaehler++)
            {
                if (Bohrer[zaehler] != null && Bohrer[zaehler].Groesse == groesse)
                {
                    Bohrer tmp = Bohrer[zaehler];
                    Bohrer[zaehler] = null;
                    return tmp;
                }
            }
            throw new Exception($"Kein Bohrer in der Größe {groesse} gefunden!");
        }

        public void BohrerEinlegen(Bohrer b)
        {
            for (int zaehler = 0; zaehler < Bohrer.Length; zaehler++)
            {
                if (Bohrer[zaehler] == null)
                {
                    Bohrer[zaehler] = b;
                }
            }
        }

        #endregion
    }
}
