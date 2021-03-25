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
    public partial class Form7 : Form
    {
        Encoding enc = Encoding.UTF8;
        String CNPJ;
        Conexao comb = new Conexao();
        public Form7(String CNP)
        {
            InitializeComponent();
            CNPJ = CNP;
        }

        public void onload() {
            dt_campanhas.Rows.Clear();
            Conexao comb3 = new Conexao();
            comb3.sql = "select tb09_nome, date(tb09_datainicio), date(tb09_datafim), tb09_id, tb09_status from tb09_campanhas where tb09_ong = " + CNPJ + " order by tb09_status ASC";
            comb3.open();
            MySqlDataReader dados2 = comb3.Execsql();

            if (dados2.HasRows)
            {
                while (dados2.Read())
                {
                    String status;
                    if (dados2["tb09_status"].ToString() == "2")
                    {
                        status = "Desativada";
                    }
                    else
                    {
                        status = "Ativada";
                    }
                    String inicio = dados2["date(tb09_datainicio)"].ToString().Substring(0, 10);
                    String fim = dados2["date(tb09_datafim)"].ToString().Substring(0, 10);

                    dt_campanhas.Rows.Add(dados2["tb09_nome"].ToString(), inicio, fim, status, dados2["tb09_id"].ToString());
                }
            }

            dt_campanhas.ClearSelection();
            deletar.Enabled = false;
            desativa.Enabled = false;
            button1.Enabled = false;
            button3.Enabled = false;


        }

        private void Form7_Load(object sender, EventArgs e)
        {
            onload();
        }

        private void deletar_Click(object sender, EventArgs e)
        {
            String campanha = dt_campanhas.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Deseja mesmo deletar a campanha "+ campanha + "?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                comb.sql = "delete from tb09_campanhas where tb09_id="+ dt_campanhas.CurrentRow.Cells[4].Value.ToString()+"";
                comb.open();
                int l = comb.Runsql();
                comb.close();
                onload();
            }
            else
            {
                dt_campanhas.ClearSelection();
            }
        }

        private void dt_campanhas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String teste = dt_campanhas.CurrentRow.Cells[0].Value.ToString();
                deletar.Enabled = true;
                desativa.Enabled = true;
                button1.Enabled = true;
                button3.Enabled = true;
            }
            catch
            {

                dt_campanhas.ClearSelection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String campanha = dt_campanhas.CurrentRow.Cells[0].Value.ToString();


            if (dt_campanhas.CurrentRow.Cells[3].Value.ToString() == "Ativada")
            {
                if (MessageBox.Show("Deseja mesmo desativar a campanha " + campanha + "?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    comb.sql = "update tb09_campanhas set tb09_status=2, where tb09_id=" + dt_campanhas.CurrentRow.Cells[4].Value.ToString() + "";
                    comb.open();
                    int l = comb.Runsql();
                    comb.close();
                    onload();
                }
                else
                {
                    dt_campanhas.ClearSelection();
                }
            }
            else {

                if (MessageBox.Show("Deseja mesmo ativar a campanha " + campanha + "?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    comb.sql = "update tb09_campanhas set tb09_status=1 where tb09_id=" + dt_campanhas.CurrentRow.Cells[4].Value.ToString() + "";
                    comb.open();
                    int l = comb.Runsql();
                    comb.close();
                    onload();
                }
                else
                {
                    dt_campanhas.ClearSelection();
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 fmr = new Form8(CNPJ);
            fmr.Show();
            this.Hide();
        }

        private void dt_campanhas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form10 fmr = new Form10(CNPJ, dt_campanhas.CurrentRow.Cells[4].Value.ToString());
            fmr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form13 fmr = new Form13(CNPJ, dt_campanhas.CurrentRow.Cells[4].Value.ToString());
            fmr.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 fmr = new Form6(CNPJ);
            this.Dispose();
            fmr.Show();
        }
    }
}
