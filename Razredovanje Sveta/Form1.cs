using System;
using System.Windows.Forms;

namespace Razredovanje_Sveta
{
    public partial class Form1 : Form
    {
        public static System.Media.SoundPlayer bgmusic = new System.Media.SoundPlayer(@"C:\Users\lokna\Downloads\Home.wav");

        public Form1()
        {
            InitializeComponent();
        }

        private void Ograda(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void Music(object sender, EventArgs e)
        {
            //bgmusic.PlayLooping();
            //bgmusic.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button5.Visible = true;
            //bgmusic.Stop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            button4.Visible = true;
            //bgmusic.PlayLooping();
            //bgmusic.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bgmusic.Stop();
            Application.Exit();
        }
    }
}
