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
    public partial class Form13 : Form
    {
        String CNPJ;
        String CAMPANHA;
        Conexao comb = new Conexao();
        public Form13(String CNP, String CAMP)
        {
            InitializeComponent();
            CNPJ = CNP;
            CAMPANHA = CAMP;
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            onload();
            button1.Enabled = false;
        }


        public void onload()
        {

            Conexao comb3 = new Conexao();
            comb3.sql = "select * from tb13_campanha_doacoes inner join tb08_user on tb13_campanha_doacoes.tb13_user = tb08_user.tb08_id inner join tb03_tipo_doacao on tb13_campanha_doacoes.tb13_material = tb03_tipo_doacao.tb03_cod where tb13_campanha = " + CAMPANHA + "";
            comb3.open();
            MySqlDataReader dados2 = comb3.Execsql();

            if (dados2.HasRows)
            {
                while (dados2.Read())
                {
                    String status;
                    if (dados2["tb13_status"].ToString() == "2")
                    {
                        status = "Recebida";
                    }
                    else
                    {
                        status = "Não recebida";
                    }

                    dt1.Rows.Add(dados2["tb03_tipo"].ToString(), dados2["tb08_nome"].ToString(), dados2["tb13_data"].ToString().Substring(0, 10), status, dados2["tb13_sequencia"].ToString());

                }
            }

            dt1.ClearSelection();
            


        }

        private void dt1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                
                
                button1.Enabled = true;
                
            }
            catch
            {

                dt1.ClearSelection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo marcar essa doação como recebida?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                comb.sql = "update tb13_campanha_doacoes set tb13_status = 2 where tb13_sequencia = " + dt1.CurrentRow.Cells[4].Value.ToString();
                comb.open();
                int l = comb.Runsql();
                comb.close();
                dt1.Rows.Clear();
                onload();
                
            }
            else
            {
                dt1.ClearSelection();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 fmr = new Form6(CNPJ);
            this.Dispose();
            fmr.Show();
        }
    }
}
