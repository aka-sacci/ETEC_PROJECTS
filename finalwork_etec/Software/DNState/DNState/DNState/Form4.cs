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
    public partial class Form4 : Form
    {
        String J;
        Conexao comb = new Conexao();
        Conexao comb2 = new Conexao();
        Conexao comb1 = new Conexao();
        List<string> lista = new List<string>();
        List<string> lista1 = new List<string>();
        List<string> lista2 = new List<string>();
        int i=0;
        String name;
        String cood;




        public Form4(String cnpj)
        {
            J = cnpj;
            InitializeComponent();
        }

        public void msg(String user) {

            comb.sql = "select tb05_mensagem, tb08_nome, tb05_data from tb05_conversas inner join tb08_user ON tb05_conversas.tb05_de = tb08_user.tb08_id where tb05_para = " + J + " and tb08_id = "+ user + " or tb05_para =  " + user + " and tb08_id = " + J + "  order by tb05_data desc";
            comb.open();
            MySqlDataReader dados = comb.Execsql();
            dt1.Rows.Clear();
            if (dados.HasRows)
            {


                while (dados.Read())
                {
                    //carrega no painel
                 
                }
            }
           
            comb.close();

        }

     
      public void onload() {


          
    
            comb.sql = "select count(tb08_nome), tb08_nome, tb08_id from tb05_conversas inner join tb08_user ON tb05_conversas.tb05_de = tb08_user.tb08_id where tb05_status = '1' and tb05_para = " + J + " or tb05_status = '2' and tb05_para = '" + J + "' group by tb08_nome order by tb05_data desc";
            comb.open();
            MySqlDataReader dados = comb.Execsql();
            dt1.Rows.Clear();
            if (dados.HasRows)
            {
               

                while (dados.Read())
                {
                                     
                    lista.Add(dados["tb08_id"].ToString());
                    lista1.Add(dados["tb08_id"].ToString());
                    dt1.Rows.Add(dados["tb08_nome"].ToString() + " (" + dados["count(tb08_nome)"].ToString() + ")", dados["tb08_id"].ToString(), dados["count(tb08_nome)"].ToString());
                    DataGridViewRow row = dt1.Rows[i];
                    row.DefaultCellStyle.ForeColor = Color.Blue;
                    i++;
                }
            }
           //MessageBox.Show(string.Join(", ", lista));
           comb.close();
          


            comb2.sql = "select tb08_nome, tb08_id from tb05_conversas inner join tb08_user ON tb05_conversas.tb05_de = tb08_user.tb08_id where tb05_status = '3' and tb05_para = '" + J + "' group by tb08_nome order by tb05_data desc";
           comb2.open();
            MySqlDataReader dados2 = comb2.Execsql();

            if (dados2.HasRows)
            {

                while (dados2.Read())
                {
                  

                    if (lista.Contains(dados2["tb08_id"].ToString()))
                    {
                        
                    }
                    else
                    {

                           dt1.Rows.Add(dados2["tb08_nome"].ToString() , dados2["tb08_id"].ToString(), "0");
                       

                        lista1.Add(dados2["tb08_id"].ToString());
                        
                    }


                }
               
            }

            comb2.close();
           
            i = 0;
            comb1.sql = "update tb05_conversas set tb05_status = 2 where tb05_status = 1 and tb05_para = " + J + " ";
            comb1.open();
            int l = comb1.Runsql();
            comb1.close();


            dt1.ClearSelection();


        }

        private void Form4_Load(object sender, EventArgs e)
        {
            onload();
            
            enviar.Enabled = false;
            txt_texto.Enabled = false;
            dt1.ClearSelection();
            


        }

        private void dt1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mensagens_Tick(object sender, EventArgs e)
        {
            comb.sql = "select count(tb08_nome), tb08_nome, tb08_id from tb05_conversas inner join tb08_user ON tb05_conversas.tb05_de = tb08_user.tb08_id where tb05_status = '1' and tb05_para = '" + J + "' group by tb08_nome order by tb05_data desc";
            comb.open();
            MySqlDataReader dados = comb.Execsql();
            
            if (dados.HasRows)
            {
                
               

                while (dados.Read())
                {

                    cood = dados["tb08_id"].ToString();

                    if (lista1.Contains(dados["tb08_id"].ToString()))
                    {
                        //MessageBox.Show(dados["tb08_id"].ToString());
                        //pega a linha
                       int i3 = 0;
                        int rows = dt1.RowCount;
                        
                        while(i3 != rows) {

                            if (dt1.Rows[i3].Cells[1].Value.ToString() == dados["tb08_id"].ToString())
                            { 
                               
                                int msg = int.Parse(dt1.Rows[i3].Cells[2].Value.ToString()) + int.Parse(dados["count(tb08_nome)"].ToString());
                                dt1.Rows.Remove(dt1.Rows[i3]);
                                dt1.Rows.Insert(0, dados["tb08_nome"].ToString() + " (" + msg.ToString() + ")", dados["tb08_id"].ToString(), msg.ToString());
                                DataGridViewRow row = dt1.Rows[0];
                                row.DefaultCellStyle.ForeColor = Color.Blue;
                                i3++;
                            }
                            else {
                                i3++;
                            }

                        } 
                       
                    }
                    else {
                       

                        lista.Add(dados["tb08_id"].ToString());
                        lista1.Add(dados["tb08_id"].ToString());                    
                        dt1.Rows.Insert(0, dados["tb08_nome"].ToString() + " (" + dados["count(tb08_nome)"].ToString() + ")", dados["tb08_id"].ToString(), dados["count(tb08_nome)"].ToString());
                        DataGridViewRow row = dt1.Rows[0];                       
                        row.DefaultCellStyle.ForeColor = Color.Blue;

                        
                        
                    }


                }
                string letra = System.AppDomain.CurrentDomain.BaseDirectory.ToString().Substring(0, 2);
                System.Media.SoundPlayer tocar;
                tocar = new System.Media.SoundPlayer(letra + @"/Arquivos/2018/TCC/Software/DNState/DNState/DNState/bin/Debug/audios/toque.wav");
                tocar.Play();
                
         
            }

            
            comb.close();
            comb1.sql = "update tb05_conversas set tb05_status = 2 where tb05_status = 1 and tb05_para = " + J + "  ";
            comb1.open();
            int l = comb1.Runsql();
            comb1.close();
           


        }


        public void getmsg(String cod) {

           
            comb1.sql = "update tb05_conversas set tb05_status = 3 where tb05_para = " + J + " and tb05_de = " + cod + " ";
             comb1.open();
             int l = comb1.Runsql();
             comb1.close();


            lb_mensagens.Items.Clear();
            comb.sql = "select tb08_nome, tb05_para, tb05_mensagem, tb08_id from tb05_conversas inner join tb08_user ON tb05_conversas.tb05_de = tb08_user.tb08_id where tb05_para = " + J + " and tb05_de = " + cod + " or tb05_para = " + cod + " and tb05_de = " + J + " order by tb05_data ASC ";
            comb.open();
            MySqlDataReader dados = comb.Execsql();
            

            if (dados.HasRows) {

                

                while (dados.Read()) {

                    if (dados["tb08_id"].ToString() == cod)
                    {
                        
                        
                        lb_mensagens.Items.Add(dados["tb08_nome"].ToString() + ": " + dados["tb05_mensagem"].ToString());
                        name = dados["tb08_nome"].ToString();

                    }
                    else {
                        
                        
                        lb_mensagens.Items.Add("Você: " + dados["tb05_mensagem"].ToString());


                    }

                }

            }
            comb.close();
           
            dt1.CurrentRow.Cells[0].Value = name;
            dt1.CurrentRow.Cells[2].Value = "0";



        }

        public void inseremsg() {
            string txt = txt_texto.Text;
            if (txt == "")
            {
                MessageBox.Show("Preencha todos os dados!");
            }
            else
            {
                comb1.sql = "insert into tb05_conversas (tb05_status, tb05_de, tb05_para, tb05_data, tb05_mensagem) VALUES (1, '" + J + "', '" + dt1.CurrentRow.Cells[1].Value.ToString() + "', now(), '" + txt_texto.Text + "' )";
                comb1.open();
                int l = comb1.Runsql();
                comb1.close();
                lb_mensagens.Items.Add("Você: " + txt_texto.Text);
                txt_texto.Text = "";
            }

        }

        private void dt1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            inseremsg();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                inseremsg();

            }
            }

        private void dt1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_texto.Enabled = true;
                enviar.Enabled = true;
                getmsg(dt1.CurrentRow.Cells[1].Value.ToString());
                DataGridViewRow row = dt1.Rows[0];
                row.DefaultCellStyle.ForeColor = Color.Gray;




            }
            catch (System.NullReferenceException)
            {

                MessageBox.Show("bait");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 fmr = new Form3(J);
            this.Dispose();
            fmr.Show();
        }
    }
}
