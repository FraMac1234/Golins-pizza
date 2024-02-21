using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golin_sPizza
{
    internal class Sala
    {
        private Tavolo[] _listaTavoli;
        private int _indice = 0;
        private bool _allarme;
        public Sala(int tTotali)
        {
            if (tTotali <= 0)
                throw new Exception("La sala deve contenere almeno 1 tavolo");
            _listaTavoli = new Tavolo[tTotali];
            
            
        }

        public int TavoliTotali
        {
            get
            {
                return _listaTavoli.Length; 
            }
        }

        public int EliminaTavolo
        {
            set
            {
                _listaTavoli[_indice] = null;
                _indice--;
                ControlloAllarme(_indice);
            }
        }

        public Tavolo AggiungiTavolo
        {
            set
            {
                ControlloAllarme(_indice);
                if (_allarme == false)
                {
                    _listaTavoli[_indice] = value;
                }
            }
        }

        void ControlloAllarme(int tavoliOccupati)
        {
            if(tavoliOccupati > (TavoliTotali * 0.9))
            {
                _allarme = true;
            }
            else
            {
                _allarme = false;
            }
        }

    }
}
