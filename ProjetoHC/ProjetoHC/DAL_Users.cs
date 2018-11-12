using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHC
{
    class DAL_Users
    {
        OracleConnection connection = DBConnection.DB_Connection;

        public void RemoveById(long? id_user)
        {
            OracleCommand cmd = connection.CreateCommand();
            cmd.CommandText = "delete from tb_user where id_user = :id";
            cmd.Parameters.Add(":id", id_user);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void Update(Users users)
        {
            OracleCommand cmd = connection.CreateCommand();
            cmd.CommandText = "update tb_user set user_name = :user_name, user_password = :user_password where id_user = :id";
            cmd.Parameters.Add(":user_name", users.user_name);
            cmd.Parameters.Add(":user_password", users.user_password);
            cmd.Parameters.Add(":id_user", users.id_user);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        private void Insert(Users users)
        {
            OracleCommand cmd = connection.CreateCommand();
            cmd.CommandText = "insert into tb_user(user_name, user_password) values (:user_name, :user_password)";
            cmd.Parameters.Add(":user_name", users.user_name);
            cmd.Parameters.Add(":user_password", users.user_password);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void Save(Users users)
        {
            if (users.id_user != null)
            {
                this.Update(users);
            }
            else
            {
                this.Insert(users);
            }
        }
            
    }
}
