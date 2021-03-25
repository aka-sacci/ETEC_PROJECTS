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

namespace DNState
{
    public partial class Form6 : Form
    {
        String CNPJ;
        int qtde = 0;
        String tt1;
        String tt2;
        String tt3;
        String tt4;
        String tt5;
        String tt6;
        String tt7;
        String tt8;
        int cont2 = 0;
        int i = 1;
        List<int> lista = new List<int>();
        int cont = 0;
        int INDEX = 0;
        int indexlimit = 0;
        String NOME;
        public Form6(String CNP)
     
        {
            
            InitializeComponent();
            CNPJ = CNP;
           
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Conexao comb3 = new Conexao();
            comb3.sql = "select count(tb07_tipo) from tb07_urgencias where tb07_ong = " + CNPJ + "";
            comb3.open();
            MySqlDataReader dados2 = comb3.Execsql();

            if (dados2.HasRows)
            {
                while (dados2.Read())
                {

                    qtde = int.Parse(dados2["count(tb07_tipo)"].ToString());
                }
            }


            Conexao comb2 = new Conexao();
            comb2.sql = "select tb07_tipo from tb07_urgencias where tb07_ong = " + CNPJ + "";
            comb2.open();
            MySqlDataReader dados3 = comb2.Execsql();

            if (dados3.HasRows)
            {

                while (dados3.Read())
                {

                    //MessageBox.Show(dados3["tb06_tipo"].ToString());

                    if (dados3["tb07_tipo"].ToString().Equals("1")) tipo1.Checked = true;
                    if (dados3["tb07_tipo"].ToString().Equals("2")) tipo2.Checked = true;
                    if (dados3["tb07_tipo"].ToString().Equals("3")) tipo3.Checked = true;
                    if (dados3["tb07_tipo"].ToString().Equals("4")) tipo4.Checked = true;
                    if (dados3["tb07_tipo"].ToString().Equals("5")) tipo5.Checked = true;
                    if (dados3["tb07_tipo"].ToString().Equals("6")) tipo6.Checked = true;
                    if (dados3["tb07_tipo"].ToString().Equals("7")) tipo7.Checked = true;
                    if (dados3["tb07_tipo"].ToString().Equals("8")) tipo8.Checked = true;
                }
                comb2.close();
            }
        }


        public void enviatudo(String t1, String t2, String t3, String t4, String t5, String t6, String t7, String t8)
        {
            Conexao cb2 = new Conexao();
            cb2.sql = "delete from tb07_urgencias where tb07_ong = " + CNPJ + "";
            cb2.open();
            cb2.Runsql();
            cb2.close();

            Conexao comb = new Conexao();                   

                            while (cont2 != 0)
                            {
                                //MessageBox.Show(cont2.ToString());
                                comb.sql = "insert into tb07_urgencias (tb07_tipo, tb07_ong) values (" + lista[INDEX].ToString() + ", '" + CNPJ + "')";
                                comb.open();
                                comb.Runsql();
                                comb.close();
                                cont2--;
                                INDEX++;




                            }

            
            Form3 fmr = new Form3(CNPJ);
            fmr.Show();
            this.Dispose();

        }


        private void button1_Click(object sender, EventArgs e)
        {
           

            if (tipo1.Checked)
            {
                tt1 = "1";
                cont2 = cont2 + 1;
                lista.Add(1);
            }
            if (tipo2.Checked)
            {
                tt2 = "2";
                cont2 = cont2 + 1;
                lista.Add(2);
            }
            if (tipo3.Checked)
            {
                tt3 = "3";
                cont2 = cont2 + 1;
                lista.Add(3);
            }
            if (tipo4.Checked)
            {
                tt4 = "4";
                cont2 = cont2 + 1;
                lista.Add(4);
            }
            if (tipo5.Checked)
            {
                cont2 = cont2 + 1;
                tt5 = "5";
                lista.Add(5);
            }
            if (tipo6.Checked)
            {
                cont2 = cont2 + 1;
                tt6 = "6";
                lista.Add(6);
            }
            if (tipo7.Checked)
            {
                cont2 = cont2 + 1;
                tt7 = "7";
                lista.Add(7);
            }
            if (tipo8.Checked)
            {
                cont2 = cont2 + 1;
                tt8 = "8";
                lista.Add(8);
            }

            if (tipo1.Checked || tipo2.Checked || tipo3.Checked || tipo4.Checked || tipo5.Checked || tipo6.Checked || tipo7.Checked || tipo8.Checked)
            {

                //MessageBox.Show(comboBox1.Text);
                if (MessageBox.Show("Deseja mesmo salvar as alterações?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    enviatudo(tt1, tt2, tt3, tt4, tt5, tt6, tt7, tt8);
                }
                else
                {
                    Form3 fmr = new Form3(CNPJ);
                    fmr.Show();
                    this.Dispose();
                }


               



            }
            else
            {
                MessageBox.Show("Selecione pelo menos um tipo de doação!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 fmr = new Form7(CNPJ);
            fmr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 fmr = new Form9(CNPJ);
            fmr.Show();
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 fmr = new Form3(CNPJ);
            this.Dispose();
            fmr.Show();
        }
    }
}
