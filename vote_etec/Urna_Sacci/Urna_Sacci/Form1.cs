using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;




namespace Urna_Sacci
{

    
    public partial class Form1 : Form
    {


        int cont;
        String nro = "";

        public Form1()
        {
            InitializeComponent();
        }



        public void limpatudo() {
           
            txt_nro1.Text = "";
            txt_nro2.Text = "";
            txt_nro3.Text = "";
            lbnome.Text = "";
            lbpartido.Text = "";
            vice.Text = "";
            nro = "";
            pbFoto.Image = null;
            pbFotos2.Image = null;

            if (cont == 2) {

                lbvoto.Text = "SENADOR";
                lbvice.Hide();
                tocar("");

            }

            if (cont == 3) {

                lbvoto.Text = "PRESIDENTE";
                lbvice.Show();
                txt_nro3.Hide();
                tocar("");


            }

            if (cont == 4)
            {

                txt_nro1.Text = "";
                txt_nro2.Text = "";
                txt_nro3.Text = "";
                lbnome.Text = "";
                lbpartido.Text = "";
                vice.Text = "";
                nro = "";
                cont = 1;
                tocar("Presidente");
                this.Hide();
                Form2 fome = new Form2();
                fome.Show();

            }

            if (cont == 5)
            {

                txt_nro1.Text = "";
                txt_nro2.Text = "";
                txt_nro3.Text = "";
                lbnome.Text = "";
                lbpartido.Text = "";
                vice.Text = "";
                nro = "";
                cont = 1;
               this.Hide();
                Form3 fome = new Form3();
                fome.Show();


            }


        }

        public void preenche(String tecla) {
            tocar("");
            if (cont <= 2)
            {


                if (txt_nro1.Text.Length == 1)
                {

                    if (txt_nro2.Text.Length == 1)
                    {
                        if (txt_nro3.Text.Length == 1)
                        {
                            
                            return;
                        }
                        else
                        {
                            txt_nro3.Text = tecla;
                          
                            return;
                        }
                    }
                    else
                    {
                        txt_nro2.Text = tecla;
                        
                        return;
                    }

                }
                txt_nro1.Text = tecla;
             


            }


            else {

                

                if (txt_nro1.Text.Length == 1)
                {
                    if (txt_nro2.Text.Length == 1)
                    {
                        
                        return;
                    }
                    else
                    {
                       
                        txt_nro2.Text = tecla;
                    }
                }
                else
                {

                   
                    txt_nro1.Text = tecla;
                   

                }

                



            }
        }

