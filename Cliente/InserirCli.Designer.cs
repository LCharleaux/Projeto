
namespace Cliente
{
    partial class InserirCli
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.CodCli = new System.Windows.Forms.Label();
            this.txt_codcli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.editar = new System.Windows.Forms.Button();
            this.excluir = new System.Windows.Forms.Button();
            this.listar = new System.Windows.Forms.Button();
            this.salvar = new System.Windows.Forms.Button();
            this.DgvDados = new System.Windows.Forms.DataGridView();
            this.selecionar = new System.Windows.Forms.Button();
            this.txt_telefone = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(100, 40);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(287, 23);
            this.txt_nome.TabIndex = 1;
            // 
            // CodCli
            // 
            this.CodCli.AutoSize = true;
            this.CodCli.Location = new System.Drawing.Point(40, 94);
            this.CodCli.Name = "CodCli";
            this.CodCli.Size = new System.Drawing.Size(86, 15);
            this.CodCli.TabIndex = 2;
            this.CodCli.Text = "Código Cliente";
            // 
            // txt_codcli
            // 
            this.txt_codcli.Location = new System.Drawing.Point(141, 86);
            this.txt_codcli.Name = "txt_codcli";
            this.txt_codcli.Size = new System.Drawing.Size(246, 23);
            this.txt_codcli.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF";
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(100, 143);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(287, 23);
            this.txt_cpf.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tel";
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(40, 467);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(96, 34);
            this.editar.TabIndex = 9;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // excluir
            // 
            this.excluir.Location = new System.Drawing.Point(291, 467);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(96, 34);
            this.excluir.TabIndex = 10;
            this.excluir.Text = "Excluir";
            this.excluir.UseVisualStyleBackColor = true;
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // listar
            // 
            this.listar.Location = new System.Drawing.Point(422, 467);
            this.listar.Name = "listar";
            this.listar.Size = new System.Drawing.Size(96, 34);
            this.listar.TabIndex = 11;
            this.listar.Text = "Listar";
            this.listar.UseVisualStyleBackColor = true;
            this.listar.Click += new System.EventHandler(this.listar_Click);
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(141, 264);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(75, 23);
            this.salvar.TabIndex = 12;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // DgvDados
            // 
            this.DgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDados.Location = new System.Drawing.Point(485, 40);
            this.DgvDados.Name = "DgvDados";
            this.DgvDados.RowTemplate.Height = 25;
            this.DgvDados.Size = new System.Drawing.Size(487, 403);
            this.DgvDados.TabIndex = 13;
            // 
            // selecionar
            // 
            this.selecionar.Location = new System.Drawing.Point(163, 467);
            this.selecionar.Name = "selecionar";
            this.selecionar.Size = new System.Drawing.Size(96, 34);
            this.selecionar.TabIndex = 14;
            this.selecionar.Text = "Selecionar";
            this.selecionar.UseVisualStyleBackColor = true;
            this.selecionar.Click += new System.EventHandler(this.selecionar_Click);
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(100, 197);
            this.txt_telefone.Mask = "(00) 0000-0000";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(150, 23);
            this.txt_telefone.TabIndex = 15;
            // 
            // Inserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 557);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.selecionar);
            this.Controls.Add(this.DgvDados);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.listar);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_codcli);
            this.Controls.Add(this.CodCli);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label1);
            this.Name = "Inserir";
            this.Text = "Inserir";
            this.Load += new System.EventHandler(this.Inserir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label CodCli;
        private System.Windows.Forms.TextBox txt_codcli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button excluir;
        private System.Windows.Forms.Button listar;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.DataGridView DgvDados;
        private System.Windows.Forms.Button selecionar;
        private System.Windows.Forms.MaskedTextBox txt_telefone;
    }
}