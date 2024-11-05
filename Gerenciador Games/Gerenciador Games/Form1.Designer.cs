namespace Gerenciador_Games
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvGerenciador = new DataGridView();
            lblClock = new Label();
            btnNovo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvGerenciador).BeginInit();
            SuspendLayout();
            // 
            // dgvGerenciador
            // 
            dgvGerenciador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGerenciador.Location = new Point(12, 12);
            dgvGerenciador.Name = "dgvGerenciador";
            dgvGerenciador.RowHeadersWidth = 62;
            dgvGerenciador.RowTemplate.Height = 33;
            dgvGerenciador.Size = new Size(933, 386);
            dgvGerenciador.TabIndex = 0;
            // 
            // lblClock
            // 
            lblClock.AutoSize = true;
            lblClock.Location = new Point(12, 409);
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(56, 25);
            lblClock.TabIndex = 1;
            lblClock.Text = "Timer";
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(823, 404);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(112, 34);
            btnNovo.TabIndex = 2;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 450);
            Controls.Add(btnNovo);
            Controls.Add(lblClock);
            Controls.Add(dgvGerenciador);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvGerenciador).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvGerenciador;
        private Label lblClock;
        private Button btnNovo;
    }
}