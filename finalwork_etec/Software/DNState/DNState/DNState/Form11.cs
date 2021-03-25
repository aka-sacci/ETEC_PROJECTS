using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNState
{
    
    public partial class Form11 : Form
    {
        int max = 0;
        String CNPJ;
        public Form11(String CNP)
        {
            InitializeComponent();
            CNPJ = CNP;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pegaimg();
        }

        public void pegaimg()
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Arquivo de Imagem | *.png";
            ofd.ShowDialog();
            if (string.IsNullOrEmpty(ofd.FileName) == false)
            {
                p1.ImageLocation = ofd.FileName;
                button1.Enabled = true;
            }
        }

        public void salvaimg()
        {
            if (txt_texto.Text == "")
            {

                MessageBox.Show("Dê uma descrição para a imagem!", "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                if (p1.Image == null)
                {

                }
                else
                {
                    Conexao comb = new Conexao();
                    comb.sql = "select MAX(tb12_seq) from tb12_imagens ";
                    comb.open();
                    MySqlDataReader dados = comb.Execsql();

                    if (dados.HasRows)
                    {

                        while (dados.Read())
                        {
                            max = int.Parse(dados["max(tb12_seq)"].ToString());
                        }

                    }



                    comb.close();
                    int newmax = max + 1;
                    string fotoString = System.IO.Path.Combine("D:/xampp/htdocs/www/imgs/" + newmax + ".png");


                    p1.Image.Save(fotoString);

                    comb.sql = "insert into tb12_imagens(tb12_ong, tb12_extencao, tb12_data_upload, tb12_descricao) VALUES (" + CNPJ + ", '.png', now(), '" + txt_texto.Text + "' )";
                    comb.open();
                    int l = comb.Runsql();
                    comb.close();

                    MessageBox.Show("Imagem Salva!", "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    p1.Image = null;
                    button1.Enabled = false;

                }
            }
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            salvaimg();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 fmr = new Form3(CNPJ);
            this.Dispose();
            fmr.Show();
        }
    }
}
