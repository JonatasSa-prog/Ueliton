using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                pessoas.AddPessoas(new Pessoa(Nome.Text, Telefone.Text));

                dataGridView1.DataSource = "";
                dataGridView1.DataSource = pessoas.Lista();
                dataGridView1.Refresh();
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

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void Pesquisar_Click(object sender, EventArgs e)
        {
            var pesquisar = Pesquisa.Text;
            dataGridView1.ClearSelection();

            var p = pessoas.GetPessoa(pesquisar);
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = p.ToList();
            dataGridView1.Refresh();

        }

        private void Resetar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = pessoas.Lista();
            dataGridView1.Refresh();

        }

        private void Nome_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Telefone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
