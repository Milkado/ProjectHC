using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHC
{
    class Grupo
    {
        public long? id_grupo { get; set; }
        public int carga_maxima { get; set; }
        public string descricao { get; set; }

        public Grupo()
        {
            this.id_grupo = null;
        }

        protected bool Equals(Grupo other)
        {
            return id_grupo.Equals(other.id_grupo);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return false;
            if (obj.GetType() != typeof(Grupo))
                return false;
            return base.Equals((Grupo)obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
