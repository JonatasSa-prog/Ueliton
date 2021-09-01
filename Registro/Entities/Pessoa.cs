using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro.Entities
{
    class Pessoa
    {
        
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Tel { get; set; }

        public Pessoa(string name, string tel)
        {
            Id = Guid.NewGuid();
            Name = name;
            Tel = tel;
        }
        public List<Pessoa> Listar()
        {
            var list = new List<Pessoa>();
            return list;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() + Name.GetHashCode() + Tel.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Pessoa))
                return false;
            Pessoa other = obj as Pessoa;
            return Id.Equals(other.Id) && Name.Equals(other.Name) && Tel.Equals(other.Tel);
        }
    }
}
