using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urna_Sacci
{
   
    public partial class Form2 : Form
    {
        int timeLeft = 5;
        public Form2()
        {
            InitializeComponent();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (timeLeft > 0)
            {

                timeLeft = timeLeft - 1;

            }
            else {


                Form1 fmr = new Form1();
                fmr.Show();
                this.Hide();
                timer1.Stop();

                
              
                

            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
