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
    public partial class ModalidadeControl : UserControl
    {
        public ModalidadeControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            tableTop.Dock = DockStyle.Top;
            panelCarga.Dock = DockStyle.Fill;
            panelId.Dock = DockStyle.Fill;
            panelNome.Dock = DockStyle.Fill;
            panelPont.Dock = DockStyle.Fill;
            panelGrupo.Dock = DockStyle.Fill;
            panelTop.Dock = DockStyle.Top;
            panelComprovante.Dock = DockStyle.Fill;
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            panelCancel.Dock = DockStyle.Fill;
            panelGravar.Dock = DockStyle.Fill;
            panelExcluir.Dock = DockStyle.Fill;
            panelBottom.Dock = DockStyle.Bottom;
            SelectModalidades();
            combo.ComboGrupo(cmbBoxGrupo);
        }

        public void ClearControls()
        {
            txtIdModal.Text = string.Empty;
            txtName.Text = string.Empty;
            txtMH.Text = string.Empty;
            txtDesc.Text = string.Empty;
            cmbBoxPont.Text = string.Empty;
            SelectModalidades();
            dtGvModalidade.ClearSelection();
            this.modalidadeAtual = null;
            txtName.Focus();
        }

        private Modalidade modalidadeAtual;
        private DAL_Modalidades dal = new DAL_Modalidades();
        OracleConnection connection = DBConnection.DB_Connection;
        FillComboGrupo combo = new FillComboGrupo();

        public void SelectModalidades()
        {
            connection.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;
            cmd.CommandText = "select id_modalidade, nome, pont_maxima, tipo_pont, g.descricao, comprovante from modalidade m inner join grupo g on (m.id_grupo = g.id_grupo) order by id_modalidade";
            OracleDataAdapter adapter = new OracleDataAdapter(cmd.CommandText, connection);
            OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dtGvModalidade.DataSource = data;
            connection.Close();
        }

        private Modalidade GetById(long id_modalidade)
        {

            Modalidade modalidade = new Modalidade();
            OracleConnection connection = DBConnection.DB_Connection;
            connection.Close();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;
            cmd.CommandText = "select id_modalidade, nome, tipo_pont, pont_maxima, comprovante, id_grupo from modalidade where id_modalidade = :id";
            cmd.Parameters.Add(":id", id_modalidade);
            connection.Open();
            using (OracleDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    modalidade.id_modaldiade = reader.GetInt32(0);
                    modalidade.nome = reader.GetString(1);
                    modalidade.tipo_pont = reader.GetString(2);
                    modalidade.pont_maxima = reader.GetInt32(3);
                    modalidade.comprovante = reader.GetString(4);
                    modalidade.id_grupo = reader.GetInt32(5);
                }
            }
            connection.Close();
            return modalidade;
        }

            private void panelCancel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            dal.Save(new Modalidade()
            {
                id_modaldiade = string.IsNullOrEmpty(txtIdModal.Text) ? (long?)null : Convert.ToInt64(txtIdModal.Text),
                nome = txtName.Text,
                pont_maxima = Convert.ToInt32(txtMH.Text),
                comprovante = txtDesc.Text,
                tipo_pont = cmbBoxPont.Text,
                id_grupo = Convert.ToInt32(cmbBoxGrupo.SelectedValue)

            });
            MessageBox.Show("Manutenção feita com sucesso!");


            ClearControls();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtIdModal.Text == string.Empty)
            {
                MessageBox.Show("Selecione a modaldiade a ser removida");
            }
            else
            {
                this.dal.RemoveById(this.modalidadeAtual.id_modaldiade);
                MessageBox.Show("Modalidade removida com sucesso!");
                ClearControls();
            }
        }

        private void txtMH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) ||
                            (e.KeyChar == '.' || e.KeyChar == '-'))
            {
                e.Handled = true;
            }

            txtMH.MaxLength = 3;
        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void dtGvModalidade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            this.modalidadeAtual = GetById(Convert.ToInt64(dtGvModalidade.Rows[e.RowIndex].Cells[0].Value));
            txtIdModal.Text = this.modalidadeAtual.id_modaldiade.ToString();
            txtName.Text = this.modalidadeAtual.nome;
            txtMH.Text = this.modalidadeAtual.pont_maxima.ToString();
            txtDesc.Text = this.modalidadeAtual.comprovante;
            cmbBoxPont.Text = this.modalidadeAtual.tipo_pont;
            cmbBoxGrupo.DisplayMember = cmbBoxGrupo.GetItemText(this.modalidadeAtual.id_grupo);
        }
    }
}
