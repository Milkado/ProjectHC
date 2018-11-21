using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHC
{
    class DAL_Horas
    {
        OracleConnection connection = DBConnection.DB_Connection;
       

        public void Procedure(Horas horas)
        {
            OracleCommand cmd = connection.CreateCommand();
            cmd.CommandText = "sum_value";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("a_id", OracleDbType.Int32).Value = horas.id_aluno;
            cmd.Parameters.Add("hora_ativ", OracleDbType.Int32).Value = horas.hora_total;            
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
