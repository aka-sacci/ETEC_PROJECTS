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
    public partial class Form9 : Form
    {
        string name;
        String CNPJ;
        int cont = 0;
        List<int> lista = new List<int>();
        List<int> lista2 = new List<int>();
        int cont2 = 0;
        Conexao comb = new Conexao();


        public Form9(String CNP)
        {
            InitializeComponent();
            CNPJ = CNP;
        }

        private void carreganame(int ID, int index) {
            Conexao comb3 = new Conexao();
            comb3.sql += "select tb01_nome from tb09_campanhas inner join tb01_ongs on tb09_campanhas.tb09_ong = tb01_ongs.tb01_cnpj where tb09_id="+ID+"";
            comb3.open();
            MySqlDataReader dados2 = comb3.Execsql();
            
            if (dados2.HasRows)
            {

                while (dados2.Read())
                {

                    name = dados2["tb01_nome"].ToString();
                    dt_campanhas.Rows[index].Cells[4].Value = name;


                }
            }


            comb3.close();


        }

        private void carreganame2(int ID, int index)
        {
            Conexao comb3 = new Conexao();
            comb3.sql += "select tb01_nome from tb09_campanhas inner join tb01_ongs on tb09_campanhas.tb09_ong = tb01_ongs.tb01_cnpj where tb09_id=" + ID + "";
            comb3.open();
            MySqlDataReader dados2 = comb3.Execsql();

            if (dados2.HasRows)
            {

                while (dados2.Read())
                {

                    name = dados2["tb01_nome"].ToString();
                    dt_camp.Rows[index].Cells[4].Value = name;


                }
            }


            comb3.close();


        }

        public void onload() {


            dt_campanhas.Rows.Clear();
            dt_camp.Rows.Clear();
            Conexao comb3 = new Conexao();
            comb3.sql += "select tb09_nome, date(tb09_datainicio), date(tb09_datafim), tb09_id, tb01_nome, tb09_status from tb10_ongs_campanhas ";
            comb3.sql += "inner join tb09_campanhas on tb10_ongs_campanhas.tb10_campanha = tb09_campanhas.tb09_id ";
            comb3.sql += "inner join tb01_ongs on tb10_ongs_campanhas.tb10_ong = tb01_ongs.tb01_cnpj where tb10_ong = " + CNPJ + " and tb09_ong <> " + CNPJ + " and tb10_status = 1 ";
            comb3.sql += "order by tb09_status ASC ";
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

                    lista.Add(int.Parse(dados2["tb09_id"].ToString()));
                    dt_campanhas.Rows.Add(dados2["tb09_nome"].ToString(), inicio, fim, status, "", dados2["tb09_id"].ToString());
                    cont++;
                }
            }

            dt_campanhas.ClearSelection();
            comb3.close();
            int index = 0;

            while (cont != 0)
            {

                carreganame(int.Parse(lista[index].ToString()), index);
                index++;
                cont--;

            }
            dt_campanhas.ClearSelection();

            comb3.sql = "";
            comb3.sql += "select tb09_nome, date(tb09_datainicio), date(tb09_datafim), tb09_id, tb01_nome, tb09_status from tb10_ongs_campanhas ";
            comb3.sql += "inner join tb09_campanhas on tb10_ongs_campanhas.tb10_campanha = tb09_campanhas.tb09_id ";
            comb3.sql += "inner join tb01_ongs on tb10_ongs_campanhas.tb10_ong = tb01_ongs.tb01_cnpj where tb10_ong = " + CNPJ + " and tb09_ong <> " + CNPJ + " and tb10_status = 2 ";
            comb3.sql += "order by tb09_status ASC ";
            comb3.open();
            


            dados2 = comb3.Execsql();

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

                    lista2.Add(int.Parse(dados2["tb09_id"].ToString()));
                    dt_camp.Rows.Add(dados2["tb09_nome"].ToString(), inicio, fim, status, "", dados2["tb09_id"].ToString());
                    cont2++;
                }
            }

            dt_campanhas.ClearSelection();
            comb3.close();

            int index2 = 0;

            while (cont2 != 0)
            {

                carreganame2(int.Parse(lista2[index2].ToString()), index2);
                index2++;
                cont2--;

            }
            dt_campanhas.ClearSelection();
            dt_camp.ClearSelection();
            Aceitar.Enabled = false;
            deletar.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            dt_campanhas.ClearSelection();
            dt_camp.ClearSelection();

        }

        private void Form9_Load(object sender, EventArgs e)
        {

            onload();
            

        }

        private void Aceitar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo aceitar a solicitação?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                comb.sql = "update tb10_ongs_campanhas set tb10_status = 2 where tb10_campanha = "+ dt_campanhas.CurrentRow.Cells[5].Value.ToString()+ " and tb10_ong = "+CNPJ+"";
                comb.open();
                int l = comb.Runsql();
                comb.close();
                onload();
            }
            else {


            }
            }

        private void dt_campanhas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String teste = dt_campanhas.CurrentRow.Cells[5].Value.ToString();
               
                deletar.Enabled = true;
                Aceitar.Enabled = true;
            }
            catch
            {

                dt_campanhas.ClearSelection();
            }
        }

        private void deletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo deletar a solicitação?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                comb.sql = "update tb10_ongs_campanhas set tb10_status = 3 where tb10_campanha = " + dt_campanhas.CurrentRow.Cells[5].Value.ToString() + " and tb10_ong = " + CNPJ + "";
                comb.open();
                int l = comb.Runsql();
                comb.close();
                onload();
            }
            else
            {


            }
        }

        private void dt_camp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String teste = dt_camp.CurrentRow.Cells[5].Value.ToString();
                MessageBox.Show(teste);
                
                button1.Enabled = true;
                button2.Enabled = true;
                
            }
            catch
            {

                dt_camp.ClearSelection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair da campanha?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                comb.sql = "update tb10_ongs_campanhas set tb10_status = 3 where tb10_campanha = " + dt_camp.CurrentRow.Cells[5].Value.ToString() + " and tb10_ong = " + CNPJ + "";
                comb.open();
                int l = comb.Runsql();
                comb.close();
                onload();
            }
            else
            {


            }
        }

        private void dt_camp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form13 fmr = new Form13(CNPJ, dt_camp.CurrentRow.Cells[5].Value.ToString());
            fmr.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 fmr = new Form6(CNPJ);
            this.Dispose();
            fmr.Show();
        }
    }
}
