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

namespace SouzaBueno_SPRMKT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

        }

        public Double Valortotal;




        private void Form1_Load(object sender, EventArgs e)
        {
            Quantidade.Hide();
            TXTQTDE.Hide();
            ValorUnitario.Hide();
            TXTVALORUNITARIO.Hide();
            Valor.Hide();
            TXTVALOR.Hide();
            Total.Hide();
            TXTTOTAL.Hide();
            Descricao.Hide();
            TXT_DESC.Hide();
            dgDados.Hide();
            valorrecebido.Hide();
            TXT_VLRR.Hide();
            troco.Hide();
            TXT_TROCO.Hide();

        }

      

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToString("HH:mm:ss");
            data.Text = DateTime.Now.ToString("dddd, dd De MMM yyyy");
        }

        private void hora_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CDBR_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F5)
            {
                Quantidade.Show();
                TXTQTDE.Show();
                TXTQTDE.Text = "1";
                ValorUnitario.Show();
                TXTVALORUNITARIO.Show();
                Valor.Show();
                TXTVALOR.Show();
                Total.Show();
                TXTTOTAL.Show();
                PB_foto.Image = Properties.Resources.Passa;
                TXT_PROD.Text = "";
                Descricao.Show();
                TXT_DESC.Show();
                dgDados.Show();
                dgDados.Rows.Clear();
                Valortotal = 0;
                TXT_TROCO.Text = "R$ 0,00";
                TXT_VLRR.Text = "R$ 0,00";
                TXT_DESC.Text = "";

                TXTTOTAL.Text = "";
                TXTVALOR.Text = "";
                TXTVALORUNITARIO.Text = "";


            }



            



            if (e.KeyCode == Keys.F6)
            {
                if (TXTQTDE.Text == "0")
                {
                    MessageBox.Show("Aperte F5 para começar a compra!", "Aviso");

                }
                else
                {
                    if (TXTTOTAL.Text == "")
                    {

                        MessageBox.Show("Passe o produto!", "Aviso");
                    }
                    else
                    {



                        if (DialogResult.Yes == MessageBox.Show("A compra vai ser paga em dinheiro?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {


                            valorrecebido.Show();
                            TXT_VLRR.Show();
                            troco.Show();
                            TXT_TROCO.Show();
                            TXT_VLRR.Focus();
                            TXTQTDE.Enabled=false;
                            TXT_PROD.Enabled = false;








                        }
                        else
                        {
                            //envia bd

                            Conexao comb = new Conexao();

                            comb.sql = "Insert into tb02_cupom (tb02_valor, tb02_data) values ('" + Valortotal + "', now())";


                            comb.open();

                            int lin = comb.Runsql();


                            comb.close();



                            //fim envia bd


                            //MessageBox.Show("Compra terminada!", "Aviso");
                            TXTQTDE.Text = "0";
                            TXTTOTAL.Text = "";
                            TXTVALOR.Text = "";
                            TXTVALORUNITARIO.Text = "";
                            Valortotal = 0;

                            Quantidade.Hide();
                            TXTQTDE.Hide();
                            ValorUnitario.Hide();
                            TXTVALORUNITARIO.Hide();
                            Valor.Hide();
                            TXTVALOR.Hide();
                            Total.Hide();
                            TXTTOTAL.Hide();
                            PB_foto.Image = Properties.Resources.CL1;
                            Descricao.Hide();
                            TXT_DESC.Hide();
                            dgDados.Hide();
                            dgDados.Rows.Clear();
                            TXT_DESC.Text = "";


                            //mandar os dados pro bd
                        }
                    }
                
                }
                }







                if (e.KeyCode == Keys.Escape)
                {

                    if (TXTQTDE.Text != "0")
                    {

                        MessageBox.Show("Sua compra não foi terminada! Cancele ou finalize-a para sair!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                    else
                    {


                  

                    if(DialogResult.Yes == MessageBox.Show("Deseja mesmo sair do sistema?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) {

                        this.Dispose();

                    }
                    }

                
            }










            if (e.KeyCode == Keys.F7)
            {


                if (TXTQTDE.Text == "0")
                {
                    MessageBox.Show("Aperte F5 para começar a compra!", "Aviso");

                }
                else
                {


                    if (DialogResult.Yes == MessageBox.Show("Deseja cancelar a compra?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {

                        TXTQTDE.Text = "0";
                        TXTTOTAL.Text = "";
                        TXTVALOR.Text = "";
                        TXTVALORUNITARIO.Text = "";
                        TXT_DESC.Text = "";
                        TXT_TROCO.Text = "R$ 0,00";
                        TXT_VLRR.Text = "R$ 0,00";
                        Quantidade.Hide();
                        TXTQTDE.Hide();
                        ValorUnitario.Hide();
                        TXTVALORUNITARIO.Hide();
                        Valor.Hide();
                        TXTVALOR.Hide();
                        Total.Hide();
                        TXTTOTAL.Hide();
                        PB_foto.Image = Properties.Resources.CL1;
                        Descricao.Hide();
                        TXT_DESC.Hide();
                        dgDados.Hide();
                        dgDados.Rows.Clear();
                        Valortotal = 0;

                    }


                }
            }
        }


        private void CBCOD_TextChanged(object sender, EventArgs e)
        {


        }


        private void CBCOD_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void CBCOD_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
            if (TXTQTDE.Text != "0" && TXTQTDE.Text != "" )
            {

                CDBR.Text = TXT_PROD.Text;

                if (TXT_PROD.Text.Length >= 13)
                {




                   
                   
                    

                    //código da consulta e do preenchimento do dataGrid vai aqui karaio

                    Conexao comb = new Conexao();

                    comb.sql = "Select * from tb01_produtos where tb01_codigo ='" +TXT_PROD.Text+ "'";
                    comb.open();
                    MySqlDataReader dados = comb.Execsql();
                    



                    if (dados.HasRows)
                    {
                        while (dados.Read())
                        {

                            //INÍCIO COD PARA IMG

                            string letra = System.AppDomain.CurrentDomain.BaseDirectory.ToString().Substring(0, 2);
                            string fotoString = System.IO.Path.Combine(Application.StartupPath + @"/IMGS/" + TXT_PROD.Text + @".jpg");

                            if (!System.IO.File.Exists(fotoString))
                            {
                                MessageBox.Show("Foto não encontrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                PB_foto.Image = null;

                                
                            }

                            PB_foto.Image = Image.FromFile(fotoString);


                            //FIM COD IMG

                            //INÍCIO CALCULOS VALOR TOTAL

                            Double valor;

                            Double dVARUN;
                            Double dqtde;
                            String VARUN = dados["tb01_preco"].ToString();
                            
                            dVARUN = Double.Parse(VARUN);
                            dqtde = Double.Parse(TXTQTDE.Text);
                            valor = dVARUN * dqtde;
                            Valortotal = Valortotal + valor;
                            
   TXT_DESC.Text = dados["tb01_nome"].ToString();

                            //FIM
				 
//transforma os valores em R$

System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("pt-BR");

                TXTVALORUNITARIO.Text = string.Format("{0:C}", Convert.ToDouble(dVARUN));
                
                TXTVALOR.Text = string.Format("{0:C}", Convert.ToDouble(valor));


 TXTTOTAL.Text = string.Format("{0:C}", Convert.ToDouble(Valortotal));

//fim do transforma os valores em R$





                            dgDados.Rows.Add(TXTVALOR.Text, TXT_DESC.Text, TXTQTDE.Text , TXT_PROD.Text);
                            TXTQTDE.Text = "1";
                            TXT_PROD.Text = "";






                        }
                    }
                    else {


                        MessageBox.Show("Produto não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TXT_PROD.Text = "";
                        
                        TXTVALOR.Text = "";
                        TXTVALORUNITARIO.Text = "";
                        TXTTOTAL.Text = "";
                        TXT_DESC.Text = "";
                        
                        TXTQTDE.Text = "1";
                    }


                    comb.close();
                    




                }



            }
            else {
                MessageBox.Show("Aperte F5 para iniciar uma nova compra antes de passar qualquer produto ou não deixe o a quantidade vazia!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
               TXTQTDE.Text = "1";


            }
        }

        private void TXTVALORUNITARIO_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TXT_VLRR_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {



                Double vrll = Double.Parse(TXT_VLRR.Text);
                Double trocoo;
                trocoo = vrll - Valortotal;



                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("pt-BR");

                
                TXT_VLRR.Text = string.Format("{0:C}", Convert.ToDouble(vrll));
                TXT_TROCO.Text = string.Format("{0:C}", Convert.ToDouble(trocoo));



                if (trocoo >= 0)
                {

                    //envia bd

                    Conexao comb = new Conexao();

                    comb.sql = "Insert into tb02_cupom (tb02_valor, tb02_data) values ('" +Valortotal+ "', now())";
                   

                    comb.open();

                    int lin = comb.Runsql();

                   
                    comb.close();

                

                //fim envia bd


                MessageBox.Show("COMPRA TERMINADA. TROCO: " +TXT_TROCO.Text+ "", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TXTQTDE.Text = "0";
                    TXTTOTAL.Text = "";
                    TXTVALOR.Text = "";
                    TXTVALORUNITARIO.Text = "";
                    TXT_DESC.Text = "";
                    Valortotal = 0;

                    Quantidade.Hide();
                    TXTQTDE.Hide();
                    ValorUnitario.Hide();
                    TXTVALORUNITARIO.Hide();
                    Valor.Hide();
                    TXTVALOR.Hide();
                    Total.Hide();
                    TXTTOTAL.Hide();
                    PB_foto.Image = Properties.Resources.CL1;
                    Descricao.Hide();
                    TXT_DESC.Hide();
                    dgDados.Hide();
                    dgDados.Rows.Clear();
                    TXT_DESC.Text = "";
                    valorrecebido.Hide();
                    TXT_VLRR.Hide();
                    troco.Hide();
                    TXT_TROCO.Hide();


                    TXT_TROCO.Text = "R$ 0,00";
                    TXT_VLRR.Text = "R$ 0,00";

                    
                    TXTQTDE.Enabled = true;
                    TXT_PROD.Enabled = true;
                    this.TXT_PROD.Focus();








                }
                else {

                    MessageBox.Show("O valor recebido é menor que o valor total da compra!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }




            if (e.KeyCode == Keys.F7)
            {


                if (TXTQTDE.Text == "0")
                {
                    MessageBox.Show("Aperte F5 para começar a compra!", "Aviso");

                }
                else
                {


                    if (DialogResult.Yes == MessageBox.Show("Deseja cancelar a compra?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {

                        TXTQTDE.Text = "0";
                        TXTTOTAL.Text = "";
                        TXTVALOR.Text = "";
                        TXTVALORUNITARIO.Text = "";
                        TXT_DESC.Text = "";
                        TXT_TROCO.Text = "R$ 0,00";
                        TXT_VLRR.Text = "R$ 0,00";
                        Quantidade.Hide();
                        TXTQTDE.Hide();
                        ValorUnitario.Hide();
                        TXTVALORUNITARIO.Hide();
                        Valor.Hide();
                        TXTVALOR.Hide();
                        Total.Hide();
                        TXTTOTAL.Hide();
                        PB_foto.Image = Properties.Resources.CL1;
                        Descricao.Hide();
                        TXT_DESC.Hide();
                        dgDados.Hide();
                        dgDados.Rows.Clear();
                        Valortotal = 0;

                    }


                }
            }

        }

        private void TXT_VLRR_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PB_foto_Click(object sender, EventArgs e)
        {

        }

        private void TXT_DESC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
