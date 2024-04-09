using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caf_practice
{
    internal class Pensione
    {
        String nominativo;
        int eta;
        int anniLavorativi;

        public Pensione(string nominativo, int eta, int anniLavorativi)
        {
            this.nominativo = nominativo;
            this.eta = eta;
            this.anniLavorativi = anniLavorativi;
        }

        public bool CheckPensione()
        {
            if ((eta + anniLavorativi) >= 100)
            {
                Console.WriteLine("Hai diritto alla pensione");
                return true;
            }
            else
            {
                Console.WriteLine("Non hai diritto alla pensione \n" +
                    "Ti mancano " + (100 - (eta + anniLavorativi)) + " anni e/o anni lavorativi");
                return false;
            }
        }
    }
}
