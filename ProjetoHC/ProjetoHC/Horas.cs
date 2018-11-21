using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHC
{
    class Horas
    {
        public long? id_hora { get; set; }
        public int hora_total { get; set; }
        public int hora_valida { get; set; }
        public int id_aluno { get; set; }

        public Horas()
        {
            this.id_hora = null;
        }

        protected bool Equals(Horas other)
        {
            return id_hora.Equals(other.id_hora);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return false;
            if (obj.GetType() != typeof(Horas))
                return false;
            return base.Equals((Horas)obj);

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
