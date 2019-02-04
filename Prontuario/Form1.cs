using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.OleDb;


namespace prontuario_medico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            neurologia neuro = new neurologia();
            neuro.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ortopedia orto = new ortopedia();
            orto.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Psiquiatria PSIQUE = new Psiquiatria();
            PSIQUE.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ginecologia GINECO = new ginecologia();
            GINECO.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reumatologia REUMATO = new Reumatologia();
            REUMATO.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Coloproctologia PROCTO = new Coloproctologia();
            PROCTO.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Dermatologia DERMATO = new Dermatologia();
            DERMATO.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Endocrinologista ENDOCRINO = new Endocrinologista();
            ENDOCRINO.Show();
        }


               



        private void Form1_Load(object sender, EventArgs e)
        {
                  

        }

        private void button9_Click(object sender, EventArgs e)
        {
            OleDbConnection conexao = new OleDbConnection();
            conexao.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Aguinaldo\documents\visual studio express\Projects\prontuario_medico\prontuario_medico\consulta_medica.accdb";

            try
            {
                conexao.Open();

                OleDbCommand CMMC = new OleDbCommand();

                CMMC.CommandText = "select max(data_retorno)from consulta01 where medico = 'psiquiatria'";
                
                CMMC.CommandType = CommandType.Text;
                CMMC.Connection = conexao;

               OleDbDataReader Data;
               Data = CMMC.ExecuteReader();
               Data.Read();
               label5.Text = Convert.ToString(Data.GetDateTime(0));

               
                }
                           

            catch (Exception ex)
            {

                MessageBox.Show(String.Format("Dados não conferem  : {0}", ex.Message));
            }


            conexao.Close();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            OleDbConnection conexao = new OleDbConnection();
            conexao.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Aguinaldo\documents\visual studio express\Projects\prontuario_medico\prontuario_medico\consulta_medica.accdb";

            try
            {
                conexao.Open();

                OleDbCommand CMMC = new OleDbCommand();

                CMMC.CommandText = "select max(data_retorno)from consulta01 where medico = 'ginecologia'";
                
                CMMC.CommandType = CommandType.Text;
                CMMC.Connection = conexao;

               OleDbDataReader Data;
               Data = CMMC.ExecuteReader();
               Data.Read();
               label6.Text = Convert.ToString(Data.GetDateTime(0));

               
                }
                           

            catch (Exception ex)
            {

                MessageBox.Show(String.Format("Dados não conferem  : {0}", ex.Message));
            }


            conexao.Close();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            OleDbConnection conexao = new OleDbConnection();
            conexao.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Aguinaldo\documents\visual studio express\Projects\prontuario_medico\prontuario_medico\consulta_medica.accdb";

            try
            {
                conexao.Open();

                OleDbCommand CMMC = new OleDbCommand();

                CMMC.CommandText = "select max(data_retorno)from consulta01 where medico = 'reumatologia'";

                CMMC.CommandType = CommandType.Text;
                CMMC.Connection = conexao;

                OleDbDataReader Data;
                Data = CMMC.ExecuteReader();
                Data.Read();
                label3.Text = Convert.ToString(Data.GetDateTime(0));


            }


            catch (Exception ex)
            {

                MessageBox.Show(String.Format("Dados não conferem  : {0}", ex.Message));
            }


            conexao.Close();


        }

        private void button12_Click(object sender, EventArgs e)
        {
            OleDbConnection conexao = new OleDbConnection();
            conexao.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Aguinaldo\documents\visual studio express\Projects\prontuario_medico\prontuario_medico\consulta_medica.accdb";

            try
            {
                conexao.Open();

                OleDbCommand CMMC = new OleDbCommand();

                CMMC.CommandText = "select max(data_retorno)from consulta01 where medico = 'ortopedia'";

                CMMC.CommandType = CommandType.Text;
                CMMC.Connection = conexao;

                OleDbDataReader Data;
                Data = CMMC.ExecuteReader();
                Data.Read();
                label4.Text = Convert.ToString(Data.GetDateTime(0));


            }


            catch (Exception ex)
            {

                MessageBox.Show(String.Format("Dados não conferem  : {0}", ex.Message));
            }


            conexao.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            OleDbConnection conexao = new OleDbConnection();
            conexao.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Aguinaldo\documents\visual studio express\Projects\prontuario_medico\prontuario_medico\consulta_medica.accdb";

            try
            {
                conexao.Open();

                OleDbCommand CMMC = new OleDbCommand();

                CMMC.CommandText = "select max(data_retorno)from consulta01 where medico = 'neurologia'";

                CMMC.CommandType = CommandType.Text;
                CMMC.Connection = conexao;

                OleDbDataReader Data;
                Data = CMMC.ExecuteReader();
                Data.Read();
                label7.Text = Convert.ToString(Data.GetDateTime(0));


            }


            catch (Exception ex)
            {

                MessageBox.Show(String.Format("Dados não conferem  : {0}", ex.Message));
            }


            conexao.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            OleDbConnection conexao = new OleDbConnection();
            conexao.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Aguinaldo\documents\visual studio express\Projects\prontuario_medico\prontuario_medico\consulta_medica.accdb";

            try
            {
                conexao.Open();

                OleDbCommand CMMC = new OleDbCommand();

                CMMC.CommandText = "select max(data_retorno)from consulta01 where medico = 'coloproctologia'";

                CMMC.CommandType = CommandType.Text;
                CMMC.Connection = conexao;

                OleDbDataReader Data;
                Data = CMMC.ExecuteReader();
                Data.Read();
                label8.Text = Convert.ToString(Data.GetDateTime(0));


            }


            catch (Exception ex)
            {

                MessageBox.Show(String.Format("Dados não conferem  : {0}", ex.Message));
            }


            conexao.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            OleDbConnection conexao = new OleDbConnection();
            conexao.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Aguinaldo\documents\visual studio express\Projects\prontuario_medico\prontuario_medico\consulta_medica.accdb";

            try
            {
                conexao.Open();

                OleDbCommand CMMC = new OleDbCommand();

                CMMC.CommandText = "select max(data_retorno)from consulta01 where medico = 'dermatologia'";

                CMMC.CommandType = CommandType.Text;
                CMMC.Connection = conexao;

                OleDbDataReader Data;
                Data = CMMC.ExecuteReader();
                Data.Read();
                label9.Text = Convert.ToString(Data.GetDateTime(0));


            }


            catch (Exception ex)
            {

                MessageBox.Show(String.Format("Dados não conferem  : {0}", ex.Message));
            }


            conexao.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            OleDbConnection conexao = new OleDbConnection();
            conexao.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Aguinaldo\documents\visual studio express\Projects\prontuario_medico\prontuario_medico\consulta_medica.accdb";

            try
            {
                conexao.Open();

                OleDbCommand CMMC = new OleDbCommand();

                CMMC.CommandText = "select max(data_retorno)from consulta01 where medico = 'endocrinologista'";

                CMMC.CommandType = CommandType.Text;
                CMMC.Connection = conexao;

                OleDbDataReader Data;
                Data = CMMC.ExecuteReader();
                Data.Read();
                label10.Text = Convert.ToString(Data.GetDateTime(0));


            }


            catch (Exception ex)
            {

                MessageBox.Show(String.Format("Dados não conferem  : {0}", ex.Message));
            }


            conexao.Close();

        }
        }
    }

