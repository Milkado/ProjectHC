using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHC
{
    class DAL_Modalidades
    {
        OracleConnection connection = DBConnection.DB_Connection;
        
        public void RemoveById(long? id_modalidades)
        {
            OracleCommand cmd = connection.CreateCommand();
            cmd.CommandText = "delete from modaldiade where id_modalidade = :id";
            cmd.Parameters.Add(":id", id_modalidades);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void Update(Modalidade modalidade)
        {
            OracleCommand cmd = connection.CreateCommand();
            cmd.CommandText = "update modalidade set nome = :nome, pont_maxima = :carga, comprovante = :comprovante, tipo_pont = :tipo_pont, id_grupo = :id_grupo where id_modalidade = :id";
            cmd.Parameters.Add(":nome", modalidade.nome);
            cmd.Parameters.Add(":carga", modalidade.pont_maxima);
            cmd.Parameters.Add(":comprovante", modalidade.comprovante);
            cmd.Parameters.Add("tipo_pont", modalidade.tipo_pont);
            cmd.Parameters.Add("id_grupo", modalidade.id_grupo);
            cmd.Parameters.Add(":id", modalidade.id_modaldiade);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void Insert(Modalidade modalidade)
        {
            OracleCommand cmd = connection.CreateCommand();
            cmd.CommandText = "insert into modalidade(nome, pont_maxima, tipo_pont, comprovante, id_grupo) values (:nome, :pont_maxima, :tipo_pont, :comprovante, :id_grupo)";
            cmd.Parameters.Add(":nome", modalidade.nome);
            cmd.Parameters.Add(":pont_maxima", modalidade.pont_maxima);
            cmd.Parameters.Add(":tipo_pont", modalidade.tipo_pont);
            cmd.Parameters.Add("comprovante", modalidade.comprovante);
            cmd.Parameters.Add("id_grupo", modalidade.id_grupo);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void Save(Modalidade modalidade)
        {
            
            
            if (modalidade.id_modaldiade != null)
            {
                this.Update(modalidade);
            }
            else
            {
                this.Insert(modalidade);
            }
        }
    }
}
