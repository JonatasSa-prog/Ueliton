using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using Registro.Entities;

namespace Registro.EntitiesDAO
{
    class ConnectionDB
    {
        MySqlConnection connection;
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

        public DataTable ListarDB( )
        {
            string str = "select * from pessoa";
            MySqlCommand command = new MySqlCommand(str,connection);
            try
            {
               MySqlDataAdapter objAdp = new MySqlDataAdapter(command);
               DataTable dtLista = new DataTable();
          
                objAdp.Fill(dtLista);
                return dtLista;
            }
            catch
            {
                
            }
            return null;
        }

        public void DeletarDB(Pessoa p)
        {
            try
            {
                string insert = $"DELETE FROM pessoa WHERE id = '{p.Id}';";
                MySqlCommand command = new MySqlCommand(insert, connection);
                command.ExecuteNonQuery();
            }
            catch
            {

            }
        }

        public void updateDB(Pessoa p)
        {
            try
            {
                string insert = $"UPDATE pessoa SET nome = '{p.Name}',cpf = '{p.CPF}',email = '{p.Email}',telefone = '{p.Tel}' WHERE id = {p.Id};";
                MySqlCommand command = new MySqlCommand(insert, connection);
                command.ExecuteNonQuery();
            }
            catch
            {

            }
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
