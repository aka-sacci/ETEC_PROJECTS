using MySql.Data.MySqlClient;
using MySql.Data;
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
    public partial class Form5 : Form
    {
        String tt1;
        String tt2;
        String tt3;
        String tt4;
        String tt5;
        String tt6;
        String tt7;
        String tt8;
        String CNPJ;
        String nomeori;
        int qtde;
        int cont2 = 0;
        int i = 1;
        List<int> lista = new List<int>();
        int cont = 0;
        int INDEX = 0;
        int indexlimit = 0;

        public Form5(String cnpj2)
        {
            InitializeComponent();
            CNPJ = cnpj2;
        }

        public void pegaimg() {
           
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Arquivo de Imagem | *.png";
            ofd.ShowDialog();
            if (string.IsNullOrEmpty(ofd.FileName) == false)
            {
                
                p1.ImageLocation = ofd.FileName;


            }
        }

        public void salvaimg()
        {
            string letra = System.AppDomain.CurrentDomain.BaseDirectory.ToString().Substring(0, 2);

           



                if (p1.Image == null)
                {




                }
                else
            {

                cnpjj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                string fotoString = System.IO.Path.Combine("D:/xampp/htdocs/www/imgs/" + CNPJ + ".png");
                    if (System.IO.File.Exists(fotoString))
                    {

                        FileInfo arquivo = new FileInfo(fotoString);

                        arquivo.Delete();
                        // MessageBox.Show("passou delete");

                    }


                    p1.Image.Save(fotoString);
                    // MessageBox.Show("Logo salvo!", "Aviso", MessageBoxButtons.OK);
                }
             


           

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

            if (!tipo1.Checked)
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

            if (tipo1.Checked || tipo2.Checked || tipo3.Checked || tipo4.Checked || tipo5.Checked || tipo6.Checked || tipo7.Checked || tipo8.Checked)
            {

                //MessageBox.Show(comboBox1.Text);


                cnpjj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                enviatudo(name.Text, cnpjj.Text, endereco.Text, senha2.Text, telefone.Text, tt1, tt2, tt3, tt4, tt5, tt6, tt7, tt8, desc.Text, comboBox1.Text, email.Text);
               


            }
            else
            {
                MessageBox.Show("Selecione pelo menos um tipo de doação!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
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


                        comb.sql = "update tb01_ongs set  tb01_nome = '" + nome + "', tb01_endereco = '" + end + "', tb01_senha = '" + senha + "', tb01_descricao =  '" + descricao + "', tb01_bairro = '" + bairro + "', tb01_telefone = '" + telefone + "', tb01_email = '" + email + "' where tb01_cnpj = " + cnpjooj + " ";
                        comb.open();
                        // MessageBox.Show(comb.sql);

                        int l = comb.Runsql();


                        if (l == 0)
                        {
                            MessageBox.Show("Erro", "ERRO:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            comb.close();
                        }

                        else
                        {
                            //faz outros inserts
                            comb.close();
                            Conexao cb2 = new Conexao();
                            cb2.sql = "delete from tb06_tipos where tb06_ong = "+cnpjooj+"";
                            cb2.open();
                            l = cb2.Runsql();
                            cb2.close();

                            while (cont2 != 0)
                            {
                                // MessageBox.Show(cont2.ToString());
                                indexlimit = cont2 - 1;





                                
                                comb.sql = "insert into tb06_tipos (tb06_ong, tb06_tipo) values (" + cnpjooj + ", " + lista[INDEX].ToString() + ")";
                                comb.open();
                                l = comb.Runsql();
                                comb.close();
                                cont2--;
                                INDEX++;




                            }

                            salvaimg();
                            cnpjj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                            comb.sql = "update tb08_user set tb08_nome = '" + nome + "', tb08_email = '" + email + "', tb08_senha = '" + senha + "' where tb08_id = '" + cnpjj.Text + "'";
                            comb.open();
                            l = comb.Runsql();
                            comb.close();
                            MessageBox.Show("Conta alterada!", "Aviso", MessageBoxButtons.OK ,MessageBoxIcon.Information);
                            
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



        private void Form5_Load(object sender, EventArgs e)
        {

            cnpjj.Text = CNPJ;
            Conexao comb = new Conexao();
            comb.sql = "select * from tb01_ongs where tb01_cnpj = " + CNPJ + "";
            comb.open();
            MySqlDataReader dados = comb.Execsql();

            if (dados.HasRows)
            {
                while (dados.Read())
                {
                    telefone.Text = dados["tb01_telefone"].ToString();
                    name.Text = dados["tb01_nome"].ToString();
                    nomeori = dados["tb01_nome"].ToString();
                    endereco.Text = dados["tb01_endereco"].ToString();
                    senha.Text = dados["tb01_senha"].ToString();
                    senha2.Text = dados["tb01_senha"].ToString();
                    desc.Text = dados["tb01_descricao"].ToString();
                    comboBox1.Text = dados["tb01_bairro"].ToString();
                    email.Text = dados["tb01_email"].ToString();
                   // string letra = System.AppDomain.CurrentDomain.BaseDirectory.ToString().Substring(0, 2);
                    //string fotoString = System.IO.Path.Combine(letra + @"/Arquivos/2018/TCC/Software/DNState/DNState/DNState/bin/Debug/logos/" + CNPJ + @".jpg");
                    //p1.Image = Image.FromFile(fotoString);
                    

                }
            }
           
            comb.close();
            Conexao comb3 = new Conexao();
            comb3.sql = "select count(tb06_tipo) from tb06_tipos where tb06_ong = " + CNPJ + "";
            comb3.open();
            MySqlDataReader dados2 = comb3.Execsql();

            if (dados2.HasRows)
            {
                while (dados2.Read())
                {
                    
                    qtde = int.Parse(dados2["count(tb06_tipo)"].ToString()); 
                }
            }

            
            comb3.close();
            Conexao comb2 = new Conexao();
            comb2.sql = "select tb06_tipo from tb06_tipos where tb06_ong = " + CNPJ + "";
            comb2.open();
            MySqlDataReader dados3 = comb2.Execsql();

            if (dados3.HasRows)
            {
               
                while (dados3.Read())
                {
                   
                    //MessageBox.Show(dados3["tb06_tipo"].ToString());

                    if (dados3["tb06_tipo"].ToString().Equals("1")) tipo1.Checked = true;
                    if (dados3["tb06_tipo"].ToString().Equals("2")) tipo2.Checked = true;
                    if (dados3["tb06_tipo"].ToString().Equals("3")) tipo3.Checked = true;
                    if (dados3["tb06_tipo"].ToString().Equals("4")) tipo4.Checked = true;
                    if (dados3["tb06_tipo"].ToString().Equals("5")) tipo5.Checked = true;
                    if (dados3["tb06_tipo"].ToString().Equals("6")) tipo6.Checked = true;
                    if (dados3["tb06_tipo"].ToString().Equals("7")) tipo7.Checked = true;
                    if (dados3["tb06_tipo"].ToString().Equals("8")) tipo8.Checked = true;
                }
                comb2.close();
            }
                              
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

        private void button2_Click(object sender, EventArgs e)
        {
            pegaimg();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo salvar as alterações?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                testa();
            }
            else
            {
                cnpjj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                Form3 fm = new Form3(cnpjj.Text);
                this.Hide();
                fm.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair sem salvar as alterações?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cnpjj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                Form3 fm = new Form3(cnpjj.Text);
                this.Hide();
                fm.Show();
            }
            else
            {
               
            }
        }

        private void tipo1_CheckedChanged(object sender, EventArgs e)
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

        private void tipo5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tipo7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tipo6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tipo8_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
