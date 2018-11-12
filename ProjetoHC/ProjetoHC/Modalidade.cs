using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHC
{
    class Modalidade
    {
        public long? id_modaldiade { get; set; }
        public string nome { get; set; }
        public int pont_maxima { get; set; }
        public string comprovante { get; set; }
        public int id_grupo { get; set; }
        public string tipo_pont { get; set; }



        public Modalidade()
        {
            this.id_modaldiade = null;
        }

        protected bool Equals(Modalidade other)
        {
            return id_modaldiade.Equals(other.id_modaldiade);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return false;
            if (obj.GetType() != typeof(Modalidade))
                return false;
            return base.Equals((Modalidade)obj);

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
