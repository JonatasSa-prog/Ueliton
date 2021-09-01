using System;
using System.Collections.Generic;
using System.Linq;
using Registro.Entities.Exceptions;

namespace Registro.Entities
{
    class Pessoas
    {
        List<Pessoa> pessoas = new List<Pessoa>();

        public Pessoas()
        {
            this.add();
        }

        public void AddPessoas(Pessoa pessoa)
        {
            if (pessoas.Where(p => p.Name == pessoa.Name).Any())
                throw new IdenticPeploExptions("Não foi possivel adicionar essa pessoa poís o nome já exite no banco!");
            if (pessoas.Where(p => p.Tel == pessoa.Tel).Any())
                throw new IdenticPeploExptions("Não foi possivel adicionar essa pessoa poís o telefone já exite no banco!");
            if (pessoa.Name == "")
                throw new IdenticPeploExptions("Informe o Nome");
            if (pessoa.Tel == "")
                throw new IdenticPeploExptions("Informe o Telefone");
            if(pessoa.Name.Count() < 3)
                throw new IdenticPeploExptions("O nome deve ter ao menos 3 letras");
           
            pessoas.Add(pessoa);
        }

        public void add()
        {
            this.AddPessoas(new Pessoa("Jonatas", "71991110795"));
            this.AddPessoas(new Pessoa("Higor", "71999999999"));
            this.AddPessoas(new Pessoa("Uelitona", "71988888888"));
            this.AddPessoas(new Pessoa("Rafael", "71977777777"));
        }

        public  IEnumerable<Pessoa> GetPessoa(String  name) 
        {
            var p = pessoas.Where(x => x.Name.Contains(name));
            return p;
        }

        public List<Pessoa> Lista()
        {
            return pessoas;
        }
    }
}
