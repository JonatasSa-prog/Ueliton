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

namespace Registro
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string nome, string cpf, string email, string telefone) : this()
        {
            Nome.Text = nome;
            CPF.Text = cpf;
            Email.Text = email;
            Telefone.Text = telefone;
        }
        private void Atualizar_Click(object sender, EventArgs e)
        {



        }
    }
}
