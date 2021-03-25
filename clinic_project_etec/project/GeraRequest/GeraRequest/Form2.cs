using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeraRequest
{
    public partial class Form2 : Form
    {
        String g;
        MySqlDataReader dados;
        int cont;
        int define;
        public Form2(String guiche)
        {
            InitializeComponent();
            g = guiche;
        }



        public void select()
        {

            if (cont == 3)
            {
                Conexao comb = new Conexao();
                comb.sql = "Select tb01_nro from tb01_normal where tb01_status = '1' order by tb01_nro ASC limit 1";
                comb.open();
                dados = comb.Execsql();

                if (dados.HasRows)
                {
                    while (dados.Read())
                    {
                        define = int.Parse(dados["tb01_nro"].ToString());

                        if (define <= 9) label2.Text = "Senha: 00" + dados["tb01_nro"].ToString() + ", Tipo: Normal";
                        if (define >= 10 && define <= 99) label2.Text = "Senha: 0" + dados["tb01_nro"].ToString() + ", Tipo: Normal";
                        if (define >= 100 && define <= 999) label2.Text = "Senha: " + dados["tb01_nro"].ToString() + ", Tipo: Normal";
                        cont = 0;
                    }
                }

            }
            else
            {

                Conexao comb = new Conexao();
                comb.sql = "Select tb03_nro from tb03_urgente where tb03_status = '1' order by tb03_nro ASC limit 1";
                comb.open();
                dados = comb.Execsql();
                if (dados.HasRows)
                {
                    while (dados.Read())
                    {
                        define = int.Parse(dados["tb03_nro"].ToString());
                      
                        if (define <= 9) label2.Text = "Senha: 00" + dados["tb03_nro"].ToString() + ", Tipo: Urgente";
                        if (define >= 10 && define <= 99) label2.Text = "Senha: 0" + dados["tb03_nro"].ToString() + ", Tipo: Urgente";
                        if (define >= 100 && define <= 999) label2.Text = "Senha: " + dados["tb03_nro"].ToString() + ", Tipo: Urgente";

            


                    }

                }
                else
                {
                    comb.close();
                    comb.sql = "Select tb02_nro from tb02_prioritario where tb02_status = '1' order by tb02_nro ASC limit 1";
                    comb.open();
                    dados = comb.Execsql();

                    if (dados.HasRows)
                    {
                        while (dados.Read())
                        {
                            define = int.Parse(dados["tb02_nro"].ToString());
                            
                            if (define <= 9) label2.Text = "Senha: 00" + dados["tb02_nro"].ToString() + ", Tipo: Prioritário";
                            if (define >= 10 && define <= 99) label2.Text = "Senha: 0" + dados["tb02_nro"].ToString() + ", Tipo: Prioritário";
                            if (define >= 100 && define <= 999) label2.Text = "Senha: " + dados["tb02_nro"].ToString() + ", Tipo: Prioritário";

                            cont++;


                        }

                    }

                    else
                    {
                        comb.close();
                        comb.sql = "Select tb01_nro from tb01_normal where tb01_status = '1' order by tb01_nro ASC limit 1";
                        comb.open();
                        dados = comb.Execsql();

                        if (dados.HasRows)
                        {
                            while (dados.Read())
                            {
                                define = int.Parse(dados["tb01_nro"].ToString());
                                
                                if (define <= 9) label2.Text = "Senha: 00" + dados["tb01_nro"].ToString() + ", Tipo: Normal";
                                if (define >= 10 && define <= 99) label2.Text = "Senha: 0" + dados["tb01_nro"].ToString() + ", Tipo: Normal";
                                if (define >= 100 && define <= 999) label2.Text = "Senha: " + dados["tb01_nro"].ToString() + ", Tipo: Normal";



                            }
                        }
                    }
                }
            }
        } 

        public void insert() {
            Conexao conn = new Conexao();
            conn.sql = "insert into tb05_request (tb05_status, tb05_guiche, tb05_data) values ('1', '"+g+"', now())";
            conn.open();
            conn.Runsql();
            conn.close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label3.Text = "G"+g;
            label1.Text = DateTime.Now.ToString("dddd, dd De MMMM yyyy") + ", " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            select();
            insert();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dddd, dd De MMMM yyyy") + ", " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
