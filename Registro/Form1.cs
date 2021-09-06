using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Registro.Entities;
using Registro.Entities.Exceptions;
using Registro.EntitiesDAO;


namespace Registro
{
    public partial class Form1 : Form
    {
        Pessoas pessoas = new Pessoas();
        Pessoa pessoa;
        //String connect = "server=localhost;port=3306;User Id=root;database=Pessoas; password=Renova@2021";
        ConnectionDB connection = new ConnectionDB("server=localhost;port=3306;User Id=root;database=Pessoas; password=Renova@2021");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Resetar();
                      
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {              
                connection.InsertDB(new Pessoa(Nome.Text, Telefone.Text, CPF.Text, Email.Text, Nascimento.Value.Date));
               
                Resetar();

                Nome.Text = Nome.Text.Remove(0);
                CPF.Text = CPF.Text.Remove(0);
                Email.Text = Email.Text.Remove(0);
                Telefone.Text = Telefone.Text.Remove(0);
            }
            catch(IdenticPeploExptions a)
            {
               MessageBox.Show("Error: " + a.Message);
                
            }
            
        }
        private void pessoaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void pessoasBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }  

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void Pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                
                var pesquisar = Pesquisa.Text;
                if(pesquisar != "")
                {
                    dataGridView1.ClearSelection();
                    var p = pessoas.GetPessoa(pesquisar);
                    dataGridView1.DataSource = "";
                    dataGridView1.DataSource = p.ToList();
                    dataGridView1.Refresh();
                }
                else
                {
                    
                    Resetar();
                }
                
            }catch(IdenticPeploExptions a)
            {
                MessageBox.Show("Error: " + a.Message);
                if(Pesquisa.Text.Length > 0)
                    Pesquisa.Text = Pesquisa.Text.Remove(0);          
            }
            

        }

        private void Resetar()
        {
            
                
                pessoas = connection.ListarDB();
                dataGridView1.DataSource = "";
                dataGridView1.DataSource = pessoas.Lista();
                dataGridView1.Refresh();
                              
          
                connection.CloseDB();
            
        }

        private void Nome_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Nome.Text, "[^A-z]"))
            {
                MessageBox.Show("Este campo aceita apenas letras!");
                Nome.Text = Nome.Text.Remove(Nome.Text.Length - 1);
            }
        }

        private void Telefone_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Telefone.Text, "[^0-9]"))
            {
                MessageBox.Show("Este campo aceita apenas números!");
                Telefone.Text = Telefone.Text.Remove(Telefone.Text.Length - 1);
            }
        }

        private void Pesquisa_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Nome.Text, "[^A-z]"))
            {
                MessageBox.Show("Please enter only Caracters.");
                Nome.Text = Nome.Text.Remove(Nome.Text.Length - 1);
            }
        }

        private void CPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            pessoa.Name = Nome.Text;
            pessoa.CPF = CPF.Text;
            pessoa.Email = Email.Text;
            pessoa.Tel = Telefone.Text;
    
            pessoas.Update(pessoa.Id);

            Resetar();

        }
        private void Deletar_Click(object sender, EventArgs e)
        {
            try
            {
                //connection.OpenDB();
                var p = dataGridView1.CurrentCell.Value;                                           
                connection.DeletarDB(p.ToString());

                Resetar();
            }
            catch
            {

            }
            finally
            {
                connection.CloseDB();
            }       
        }

        private void Pegar_Click(object sender, EventArgs e)
        {
            try
            {
                var p = dataGridView1.CurrentCell.Value;
                pessoa = pessoas.GetPessoaById((Guid)p);

                Nome.Text = pessoa.Name;
                Email.Text = pessoa.Email;
                Telefone.Text = pessoa.Tel;
                CPF.Text = pessoa.CPF;
            }
            catch(System.InvalidCastException)
            {
                MessageBox.Show("Error: ID não é válido. Selecione uma pessoa no Compo (Id)");
            }
            catch(System.NullReferenceException)
            {
                MessageBox.Show("Error: ID não é válido. Selecione uma pessoa no Compo (Id)");
            }
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Resetar();
            }
            catch
            {

            }
            
        }
    }
}
