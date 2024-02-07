
namespace Material
{
    public class Material : Stvar
    {
        private bool strupeno;
        private bool naravno;
        private bool radioaktivno;
        private string oblika;
        private string opis;
        private string barva;
        static private int stMaterialov = 0;
        public bool Strupeno
        {
            get { return strupeno; }
            set { strupeno = value; }
        }

        public bool Naravno
        {
            get { return naravno; }
            set { naravno = value; }
        }

        public bool Radioaktivno
        {
            set { radioaktivno = value; }
            get { return radioaktivno; }
        }
        public string Oblika
        {
            get { return oblika; }
            set { oblika = value; }
        }

        public string Opis
        {
            get { return opis; }
            set { opis = value; }
        }

        public string Barva
        {
            get { return barva; }
            set { barva = value; }
        }

        public Material(bool strupeno, bool naravno, bool radioaktivno, string oblika, string opis, string barva)
        {
            this.strupeno = strupeno;
            this.naravno = naravno;
            this.radioaktivno = radioaktivno;
            this.oblika = oblika;
            this.opis = opis;
            this.barva = barva;
            stMaterialov++;
        }

        public Material()
        {
            this.strupeno = false;
            this.naravno = true;
            this.radioaktivno = false;
            this.oblika = "toroid";
            this.opis = "Trdi kamen z obliko ameriškega krofa";
            this.barva = "Siva z traki rdčkasto-oranžne";
            stMaterialov++;
        }

        public Material(Material a)
        {
            this.strupeno = a.Strupeno;
            this.naravno = a.Naravno;
            this.radioaktivno = a.Radioaktivno;
            this.oblika = a.Oblika;
            this.opis = a.Opis;
            this.barva = a.Barva;
            stMaterialov++;
        }

        ~Material()
        {
            stMaterialov--;
        }
        public int SteviloMaterialov()
        {
            return stMaterialov;
        }
    }
}
