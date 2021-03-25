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
    public partial class Form8 : Form
    {
        String CPNJ;
        String tt1;
        String tt2;
        String tt3;
        String tt4;
        String tt5;
        String tt6;
        String tt7;
        String tt8;
        int cont2 = 0;
        int cont = 0;
        List<int> lista = new List<int>();
        Conexao comb = new Conexao();

        public Form8(String CNP)
        {
            InitializeComponent();
            CPNJ = CNP;

        }


        public void testa()
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

            //testa aqui
            String fim = dtp_fim.Value.Date.ToString("yyyy-MM-dd");
            String inicio = dtp_inicio.Value.Date.ToString("yyyy-MM-dd");

            if (tipo1.Checked || tipo2.Checked || tipo3.Checked || tipo4.Checked || tipo5.Checked || tipo6.Checked || tipo7.Checked || tipo8.Checked)
            {
                String sts = "2";
                if (inicio.Substring(0, 2) == DateTime.Now.Day.ToString())
                {
                    sts = "1";
                }

                if (MessageBox.Show("Deseja mesmo inserir a campanha " + txt_nome.Text + "?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    comb.sql = "insert into tb09_campanhas (tb09_nome, tb09_ong, tb09_status, tb09_datainicio, tb09_datafim, tb09_descricao, tb09_objetivo) values ('" + txt_nome.Text + "', '" + CPNJ + "', " + sts + ", '" + inicio + "', '" + fim + "s', '" + txt_descricao.Text + "', '" + txt_objetivo.Text + "')";
                    comb.open();
                    int l = comb.Runsql();
                    comb.close();

                    int newid = 0;
                    comb.sql = "SELECT MAX(tb09_id) FROM tb09_campanhas where tb09_ong='" + CPNJ + "'";
                    comb.open();
                    MySqlDataReader dados = comb.Execsql();

                    if (dados.HasRows)
                    {
                        while (dados.Read())
                        {

                            newid = int.Parse(dados["MAX(tb09_id)"].ToString());

                        }
                    }



                    comb.close();


                    comb.sql = "insert into tb10_ongs_campanhas (tb10_campanha, tb10_ong, tb10_status) values ("+newid+", "+CPNJ+", 2)";
                    comb.open();
                    l = comb.Runsql();
                    comb.close();
                    int dex = 0;
                    while (cont2 != 0) {

                        comb.sql = "insert into tb11_campanha_doacoes (tb11_tipo, tb11_campanha) values ("+lista[dex].ToString()+", "+newid+")";
                        comb.open();
                        l = comb.Runsql();
                        comb.close();
                        cont2--;
                        dex++;

                    }


                    Form7 fmr = new Form7(CPNJ);
                    fmr.Show();
                    this.Hide();
                }
                else
                {

                }

            }
            else
            {
                MessageBox.Show("Selecione pelo menos um tipo de doação!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }


        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void Inserir_Click(object sender, EventArgs e)
        {
            String fim = dtp_fim.Value.Date.ToString("yyyy-MM-dd");
            String inicio = dtp_inicio.Value.Date.ToString("yyyy-MM-dd");
            //MessageBox.Show(inicio + ", " + fim);
            if (txt_nome.Text != "" && txt_objetivo.Text != "" && txt_descricao.Text != "")
            {
                if (inicio == fim)
                {
                    MessageBox.Show("A campanha tem que durar mais do que um dia!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    testa();
                    
                }
            }
            else {

                MessageBox.Show("Preencha todos os campos!","Aviso:" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 fmr = new Form6(CPNJ);
            this.Dispose();
            fmr.Show();
        }
    }
}
