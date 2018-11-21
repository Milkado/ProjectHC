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
            
        }

        OracleConnection connection = DBConnection.DB_Connection;
        private Atividade atividadeAtual;
        private DAL_Atividades dal = new DAL_Atividades();
        FillComboGrupo combo = new FillComboGrupo();
        DAL_Horas horas = new DAL_Horas();
        private Horas horaAtual;
        FillComboAluno alunoCombo = new FillComboAluno();

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

        public void SelectAtividade()
        {
            connection.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;
            cmd.CommandText = "select id_, nome, pont_maxima, tipo_pont, g.descricao, comprovante from modalidade m inner join grupo g on (m.id_grupo = g.id_grupo) order by id_modalidade";
            OracleDataAdapter adapter = new OracleDataAdapter(cmd.CommandText, connection);
            OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dgvAtiv.DataSource = data;
            connection.Close();
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
            horas.Procedure(new Horas(), new Atividade
            {
                id_aluno = Convert.ToInt32(cmbBoxAluno.SelectedValue),
                tempo = Convert.ToInt32(txtAtivTempo.Text)
            });
            MessageBox.Show("Manutenção feita com sucesso!");


            ClearControls();
        }
    }
}
