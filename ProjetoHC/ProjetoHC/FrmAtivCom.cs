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
            OracleCommand cmdText = new OracleCommand();
            cmdText.Connection = connection;
            cmdText.CommandText = "select nome, id_modalidade from modalidade m inner join grupo g on (m.id_grupo = g.id_grupo) where g.id_grupo = :id_grupo";
            int value = Convert.ToInt32(cmbBoxGrupo.SelectedValue);
            cmdText.Parameters.Add(":id_grupo", value);
            OracleDataAdapter da = new OracleDataAdapter(cmdText.CommandText, connection);            
            connection.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "Modalidade");
            cmbBoxModal.DisplayMember = "nome";
            cmbBoxModal.ValueMember = "id_modalidade";
            cmbBoxModal.DataSource = ds.Tables["Modalidade"];
            
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
    }
}
