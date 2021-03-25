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
    public partial class Form12 : Form
    {
        String CNPJ;
        Conexao comb = new Conexao();
        public Form12(String CNP)
        {
            InitializeComponent();
            CNPJ = CNP;
        }

        public void onload() {


            Conexao comb3 = new Conexao();
            comb3.sql = "select * from tb02_doacoes inner join tb08_user on tb02_doacoes.tb02_user = tb08_user.tb08_id inner join tb03_tipo_doacao on tb02_doacoes.tb02_tipo = tb03_tipo_doacao.tb03_cod where tb02_ong = " + CNPJ + "";
            comb3.open();
            MySqlDataReader dados2 = comb3.Execsql();

            if (dados2.HasRows)
            {
                while (dados2.Read())
                {
                    String status;
                    if (dados2["tb02_status"].ToString() == "2")
                    {
                        status = "Recebida";
                    }
                    else
                    {
                        status = "Não recebida";
                    }

                    dt1.Rows.Add(dados2["tb03_tipo"].ToString(), dados2["tb08_nome"].ToString(), dados2["tb02_data"].ToString().Substring(0, 10), status, dados2["tb02_cod"].ToString());

                }
            }
            button1.Enabled = false;

        }

        private void Form12_Load(object sender, EventArgs e)
        {
            onload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo marcar essa doação como recebida?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                comb.sql = "update tb02_doacoes set tb02_status = 2 where tb02_cod = " + dt1.CurrentRow.Cells[4].Value.ToString();
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

        private void dt1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fmr = new Form3(CNPJ);
            this.Dispose();
            fmr.Show();
        }
    }
}