        public void tocar(String p) {
            System.Media.SoundPlayer tocar;

            if (p == "Presidente")
            {
                tocar = new System.Media.SoundPlayer(Application.StartupPath + @"/sons/ultimo barulho.wav");
                tocar.Play();

            }
            else
            {
                tocar = new System.Media.SoundPlayer(Application.StartupPath + @"/sons/primeiro barulho.wav");
                tocar.Play();

            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            preenche(button9.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

                lbvoto.Text = "GOVERNADOR";
            cont = 1;
         
            
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            preenche(button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            preenche(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            preenche(button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            preenche(button4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            preenche(button5.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            preenche(button6.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            preenche(button7.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            preenche(button8.Text);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            preenche(button0.Text);
        }

        private void button10_Click(object sender, EventArgs e)

        {
            tocar("");
            if (nro == "")
            {

                MessageBox.Show("Digite um número!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                //INSERE OS DADOS NO BD, LIMPA OS DADOS, +1 NO CARAIO DO CONTADOR, MUDA "SEU VOTO"

                Conexao comb = new Conexao();

                //update no nro de votos
                comb.sql = "update tb01_candidatos set tb01_votos = tb01_votos + 1 where tb01_numero=" + nro + "";
                comb.open();
                comb.Runsql();
                comb.close();


                comb.sql = "update tb03_apuracao set tb03_validos = tb03_validos + 1 where tb03_cargo=" + cont + "";
                comb.open();
                comb.Runsql();
                comb.close();
                cont++;


                limpatudo();

            }
        }

        private void txt_nro3_TextChanged(object sender, EventArgs e)
        {


            if (txt_nro2.Text.Length == 1)
            {

                Conexao comb = new Conexao();
                nro = txt_nro1.Text + txt_nro2.Text + txt_nro3.Text;

                comb.sql = "Select * from tb01_candidatos where tb01_numero =" + nro + " and tb01_cargo = " + cont + ";";
                comb.open();
                MySqlDataReader dados = comb.Execsql();




                if (dados.HasRows)
                {
                    while (dados.Read())
                    {

                        lbnome.Text = dados["tb01_nome"].ToString();
                        lbpartido.Text = dados["tb01_partido"].ToString();
                        vice.Text = dados["tb01_vice"].ToString();


                        //INÍCIO COD PARA IMG


                        string letra = System.AppDomain.CurrentDomain.BaseDirectory.ToString().Substring(0, 2);
                        string fotoString = System.IO.Path.Combine(Application.StartupPath + @"/imaam/" + nro + @".jpg");
                        
                        if (!System.IO.File.Exists(fotoString))
                        {
                            MessageBox.Show("Foto não encontrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            pbFoto.Image = null;
                            return;


                        }

                        pbFoto.Image = Image.FromFile(fotoString);


                        //FIM COD IMG
                        if (cont == 2)
                        {
                        }
                        else
                        {

                            //INÍCIO COD PARA IMG

                            string letra2 = System.AppDomain.CurrentDomain.BaseDirectory.ToString().Substring(0, 2);
                            string fotoString2 = System.IO.Path.Combine(Application.StartupPath + @"/imaam/" + nro + @"(1).jpg");

                            if (!System.IO.File.Exists(fotoString))
                            {
                                MessageBox.Show("Foto não encontrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                pbFoto.Image = null;
                                return;


                            }

                            pbFotos2.Image = Image.FromFile(fotoString2);


                            //FIM COD IMG
                        }

                    }
                }
                else
                {

                    MessageBox.Show("O candidato não existe!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpatudo();
                
                }


                comb.close();
            }
            else {

            }

        }

        private void txt_nro2_TextChanged(object sender, EventArgs e)
        {
            if (cont == 3)
            {

                if (txt_nro2.Text.Length == 1)
                {

                    Conexao comb = new Conexao();
                    nro = txt_nro1.Text + txt_nro2.Text + txt_nro3.Text;

                    comb.sql = "Select * from tb01_candidatos where tb01_numero =" + nro + " and tb01_cargo = " + cont + ";";
                    comb.open();
                    MySqlDataReader dados = comb.Execsql();




                    if (dados.HasRows)
                    {
                        while (dados.Read())
                        {

                            lbnome.Text = dados["tb01_nome"].ToString();
                            lbpartido.Text = dados["tb01_partido"].ToString();
                            vice.Text = dados["tb01_vice"].ToString();


                            //INÍCIO COD PARA IMG


                            string letra = System.AppDomain.CurrentDomain.BaseDirectory.ToString().Substring(0, 2);
                            string fotoString = System.IO.Path.Combine(Application.StartupPath + @"/imaam/" + nro + @".jpg");

                            if (!System.IO.File.Exists(fotoString))
                            {
                                MessageBox.Show("Foto não encontrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                pbFoto.Image = null;
                                return;


                            }

                            pbFoto.Image = Image.FromFile(fotoString);


                            //FIM COD IMG


                            //INÍCIO COD PARA IMG

                            string letra2 = System.AppDomain.CurrentDomain.BaseDirectory.ToString().Substring(0, 2);
                            string fotoString2 = System.IO.Path.Combine(Application.StartupPath + @"/imaam/" + nro + @"(1).jpg");

                            if (!System.IO.File.Exists(fotoString))
                            {
                                MessageBox.Show("Foto não encontrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                pbFoto.Image = null;
                                return;


                            }

                            pbFotos2.Image = Image.FromFile(fotoString2);


                            //FIM COD IMG


                        }
                    }
                    else
                    {

                        MessageBox.Show("Candidato não existe!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        limpatudo();

                    }


                    comb.close();
                }
                else
                {

                }
            }



        }

        private void button11_Click(object sender, EventArgs e)
        {
            tocar("");
            if (MessageBox.Show("Tem certaza que você quer anular o seu voto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {

                limpatudo();

            }
            else
            {
               

                Conexao comb = new Conexao();

               
               

                comb.sql = "update tb03_apuracao set tb03_nulos = tb03_nulos + 1  where tb03_cargo=" + cont + "";
                comb.open();
                comb.Runsql();
                comb.close();
                cont++;


                limpatudo();

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tocar("");
            if (MessageBox.Show("Tem certaza que você quer votar em branco?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {

                limpatudo();

            }
            else
            {


                Conexao comb = new Conexao();




                comb.sql = "update tb03_apuracao set tb03_brancos = tb03_brancos + 1  where tb03_cargo=" + cont + "";
                comb.open();
                comb.Runsql();
                comb.close();
                cont++;


                limpatudo();

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {

                if (cont > 1)
                {
                    MessageBox.Show("Termine de votar para sair!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else
                {

                    if (MessageBox.Show("Tem certaza que você quer sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        this.Dispose();

                    }
                    else
                    {


                    }

                }
            }



            if (e.KeyCode == Keys.F1)
            {

                if (cont > 1)
                {
                    MessageBox.Show("Termine de votar para sair!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else
                {
                         cont = 5;
                    limpatudo();
                        //MessageBox.Show("foi");
                }

            }




            }
    }

       
    }

