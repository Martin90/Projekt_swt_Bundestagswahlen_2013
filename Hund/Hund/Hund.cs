using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hund
{
    class Hund
    {
        string name, typ, bild;

        public Hund(string n, string t, string b)
        {
            name = n;
            typ = t;
            bild = b;
        }

        public string ZeigeBild()
        {
            return bild;
        }

        public string ZeigeName()
        {
            return name;
        }

        public string ZeigeTyp()
        {
            return typ;
        }

        public string loeschen()
        {
            return "";
        }

        
    }

    
}

