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
    public partial class Form1 : Form
    {
        Conexao comb = new Conexao();
        String nome;
        public Form1()
        {
            InitializeComponent();
        }

        private void loga(String cnpj, String senha) {

            if (cnpj.Length != 13)
            {
                if (textBox2.Text != "")
                {
                    textBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    comb.sql = "Select * From `tb01_ongs` WHERE `tb01_CNPJ` = '" + textBox1.Text + "' AND tb01_senha = '" + textBox2.Text + "'; ";


                    comb.open();

                    MySqlDataReader dados = comb.Execsql();

                    if (dados.HasRows)
                    {

                        while (dados.Read()) {
                            nome = dados["tb01_nome"].ToString();
                        }




                        Form3 fmr = new Form3(textBox1.Text);
                        fmr.Show();
                        this.Hide();
                        //abre outro form
                    }

                    else {
                        MessageBox.Show("Conta inválida!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    comb.close();

                   

                }
               



            }
            else {

                MessageBox.Show("CNPJ inválido! Digite 13 dígitos!","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Error);
                LIMPA();
            }
           
            
        }

        public void LIMPA() {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.MaxLength = 14;
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 20;
            
        }

      
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                loga(textBox1.Text, textBox2.Text);
            }

            if (e.KeyCode == Keys.Escape)
            {

                    if (MessageBox.Show("Tem certeza que você quer sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        this.Dispose();

                    }
            }


            if (e.KeyCode == Keys.F1)
            {
                Form2 f = new Form2();
                f.Show();
                this.Hide();

            }
            }



        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //aqui entra o sqlite
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
    }

