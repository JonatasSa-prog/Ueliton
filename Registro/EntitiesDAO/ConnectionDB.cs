using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using Registro.Entities;
using Registro.Entities.Exceptions;

namespace Registro.EntitiesDAO
{
    class ConnectionDB
    {
        MySqlConnection connection;
        Pessoas pessoas = new Pessoas();
        public ConnectionDB(String connect)
        {
            
            try
            {
                 connection = new MySqlConnection(connect);                        
            }
            catch(Exception a){
                throw new Exception("Error: " + a);
            }
        }

        public void InsertDB(Pessoa pessoa)
        {
            try
            {
                

                string insert = $"insert into pessoa(id,nome,cpf,email,telefone,nascimento) values(uuid(), '{pessoa.Name}', '{pessoa.CPF}', '{pessoa.Email}','{pessoa.Tel}', '{pessoa.Nascimento.ToString("yyyy-MM-dd")}')";
                MySqlCommand command = new MySqlCommand(insert,connection);
                command.ExecuteNonQuery();
            }
            catch
            {

            }
            
        }

        public void InsertDB(String pessoa)
        {
            try
            {
                
                MySqlCommand command = new MySqlCommand(pessoa,connection);
                command.ExecuteNonQuery();
                
            }
            catch
            {

            }

        }

        public Pessoas ListarDB( )
        {

            
            string str = "select id,nome,cpf,email,telefone,nascimento from pessoa";
            MySqlCommand command = new MySqlCommand(str,connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                pessoas.AddPessoas(new Pessoa(Guid.Parse(reader.GetString(0)), reader.GetString(1), reader.GetString(4), reader.GetString(2), reader.GetString(3), DateTime.Parse(reader.GetString(5))));
            }
            
            return pessoas;
        }

        public void DeletarDB(string p)
        {
                
                string delete = $"DELETE FROM pessoa WHERE id = '{p}';";
                MySqlCommand command = new MySqlCommand(delete, connection);
                command.ExecuteNonQuery();
            
          
        }

        public void updateDB(Pessoa p)
        {
          
                string update = $"UPDATE pessoa SET nome = '{p.Name}',cpf = '{p.CPF}',email = '{p.Email}',telefone = '{p.Tel}' WHERE id = '{p.Id}';";
                MySqlCommand command = new MySqlCommand(update, connection);
                command.ExecuteNonQuery();
         
        }

        public Pessoa SelectDB(string id)
        {
            string str = $"select * from pessoa where id = {id}";
            MySqlCommand command = new MySqlCommand(str, connection);
           
            var reader = command.ExecuteReader();
            reader.Read();
                
            return new Pessoa(Guid.Parse(reader.GetString(0)), reader.GetString(1), reader.GetString(4), reader.GetString(2), reader.GetString(3), DateTime.Parse(reader.GetString(5)));
        }
        public void OpenDB()
        {
            connection.Open();
        }
        public void CloseDB()
        {
            connection.Close();
        }
    }
}
