using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHC
{
    class Atividade
    {
        public long? id_atividade { get; set; }
        public string atividade { get; set; }
        public string local_realiz { get; set; }
        public string documento { get; set; }
        public int tempo { get; set; }       
        public int id_grupo { get; set; }
        public int id_modalidade { get; set; }
        public int id_aluno { get; set; }



        public Atividade()
        {
            this.id_atividade = null;
        }

        protected bool Equals(Atividade other)
        {
            return id_atividade.Equals(other.id_atividade);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return false;
            if (obj.GetType() != typeof(Atividade))
                return false;
            return base.Equals((Atividade)obj);

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
