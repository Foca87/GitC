namespace CadastroDeAlunos
{
    partial class CadastroAluno
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
            this.labelNome = new System.Windows.Forms.Label();
            this.labelIdade = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.numericUpDownIdade = new System.Windows.Forms.NumericUpDown();
            this.buttonRegistrarAluno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdade)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(12, 15);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(159, 58);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome";
            // 
            // labelIdade
            // 
            this.labelIdade.AutoSize = true;
            this.labelIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdade.Location = new System.Drawing.Point(12, 91);
            this.labelIdade.Name = "labelIdade";
            this.labelIdade.Size = new System.Drawing.Size(151, 58);
            this.labelIdade.TabIndex = 1;
            this.labelIdade.Text = "Idade";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(177, 12);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(385, 64);
            this.textBoxNome.TabIndex = 2;
            // 
            // numericUpDownIdade
            // 
            this.numericUpDownIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownIdade.Location = new System.Drawing.Point(177, 89);
            this.numericUpDownIdade.Name = "numericUpDownIdade";
            this.numericUpDownIdade.Size = new System.Drawing.Size(385, 64);
            this.numericUpDownIdade.TabIndex = 3;
            // 
            // buttonRegistrarAluno
            // 
            this.buttonRegistrarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarAluno.Location = new System.Drawing.Point(13, 174);
            this.buttonRegistrarAluno.Name = "buttonRegistrarAluno";
            this.buttonRegistrarAluno.Size = new System.Drawing.Size(549, 109);
            this.buttonRegistrarAluno.TabIndex = 4;
            this.buttonRegistrarAluno.Text = "Registrar Aluno";
            this.buttonRegistrarAluno.UseVisualStyleBackColor = true;
            this.buttonRegistrarAluno.Click += new System.EventHandler(this.ButtonRegistrarAluno_Click);
            // 
            // CadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 295);
            this.ControlBox = false;
            this.Controls.Add(this.buttonRegistrarAluno);
            this.Controls.Add(this.numericUpDownIdade);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.labelIdade);
            this.Controls.Add(this.labelNome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroAluno";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIdade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelIdade;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.NumericUpDown numericUpDownIdade;
        private System.Windows.Forms.Button buttonRegistrarAluno;
    }
}