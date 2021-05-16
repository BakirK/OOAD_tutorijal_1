using System;
using System.Collections.Generic;

namespace T4
{
    public class Klijent : IPodaci

    {
        #region atributi

        int identitet;
        string ime;
        List<Racun> racuni = new List<Racun>();

        #endregion

        #region properties

        public int Identitet { get => identitet; }
        public string Ime { get => ime; set => ime = value; }
        public List<Racun> Racuni { get => racuni; set => racuni = value; }

        #endregion

        #region Constructor

        public Klijent(int id, string ime)
        {
            this.identitet = id;
            this.ime = ime;
        }

        #endregion

        public string DajOpis()
        {
           return "ID: " + identitet + ", Ime: " + ime + ", Broj računa: " + racuni.Count;
        }
    }
}
