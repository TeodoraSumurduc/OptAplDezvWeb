using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1
{
    public class Persoana

    {
        public string Prenume { get; set; }

        public List<Produs> ListaCumparaturi = new List<Produs>();

        public double PretTotal()
        {
            double pret = 0; 
            foreach(Produs a in ListaCumparaturi)
            {
                pret += a.Pret;
            }
            return pret;
        }


     }
    public class Produs
    {
        public string Denumire { get; set; }
        public int NrBucati { get; set; }
        public int Pret { get; set; }

    }
}
