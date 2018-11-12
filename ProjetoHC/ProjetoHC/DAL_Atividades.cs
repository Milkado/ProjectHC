using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHC
{
    class DAL_Atividades
    {
        OracleConnection connection = DBConnection.DB_Connection;

        public void RemoveById(long? id_atividade)
        {
            OracleCommand cmd = connection.CreateCommand();
            cmd.CommandText = "delete from atividade where id_atividade = :id";
            cmd.Parameters.Add(":id", id_atividade);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void Update(Atividade atividade)
        {
            OracleCommand cmd = connection.CreateCommand();
            cmd.CommandText = "update atividade set atividade = :atividade, local_realiz = :local_realiz, documento = :documento, tempo = :tempo, id_grupo = :id_grupo, id_modalidade =  :id_modalidade, id_aluno = :id_aluno where id_atividade = :id";
            cmd.Parameters.Add(":atividade", atividade.atividade);
            cmd.Parameters.Add(":local_realiz", atividade.local_realiz);
            cmd.Parameters.Add(":documento", atividade.documento);
            cmd.Parameters.Add("tempo", atividade.tempo);
            cmd.Parameters.Add("id_grupo", atividade.id_grupo);
            cmd.Parameters.Add("id_modalidade", atividade.id_modalidade);
            cmd.Parameters.Add("id_aluno", atividade.id_aluno);
            cmd.Parameters.Add(":id", atividade.id_atividade);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void Insert(Atividade atividade)
        {
            OracleCommand cmd = connection.CreateCommand();
            cmd.CommandText = "insert into atividade(atividade, local_realiz, documento, tempo, id_grupo, id_modalidade, id_aluno) values (:atividade, :local_realiz, :documento, :tempo, :id_grupo, :id_modalidade, :id_aluno)";
            cmd.Parameters.Add(":atividade", atividade.atividade);
            cmd.Parameters.Add(":local_realiz", atividade.local_realiz);
            cmd.Parameters.Add(":documento", atividade.documento);
            cmd.Parameters.Add("tempo", atividade.tempo);
            cmd.Parameters.Add("id_grupo", atividade.id_grupo);
            cmd.Parameters.Add("id_modalidade", atividade.id_modalidade);
            cmd.Parameters.Add("id_aluno", atividade.id_aluno);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void Save(Atividade atividade)
        {


            if (atividade.id_atividade != null)
            {
                this.Update(atividade);
            }
            else
            {
                this.Insert(atividade);
            }
        }
    }
}
