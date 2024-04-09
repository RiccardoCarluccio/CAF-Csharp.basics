using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caf_practice
{
    internal class Naspi
    {
        String nominativo;
        double ultimaBustaPaga;
        int mesiOccupazione;

        public Naspi(String nominativo, double ultimaBustaPaga, int mesiOccupatione)
        {
            this.nominativo = nominativo;
            this.ultimaBustaPaga = ultimaBustaPaga;
            this.mesiOccupazione = mesiOccupatione;
        }

        public bool CheckNaspi()
        {
            double sussidio;

            if (mesiOccupazione >= 24)
            {
                sussidio = ultimaBustaPaga * 0.7;
                sussidio = CheckSussidio(sussidio);
                Console.WriteLine("Puoi beneficiare della NASPI \n" +
                    "Hai diritto a " + sussidio + " euro mensili");
                return true;
            }
            else if (mesiOccupazione >= 12 && mesiOccupazione < 24)
            {
                sussidio = ultimaBustaPaga * 0.4;
                sussidio = CheckSussidio(sussidio);
                Console.WriteLine("Puoi beneficiare della NASPI \n" +
                    "Hai diritto a " + sussidio + " euro mensili");
                return true;
            }
            else
            {
                Console.WriteLine("Non hai abbastanza mesi di occupazione \n" +
                    "Non puoi beneficiare della NASPI");
                return false;
            }
        }

        public double CheckSussidio(double sussidio)
        {
            if (sussidio > 1200)
                return 1200;
            return sussidio;
        }
    }
}
