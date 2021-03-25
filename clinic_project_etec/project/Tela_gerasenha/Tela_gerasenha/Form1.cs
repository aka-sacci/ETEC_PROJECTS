using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tela_gerasenha
{
    public partial class Form1 : Form
    {
        int cont = 0;
        String tabela;
        String tipo;
        String campo;
        String nro;
        Conexao conn = new Conexao();
        public Form1()
        {
            InitializeComponent();
        }


        public void insert(String tab, String tipo, String numtab) {
            //MessageBox.Show("chamou bb");
            conn.sql = "insert into " + tab + " (tb0"+numtab+ "_status, tb0" + numtab + "_data) values('1', now());";
           // MessageBox.Show(conn.sql);
            conn.open();
            conn.Runsql();
            conn.close();
            //imprime aqui

            using (PrintDocument print = new PrintDocument())
            using (PrintPreviewDialog dialog = new PrintPreviewDialog())
            {
                print.PrintPage += Print_PrintPage;
                dialog.Document = print;
                dialog.ShowDialog();
            }


        }

        private void Print_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            string letra = System.AppDomain.CurrentDomain.BaseDirectory.ToString().Substring(0, 2);
            string fotoString = System.IO.Path.Combine(Application.StartupPath + @"/IMGS/sus2.png");
            Image image = Image.FromFile(string.Format(fotoString));
            g.DrawImage(image, 150, 20);
   
            Conexao comb = new Conexao();

            comb.sql = "Select max("+campo+") from " +tabela+ "";
            comb.open();
            MySqlDataReader dados = comb.Execsql();
            if (dados.HasRows)
            {
                while (dados.Read())
                {

                    using (Font font = new Font("Baskerville Old Face", 50, FontStyle.Bold))
                    {
                        Font font2 = new Font("Baskerville Old Face", 100, FontStyle.Bold);
                        Font font3 = new Font("Baskerville Old Face", 20);
                        Color minhaCor = Color.FromArgb(0, 91, 171);
                        SolidBrush brush = new SolidBrush(minhaCor);
                        if (tipo == "") {
                        }
                        g.DrawString("Atendimento: " + tipo, font, brush, 65, 400);
                        g.DrawString("Senha: "+dados["max("+campo+")"].ToString() +"", font2, brush, 100, 700);
                        g.DrawString("ETEC CARMINE BIAGIO TUNDISI ", font3, brush, 150, 1090);
                        g.DrawString(DateTime.Now.ToString("dddd, dd De MMMM yyyy") + ", " + DateTime.Now.ToString("HH:mm:ss"), font3, brush, 150, 1125);



                    }

                }


            }



                   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.ForeColor = System.Drawing.Color.White;
            cont = 1;
            tabela = "tb01_normal";
            tipo = "Normal";
            campo = "tb01_nro";
            nro = "1";
            insert(tabela, tipo, nro);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.ForeColor = System.Drawing.Color.White;
            cont = 1;
            tabela = "tb02_prioritario";
            tipo = "Prioritário";
            campo = "tb02_nro";
            nro = "2";
            insert(tabela, tipo, nro);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.ForeColor = System.Drawing.Color.White;
            cont = 1;
            tabela = "tb03_urgente";
            tipo = "Urgente";
            campo = "tb03_nro";
            nro = "3";
            insert(tabela, tipo, nro);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cont == 0)
            {

            }
            else {
                Color minhaCor = Color.FromArgb(0, 91, 171);
                button1.ForeColor = minhaCor;
                cont = 0;
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
