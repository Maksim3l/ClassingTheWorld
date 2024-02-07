
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class Zival : Bitje
{
    private int stNog;
    private string zivljenjski_prostor;
    private string brava;
    private float velikost;
    private string opis;
    private char spol;
    static private int stZivali = 0;
    private bool jeFantasticno;
    private bool lacen;
    public readonly int avgweight = 174;
    const int maxage = 100;
    static public List<Zival> Zivali = new List<Zival>();
    public int StNog
    {
        get { return stNog; }
        set { stNog = value; }
    }
    public string Zivljenjski_prostor
    {
        get { return zivljenjski_prostor; }
        set { zivljenjski_prostor = value; }
    }
    public string Barva
    {
        get { return brava; }
        set { brava = value; }
    }
    public float Velikost
    {
        get { return velikost; }
        set { velikost = value; }
    }
    public string Opis
    {
        get { return opis; }
        set { opis = value; }
    }
    public char Spol
    {
        get { return spol; }
        set { spol = value; }
    }

    public bool JeFantasticno
    {
        get { return jeFantasticno; }
        set { jeFantasticno = value; }
    }

    public bool Lacen
    {
        get { return lacen; }
        set { lacen = value; }
    }

    public List<Zival> Zivalice()
        {
        return Zivali;
        }

    public Zival()
        {
            this.stNog = 4;
            this.zivljenjski_prostor = "Gozd";
            this.brava = "Sivo-Črna";
            this.velikost = 1.53f;
            this.opis = "Ima veliki, zdravi, sivočrni kožuh, z majhnim nosekom.";
            this.spol = 'M';
            this.jeFantasticno = false; 
            this.lacen = false;
            base.JeZivo = true;
            base.JeRanjeno = false;
            base.StPotomcov = 0;
            base.Teza = 85.6f;
            base.Kolicina = 1;
        base.Ime = "Sivi volk";
        stZivali++;
        Zivali.Add(this);
        }
        
        public Zival(int n, string z, string b, float v, string o, char s, bool f, bool l,float t, int k, string i)
        {
            this.stNog = n;
            this.zivljenjski_prostor = z;
            this.brava = b;
            this.velikost = v;
            this.opis = o;
            this.spol = s;
            this.jeFantasticno = f;
            this.lacen = l;
        base.JeZivo = true;
        base.JeRanjeno = false;
        base.StPotomcov = 0;
        base.Teza = t;
        base.Kolicina = k;
        base.Ime = i;
        stZivali++;
        Zivali.Add(this);
    }
        
        public Zival(Zival a)
        {
            this.stNog = a.StNog;
            this.opis = a.Opis;
            this.spol = a.Spol;
            this.brava = a.Barva;
            this.velikost = a.Velikost;
            this.zivljenjski_prostor = a.Zivljenjski_prostor;
            this.jeFantasticno = a.jeFantasticno;
            this.lacen = a.Lacen;
        base.JeZivo = a.JeZivo;
        base.JeRanjeno = a.JeRanjeno;
        base.StPotomcov = a.StPotomcov;
        base.Teza = a.Teza;
        base.Kolicina = a.Kolicina;
        base.Ime = a.Ime;
        stZivali++;
        Zivali.Add(this);
    }

        ~Zival()
        {
            stZivali--;
        Umre();
        UniciStvar();
        Zivali.Remove(this);
    }

        static public int SteviloZivali()
        {
            return stZivali;
        }
    public string Giveweigh()
    {
        return Convert.ToString(this.Teza);
    }

    public override string InfoKartica()
    {
        return base.InfoKartica()+$"Stavilo nog: {stNog}, Zivljenjski prostor: {zivljenjski_prostor}, Brava: {Barva}, Velikost: {Velikost}, Opis: {Opis}, Spol: {Spol}, Je Fantasticno: {jeFantasticno}, Lacen: {lacen}";
    }

    public int StLacnih()
    {
        int a = 0;
        foreach (Zival I in Zivali)
        {
            if(I.Lacen == true)
            {
                if(I.JeZivo == true)
                {
                    a++;
                }
                
            }
        }
        return a;
    }

    public int StRanjenih()
    {
        int a = 0;
        foreach (Zival I in Zivali)
        {
            if (I.JeZivo == true)
            {
                a++;
            }
        }
        return a;
    }

    public static Zival operator +(Zival a, Zival b)
    => new Zival(a.StNog+b.StNog, a.Zivljenjski_prostor ="Temnice", a.Barva, a.Velikost, a.Opis="Amalgamacija", a.Spol='S', a.jeFantasticno=true, a.Lacen, a.Teza+b.Teza,a.Kolicina = 1, a.Ime);
    public static Zival operator -(Zival a, Zival b)
    => new Zival(a.StNog - b.StNog, a.Zivljenjski_prostor = "Temnice", a.Barva, a.Velikost, a.Opis = "Amalgamacija", a.Spol = 'S', a.jeFantasticno = true, a.Lacen, a.Teza - b.Teza, a.Kolicina = 1, a.Ime);
    public static Zival operator ++(Zival a)
    => new Zival(a.StNog+1, a.Zivljenjski_prostor, a.Barva, a.Velikost, a.Opis = a.Opis+" nekaj je narobe", a.Spol, a.jeFantasticno = true,a.Lacen, a.Teza+=3, a.Kolicina, a.Ime);
    public static Zival operator --(Zival a)
    => new Zival(a.StNog - 1, a.Zivljenjski_prostor, a.Barva, a.Velikost, a.Opis = a.Opis + " zgleda uranjeno", a.Spol, a.jeFantasticno, a.Lacen, a.Teza-=3, a.Kolicina, a.Ime);
    public static Zival operator +(Zival a, int b)
    => new Zival(a.StNog + b, a.Zivljenjski_prostor, a.Barva, a.Velikost, a.Opis = a.Opis + "Pošast", a.Spol, a.jeFantasticno = true,a.Lacen, a.Teza + b, a.Kolicina, a.Ime);
    public static Zival operator -(Zival a, int b)
    => new Zival(a.StNog - b, a.Zivljenjski_prostor, a.Barva, a.Velikost, a.Opis = a.Opis + " zgleda uranjeno morda naspol mrtvo", a.Spol, a.jeFantasticno, a.Lacen, a.Teza-b, a.Kolicina, a.Ime);
}
