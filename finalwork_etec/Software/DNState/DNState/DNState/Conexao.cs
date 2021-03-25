using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace DNState
{
    class Conexao
    {
        public string sql = "";

        MySqlConnection conecta = new MySqlConnection();

        public int Runsql()
        {
            int nrlinhas;
            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = sql;
                comando.Connection = conecta;

                nrlinhas = comando.ExecuteNonQuery();

            }
            catch
            {
                nrlinhas = 0;
            }

            return nrlinhas;
        }

        public MySqlDataReader Execsql()
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = sql;
            comando.Connection = conecta;

            MySqlDataReader dados = comando.ExecuteReader();

            return dados;
        }



        public int ExecuteScalar()
        {

            Int32 conta = 0;

            try
            {

                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = sql;
                comando.Connection = conecta;

                conta = (Int32)comando.ExecuteScalar();
            }
            catch
            {
                conta = 0;
            }
            return conta;

        }


        public void open()
        {
            if (conecta.State.ToString() == "Closed")
            {
                conecta.ConnectionString = ("Server=localhost;Database=banco_tcc_doacao_novo;User=root;Pwd=");
                conecta.Open();
            }
        }


        public void close()
        {
            if (conecta.State.ToString() == "Open")
            {
                conecta.Close();
            }
        }
    }
}

