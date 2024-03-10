namespace caf_practice
{
    internal class Program
    {
        static String nominativo;
        static int eta;

        static void Main(string[] args)
        {
            int sceltaUtente;

            double isee;
            double patrimonioImmobiliare;
            int anniLavorativi;
            double reddito;
            double ultimaBustaPaga;
            int mesiOccupazione;

            Console.WriteLine("Scegliere l'operazione da effettuare: \n" +
                "1.Reddito di Cittadinanza \n" +
                "2.Pensione \n" +
                "3.Calcolo Tassazione \n" +
                "4.Calcolo NASPI");
            sceltaUtente = Convert.ToInt16(Console.ReadLine());
            //serve un controllo sull'input dell'utente

            switch(sceltaUtente)
            {
                case 1:
                    InserimentoNominativo();
                    InserimentoEta();

                    Console.WriteLine("Inserisci l'ISEE");
                    isee = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Inserisci il partimonio immobiliare");
                    patrimonioImmobiliare = Convert.ToDouble(Console.ReadLine());

                    RedditoCittadinanza rcObject = new RedditoCittadinanza(nominativo, eta, isee, patrimonioImmobiliare);
                    Console.WriteLine(rcObject.CheckRedditoCittadinanza());
                    break;

                case 2:
                    InserimentoNominativo();
                    InserimentoEta();

                    Console.WriteLine("Inserire gli anni lavorativi");
                    anniLavorativi = Convert.ToInt16(Console.ReadLine());

                    Pensione psObject = new Pensione(nominativo, eta, anniLavorativi);
                    Console.WriteLine(psObject.CheckPensione());
                    break;

                case 3:
                    Console.WriteLine("Inserisci il nominativo");
                    nominativo = Console.ReadLine();

                    Console.WriteLine("Inserire il reddito");
                    reddito = Convert.ToDouble(Console.ReadLine());

                    Tassazione taxObject = new Tassazione(nominativo, reddito);
                    Console.WriteLine(taxObject.CheckTassazione());
                    break;

                case 4:
                    InserimentoNominativo();

                    Console.WriteLine("Inserisci l'importo netto dell'ultima busta paga");
                    ultimaBustaPaga = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Inserisci i mesi di occupazione");
                    mesiOccupazione = Convert.ToInt16(Console.ReadLine());

                    Naspi nasObject = new Naspi(nominativo, ultimaBustaPaga, mesiOccupazione);
                    Console.WriteLine(nasObject.CheckNaspi());
                    break;

                default:
                    Console.WriteLine("Operazione non esistente");
                    break;
            }
        }

        public static void InserimentoNominativo()
        {
            Console.WriteLine("Inserisci il nominativo");
            nominativo = Console.ReadLine();
        }

        public static void InserimentoEta()
        {
            Console.WriteLine("Inserisci l'età");
            eta = Convert.ToInt16(Console.ReadLine());
        }
    }
}
