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
    public partial class Endocrinologista : Form
    {
        public Endocrinologista()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ENDO_grid endo = new ENDO_grid();
            endo.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
                     OleDbConnection conexao = new OleDbConnection();
              conexao.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Aguinaldo\documents\visual studio express\Projects\prontuario_medico\prontuario_medico\consulta_medica.accdb";

//Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Aguinaldo\Desktop\consulta_medica.accdb
// - VALOR DATA DIRECTORY  - @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\consulta_medica.accdb";

              //CAMINHO DO COMPUTADOR - C:\Users\Aguinaldo\documents\visual studio express\Projects\prontuario_medico\prontuario_medico\consulta_medica.accdb


            try
            {
                conexao.Open();

                OleDbCommand CMMC = new OleDbCommand();

                CMMC.CommandText = " insert into consulta01 (medico, data_consulta, exames, diagnostico, tratamento, medicamentos, resultado, data_retorno) values ('" + label1.Text + "','" + dateTimePicker2.Value + "', '" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + dateTimePicker3.Value + "')";

                CMMC.CommandType = CommandType.Text;
                CMMC.Connection = conexao;


                CMMC.ExecuteNonQuery();


                this.BackColor = Color.DarkOrange ;

                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }

           // POSSO COLOCAR O EXCEPTION PARA TRAZER O ERRO DE FORMA DESCRITIVA. Ex: Catch (Exception ex)


            catch (Exception ex)
            {

                MessageBox.Show (String.Format( "Dados não conferem  : {0}", ex.Message));
            }



            conexao.Close();

        }

        }
    }

