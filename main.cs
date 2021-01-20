using System;

namespace Werkstatt
{
    public class main
    {
        static void Main(string[] args)
        {
            Werkzeugschrank ws = new Werkzeugschrank();
            Bohrmaschine b = new Bohrmaschine();

            b.BohrerEinsetzen(ws.BohrerNehmen(5));

            ws.BohrerEinlegen(b.BohrerEntfernen());
        }
    }
}
