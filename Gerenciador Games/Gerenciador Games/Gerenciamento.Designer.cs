namespace Gerenciador_Games
{
    partial class Gerenciamento
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
            lblTitulo = new Label();
            txtTitulo = new TextBox();
            txtGenero = new TextBox();
            lblGenero = new Label();
            textBox3 = new TextBox();
            lblPlataforma = new Label();
            txtValor = new TextBox();
            lblValor = new Label();
            txtAvaliacao = new TextBox();
            lblAvaliacao = new Label();
            btnSalvareFechar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(56, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Título";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(116, 9);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(319, 31);
            txtTitulo.TabIndex = 1;
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(116, 59);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(319, 31);
            txtGenero.TabIndex = 3;
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(12, 59);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(69, 25);
            lblGenero.TabIndex = 2;
            lblGenero.Text = "Gênero";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(116, 107);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(319, 31);
            textBox3.TabIndex = 5;
            // 
            // lblPlataforma
            // 
            lblPlataforma.AutoSize = true;
            lblPlataforma.Location = new Point(12, 107);
            lblPlataforma.Name = "lblPlataforma";
            lblPlataforma.Size = new Size(98, 25);
            lblPlataforma.TabIndex = 4;
            lblPlataforma.Text = "Plataforma";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(116, 164);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(319, 31);
            txtValor.TabIndex = 7;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(12, 161);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(52, 25);
            lblValor.TabIndex = 6;
            lblValor.Text = "Valor";
            // 
            // txtAvaliacao
            // 
            txtAvaliacao.Location = new Point(116, 216);
            txtAvaliacao.Name = "txtAvaliacao";
            txtAvaliacao.Size = new Size(319, 31);
            txtAvaliacao.TabIndex = 9;
            // 
            // lblAvaliacao
            // 
            lblAvaliacao.AutoSize = true;
            lblAvaliacao.Location = new Point(12, 216);
            lblAvaliacao.Name = "lblAvaliacao";
            lblAvaliacao.Size = new Size(87, 25);
            lblAvaliacao.TabIndex = 8;
            lblAvaliacao.Text = "Avaliação";
            // 
            // btnSalvareFechar
            // 
            btnSalvareFechar.Location = new Point(12, 265);
            btnSalvareFechar.Name = "btnSalvareFechar";
            btnSalvareFechar.Size = new Size(423, 86);
            btnSalvareFechar.TabIndex = 10;
            btnSalvareFechar.Text = "Salvar e Fechar";
            btnSalvareFechar.UseVisualStyleBackColor = true;
            // 
            // Gerenciamento
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 375);
            Controls.Add(btnSalvareFechar);
            Controls.Add(txtAvaliacao);
            Controls.Add(lblAvaliacao);
            Controls.Add(txtValor);
            Controls.Add(lblValor);
            Controls.Add(textBox3);
            Controls.Add(lblPlataforma);
            Controls.Add(txtGenero);
            Controls.Add(lblGenero);
            Controls.Add(txtTitulo);
            Controls.Add(lblTitulo);
            Name = "Gerenciamento";
            Text = "Gerenciamento";
            Load += Gerenciamento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtTitulo;
        private TextBox txtGenero;
        private Label lblGenero;
        private TextBox textBox3;
        private Label lblPlataforma;
        private TextBox txtValor;
        private Label lblValor;
        private TextBox txtAvaliacao;
        private Label lblAvaliacao;
        private Button btnSalvareFechar;
    }
}