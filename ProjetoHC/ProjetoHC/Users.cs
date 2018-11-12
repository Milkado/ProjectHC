using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHC
{
    class Users
    {
        public long? id_user { get; set; }
        public string user_name { get; set; }
        public string user_password { get; set; }

        public Users()
        {
            this.id_user = null;
        }

        protected bool Equals(Users other)
        {
            return id_user.Equals(other.id_user);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return false;
            if (obj.GetType() != typeof(Users))
                return false;
            return base.Equals((Users)obj);

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}


