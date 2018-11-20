using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace ProjetoHC
{
    public partial class UsuarioComtrol : UserControl
    {
        public UsuarioComtrol()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            tableTop.Dock = DockStyle.Top;
            panelID.Dock = DockStyle.Fill;
            panelSenha.Dock = DockStyle.Fill;
            panelConfirmar.Dock = DockStyle.Fill;
            panelUser.Dock = DockStyle.Fill;           
            panelGravar.Dock = DockStyle.Fill;
            panelExcluir.Dock = DockStyle.Fill;
            panelCancel.Dock = DockStyle.Fill;
            panelBottom.Dock = DockStyle.Bottom;
            //dgvUser.Dock = DockStyle.Fill;
            SelectUsers();
        }

        private Users userAtual;
        private DAL_Users dal = new DAL_Users();
        OracleConnection connection = DBConnection.DB_Connection;

        public void ClearControls()
        {
            txtIdUsuario.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirm.Text = string.Empty;
            txtIdUsuario.Text = string.Empty;
            SelectUsers();
            dgvUser.ClearSelection();
            this.userAtual = null;
            txtUser.Focus();
        }

        public void SelectUsers()
        {
            connection.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;
            cmd.CommandText = "select id_user, user_name, user_password from tb_user order by id_user";
            OracleDataAdapter adapter = new OracleDataAdapter(cmd.CommandText, connection);
            OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
            DataTable data = new DataTable();

            adapter.Fill(data);

            dgvUser.DataSource = data;

            connection.Close();
        }

        private Users GetById(long id_user)
        {

            Users users = new Users();
            OracleConnection connection = DBConnection.DB_Connection;
            connection.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;
            cmd.CommandText = "select id_user, user_name, user_password from tb_user where id_user = :id";
            cmd.Parameters.Add(":id", id_user);
            
            using (OracleDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    users.id_user = reader.GetInt32(0);
                    users.user_name = reader.GetString(1);
                    users.user_password = reader.GetString(2);

                }
                connection.Close();
                return users;

            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtConfirm.Text)
            {
                dal.Save(new Users()
                {
                    id_user = string.IsNullOrEmpty(txtIdUsuario.Text) ? (long?)null : Convert.ToInt64(txtIdUsuario.Text),
                    user_name = txtUser.Text,
                    user_password = txtPassword.Text
                });
                MessageBox.Show("Manutenção feita com sucesso!");


                ClearControls();
            }
            else
            {
                MessageBox.Show("Os campos senha e confirmar senha não são iguais!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtIdUsuario.Text == string.Empty)
            {
                MessageBox.Show("Selecione a modaldiade a ser removida");
            }
            else
            {
                this.dal.RemoveById(this.userAtual.id_user);
                MessageBox.Show("Usuário removido com sucesso!");
                ClearControls();
            }
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            this.userAtual = GetById(Convert.ToInt64(dgvUser.Rows[e.RowIndex].Cells[0].Value));
            txtIdUsuario.Text = this.userAtual.id_user.ToString();
            txtUser.Text = this.userAtual.user_name;
            txtPassword.Text = this.userAtual.user_password;
        }
    }
}
