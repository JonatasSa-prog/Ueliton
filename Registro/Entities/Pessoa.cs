using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro.Entities
{
    class Pessoa
    {

        public Guid Id { get; set; }
        public String Name { get; set; }
        public String CPF { get; set; }
        public String Tel { get; set; }
        public String Email { get; set; }
        public DateTime Nascimento { get; set; }
        


        public Pessoa(string name, string tel, String cpf, String email, DateTime nascimento)
        {
            Id = Guid.NewGuid();
            Name = name;
            CPF = cpf;
            Tel = tel;
            Email = email;
            Nascimento = nascimento;
        }

        public Pessoa(string name, string tel, String cpf, String email)
        {
            Id = Guid.NewGuid();
            Name = name;
            CPF = cpf;
            Tel = tel;
            Email = email;
            
        }
        public List<Pessoa> Listar()
        {
            var list = new List<Pessoa>();
            return list;
        }

        public override int GetHashCode()
        {
            return CPF.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Pessoa))
                return false;
            Pessoa other = obj as Pessoa;
            return CPF.Equals(other.CPF);
        }
    }
}
