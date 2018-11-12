using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHC
{
    public sealed class DBConnection
    {
        private static volatile OracleConnection instance;
        private DBConnection() { }

        public static OracleConnection DB_Connection
        {
            get
            {
                if (instance == null)
                {
                    instance = new OracleConnection("Data Source=localhost:1521/xe;User Id = projecthc; Password=projecthc;");
                }
                return instance;
            }
        }
    }

}
