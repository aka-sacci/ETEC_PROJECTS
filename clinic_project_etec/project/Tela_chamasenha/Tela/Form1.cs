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

namespace Tela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlDataReader dados;
        int define;
        int cont;

        public void request() {


            Conexao comb = new Conexao();
            comb.sql = "Select tb05_cod, tb05_guiche from tb05_request where tb05_status = '1' order by tb05_cod ASC limit 1";
            comb.open();
            dados = comb.Execsql();

            if (dados.HasRows)
            {
                while (dados.Read())
                {
                    String geeg = dados["tb05_cod"].ToString();
                    String jaaj = dados["tb05_guiche"].ToString();
                    seleciona();
                    Conexao comb2 = new Conexao();
                    comb2.sql = "Update tb05_request set tb05_status = 2 where tb05_cod=" + geeg + " ";
                    comb2.open();
                    comb2.Runsql();
                    comb2.close();
                    label3.Text = "Guichê: " + jaaj + "";
                    

                }


            }
            else {


            }

            comb.close();

        }


        public void seleciona() {

            if (cont == 3)
            {
                Conexao comb = new Conexao();
                comb.sql = "Select tb01_nro from tb01_normal where tb01_status = '1' order by tb01_nro ASC limit 1";
                comb.open();
                dados = comb.Execsql();

                if (dados.HasRows)
                {
                    while (dados.Read())
                    {
                        define = int.Parse(dados["tb01_nro"].ToString());
                        label4.Text = "Tipo: NORMAL";
                        if (define <= 9) label2.Text = "00" + dados["tb01_nro"].ToString();
                        if (define >= 10 && define <= 99) label2.Text = "0" + dados["tb01_nro"].ToString();
                        if (define >= 100 && define <= 999) label2.Text = dados["tb01_nro"].ToString();

                        Conexao comb2 = new Conexao();
                        comb2.sql = "Update tb01_normal set tb01_status = 4 where tb01_nro=" + define + " ";
                        comb2.open();
                        comb2.Runsql();
                        comb2.close();
                        System.Media.SoundPlayer tocar;
                        tocar = new System.Media.SoundPlayer(Application.StartupPath + "/TOQUES/CAMPANHA.wav");
                        tocar.Play();
                        cont = 0;
                    }
                }

            }
            else
            {

                Conexao comb = new Conexao();
                comb.sql = "Select tb03_nro from tb03_urgente where tb03_status = '1' order by tb03_nro ASC limit 1";
                comb.open();
                dados = comb.Execsql();
                if (dados.HasRows)
                {
                    while (dados.Read())
                    {
                        define = int.Parse(dados["tb03_nro"].ToString());
                        label4.Text = "Tipo: URGENTE";
                        if (define <= 9) label2.Text = "00" + dados["tb03_nro"].ToString();
                        if (define >= 10 && define <= 99) label2.Text = "0" + dados["tb03_nro"].ToString();
                        if (define >= 100 && define <= 999) label2.Text = dados["tb03_nro"].ToString();

                        Conexao comb2 = new Conexao();
                        comb2.sql = "Update tb03_urgente set tb03_status = 4 where tb03_nro=" + define + " ";
                        comb2.open();
                        comb2.Runsql();
                        comb2.close();
                        System.Media.SoundPlayer tocar;
                        tocar = new System.Media.SoundPlayer(Application.StartupPath + "/TOQUES/CAMPANHA.wav");
                        tocar.Play();
                        cont++;


                    }

                }
                else
                {
                    comb.close();
                    comb.sql = "Select tb02_nro from tb02_prioritario where tb02_status = '1' order by tb02_nro ASC limit 1";
                    comb.open();
                    dados = comb.Execsql();

                    if (dados.HasRows)
                    {
                        while (dados.Read())
                        {
                            define = int.Parse(dados["tb02_nro"].ToString());
                            label4.Text = "Tipo: PRIORITÁRIO";
                            if (define <= 9) label2.Text = "00" + dados["tb02_nro"].ToString();
                            if (define >= 10 && define <= 99) label2.Text = "0" + dados["tb02_nro"].ToString();
                            if (define >= 100 && define <= 999) label2.Text = dados["tb02_nro"].ToString();

                            Conexao comb2 = new Conexao();
                            comb2.sql = "Update tb02_prioritario set tb02_status = 4 where tb02_nro=" + define + " ";
                            comb2.open();
                            comb2.Runsql();
                            comb2.close();
                            System.Media.SoundPlayer tocar;
                            tocar = new System.Media.SoundPlayer(Application.StartupPath + "/TOQUES/CAMPANHA.wav");
                            tocar.Play();
                            cont++;


                        }

                    }

                    else
                    {
                        comb.close();
                        comb.sql = "Select tb01_nro from tb01_normal where tb01_status = '1' order by tb01_nro ASC limit 1";
                        comb.open();
                        dados = comb.Execsql();

                        if (dados.HasRows)
                        {
                            while (dados.Read())
                            {
                                define = int.Parse(dados["tb01_nro"].ToString());
                                label4.Text = "Tipo: NORMAL";
                                if (define <= 9) label2.Text = "00" + dados["tb01_nro"].ToString();
                                if (define >= 10 && define <= 99) label2.Text = "0" + dados["tb01_nro"].ToString();
                                if (define >= 100 && define <= 999) label2.Text = dados["tb01_nro"].ToString();

                                Conexao comb2 = new Conexao();
                                comb2.sql = "Update tb01_normal set tb01_status = 4 where tb01_nro=" + define + " ";
                                comb2.open();
                                comb2.Runsql();
                                comb2.close();
                                System.Media.SoundPlayer tocar;
                                tocar = new System.Media.SoundPlayer(Application.StartupPath + "/TOQUES/CAMPANHA.wav");
                                tocar.Play();
                            }
                        }
                    }
                }
            }
  }

        private void select_Tick(object sender, EventArgs e)
        {
            request();

        }

        private void tempo_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dddd, dd De MMM yyyy, HH:mm:ss");
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
