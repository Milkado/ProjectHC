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
    public partial class Relatorios : UserControl
    {
        public Relatorios()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            tblLayoutTop.Dock = DockStyle.Top;
            panelBottom.Dock = DockStyle.Bottom;
            dgvRelatorio.Dock = DockStyle.Fill;
            comboAluno.ComboAluno(cmbBoxAluno);
            
        }

        OracleConnection connection = DBConnection.DB_Connection;
        FillComboAluno comboAluno = new FillComboAluno();

        public void SelectHoras()
        {
            connection.Close();
            connection.Open();
            string cmdText = "select id_hora, hora_total, hora_valida from hora_complementar where id_aluno = :aluno";
            OracleCommand cmd = new OracleCommand(cmdText);
            cmd.Connection = connection;
            cmd.Parameters.Add(":aluno", cmbBoxAluno.SelectedValue);
            //cmd.BindByName = true;
            OracleDataAdapter adapter = new OracleDataAdapter(cmd);
            OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dgvRelatorio.DataSource = data;
            connection.Close();
        }

        private void cmbBoxAluno_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbBoxAluno.SelectedIndex > -1)
            {
               SelectHoras();
            }
        }
    }
}
