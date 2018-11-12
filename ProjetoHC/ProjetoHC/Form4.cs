using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoHC
{
    public partial class FrmGrupo : Form
    {
        public FrmGrupo()
        {
            InitializeComponent();
            SelectModalidades();
        }

        private Grupo grupoAtual;
        private DAL_Grupos dal = new DAL_Grupos();
        OracleConnection connection = DBConnection.DB_Connection;

        public void SelectModalidades()
        {
            connection.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;
            cmd.CommandText = "select id_grupo, descricao, carga_maxima from grupo order by id_grupo";
            OracleDataAdapter adapter = new OracleDataAdapter(cmd.CommandText, connection);
            OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
            DataTable data = new DataTable();

            adapter.Fill(data);

            dgvGrupos.DataSource = data;

            connection.Close();
        }

        public void ClearControls()
        {
            txtIdGrupo.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtCarga.Text = string.Empty;
            SelectModalidades();
            dgvGrupos.ClearSelection();
            this.grupoAtual = null;
            txtNome.Focus();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            dal.Save(new Grupo()
            {
                id_grupo = string.IsNullOrEmpty(txtIdGrupo.Text) ? (long?)null : Convert.ToInt64(txtIdGrupo.Text),
                descricao = txtNome.Text,
                carga_maxima = Convert.ToInt32(txtCarga.Text),
                
            });
            MessageBox.Show("Manutenção feita com sucesso!");
            ClearControls();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (txtIdGrupo.Text == string.Empty)
            {
                MessageBox.Show("Selecione o grupo a ser removida");
            }
            else
            {
                this.dal.RemoveById(this.grupoAtual.id_grupo);
                MessageBox.Show("Grupo removida com sucesso!");
                ClearControls();
            }
        }

        private Grupo GetById(long id_grupo)
        {

            Grupo grupo = new Grupo();
            OracleConnection connection = DBConnection.DB_Connection;
            connection.Close();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;
            cmd.CommandText = "select id_grupo, descricao, carga_maxima from grupo where id_grupo = :id";
            cmd.Parameters.Add(":id", id_grupo);
            connection.Open();
            using (OracleDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    grupo.id_grupo = reader.GetInt32(0);
                    grupo.descricao = reader.GetString(1);
                    grupo.carga_maxima = reader.GetInt32(2);
                }
            }
            connection.Close();
            return grupo;

        }

        private void dgvGrupos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            this.grupoAtual = GetById(Convert.ToInt64(dgvGrupos.Rows[e.RowIndex].Cells[0].Value));
            txtIdGrupo.Text = this.grupoAtual.id_grupo.ToString();
            txtNome.Text = this.grupoAtual.descricao;
            txtCarga.Text = this.grupoAtual.carga_maxima.ToString();            
        }

        private void txtCarga_TextChanged(object sender, EventArgs e)
        {
            
    }

        private void txtCarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) ||
                            (e.KeyChar == '.' || e.KeyChar == '-'))
            {
                e.Handled = true;
            }

            txtCarga.MaxLength = 3;
        }
    }
    }
