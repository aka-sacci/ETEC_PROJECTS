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
    public partial class Form10 : Form
    {
        String CNPJ;
        String CAMPANHA;
        String CP;
        Conexao comb = new Conexao();

        public Form10(String CNP, String CAMP)
        {
            InitializeComponent();
            CNPJ = CNP;
            CAMPANHA = CAMP;
            
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            txt_nome.Hide();
            txt_numero.Hide();
            txt_email.Hide();
            txt_end.Hide();
            button1.Enabled = false;
            
            Conexao comb3 = new Conexao();
            comb3.sql = "select * from tb09_campanhas where tb09_id = "+CAMPANHA+"";
            comb3.open();
            MySqlDataReader dados2 = comb3.Execsql();

            if (dados2.HasRows)
            {
                while (dados2.Read())
                {
                    label_campanha.Text = dados2["tb09_nome"].ToString();
                   

                }
            }



        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txt_cnpj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txt_cnpj_TextChanged(object sender, EventArgs e)
        {


            txt_cnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txt_cnpj.Text.Length == 14)
            {
                
                if (txt_cnpj.Text == CNPJ)
                {
                    
                    MessageBox.Show("Digite uma Ong DIFERENTE da sua!");
                    txt_cnpj.Text = "";
                }
                else
                {


                    Conexao comb3 = new Conexao();
                    txt_cnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    
                    comb3.sql = "select * from tb01_ongs where tb01_cnpj = " + txt_cnpj.Text + "";
                    comb3.open();
                    MySqlDataReader dados2 = comb3.Execsql();

                    if (dados2.HasRows)
                    {
                        while (dados2.Read())
                        {
                            String tel = dados2["tb01_telefone"].ToString();



                            CP = txt_cnpj.Text;
                            txt_nome.Show();
                            txt_nome.Text = dados2["tb01_nome"].ToString();
                            txt_numero.Show();
                            txt_numero.Text = tel;
                            txt_email.Show();
                            txt_email.Text = dados2["tb01_email"].ToString();
                            txt_end.Show();
                            txt_end.Text = dados2["tb01_endereco"].ToString() + ", " + dados2["tb01_bairro"].ToString();
                            button1.Enabled = true;


                        }
                    }

                    else
                    {
                        
                        MessageBox.Show("ONG não encontrada!");
                        txt_cnpj.Text = "";

                    }
                    comb3.close();
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo solicitar que a '" + txt_nome.Text + "' entre na campanha '"+ label_campanha.Text + "' ?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Conexao comb3 = new Conexao();
                txt_cnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                comb3.sql = "select * from tb10_ongs_campanhas where tb10_ong = " + CP + " and tb10_campanha = "+CAMPANHA+"";
                comb3.open();
                MySqlDataReader dados2 = comb3.Execsql();

                if (dados2.HasRows)
                {
                    MessageBox.Show("A ONG já está inserida na campanha/Você já mandou a solicitação para essa ONG");
                    comb3.close();

                }
                else {

                    comb.sql = "insert into tb10_ongs_campanhas(tb10_campanha, tb10_ong, tb10_status) values ("+CAMPANHA+", "+CP+", 1)";
                    comb.open();
                    int l = comb.Runsql();
                    comb.close();
                    MessageBox.Show("Convite enviado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form7 fmr = new Form7(CNPJ);
                    this.Dispose();
                    fmr.Show();
                }

                
            }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 fmr = new Form7(CNPJ);
            this.Dispose();
            fmr.Show();
        }
    }
}
