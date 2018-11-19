using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoHC
{
    public partial class FrmLogar : Form
    {
        public FrmLogar()
        {
            InitializeComponent();
           
        }

        private void BtnLogar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Insira usuário e senha");
                return;
            }
            try
            {
                
                
                /*OracleConnection connection = new OracleConnection("Data Source=localhost:1521/xe;User Id = PROJECTHC; Password=projeto;");
                connection.Open();*/
                OracleConnection connection = DBConnection.DB_Connection;
                OracleCommand cmd = connection.CreateCommand();
                cmd.CommandText = "select * from tb_user where user_name = :userlogin and user_password = :password";
                cmd.Parameters.Add(":userlogin", txtUser.Text);
                cmd.Parameters.Add(":password", txtPassword.Text);
                
                connection.Open();
                OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                connection.Close();
                int rowCount = ds.Tables[0].Rows.Count;
                if(rowCount == 1)
                {
                    LoginID.UserID = txtUser.Text;
                    LoginID.name = ds.Tables[0].Rows[0]["nome_user"].ToString();
                    this.Hide();
                    FrmMenu fm = new FrmMenu();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválido!");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
