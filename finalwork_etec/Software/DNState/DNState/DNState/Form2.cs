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
using System.IO;
namespace DNState
{
    public partial class Form2 : Form
    {
        int cont = 0;
        String tt1;
        String tt2;
        String tt3;
        String tt4;
        String tt5;
        String tt6;
        String tt7;
        String tt8;
        int cont2 = 0;
        int INDEX = 0;
        int indexlimit = 0;
        List<int> lista = new List<int>();
        

        public Form2()
        {
            InitializeComponent();
        }

        public void enviatudo(String nome, String cnpjooj, String end, String senha, String telefone, String t1, String t2, String t3, String t4, String t5, String t6, String t7, String t8, String descricao, String bairro, String email)
        {
            //MessageBox.Show(bairro);
            

            if (nome != "" && cnpjooj != "" && end != "" && senha != "" && telefone != "" && descricao != "" && bairro != "" && email != "")
            {
                if (cont == 1)
                {
                    if (cnpjooj.Length == 14)
                    {


                        Conexao comb = new Conexao();
                       
                       
                            comb.sql = "insert into tb01_ongs (tb01_cnpj, tb01_nome, tb01_endereco, tb01_senha, tb01_descricao, tb01_bairro, tb01_telefone, tb01_email) values ("+cnpjooj+", '"+nome+"', '"+ end+"', '"+senha+"', '"+descricao+"', '"+bairro+"', '"+telefone+"', '"+email+"')";
                            comb.open();
                           // MessageBox.Show(comb.sql);
                       
                          int l =  comb.Runsql();
                           

                        if (l == 0)
                        {
                            MessageBox.Show("CNPJ já cadastrado!", "ERRO:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            comb.close();
                        }
                        else {
                            //faz outros inserts

                            while (cont2 != 0) {
                               // MessageBox.Show(cont2.ToString());
                                indexlimit = cont2 - 1;

                                
                                    
                                    
                                                
                                    comb.close();
                                    comb.sql = "insert into tb06_tipos (tb06_ong, tb06_tipo) values (" + cnpjooj + ", " + lista[INDEX].ToString() + ")";
                                    comb.open();
                                    l = comb.Runsql();
                                    comb.close();
                                    cont2--;
                                    INDEX++;
                                
                                
                                

                            }




                            
                            comb.sql = "insert into tb08_user (tb08_id, tb08_nome, tb08_email, tb08_senha) values ('" + cnpjooj + "', '" + nome + "', '" + email + "', '" + senha + "')";
                            comb.open();
                            l = comb.Runsql();
                            comb.close();

                            MessageBox.Show("Conta registrada!");
                            salvaimg();
                            Form3 fmr = new Form3(cnpjooj);
                            fmr.Show();
                            this.Hide();



                            //vai pra uotro form
                        }

                        
                 

                        


                    }
                    else
                    {
                        MessageBox.Show("Digite um CNPJ válido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("As senhas não coincidem!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }
            else
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        public void testa()
        {
            if (tipo.Checked)
            {
                tt1 = "1";
                cont2 = cont2+1;
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

            if (!tipo.Checked)
            {
                tt1 = "9";
            }
            if (!tipo2.Checked)
            {
                tt2 = "9";
            }
            if (!tipo3.Checked)
            {
                tt3 = "9";
            }
            if (!tipo4.Checked)
            {
                tt4 = "9";
            }
            if (!tipo5.Checked)
            {
                tt5 = "9";
            }
            if (!tipo6.Checked)
            {
                tt6 = "9";
            }
            if (!tipo7.Checked)
            {
                tt7 = "9";
            }
            if (!tipo8.Checked)
            {
                tt8 = "9";
            }

            if (tipo.Checked || tipo2.Checked || tipo3.Checked || tipo4.Checked || tipo5.Checked || tipo6.Checked || tipo7.Checked || tipo8.Checked)
            {

                //MessageBox.Show(comboBox1.Text);

                if (p1.Image != null)
                {

                    enviatudo(name.Text, cnpj.Text, endereco.Text, senha2.Text, telefone.Text, tt1, tt2, tt3, tt4, tt5, tt6, tt7, tt8, desc.Text, comboBox1.Text, email.Text);
                }
                else {

                    MessageBox.Show("Selecione o logo da ONG", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    pegaimg();
                }

                
            }
            else
            {
                MessageBox.Show("Selecione pelo menos um tipo de doação!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        public void salvaimg() {
            string letra = System.AppDomain.CurrentDomain.BaseDirectory.ToString().Substring(0, 2);

            if (cnpj.Text.Length == 14)
            {
                string fotoString = System.IO.Path.Combine("D:/xampp/htdocs/www/imgs/" + cnpj.Text + ".png");
                p1.Image.Save(fotoString);
                //MessageBox.Show("Logo salvo!", "Aviso", MessageBoxButtons.OK);
               
            }
            else {

                MessageBox.Show("Digite um CNPJ válido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

           
          

        }
        public void pegaimg() {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Arquivo de Imagem | *.png";
            ofd.ShowDialog();
            if (string.IsNullOrEmpty(ofd.FileName) == false) {

                p1.ImageLocation = ofd.FileName;
               
                
            }
        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {

                testa();

            }

            if (e.KeyCode == Keys.Escape)
            {

                if (MessageBox.Show("Tem certeza que você quer sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Application.Exit();

                }
            }

        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void senha2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cnpj_TextChanged(object sender, EventArgs e)
        {
            cnpj.MaxLength = 14;
        }

        private void telefone_TextChanged(object sender, EventArgs e)
        {
            telefone.MaxLength = 11;
        }

        private void senha_TextChanged(object sender, EventArgs e)
        {
            senha.MaxLength = 20;

            if (senha.Text != senha2.Text)
            {
                lbconfirm.Text = "As senhas não coincidem!";
                lbconfirm.ForeColor = System.Drawing.Color.Red;
                cont = 0;

            }
            else
            {
                lbconfirm.Text = "As senhas coincidem!";
                lbconfirm.ForeColor = System.Drawing.Color.Green;
                cont = 1;
            }

        }

        private void senha2_TextChanged(object sender, EventArgs e)
        {
            senha2.MaxLength = 20;

            if (senha.Text != senha2.Text)
            {
                lbconfirm.Text = "As senhas não coincidem!";
                lbconfirm.ForeColor = System.Drawing.Color.Red;
                cont = 0;

            }
            else
            {
                lbconfirm.Text = "As senhas coincidem!";
                lbconfirm.ForeColor = System.Drawing.Color.Green;
                cont = 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            testa();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    

      

        private void button2_Click(object sender, EventArgs e)
        {
            pegaimg();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void tipo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tipo2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tipo3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tipo4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tipo8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tipo7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tipo6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tipo5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbconfirm_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void p1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
