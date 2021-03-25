using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DNState
{
    
    public partial class Form3 : Form
    {

        String J;
        Conexao comb = new Conexao();
        String nome;
        int c = 0;
        public Form3(String CNPJOOJ)
        {
            InitializeComponent();
            J = CNPJOOJ;
            
                 
        }

        public void donations() {
            //abre outro form , passa infos
        }

        public void onload(String CJ) {
            
            
                string letra = System.AppDomain.CurrentDomain.BaseDirectory.ToString().Substring(0, 2);
                string fotoString = System.IO.Path.Combine("D:/xampp/htdocs/www/imgs/" + CJ + ".png");
                //pictureBox1.Image = Image.FromFile(fotoString);

            if (!System.IO.File.Exists(fotoString))
            {
                MessageBox.Show("Foto não encontrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                pictureBox1.Image = null;


            }

           // fotoString = System.IO.Path.Combine(letra + @"/Arquivos/2018/TCC/Software/DNState/DNState/DNState/bin/Debug/logos/" + CJ + @".jpeg");
               // pictureBox1.Image = Image.FromFile(fotoString);
            




            comb.sql = "Select count(tb02_cod) from tb02_doacoes where tb02_ong = '" + CJ+ "' and tb02_status = 1 ";


            comb.open();

            MySqlDataReader dados = comb.Execsql();

            if (dados.HasRows)
            {
                while (dados.Read())
                {
                    String resul = dados["count(tb02_cod)"].ToString();
                   // MessageBox.Show(resul);
                    if (resul != "0")
                    {
                        if (resul == "1") {

                            lbst.Text = "Você tem " + resul + " doação nova!";
                            c = 1;

                        } else {

                            lbst.Text = "Você tem " + resul + " doações novas!";
                            c = 1;

                        }


                    }
                    else {
                        lbst.Text = "Você não tem nenhuma doação nova!";
                        c = 0;


                    }

                }



            }
      
        

            comb.close();

            //carrega o logo da ong e exibe a aba de conversas
            //String sqlel = "Select count(tb05_cod) from tb05_conversas where tb05_ong = '" + CJ + "' and tb05_status = 2 ";
            comb.sql = "Select count(tb05_sequencia) from tb05_conversas where tb05_para = '" + CJ + "' and tb05_status = 1 ";

           
            comb.open();

            MySqlDataReader dados2 = comb.Execsql();
           // MessageBox.Show(sqlel);


            if (dados2.HasRows)
            {
                
                while (dados2.Read())
                {
                    String resul = dados2["count(tb05_sequencia)"].ToString();
                    //MessageBox.Show(resul);
                
                if (resul != "0")
                {
                        if (resul == "1")
                        {
                            lbcv.Text = "Você tem " + resul + " mensagem não respondida!!";
                            Conversas.Text = "CONVERSAS (" + resul + ")";
                        }
                        else {

                            lbcv.Text = "Você tem " + resul + " mensagens não respondidas!!";
                            Conversas.Text = "CONVERSAS (" + resul + ")";
                        }

                   

                }
                else
                {
                    lbcv.Text = "Você não tem nehuma mensagem nova!";


                }

                }

            }
           


            comb.close();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           // MessageBox.Show(J);
            
            onload(J);
            comb.sql = "Select tb01_nome from tb01_ongs where tb01_cnpj = '" + J + "'";


            comb.open();

            MySqlDataReader dados = comb.Execsql();

            if (dados.HasRows)
            {
                while (dados.Read())
                {

                    nome = dados["tb01_nome"].ToString();
                    namee.Text = nome;

                }
            }



            comb.close();



            //aqui vai fazer o select
        }

        private void lbst_Click(object sender, EventArgs e)
        {
            donations();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Conversas_Click(object sender, EventArgs e)
        {
            Form4 fmr = new Form4(J);
            fmr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 fmr = new Form6(J);
            fmr.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 fmr = new Form12(J);
            fmr.Show();
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 fm = new Form5(J);
            pictureBox1.Image.Dispose();
            this.Dispose();
            fm.Show();
        }

        private void lbcv_Click(object sender, EventArgs e)
        {

        }

        private void namee_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form11 fmr = new Form11(J);
            fmr.Show();
            this.Dispose();
        }
    }
}
