using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golin_sPizza
{
    internal class Tavolo
    {
        private int _numero = 0;
        private int _nPosti = 0;
        private int _nOccupati = 0;

        public Tavolo(int n, int p, int o)
        {
            Numero = n;
            NPosti = p;
            NOccupati = o;
        }
        public int Numero
        {
            get
            {
                return _numero;
            }
            set
            {
                ControllaIndice(value);
                _numero = value;
            }
        }

        public int NPosti 
        {
            get
            {
                return _nPosti;
            }
            set
            {
                ControllaIndice(value);
                _nPosti = value;
            }
        }

        public int NOccupati 
        {
            get
            {
                return _nOccupati;
            }
            set
            {
                ControllaIndice(value);
                _nOccupati = value;
            }
        }

        void ControllaIndice(int i)
        {
            throw new Exception("Il numero deve essere > 0");
        }
    }
}
