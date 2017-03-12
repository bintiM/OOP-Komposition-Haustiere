using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haustiere
{
    enum tierArt{
        hund, katze, papagei
    }

    class Haustier
    {
        tierArt _art;
        public tierArt art
        {
            get { return _art; }
        }

        private string _unterArt;
        public string unterArt
        {
            get { return _unterArt; }
        }

        private string _name;
        public string name
        {
            get { return _name; }
        }


        private int _alter;
        public int alter
        {
            get { return _alter; }
        }

        private double _gewicht;
        public double gewicht
        {
            get { return _gewicht; }
        }

        private ConsoleColor _lieblingsFarbe;
        private string _lieblingsFutter;

        public Haustier()
        {
            _art = tierArt.hund;
            _unterArt = "";
            _name = "";
            _alter = 0;
            _gewicht = 0.0d;
            _lieblingsFarbe = ConsoleColor.White;
            _lieblingsFutter = "";
        }
        public Haustier(string name, int alt = 0)
        {
            _art = tierArt.hund;
            _unterArt = "";
            _name = name;
            _alter = alt;
            _gewicht = 0.0d;
            _lieblingsFarbe = ConsoleColor.White;
            _lieblingsFutter = "";
        }

        public string DatenAnzeigen()
        {
            return "Name: " + _name + ", Alter: " + _alter;
        }

    }
}
