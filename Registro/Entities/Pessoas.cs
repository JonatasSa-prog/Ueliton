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
            if (pessoa.CPF == "")
                throw new IdenticPeploExptions("Informe o CPF");
            if (pessoa.Email == "")
                throw new IdenticPeploExptions("Informe o E-mail");
            if (pessoa.Nascimento == null)
                throw new IdenticPeploExptions("Informe a Data de Nascimento");
            if (pessoa.Nascimento > DateTime.Now.Date)
                throw new IdenticPeploExptions("Informe uma Data de Nascimento válida");
            if (pessoa.Name.Count() < 3)
                throw new IdenticPeploExptions("O nome deve ter ao menos 3 letras");
            if (pessoa.Tel.Count() != 11)
                throw new IdenticPeploExptions("Informe um número de telefone válido");
            if (pessoa.CPF.Count() != 11)
                throw new IdenticPeploExptions("Informe um CPF válido");

            pessoas.Add(pessoa);
        }

        public void add()
        {
            this.AddPessoas(new Pessoa("Jonatas", "71991110795","86474711566","jonatas.sa.25@gmail.com",DateTime.Parse("28/02/2000")));

            this.AddPessoas(new Pessoa("Higor", "71999999999", "99999999999", "highor@gmail.com", DateTime.Parse("21/02/2000")));

            this.AddPessoas(new Pessoa("Icaro", "71988888888", "88888888888", "icaro@gmail.com", DateTime.Parse("27/04/2000")));

            this.AddPessoas(new Pessoa("Inocencio", "71977777777", "77777777777", "inocencio@gmail.com", DateTime.Parse("11/04/2000")));

        }

        public  IEnumerable<Pessoa> GetPessoa(String  name) 
        {
            if(!pessoas.Where(x => x.Name.ToUpper().Contains(name.ToUpper())).Any())
                throw new IdenticPeploExptions("Nenhuma pessoas encontrada!");

            var p = pessoas.Where(x => x.Name.ToUpper().Contains(name.ToUpper()));
            return p;
        }

        public Pessoa GetPessoaById(Guid id)
        {
            if (!pessoas.Where(x => x.Id == id).Any())
                throw new IdenticPeploExptions("Nenhuma pessoas encontrada!");

            var p = pessoas.Where(x => x.Id == id);
            return (Pessoa) p.FirstOrDefault();
        }

        public void Update(Guid id)
        {
            if(!pessoas.Where(a => a.Id == id).Any())
                throw new IdenticPeploExptions("O id não consta no banco de dados!");

            Pessoa pe = GetPessoaById(id);
            
            foreach(Pessoa p in pessoas)
            {
                if (p.Id == id)
                {
                    p.Name = pe.Name;
                    p.Tel = pe.Tel;
                    p.CPF = pe.CPF;
                    p.Email = pe.Email;
                }
            }

        }
    
        public void Delete(Pessoa a)
        {
            pessoas.Remove(a);
        }
        public List<Pessoa> Lista()
        {
            return pessoas;
        }
    }
}
