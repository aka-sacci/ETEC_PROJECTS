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

namespace Urna_Sacci
{
    public partial class Form3 : Form
    {
        String num;
        public Form3()
        {
            InitializeComponent();
            
        }

        public void preenche1() {

            Conexao comb = new Conexao();

            comb.open();

            comb.sql = "Select * from tb01_candidatos where tb01_cargo = 3 ";

            try
            {
                MySqlDataReader dados = comb.Execsql();




                if (dados.HasRows)
                {
                    while (dados.Read())
                    {

                        dt1.Rows.Clear();
                        dt1.Rows.Add(dados["tb01_nome"].ToString(), dados["tb01_partido"].ToString(), dados["tb01_votos"].ToString(), dados["tb01_numero"]);


                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            comb.close();

        }

        public void preenche2() {

            Conexao comb2 = new Conexao();

            comb2.open();

            comb2.sql = "Select * from tb01_candidatos where tb01_cargo = 2 ";

            try
            {
                MySqlDataReader dados2 = comb2.Execsql();




                if (dados2.HasRows)
                {
                    while (dados2.Read())
                    {

                        dt2.Rows.Clear();
                        dt2.Rows.Add(dados2["tb01_nome"].ToString(), dados2["tb01_partido"].ToString(), dados2["tb01_votos"].ToString(), dados2["tb01_numero"]);


                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            comb2.close();

        }

        public void preenche3() {

            Conexao comb3 = new Conexao();
            comb3.open();

            comb3.sql = "Select * from tb01_candidatos where tb01_cargo = 1 ";

            try
            {
                MySqlDataReader dados3 = comb3.Execsql();




                if (dados3.HasRows)
                {
                    while (dados3.Read())
                    {

                        dt3.Rows.Clear();
                        dt3.Rows.Add(dados3["tb01_nome"].ToString(), dados3["tb01_partido"].ToString(), dados3["tb01_votos"].ToString(), dados3["tb01_numero"]);


                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            comb3.close();

        }

        public void vos() {

            Conexao comb3 = new Conexao();
            comb3.open();

            comb3.sql = "Select sum(tb03_brancos), sum(tb03_nulos), sum(tb03_validos) from tb03_apuracao";

            try
            {
                MySqlDataReader dados3 = comb3.Execsql();




                if (dados3.HasRows)
                {
                    while (dados3.Read())
                    {


                        lbbrancos.Text = dados3["sum(tb03_brancos)"].ToString();
                        lbnulos.Text = dados3["sum(tb03_nulos)"].ToString();
                       lbvalidos.Text = dados3["sum(tb03_validos)"].ToString();

                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            comb3.close();

        }


        public void envia(String vai)
        {

            Form4 formB = new Form4(vai);
            formB.Show();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {


            preenche1();
            preenche2();
            preenche3();
            vos();
           
           
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {

                this.Hide();
                Form1 fome = new Form1();
                fome.Show();
            }

            }

        private void dt1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
          envia(dt1.CurrentRow.Cells[3].Value.ToString());
        }

        private void dt2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            envia(dt2.CurrentRow.Cells[3].Value.ToString());
        }

        private void dt3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            envia(dt3.CurrentRow.Cells[3].Value.ToString());
        }

        private void dt1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

