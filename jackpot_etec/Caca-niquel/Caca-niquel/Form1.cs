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
using Conn;

namespace Caca_niquel
{
   
    public partial class Form1 : Form
    {
        public int chances;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                if (NOME.Text.Length != 0 && DINHEIROS.Text.Length != 0)
                {


                    //Conexao comb = new Conexao();
                    //update no nro de votos
                    //comb.sql = "Insert into tb02_ganhadores(tb02_data, tb02_nome, tb02_valor) values (now(), '"+NOME.Text+"', '"+DINHEIROS.Text+"') ";
                    // comb.open();
                    // comb.Runsql();
                    // comb.close();

                    //aqui tranfere dados de um form para outro

                    chances = int.Parse(DINHEIROS.Text) * 7;
                    this.Hide();

                    Form2 fome = new Form2(chances.ToString(), NOME.Text);
                    fome.Show();

                    Conexao conn = new Conexao();
                    conn.sql = "insert into tb01_apostas(tb01_data, tb01_valor) values (now(), "+DINHEIROS.Text+") ";

                    conn.open();
                    conn.Runsql();
                    conn.close();

                }
                else {

                    MessageBox.Show("DIZ O SEU NOME E COLOCA UM DINHEIRO AE MANO", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    DINHEIROS.Text = "";
                    NOME.Text = "";
                }
            }

        }

        private void DINHEIROS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void NOME_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
