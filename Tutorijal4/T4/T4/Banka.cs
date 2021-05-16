using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    public class Banka
    {
        List<IPodaci> objekti = new List<IPodaci>();
        // List<Klijent> klijenti = new List<Klijent>();
        // List<Racun> racuni = new List<Racun>();

        /*
        public void DodajKlijenta(Klijent osoba)
        {
            klijenti.Add(osoba);
        }
        */

        public void DodajKlijentaIliRacun(IPodaci objekat)
        {
            objekti.Add(objekat);
        }

        public void OtvoriRacunZaOsobu(IPodaci osoba)
        {
            /*Racun racun = new Racun(0)
            {
                Id = racuni.Count
            };
            racuni.Add(racun);
            osoba.Racuni.Add(racun);*/

            IPodaci racun = new Racun(0)
            {
                Id = osoba.GenerišiID()
            };
            objekti.Add(racun);
            ((Klijent)osoba).Racuni.Add((Racun)racun);
        }

        public IPodaci PronadjiKlijenta(int identitet)
        {
            // return klijenti.Find(osoba => osoba.Identitet == id);

            return objekti.Find(osoba => osoba is Klijent && ((Klijent)osoba).Identitet == identitet);
        }

        public void PrebaciNovac(Racun racun, decimal kolicina)
        {
            racun.PoloziNovac(kolicina);
        }
    }
}
