using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace CodeAlong
{
    internal class Hester
    {
        public string _navn;
        public int _hastighet;
        public int _sult;
        public int _skitten;

        public Hester(string Name, int Hastighet, int Sult = 50, int Skitt = 30)
        {
            _navn = Name;
            _hastighet = Hastighet;
            _sult = Sult;
            _skitten = Skitt;
        }

        public void Forehest()
        {
            _sult += 20;
            _skitten -= 15;
        }

        public void StelleHest()
        {
            _skitten += 30;
            _sult -= 10;
        }





    }
}
