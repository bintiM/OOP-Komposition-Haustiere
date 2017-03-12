using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haustiere
{
    class Besitzer
    {
        private string _name;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _wohnort;

        public string wohnort
        {
            get { return _wohnort; }
            set { _wohnort = value; }
        }

        private List<Haustier> _tiere;

        public Besitzer()
        {
            _name = "";
            _wohnort = "";
            _tiere = new List<Haustier>();
        }
        public Besitzer(string name, string wohnort)
        {
            _name = name;
            _wohnort = wohnort;
            _tiere = new List<Haustier>();
        }

        public void haustierHinzufuegen(Haustier tier)
        {
            _tiere.Add(tier);
        }
        public void haustierLoeschen(Haustier tier)
        {
            _tiere.Remove(tier);
        }
        public void haustierLoeschen(string suchName)
        {
            //Haustier foundVieh = _tiere.Find(h => h.name == suchName);
            //Haustier foundVieh = _tiere.Find(h => h.name.Contains(suchName));
            Haustier foundVieh = _tiere.Find(h => h.name.StartsWith(suchName));
            _tiere.Remove(foundVieh);
        }

        public List<Haustier> getHaustiere()
        {
            return _tiere;
        }


    }
}
