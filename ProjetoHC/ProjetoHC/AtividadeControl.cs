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
    public partial class AtividadeControl : UserControl
    {
        public AtividadeControl()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            tableTop.Dock = DockStyle.Top;
            panelId.Dock = DockStyle.Fill;
            panelAluno.Dock = DockStyle.Fill;
            panelAtividade.Dock = DockStyle.Fill;
            panelGrupo.Dock = DockStyle.Fill;
            panelMatricula.Dock = DockStyle.Fill;
            panelLocal.Dock = DockStyle.Fill;
            panelTempo.Dock = DockStyle.Fill;
            panelDocumento.Dock = DockStyle.Fill;
            panelbottom.Dock = DockStyle.Bottom;
            panelGravar.Dock = DockStyle.Fill;
            panelExcluir.Dock = DockStyle.Fill;
            panelCancel.Dock = DockStyle.Fill;
            alunoCombo.ComboAluno(cmbBoxAluno);
            combo.ComboGrupo(cmbBoxGrupo);
            SelectAtividade();
            
        }

        OracleConnection connection = DBConnection.DB_Connection;
        private Atividade atividadeAtual;
        private DAL_Atividades dal = new DAL_Atividades();
        FillComboGrupo combo = new FillComboGrupo();
        DAL_Horas horas = new DAL_Horas();
        FillComboAluno alunoCombo = new FillComboAluno();
        public void SelectAtividade()
        {
            connection.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;
            cmd.CommandText = "select id_atividade, atividade_realizada, local_realiz, documento, tempo, g.descricao as Grupo, m.nome as Modalidade, s.nome as Aluno, s.matricula " +
                "from atividade a " +
                "inner join modalidade m on (a.id_modalidade = m.id_modalidade) " +
                "inner join grupo g on (a.id_grupo = g.id_grupo) " +
                "inner join aluno s on (a.id_aluno = s.id_aluno) " +
                "order by id_atividade";
            OracleDataAdapter adapter = new OracleDataAdapter(cmd.CommandText, connection);
            OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dgvAtiv.DataSource = data;
            connection.Close();
        }


        public void ClearControls()
        {
            txtidAtiv.Text = string.Empty;
            txtAtiv.Text = string.Empty;
            txtLocal.Text = string.Empty;
            txtDocuVal.Text = string.Empty;
            txtAtivTempo.Text = string.Empty;
            cmbBoxGrupo.Text = string.Empty;
            cmbBoxModal.Text = string.Empty;
            cmbBoxAluno.Text = string.Empty;
            SelectAtividade();
            dgvAtiv.ClearSelection();
            this.atividadeAtual = null;
            txtAtiv.Focus();
        }

        

        void FillComboModalidade()
        {
            connection.Close();
            string cmdText = "select nome, id_modalidade from modalidade where id_grupo = :id_grupo";
            OracleCommand cmd = new OracleCommand(cmdText);
            cmd.Connection = connection;
            cmd.Parameters.Add(":id_grupo", cmbBoxGrupo.SelectedValue);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            connection.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "Modalidade");
            cmbBoxModal.DisplayMember = "nome";
            cmbBoxModal.ValueMember = "id_modalidade";
            cmbBoxModal.DataSource = ds.Tables["Modalidade"];
            cmbBoxModal.SelectedIndex = -1;
            connection.Close();

        }

        private void cmbBoxGrupo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmbBoxGrupo.SelectedIndex > -1)
            {
                cmbBoxModal.Enabled = true;
                FillComboModalidade();
            }
            else
            {
                cmbBoxModal.Enabled = false;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            dal.Save(new Atividade()
            {
                id_atividade = string.IsNullOrEmpty(txtidAtiv.Text) ? (long?)null : Convert.ToInt64(txtidAtiv.Text),
                atividade = txtAtiv.Text,
                local_realiz = txtLocal.Text,
                documento = txtDocuVal.Text,
                tempo = Convert.ToInt32(txtAtivTempo.Text),
                id_grupo = Convert.ToInt32(cmbBoxGrupo.SelectedValue),
                id_modalidade = Convert.ToInt32(cmbBoxModal.SelectedValue),
                id_aluno = Convert.ToInt32(cmbBoxAluno.SelectedValue)

            });
            horas.Procedure(new Horas()
            {
                id_aluno = Convert.ToInt32(cmbBoxAluno.SelectedValue),
                hora_total = Convert.ToInt32(txtAtivTempo.Text)
            });
            MessageBox.Show("Manutenção feita com sucesso!");


            ClearControls();
        }

        private void cmbBoxAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private Atividade GetById(long id_atividade)
        {

            Atividade atividade = new Atividade();
            OracleConnection connection = DBConnection.DB_Connection;
            connection.Close();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;
            cmd.CommandText = "select id_atividade, atividade_realizada, local_realiz, documento, tempo, id_grupo, id_modalidade, id_aluno from atividade where id_atividade = :id";
            cmd.Parameters.Add(":id", id_atividade);
            connection.Open();
            using (OracleDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    atividade.id_atividade = reader.GetInt32(0);
                    atividade.atividade = reader.GetString(1);
                    atividade.local_realiz = reader.GetString(2);
                    atividade.documento = reader.GetString(3);
                    atividade.tempo = reader.GetInt32(4);
                    atividade.id_grupo = reader.GetInt32(5);
                    atividade.id_modalidade = reader.GetInt32(6);
                    atividade.id_aluno = reader.GetInt32(7);
                }
            }
            connection.Close();
            return atividade;
        }

        private void dgvAtiv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            this.atividadeAtual = GetById(Convert.ToInt64(dgvAtiv.Rows[e.RowIndex].Cells[0].Value));
            txtidAtiv.Text = this.atividadeAtual.id_atividade.ToString();
            txtAtiv.Text = this.atividadeAtual.atividade;
            txtLocal.Text = this.atividadeAtual.local_realiz;
            txtDocuVal.Text = this.atividadeAtual.documento;
            txtAtivTempo.Text = this.atividadeAtual.tempo.ToString();
            cmbBoxGrupo.SelectedValue = this.atividadeAtual.id_grupo;
            cmbBoxModal.SelectedValue = this.atividadeAtual.id_modalidade;
            cmbBoxAluno.SelectedValue = this.atividadeAtual.id_aluno;

        }

        private void cmbBoxAluno_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmbBoxAluno.SelectedIndex > -1)
            {
                connection.Close();
                string cmdText = "select matricula from aluno where id_aluno = :id_combo";
                OracleCommand cmd = new OracleCommand(cmdText);
                cmd.Connection = connection;
                cmd.Parameters.Add(":id_combo", cmbBoxAluno.SelectedValue);
                connection.Open();
                cmd.ExecuteNonQuery();
                OracleDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string matricula = (string)reader["matricula"].ToString();
                    txtMat.Text = matricula;
                }
                connection.Close();
            }
        }
    }
}
