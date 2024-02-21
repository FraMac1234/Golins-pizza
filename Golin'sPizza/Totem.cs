using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net.NetworkInformation;

namespace Golin_sPizza
{
    public class Totem
    {
        public double Prezzo{ get; set;}
        public Totem(double prezzo) 
        {
            Prezzo = prezzo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        int CreazioneCoda()
        {
            Random random = new Random();
            int attesa = random.Next(2, 5);
            Console.WriteLine("Tempo di attesa in coda = " + attesa + "secondi.");
            return attesa;
        }

    }
}
