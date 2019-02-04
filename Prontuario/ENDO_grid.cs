using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace prontuario_medico
{
    public partial class ENDO_grid : Form
    {
        public ENDO_grid()
        {
            InitializeComponent();
        }

        private void ENDO_grid_Load(object sender, EventArgs e)
        {
            OleDbConnection conexao = new OleDbConnection();
            conexao.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Aguinaldo\documents\visual studio express\Projects\prontuario_medico\prontuario_medico\consulta_medica.accdb";


            // o DATA DIRECTORY NAO CONSEGUE CHEGAR ATÉ O LOCAL, TIVE QUE COPIAR O CAMINHO E COLAR CONFORME ACIMA.ESTE É O CAMINHO ANTERIOR .@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\consulta_medica.accdb";

            try
            {
                conexao.Open();

                OleDbCommand CMMC = new OleDbCommand();

                CMMC.CommandText = " select medico, data_consulta, exames, diagnostico, tratamento, medicamentos, resultado, data_retorno from consulta01 where medico='ENDOCRINOLOGISTA'";
                //" select  medico ,data_consulta, exames, diagnostico, tratamento, medicamentos, resultado, data_retorno from consulta01 ";

                CMMC.CommandType = CommandType.Text;
                CMMC.Connection = conexao;

                OleDbDataReader DR;
                DR = CMMC.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(DR);

                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();


            }

            catch (Exception ex)
            {

                MessageBox.Show(String.Format("Dados não conferem  : {0}", ex.Message));
            }


            conexao.Close();

        }
    }
}
