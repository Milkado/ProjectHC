using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoHC
{
    class FillComboAluno
    {
        public void ComboAluno(ComboBox comboBox)
        {
            OracleConnection connection = DBConnection.DB_Connection;
            string cmdText = "select nome, id_aluno from aluno";
            OracleDataAdapter da = new OracleDataAdapter(cmdText, connection);
            connection.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "aluno");
            comboBox.DisplayMember = "nome";
            comboBox.ValueMember = "id_aluno";
            comboBox.DataSource = ds.Tables["aluno"];
            comboBox.SelectedIndex = -1;
            connection.Close();
        }
    }
}
