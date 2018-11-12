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
    public partial class FrmAtivCom : Form
    {
        public FrmAtivCom()
        {
            InitializeComponent();
            FillComboGrupo();


        }

        OracleConnection connection = DBConnection.DB_Connection;
        private Atividade atividadeAtual;
        private DAL_Atividades dal = new DAL_Atividades();

        void FillComboGrupo()
        {
            string cmdText = "select descricao, id_grupo from grupo";
            OracleDataAdapter da = new OracleDataAdapter(cmdText, connection);
            connection.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "Grupo");
            cmbBoxGrupo.DisplayMember = "descricao";
            cmbBoxGrupo.ValueMember = "id_grupo";
            cmbBoxGrupo.DataSource = ds.Tables["Grupo"];
            cmbBoxGrupo.SelectedIndex = -1;
            connection.Close();
            
        }

        void FillComboModalidade()
        {
            connection.Close();
            OracleCommand cmdText = connection.CreateCommand();            
            cmdText.CommandText = "select nome, id_modalidade from modalidade m inner join grupo g on (m.id_grupo = g.id_grupo) where g.id_grupo =1";
            cmdText.Parameters.Add(":id_grupos", 1);
            OracleDataAdapter da = new OracleDataAdapter(cmdText.CommandText, connection);            
            connection.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "Modalidade");
            cmbBoxModal.DisplayMember = "nome";
            cmbBoxModal.ValueMember = "id_modalidade";
            cmbBoxModal.DataSource = ds.Tables["Modalidade"];
            cmbBoxModal.SelectedIndex = -1;
            
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

            //dtGvModalidade.DataSource = data;

            connection.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Show();
        }

        private void cmbBoxGrupo_SelectedValueChanged(object sender, EventArgs e)
        {

            FillComboModalidade();
            
        }

        private void cmbBoxModal_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbBoxGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            dal.Save(new Atividade()
            {
                id_atividade = string.IsNullOrEmpty(txtidAtiv.Text) ? (long?)null : Convert.ToInt64(txtidAtiv.Text),
                atividade = txtAtiv.Text,
                local_realiz =txtLocal.Text,
                documento = txtDocuVal.Text,
                tempo = Convert.ToInt32(txtAtivTempo),
                id_grupo = Convert.ToInt32(cmbBoxGrupo.SelectedValue),
                id_modalidade = Convert.ToInt32(cmbBoxModal.SelectedValue),
                id_aluno = Convert.ToInt32(cmbBoxAluno.SelectedValue)

            });
            MessageBox.Show("Manutenção feita com sucesso!");


            ClearControls();
        }
    }
}
