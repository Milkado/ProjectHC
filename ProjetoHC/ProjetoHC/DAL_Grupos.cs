using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHC
{
    class DAL_Grupos
    {
        OracleConnection connection = DBConnection.DB_Connection;

        public void RemoveById(long? id_grupo)
        {
            OracleCommand cmd = connection.CreateCommand();
            cmd.CommandText = "delete from grupo where id_grupo = :id";
            cmd.Parameters.Add(":id", id_grupo);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void Update(Grupo grupo)
        {
            OracleCommand cmd = connection.CreateCommand();
            cmd.CommandText = "update grupo set carga_maxima = :carga, descricao = :descricao where id_grupo = :id";
            cmd.Parameters.Add(":carga", grupo.carga_maxima);
            cmd.Parameters.Add(":desc_modal", grupo.descricao);
            cmd.Parameters.Add(":id", grupo.id_grupo);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void Insert(Grupo grupo)
        {
            OracleCommand cmd = connection.CreateCommand();
            cmd.CommandText = "insert into grupo(carga_maxima, descricao) values (:carga_max, :descricao)";
            cmd.Parameters.Add(":carga_max", grupo.carga_maxima);
            cmd.Parameters.Add(":descricao", grupo.descricao);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void Save(Grupo grupo)
        {


            if (grupo.id_grupo != null)
            {
                this.Update(grupo);
            }
            else
            {
                this.Insert(grupo);
            }
        }
    }
}
