using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Razredovanje_Sveta
{
    public partial class Form2 : Form
    {
        public static ulong Hrana = 0;
        public static ulong FPC = 1;
        public static Zival Ruler = new Zival();
        public static Zival Ruler2 = new Zival();
        public static Bitje PrinceA = new Bitje();
        public static Stvar PrincessA = new Stvar();
        Zival Queen;
        Bitje Prince;
        Stvar Princess;
        public static ulong lakota = 0;
        public static float percent = 0.005f;
        public ulong gps = 0;
        public int stlacnih;
        public int stranjenih;
        public Form2()
        {
            InitializeComponent();
        }

        private void živaliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            title.Text = "Zivali";
            NVHrana();
            NNovazival();
            Zivalceon();
            NovobitjeOff();
            Inventoff();

            listView2.Items.Clear();
            ColumnHeader Zival = new ColumnHeader();
            Zival.Text = "Zival";
            Zival.Width = 500;
            listView2.Columns.Add(Zival);
            List<Zival> Koko = Ruler.Zivalice();
            foreach (Zival item in Koko)
            {
                //string Namae = item.Ime;

                listView2.Items.Add(item.InfoKartica());

            }
        }

        private void hranaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            title.Text = "Hrana";
            VHrana();
            NNovazival();
            Zivalceoff(); 
            NovobitjeOff();
            Inventoff();
        }

        public void VHrana()
        {
            Thebutton.Visible = true;
            UpgradesL.Visible = true;
            up1.Visible = true;
            up10.Visible = true;
            up100.Visible = true;
            up1000.Visible = true;
            up10k.Visible = true;
            up100k.Visible = true;
            HNK.Visible = true;
            gpsin.Visible = true;
            add1gps.Visible=true;
            add10gps.Visible = true;
            add1kgps.Visible = true;
            add10kgps.Visible = true;
            add1tps.Visible = true;
            label12.Visible = true;
        }

        public void NVHrana()
        {
            Thebutton.Visible = false;
            UpgradesL.Visible = false;
            up1.Visible = false;
            up10.Visible = false;
            up100.Visible = false;
            up1000.Visible = false;
            up10k.Visible = false;
            up100k.Visible = false;
            HNK.Visible = false;
            gpsin.Visible = false; 
            add1gps.Visible = false;
            add10gps.Visible = false;
            add1kgps.Visible = false;
            add10kgps.Visible = false;
            add1tps.Visible = false;
            label12.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hrana = Hrana+FPC;
            updatetext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Hrana >= 100)
            {
                Hrana -= 100;
                FPC += 1;
            }
            updatetext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Hrana >= 1000)
            {
                Hrana -= 1000;
                FPC += 10;
            }
            updatetext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Hrana >= 10000)
            {
                Hrana -= 10000;
                FPC += 100;
            }
            updatetext();
        }

        public void updatetext()
        {
            if (Hrana < 1000)
            {
                Hranacount.Text = Convert.ToString(Hrana)+"g";
            }
            else if (Hrana < 1000000)
            {
                ulong dN = Hrana / 1000;
                Hranacount.Text = Convert.ToString(dN) + "kg";
            }
            else if (Hrana < 1000000000)
            {
                ulong dN = Hrana / 1000000;
                Hranacount.Text = Convert.ToString(dN) + "t";
            }
            else if (Hrana < 1000000000000)
            {
                ulong dN = Hrana / 1000000000;
                Hranacount.Text = Convert.ToString(dN) + "Gg";
            }
            else if (Hrana < 1000000000000000)
            {
                ulong dN = Hrana / 1000000000000;
                Hranacount.Text = Convert.ToString(dN) + " Tg";
            }

            if (FPC < 1000)
            {
                HNK.Text ="HNK: "+ Convert.ToString(FPC)+"g";
            }
            else if (FPC < 1000000)
            {
                ulong cl = FPC / 1000;
                HNK.Text = "HNK: " + Convert.ToString(cl) + "kg";
            }
            else if (FPC < 1000000000)
            {
                ulong cl = FPC / 1000000;
                HNK.Text = "HNK: " + Convert.ToString(cl) +"Mg";
            }
            else if (FPC < 1000000000000)
            {
                ulong cl = FPC / 1000000000;
                HNK.Text = "HNK: " + Convert.ToString(cl)+"Gg";
            }
            else if (FPC < 1000000000000000)
            {
                ulong cl = FPC / 1000000000000;
                HNK.Text = "HNK: " + Convert.ToString(cl)+"Tg";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Hrana >= 100000)
            {
                Hrana -= 100000;
                FPC += 1000;
            }
            updatetext();
        }

        private void zapriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Hrana >= 1000000)
            {
                Hrana -= 1000000;
                FPC += 10000;
            }
            updatetext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Hrana >= 10000000)
            {
                Hrana -= 10000000;
                FPC += 100000;
            }
            updatetext();
        }

        private void novaŽivalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            title.Text = "Nova Zival";
            NVHrana();
            Novazival();
            Zivalceoff();
            NovobitjeOff(); 
            Inventoff();
        }

        public void Zivalceon()
        {
            listView2.Visible = true;
            feed.Visible = true;
            potrebovanahrana.Visible = true;
            label11.Visible = true;
            lacno.Visible = true;
            ranjeno.Visible = true;
            splosno.Visible = true;
            UpdateFoodtext();
        }

        public void Zivalceoff()
        {
            listView2.Visible = false;
            feed.Visible = false;
            potrebovanahrana.Visible = false;
            label11.Visible = false;
            lacno.Visible = false;
            ranjeno.Visible = false;
            splosno.Visible=false;  
        }
        

        public void Novazival()
        {
            Options.Visible = true;
            Ime.Visible = true;
            Spol.Visible = true;
            Barva.Visible = true;
            Opis.Visible = true;
            Teza.Visible = true;
            Velikost.Visible = true;
            Prostor.Visible = true;
            Noge.Visible = true;
            Potomci.Visible = true;
            Kolicina.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            Create.Visible = true;
            
        }

        public void NNovazival()
        {
            Options.Visible = false;
            Ime.Visible = false;
            Spol.Visible = false;
            Barva.Visible = false;
            Opis.Visible = false;
            Teza.Visible = false;
            Velikost.Visible = false;
            Prostor.Visible = false;
            Noge.Visible = false;
            Potomci.Visible = false;
            Kolicina.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            Create.Visible = false;
            
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Create_Click(object sender, EventArgs e)
        {
            try { Queen = new Zival(int.Parse(Noge.Text), Prostor.Text, Barva.Text, float.Parse(Velikost.Text), Opis.Text, char.Parse(Spol.Text), checkBox2.Checked, checkBox4.Checked, float.Parse(Teza.Text), int.Parse(Kolicina.Text), Ime.Text); }
            catch { Queen = new Zival(); }

            Noge.Text = "";
            Prostor.Text = "";
            Barva.Text = "";
            Velikost.Text = "";
            Opis.Text = "";
            Spol.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            Teza.Text = "";
            Kolicina.Text = "";
            Ime.Text = "";
            Potomci.Text = "";

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            listView2.Columns.Add("Zival", 1000, HorizontalAlignment.Center);
        }

        private void DisplayIme_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            List <Zival> Zipper = Ruler.Zivalice();
            Random rnd = new Random();
            int randomn = rnd.Next(0, Zipper.Count);

            if (Zipper[randomn].Lacen == false)
            {
                Zipper[randomn].Lacen = true;
            }
            else if (Zipper[randomn].JeRanjeno == false)
            {
                Zipper[randomn].JeRanjeno = true;
            }
            else { Zipper[randomn].JeZivo = false; Zipper[randomn].Umre(); Zipper.RemoveAt(randomn); }

            foreach (Zival item in Zipper)
            {
                if (item.JeRanjeno == true)
                {
                    lakota += Convert.ToUInt64((item.Teza * item.Kolicina * 3) + Math.Round((item.Teza * item.Kolicina * 3) * percent));
                }
                if (item.Lacen == true)
                {
                    lakota += Convert.ToUInt64(((item.Teza / 2) * item.Kolicina) + Math.Round((item.Teza * item.Kolicina * 3) * percent));
                }
            }
            UpdateFoodtext();
        }

        public void UpdateFoodtext()
        {
            if(lakota < 1000)
            {
                potrebovanahrana.Text = Convert.ToString(lakota) + "g";
            }
            else if (lakota < 1000000)
            {
                double cl = lakota / 1000;
                potrebovanahrana.Text = Convert.ToString(cl) + "kg";
            }
            else if (lakota < 1000000000)
            {
                double cl = lakota / 1000000;
                potrebovanahrana.Text = Convert.ToString(cl) + "Mg";
            }
            else if (lakota < 1000000000000)
            {
                double cl = lakota / 1000000000;
                potrebovanahrana.Text = Convert.ToString(cl) + "Gg";
            }
            else if (lakota < 1000000000000000)
            {
                double cl = lakota / 1000000000000;
                potrebovanahrana.Text = Convert.ToString(cl) + "Tg";
            }

            splosno.Text = "Zivali: " + Convert.ToString(Ruler.SteviloZivali());
            lacno.Text = "Lacne: " + Convert.ToString(Ruler.StLacnih());
            ranjeno.Text = "Ranjene: " + Convert.ToString(Ruler.StRanjenih());
        }

        private void feed_Click(object sender, EventArgs e)
        {
            if(Hrana >= lakota)
            {
                Hrana -= Convert.ToUInt64(lakota);

                List<Zival> Zipper = Ruler.Zivalice();

                foreach (Zival item in Zipper)
                {
                    if (item.JeRanjeno == true)
                    {
                        item.JeRanjeno = false;
                    }
                    if (item.Lacen == true)
                    {
                        item.Lacen = false;
                    }
                }

                updatetext();
                potrebovanahrana.Text = "0g";
                lakota = 0;
            }
            

        }

        private void copyrnd_Tick(object sender, EventArgs e)
        {
            List<Zival> Zipper = Ruler.Zivalice();
            Random rnd = new Random();
            int randomn = rnd.Next(0, Zipper.Count);

            Zival bonke = new Zival(Zipper[randomn]);

            if (Zipper[randomn].Lacen == false)
            {
                Zipper[randomn].Lacen = true;
            }
            else if (Zipper[randomn].JeRanjeno == false)
            {
                Zipper[randomn].JeRanjeno = true;
            }
            else { 
                Zipper[randomn].JeZivo = false;
                
                for (int b = Zipper[randomn].StPotomcov; b > 0; b--)
                {
                    Zival dapers = new Zival(Zipper[randomn]);
                }

                Zipper[randomn].Umre(); 
                Zipper.RemoveAt(randomn); }

            foreach (Zival item in Zipper)
            {
                if (item.JeRanjeno == true)
                {
                    lakota += Convert.ToUInt64((item.Teza * item.Kolicina * 3) + Math.Round((item.Teza * item.Kolicina * 3) * percent));
                }
                if (item.Lacen == true)
                {
                    lakota += Convert.ToUInt64(((item.Teza / 2) * item.Kolicina) + Math.Round((item.Teza * item.Kolicina * 3) * percent));
                }
            }
            UpdateFoodtext();
        }

        private void prcentup_Tick(object sender, EventArgs e)
        {
            percent += 0.005f;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Hrana += gps;
            Updategps();
            UpdateFoodtext();
            updatetext();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Hrana > 1000)
            {
                gps++;
                Hrana -= 1000;
            }
            Updategps();
            UpdateFoodtext();
            updatetext();
        }

        private void add10gps_Click(object sender, EventArgs e)
        {
            if (Hrana > 10000)
            {
                gps += 10;
                Hrana -= 10000;
            }
            Updategps();
            UpdateFoodtext();
            updatetext();
        }

        private void add10kgps_Click(object sender, EventArgs e)
        {
            if (Hrana > 1000000)
            {
                gps += 10000;
                Hrana -= 10000000;
            }
            Updategps();
            UpdateFoodtext();
            updatetext();
        }

        private void add1kgps_Click(object sender, EventArgs e)
        {
            if (Hrana > 100000)
            {
                gps += 1000;
                Hrana -= 1000000;
            }
            Updategps();
            UpdateFoodtext();
            updatetext();
        }

        private void add1tps_Click(object sender, EventArgs e)
        {
            if (Hrana > 10000000)
            {
                gps += 1000000;
                Hrana -= 100000000;
            }
            Updategps();
            UpdateFoodtext();
            updatetext();
            
        }

        public void Updategps()
        {
            if (gps < 1000)
            {
                gpsin.Text = Convert.ToString(gps) + "g";
            }
            else if (gps < 1000000)
            {
                double cl = gps / 1000;
                gpsin.Text = Convert.ToString(cl) + "kg";
            }
            else if (gps < 1000000000)
            {
                double cl = gps / 1000000;
                gpsin.Text = Convert.ToString(cl) + "Mg";
            }
            else if (gps < 1000000000000)
            {
                double cl = gps / 1000000000;
                gpsin.Text = Convert.ToString(cl) + "Gg";
            }
            else if (gps < 1000000000000000)
            {
                double cl = gps / 1000000000000;
                gpsin.Text = Convert.ToString(cl) + "Tg";
            }
        }

        private void inventoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventon();
            NovobitjeOff();
            NVHrana();
            NNovazival();
            Zivalceoff();

            listView5.Items.Clear();
            ColumnHeader Stvar = new ColumnHeader();
            Stvar.Text = "Zival";
            Stvar.Width = 500;
            listView5.Columns.Add(Stvar);
            List<Stvar> Piko = PrincessA.Stvarice();
            foreach (Stvar item in Piko)
            {
                //string Namae = item.Ime;

                listView5.Items.Add(item.InfoKartica());

            }
        }

        private void zabeležiNovoBitjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovobitjeOn();
            NVHrana();
            NNovazival();
            Zivalceoff();
            Inventoff();

            listView4.Items.Clear();
            ColumnHeader Bitje = new ColumnHeader();
            Bitje.Text = "Zival";
            Bitje.Width = 500;
            listView4.Columns.Add(Bitje);
            List<Bitje> Piko = PrinceA.Bitjeca();
            foreach (Bitje item in Piko)
            {
                //string Namae = item.Ime;

                listView4.Items.Add(item.InfoKartica());

            }
        }

        public void NovobitjeOff()
        {
            KnjRanjen.Visible = false;
            KnjZiv.Visible = false;
            KnjTeza.Visible = false;
            KnjKolicina.Visible = false;
            KnjIme.Visible = false;
            KnjPot.Visible = false;
            label17.Visible = false;
            label16.Visible = false;
            label15.Visible = false;
            label14.Visible = false;
            label13.Visible = false;
            groupBox1.Visible = false;
            Ustvari.Visible=false;
            listView4.Visible = false;
        }
        public void NovobitjeOn()
        {
            KnjRanjen.Visible = true;
            KnjZiv.Visible = true;
            KnjTeza.Visible = true;
            KnjKolicina.Visible = true;
            KnjIme.Visible = true;
            KnjPot.Visible = true;
            label17.Visible = true;
            label16.Visible = true;
            label15.Visible=true;
            label14.Visible = true;
            label13.Visible = true;
            groupBox1.Visible = true;
            Ustvari.Visible = true;
            listView4.Visible=true;
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Ustvari_Click(object sender, EventArgs e)
        {
            try { Prince = new Bitje(KnjZiv.Checked, KnjRanjen.Checked, Convert.ToInt32(KnjPot.Text), float.Parse(KnjTeza.Text), Convert.ToInt32(KnjKolicina.Text), KnjIme.Text); }
            catch { Prince = new Bitje(); }

            KnjRanjen.Checked = false;
            KnjZiv.Checked = false;
            KnjTeza.Text = "";
            KnjKolicina.Text = "";
            KnjIme.Text = "";
            KnjPot.Text = "";

            listView4.Items.Clear();
            ColumnHeader Bitje = new ColumnHeader();
            Bitje.Text = "Zival";
            Bitje.Width = 500;
            listView4.Columns.Add(Bitje);
            List<Bitje> Piko = PrinceA.Bitjeca();
            foreach (Bitje item in Piko)
            {
                //string Namae = item.Ime;

                listView4.Items.Add(item.InfoKartica());

            }
        }

        public void Inventon()
        {
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            button1.Visible = true;
            listView5.Visible = true;
        }

        public void Inventoff()
        {
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            button1.Visible = false;
            listView5.Visible = false;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            try {  Princess = new Stvar(textBox3.Text, Convert.ToInt32(textBox2.Text), float.Parse(textBox1.Text)); }
            catch { Princess = new Stvar(); }

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            listView5.Items.Clear();
            ColumnHeader Stvar = new ColumnHeader();
            Stvar.Text = "Zival";
            Stvar.Width = 500;
            listView5.Columns.Add(Stvar);
            List<Stvar> Ploko = PrincessA.Stvarice();
            foreach (Stvar item in Ploko)
            {
                //string Namae = item.Ime;

                listView5.Items.Add(item.InfoKartica());

            }
        }
    }
}
