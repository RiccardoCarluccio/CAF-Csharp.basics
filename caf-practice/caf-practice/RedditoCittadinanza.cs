using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caf_practice
{
    internal class RedditoCittadinanza
    {
        String nominativo;
        int eta;
        double isee;
        double patrimonioImmobiliare;   //esclusa prima casa

        public RedditoCittadinanza(String nominativo, int eta, double isee, double patrimonioImmobiliare)
        {
            this.nominativo = nominativo;
            this.eta = eta;
            this.isee = isee;
            this.patrimonioImmobiliare = patrimonioImmobiliare;
        }

        public bool CheckRedditoCittadinanza()
        {
            if ((eta >= 26 && eta <= 67) && (isee <= 9636) && (patrimonioImmobiliare < 30000))
            {
                Console.WriteLine("Hai diritto al reddito di cittadinanza");
                return true;
            }
            else
            {
                Console.WriteLine("Non hai diritto al reddito di cittadinanza perchè: ");
                if (eta < 26)
                    Console.WriteLine("Hai meno di 26 anni");
                if (eta > 67)
                    Console.WriteLine("Hai più di 67 anni");
                if (isee > 9636)
                    Console.WriteLine("Il tuo ISEE è maggiore di 9.636 euro");
                if (patrimonioImmobiliare > 30000)
                    Console.WriteLine("Il tuo patrimonio immobiliare è maggiore di 30.000 euro");
                return false;
            }
        }
    }
}
