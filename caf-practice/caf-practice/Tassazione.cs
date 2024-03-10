using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caf_practice
{
    internal class Tassazione
    {
        String nominativo;
        double reddito;

        public Tassazione(string nominativo, double reddito)
        {
            this.nominativo = nominativo;
            this.reddito = reddito;
        }

        public bool CheckTassazione()
        {
            double scaglione23 = (15000 * 0.77); //11.550
            double scaglione27 = ((28000 - 15000) * 0.73) + scaglione23; //9.490 + s1
            double scaglione38 = ((55000 - 28000) * 0.62) + scaglione27;
            double scaglione41 = ((75000 - 55000) * 0.59) + scaglione38;

            if (reddito <= 15000)
            {
                Console.WriteLine("La tua aliquota Irpef al 2020 è del 23% \n" +
                    "Il tuo reddito netto è pari a: " + 
                    (reddito * 0.77) + " euro");
                return true;
            } else if (reddito > 15000 && reddito <= 28000)
            {
                Console.WriteLine("La tua aliquota Irpef al 2020 è del 27% \n" +
                    "Il tuo reddito netto è pari a: " +
                    (((reddito - 15000) * 0.73) + scaglione23) + " euro");
                return true;
            }
            else if (reddito > 28000 && reddito <= 55000)
            {
                Console.WriteLine("La tua aliquota Irpef al 2020 è del 38% \n" +
                    "Il tuo reddito netto è pari a " +
                    (((reddito - 28000) * 0.62) + scaglione27) + " euro");
                return true;
            }
            else if (reddito > 55000 && reddito <= 75000)
            {
                Console.WriteLine("La tua aliquota Irpef al 2020 è del 41% \n" +
                    "Il tuo reddito netto è pari a " +
                    (((reddito - 55000) * 0.59) + scaglione38) + " euro");
                return true;
            }
            else if (reddito > 75000)
            {
                Console.WriteLine("La tua aliquota Irpef al 2020 è del 43% \n" +
                    "Il tuo reddito netto è pari a " +
                    (((reddito - 75000) * 0.57) + scaglione41) + " euro");
                return true;
            }
            else
            {
                Console.WriteLine("Hai inserito un valore errato");
                return false;
            } 
                
        }
    }
}
