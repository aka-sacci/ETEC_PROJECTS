using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caca_niquel
{
    public partial class Form2 : Form
    {
        int chan;
        String NAME;
        int cont;
        int dinehiros;
        Random r = new Random();
        Random r2 = new Random();
        Random r3 = new Random();



        public Form2(string valor, string nomem)
        {
            InitializeComponent();
           chan = int.Parse(valor);
            NAME = nomem;
           
        }

        public void preenche() {

            NOME.Text = NAME;
            FICHA.Text = chan.ToString()+" FICHAS";

        }
    

        private void Form2_Load(object sender, EventArgs e)
        {

            preenche();
            pictureBox1.Hide();
            pictureBox1.Enabled = false;
            cont = 0; 

        }

        private void FICHA_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //faz sorteio, chan --, cont = 1
            if (chan != 0)
            {

                cont = 1;

                int rr = r.Next(4);
                int rr2 = r.Next(4);
                int rr3 = r.Next(4);
                chan--;
                preenche();
                //aqui seta as img

               
                string fotoString1 = System.IO.Path.Combine(Application.StartupPath + @"/imagens/" + rr + @".jpg");
                p1.Image = Image.FromFile(fotoString1);

                
                string fotoString2 = System.IO.Path.Combine(Application.StartupPath + @"/imagens/" + rr2 + @".jpg");
                p2.Image = Image.FromFile(fotoString2);

                
                string fotoString3 = System.IO.Path.Combine(Application.StartupPath + @"/imagens/" + rr3 + @".jpg");
                p3.Image = Image.FromFile(fotoString3);


                if (rr == 0 && rr2 == 0 && rr3 == 0)
                {
                    dinehiros = dinehiros + 10;
                    label5.Text = string.Format("{0:C}", Convert.ToDouble(dinehiros));
                    chan = chan + 7;

                    System.Media.SoundPlayer tocar;
                    tocar = new System.Media.SoundPlayer(Application.StartupPath + "/audios/aceto.wav");
                    tocar.Play();

                }

                if (rr == 1 && rr2 == 1 && rr3 == 1)
                {
                    dinehiros = dinehiros + 10;
                    label5.Text = string.Format("{0:C}", Convert.ToDouble(dinehiros));
                    chan = chan + 7;

                    System.Media.SoundPlayer tocar;
                    tocar = new System.Media.SoundPlayer(Application.StartupPath + "/audios/macho.wav");
                    tocar.Play();

                }
                if (rr == 2 && rr2 == 2 && rr3 == 2)
                {

                    dinehiros = dinehiros + 10;
                    label5.Text = string.Format("{0:C}", Convert.ToDouble(dinehiros));
                    chan = chan + 7;

                    System.Media.SoundPlayer tocar;
                    tocar = new System.Media.SoundPlayer(Application.StartupPath +  "/audios/jooj.wav");
                    tocar.Play();

                }
                if (rr == 3 && rr2 == 3 && rr3 == 3)
                {
                    dinehiros = dinehiros + 20;
                    dinehiros = dinehiros * 2;
                    label5.Text = string.Format("{0:C}", Convert.ToDouble(dinehiros));
                    //toca audio do nego bam
                    System.Media.SoundPlayer tocar;
                    tocar = new System.Media.SoundPlayer(Application.StartupPath + "/audios/sus.wav");
                    tocar.Play();
                }
            }
            else {

                MessageBox.Show("ZUAS CHANZES ACABARAM VAZIÃUM. VOZÊ GANHOU " + label5.Text + "");
                Application.Exit();
                    }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cont == 0)
            {
                pictureBox1.Hide();
                pictureBox1.Enabled = false;
                pictureBox4.Show();
                pictureBox4.Enabled = true;
            }
            else {
                pictureBox4.Hide();
                pictureBox4.Enabled = false;
                pictureBox1.Show();
                cont = 0;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
