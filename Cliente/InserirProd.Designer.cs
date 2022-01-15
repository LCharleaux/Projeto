
namespace Cliente
{
    partial class InserirProd
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
            this.selecionar = new System.Windows.Forms.Button();
            this.DgvDados = new System.Windows.Forms.DataGridView();
            this.salvar = new System.Windows.Forms.Button();
            this.listar = new System.Windows.Forms.Button();
            this.excluir = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_codprod = new System.Windows.Forms.TextBox();
            this.CodCli = new System.Windows.Forms.Label();
            this.txt_produto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // selecionar
            // 
            this.selecionar.Location = new System.Drawing.Point(149, 475);
            this.selecionar.Name = "selecionar";
            this.selecionar.Size = new System.Drawing.Size(96, 34);
            this.selecionar.TabIndex = 28;
            this.selecionar.Text = "Pesquisar";
            this.selecionar.UseVisualStyleBackColor = true;
            this.selecionar.Click += new System.EventHandler(this.selecionar_Click);
            // 
            // DgvDados
            // 
            this.DgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDados.Location = new System.Drawing.Point(471, 48);
            this.DgvDados.Name = "DgvDados";
            this.DgvDados.RowTemplate.Height = 25;
            this.DgvDados.Size = new System.Drawing.Size(487, 403);
            this.DgvDados.TabIndex = 27;
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(183, 274);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(109, 30);
            this.salvar.TabIndex = 26;
            this.salvar.Text = "Adicionar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // listar
            // 
            this.listar.Location = new System.Drawing.Point(408, 475);
            this.listar.Name = "listar";
            this.listar.Size = new System.Drawing.Size(96, 34);
            this.listar.TabIndex = 25;
            this.listar.Text = "Listar";
            this.listar.UseVisualStyleBackColor = true;
            this.listar.Click += new System.EventHandler(this.listar_Click);
            // 
            // excluir
            // 
            this.excluir.Location = new System.Drawing.Point(277, 475);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(96, 34);
            this.excluir.TabIndex = 24;
            this.excluir.Text = "Excluir";
            this.excluir.UseVisualStyleBackColor = true;
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(26, 475);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(96, 34);
            this.editar.TabIndex = 23;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Valor Unitário";
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Location = new System.Drawing.Point(127, 148);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(287, 23);
            this.txt_quantidade.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 20;
            this.label3.Text = "Quantidade";
            // 
            // txt_codprod
            // 
            this.txt_codprod.Location = new System.Drawing.Point(127, 94);
            this.txt_codprod.Name = "txt_codprod";
            this.txt_codprod.Size = new System.Drawing.Size(287, 23);
            this.txt_codprod.TabIndex = 19;
            // 
            // CodCli
            // 
            this.CodCli.AutoSize = true;
            this.CodCli.Location = new System.Drawing.Point(26, 102);
            this.CodCli.Name = "CodCli";
            this.CodCli.Size = new System.Drawing.Size(92, 15);
            this.CodCli.TabIndex = 18;
            this.CodCli.Text = "Código Produto";
            // 
            // txt_produto
            // 
            this.txt_produto.Location = new System.Drawing.Point(127, 48);
            this.txt_produto.Name = "txt_produto";
            this.txt_produto.Size = new System.Drawing.Size(287, 23);
            this.txt_produto.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nome";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(127, 199);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(100, 23);
            this.txt_valor.TabIndex = 29;
            // 
            // InserirProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 557);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.selecionar);
            this.Controls.Add(this.DgvDados);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.listar);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_quantidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_codprod);
            this.Controls.Add(this.CodCli);
            this.Controls.Add(this.txt_produto);
            this.Controls.Add(this.label1);
            this.Name = "InserirProd";
            this.Text = "InserirProd";
            ((System.ComponentModel.ISupportInitialize)(this.DgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button selecionar;
        private System.Windows.Forms.DataGridView DgvDados;
        private System.Windows.Forms.Button salvar;
        private System.Windows.Forms.Button listar;
        private System.Windows.Forms.Button excluir;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_codprod;
        private System.Windows.Forms.Label CodCli;
        private System.Windows.Forms.TextBox txt_produto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_valor;
    }
}