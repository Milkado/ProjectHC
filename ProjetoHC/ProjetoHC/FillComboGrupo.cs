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
    public class FillComboGrupo
    {

        public void ComboGrupo(ComboBox comboBox)
        {
            OracleConnection connection = DBConnection.DB_Connection;
            string cmdText = "select descricao, id_grupo from grupo";
            OracleDataAdapter da = new OracleDataAdapter(cmdText, connection);
            connection.Open();
            DataSet ds = new DataSet();
            da.Fill(ds, "Grupo");
            comboBox.DisplayMember = "descricao";
            comboBox.ValueMember = "id_grupo";
            comboBox.DataSource = ds.Tables["Grupo"];
            comboBox.SelectedIndex = -1;
            connection.Close();
        }

       
    }
}
