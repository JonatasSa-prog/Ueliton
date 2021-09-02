using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Registro.Entities;
using Registro.Entities.Exceptions;



namespace Registro
{
    public partial class Form1 : Form
    {
        Pessoas pessoas = new Pessoas();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pessoas.Lista();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                pessoas.AddPessoas(new Pessoa(Nome.Text, Telefone.Text,CPF.Text,Email.Text,Nascimento.Value.Date));

                dataGridView1.DataSource = "";
                dataGridView1.DataSource = pessoas.Lista();
                dataGridView1.Refresh();

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Pessoa> p = pessoas.Lista();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                    dataGridView1.ClearSelection();
                    dataGridView1.DataSource = "";
                    dataGridView1.DataSource = pessoas.Lista();
                    dataGridView1.Refresh();
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
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = pessoas.Lista();
            dataGridView1.Refresh();

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
            var p = dataGridView1.CurrentCell.Value;
            var pessoaAtualizar = pessoas.GetPessoaById((Guid)p);

            Nome.Text = pessoaAtualizar.Name;
            Email.Text = pessoaAtualizar.Email;
            Telefone.Text = pessoaAtualizar.Tel;
            CPF.Text = pessoaAtualizar.CPF;

            var form3 = new Form2(Nome.Text,CPF.Text,Email.Text,Telefone.Text);
            form3.ShowDialog();
                pessoas.Update(pessoaAtualizar);

            Resetar();

        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void Deletar_Click(object sender, EventArgs e)
        {
            var p = dataGridView1.CurrentCell.Value;
            var pessoaDeletar = pessoas.GetPessoaById((Guid)p);
            pessoas.Delete(pessoaDeletar);
            Resetar();
        }
    }
}
