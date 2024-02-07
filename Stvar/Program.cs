
using System;
using System.Collections.Generic;
using System.Xml.Linq;

public class Stvar
    {
        private int kolicina;
        private string ime;
        private float teza;
        static private int stStvari = 0;
        public const bool obstaja = true;
    readonly bool indistructable;
    List<Stvar> Stvari = new List<Stvar>();
        public int Kolicina
        {
            get { return kolicina; }
            set { kolicina = value; }
        }
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        public float Teza
        {
            get { return teza; }
        set { teza = value; }
        }
        

        public Stvar()
        {
            this.teza = 1;
            this.kolicina = 1;
            this.ime = "Kamen";
        this.indistructable = false;
        NovaStvar();
        Stvari.Add(this);
        }
        
        public Stvar(string i, int k, float t)
        {
            this.ime = i;
            this.teza = t;
            this.kolicina = k;
        this.indistructable = false;
        NovaStvar();
        Stvari.Add(this);
    }

        public Stvar(Stvar a)
        {
            this.teza = a.Teza;
            this.kolicina = a.Kolicina;
            this.ime = a.ime;
        this.indistructable = false;
        NovaStvar();
        Stvari.Add(this);
    }

        ~Stvar()
        {
        UniciStvar();
        }
    public List<Stvar> Stvarice()
    {
        return Stvari;
    }
    public int SteviloStvari()
    {
        return stStvari;
    }
    static public void NovaStvar()
    {
        stStvari++;
    }
    public void UniciStvar()
    {
        stStvari--;
    }
    public static Stvar operator +(Stvar a, Stvar b)
    => new Stvar(a.ime,a.Kolicina + b.Kolicina, a.Teza + b.Teza);
    public static Stvar operator -(Stvar a, Stvar b)
    => new Stvar(a.ime, a.Kolicina - b.Kolicina, a.Teza - b.Teza);
    public static Stvar operator ++(Stvar a) 
    => new Stvar(a.Ime,a.Kolicina + 1,a.Teza);
    public static Stvar operator --(Stvar a)
    => new Stvar(a.Ime, a.Kolicina - 1, a.Teza);
    public static Stvar operator +(Stvar a, int b)
    => new Stvar(a.ime, a.Kolicina + b, a.Teza + b);
    public static Stvar operator -(Stvar a, int b)
    => new Stvar(a.ime, a.Kolicina - b, a.Teza - b);

    public virtual string InfoKartica()
    {
        return ($"Ime: {Ime}, Kolicina: {Kolicina}, Teza: {Teza}");
    }
}

