
namespace Registro
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.TextBox();
            this.Telefone = new System.Windows.Forms.TextBox();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.Pesquisa = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Pesquisar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CPF = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Nascimento = new System.Windows.Forms.DateTimePicker();
            this.Atualizar = new System.Windows.Forms.Button();
            this.Deletar = new System.Windows.Forms.Button();
            this.Pegar = new System.Windows.Forms.Button();
            this.AttTabela = new System.Windows.Forms.Button();
            this.pessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pessoasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pessoasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone:";
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(65, 27);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(100, 20);
            this.Nome.TabIndex = 2;
            this.Nome.TextChanged += new System.EventHandler(this.Nome_TextChanged);
            // 
            // Telefone
            // 
            this.Telefone.Location = new System.Drawing.Point(65, 64);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(100, 20);
            this.Telefone.TabIndex = 3;
            this.Telefone.TextChanged += new System.EventHandler(this.Telefone_TextChanged);
            // 
            // Cadastrar
            // 
            this.Cadastrar.Location = new System.Drawing.Point(12, 255);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.Cadastrar.TabIndex = 5;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // Pesquisa
            // 
            this.Pesquisa.Location = new System.Drawing.Point(757, 37);
            this.Pesquisa.Name = "Pesquisa";
            this.Pesquisa.Size = new System.Drawing.Size(100, 20);
            this.Pesquisa.TabIndex = 8;
            this.Pesquisa.TextChanged += new System.EventHandler(this.Pesquisa_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(435, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 209);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // Pesquisar
            // 
            this.Pesquisar.Location = new System.Drawing.Point(676, 35);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(75, 23);
            this.Pesquisar.TabIndex = 10;
            this.Pesquisar.Text = "Pesquisar:";
            this.Pesquisar.UseVisualStyleBackColor = true;
            this.Pesquisar.Click += new System.EventHandler(this.Pesquisar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "E-mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Data de Nascimento:";
            // 
            // CPF
            // 
            this.CPF.Location = new System.Drawing.Point(65, 106);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(100, 20);
            this.CPF.TabIndex = 14;
            this.CPF.TextChanged += new System.EventHandler(this.CPF_TextChanged);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(65, 150);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(100, 20);
            this.Email.TabIndex = 15;
            // 
            // Nascimento
            // 
            this.Nascimento.Location = new System.Drawing.Point(128, 198);
            this.Nascimento.Name = "Nascimento";
            this.Nascimento.Size = new System.Drawing.Size(231, 20);
            this.Nascimento.TabIndex = 17;
            this.Nascimento.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Atualizar
            // 
            this.Atualizar.Location = new System.Drawing.Point(93, 255);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(75, 23);
            this.Atualizar.TabIndex = 18;
            this.Atualizar.Text = "Atualizar";
            this.Atualizar.UseVisualStyleBackColor = true;
            this.Atualizar.Click += new System.EventHandler(this.Atualizar_Click);
            // 
            // Deletar
            // 
            this.Deletar.Location = new System.Drawing.Point(255, 255);
            this.Deletar.Name = "Deletar";
            this.Deletar.Size = new System.Drawing.Size(75, 23);
            this.Deletar.TabIndex = 19;
            this.Deletar.Text = "Deletar";
            this.Deletar.UseVisualStyleBackColor = true;
            this.Deletar.Click += new System.EventHandler(this.Deletar_Click);
            // 
            // Pegar
            // 
            this.Pegar.Location = new System.Drawing.Point(174, 255);
            this.Pegar.Name = "Pegar";
            this.Pegar.Size = new System.Drawing.Size(75, 23);
            this.Pegar.TabIndex = 20;
            this.Pegar.Text = "Pegar";
            this.Pegar.UseVisualStyleBackColor = true;
            this.Pegar.Click += new System.EventHandler(this.Pegar_Click);
            // 
            // AttTabela
            // 
            this.AttTabela.Location = new System.Drawing.Point(676, 279);
            this.AttTabela.Name = "AttTabela";
            this.AttTabela.Size = new System.Drawing.Size(141, 23);
            this.AttTabela.TabIndex = 21;
            this.AttTabela.Text = "Atualizar Tabela";
            this.AttTabela.UseVisualStyleBackColor = true;
            this.AttTabela.Click += new System.EventHandler(this.button1_Click);
            // 
            // pessoaBindingSource
            // 
            this.pessoaBindingSource.DataSource = typeof(Registro.Entities.Pessoa);
            this.pessoaBindingSource.CurrentChanged += new System.EventHandler(this.pessoaBindingSource_CurrentChanged);
            // 
            // pessoaBindingSource1
            // 
            this.pessoaBindingSource1.DataSource = typeof(Registro.Entities.Pessoa);
            // 
            // pessoasBindingSource
            // 
            this.pessoasBindingSource.DataSource = typeof(Registro.Entities.Pessoas);
            this.pessoasBindingSource.CurrentChanged += new System.EventHandler(this.pessoasBindingSource_CurrentChanged);
            // 
            // pessoasBindingSource1
            // 
            this.pessoasBindingSource1.DataSource = typeof(Registro.Entities.Pessoas);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 308);
            this.Controls.Add(this.AttTabela);
            this.Controls.Add(this.Pegar);
            this.Controls.Add(this.Deletar);
            this.Controls.Add(this.Atualizar);
            this.Controls.Add(this.Nascimento);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Pesquisar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Pesquisa);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pessoasBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.TextBox Telefone;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.TextBox Pesquisa;
        private System.Windows.Forms.BindingSource pessoasBindingSource;
        private System.Windows.Forms.BindingSource pessoaBindingSource;
        private System.Windows.Forms.BindingSource pessoasBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Pesquisar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CPF;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.BindingSource pessoaBindingSource1;
        private System.Windows.Forms.DateTimePicker Nascimento;
        private System.Windows.Forms.Button Atualizar;
        private System.Windows.Forms.Button Deletar;
        private System.Windows.Forms.Button Pegar;
        private System.Windows.Forms.Button AttTabela;
    }
}

