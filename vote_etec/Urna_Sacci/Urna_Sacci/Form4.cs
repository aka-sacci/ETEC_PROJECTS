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
    public partial class Form4 : Form
    {
        String nro;
       
        public Form4(String nro1)
        {
            InitializeComponent();
            nro = nro1;
        }

       
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lbnome_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Conexao comb = new Conexao();
               comb.sql = "Select * from tb01_candidatos where tb01_numero =" + nro + ";";
            comb.open();
            MySqlDataReader dados = comb.Execsql();





            if (dados.HasRows)
            {
                while (dados.Read())
                {

                    lbnome.Text = dados["tb01_nome"].ToString();
                    lbpartido.Text = dados["tb01_partido"].ToString();

                    if (dados["tb01_vice"].ToString() == null) {
                        vice.Hide();


                    } else {
                        vice.Show();
                        lbvice.Text = dados["tb01_vice"].ToString();

                    }
                   


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
            
           


            comb.close();
        }
                
    }
}
