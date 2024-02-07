using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
public class Bitje : Stvar
{
        static int StBitji = 0;
        private bool jeZivo;
        private bool jeRanjeno;
        private int stPotomcov;
        private bool pociva;
        static public List<Bitje> Bitja = new List<Bitje>();
    readonly bool rabihrano = true;
    const bool alien = false;
    public bool JeZivo
        {
            get { return jeZivo; }
            set { jeZivo = value; }
        }
        public bool JeRanjeno
        {
            get { return jeRanjeno; }
            set { jeRanjeno = value; }
        }
        public int StPotomcov
        {
            get { return stPotomcov; }
            set { stPotomcov = value; }
        }
        
        public Bitje()
        {
            this.jeZivo = true;
            this.jeRanjeno = false;
            this.stPotomcov = 0;
        base.Teza = 85.6f;
        base.Kolicina = 1;
        base.Ime = "Sivi volk";
        NovoBitje();
        Bitja.Add(this);
    }
        public Bitje(bool z, bool s, int p, float t, int k, string i)
        {
            this.jeZivo = z;
            this.jeRanjeno = s;
            this.stPotomcov = p;
        base.Teza = t;
        base.Kolicina = k;
        base.Ime = i;
        NovoBitje();
        Bitja.Add(this);
    }
        public Bitje(Bitje a)
        {
            this.jeZivo = a.JeZivo;
            this.jeRanjeno = a.jeRanjeno;
            this.stPotomcov = a.StPotomcov;
        base.Teza = a.Teza;
        base.Kolicina = a.Kolicina;
        base.Ime = a.Ime;
        NovoBitje();
        Bitja.Add(this);
    }

        ~Bitje()
        {
        Umre();
        UniciStvar();
        }

        public int SteviloBitji()
        {
            return StBitji;
        }

        static public void NovoBitje()
    {
        StBitji++;
    }

    public virtual void Umre()
    {
        StBitji--;
    }
        public void Spat()
        {
            this.pociva = true;
        }

        public bool Pociva()
        {
            return pociva;
        }

        public void Zbudi()
    {
        this.pociva = false;
    }

        public void Povrze()
        {
            stPotomcov++;
        }

    public List<Bitje> Bitjeca()
    {
        return Bitja;
    }
    public override string InfoKartica()
    {
        return (base.InfoKartica()+ $", Živo: {jeZivo}, Slepost: {jeRanjeno}, Stevilo Potomcev: {stPotomcov}, Pociva: {pociva}");
    }

}

