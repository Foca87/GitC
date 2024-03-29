﻿namespace DataGridViewExample.Adicao
{
    partial class frmAdicionarCarros
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
            this.components = new System.ComponentModel.Container();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpAno = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxModelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.querysInnerJoinDataSet1 = new DataGridViewExample.QuerysInnerJoinDataSet1();
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcasTableAdapter = new DataGridViewExample.QuerysInnerJoinDataSet1TableAdapters.MarcasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.querysInnerJoinDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(12, 148);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(448, 74);
            this.btnAdicionar.TabIndex = 14;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // cbxMarca
            // 
            this.cbxMarca.DataSource = this.marcasBindingSource;
            this.cbxMarca.DisplayMember = "Nome";
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(73, 103);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(387, 24);
            this.cbxMarca.TabIndex = 13;
            this.cbxMarca.ValueMember = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Marca:";
            // 
            // dtpAno
            // 
            this.dtpAno.CustomFormat = "dd/MM/yyyy";
            this.dtpAno.Location = new System.Drawing.Point(73, 56);
            this.dtpAno.Name = "dtpAno";
            this.dtpAno.Size = new System.Drawing.Size(387, 22);
            this.dtpAno.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ano:";
            // 
            // tbxModelo
            // 
            this.tbxModelo.Location = new System.Drawing.Point(73, 18);
            this.tbxModelo.Name = "tbxModelo";
            this.tbxModelo.Size = new System.Drawing.Size(387, 22);
            this.tbxModelo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Modelo:";
            // 
            // querysInnerJoinDataSet1
            // 
            this.querysInnerJoinDataSet1.DataSetName = "QuerysInnerJoinDataSet1";
            this.querysInnerJoinDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marcasBindingSource
            // 
            this.marcasBindingSource.DataMember = "Marcas";
            this.marcasBindingSource.DataSource = this.querysInnerJoinDataSet1;
            // 
            // marcasTableAdapter
            // 
            this.marcasTableAdapter.ClearBeforeFill = true;
            // 
            // frmAdicionarCarros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 242);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpAno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxModelo);
            this.Controls.Add(this.label1);
            this.Name = "frmAdicionarCarros";
            this.Text = "frmAdicionarCarros";
            this.Load += new System.EventHandler(this.FrmAdicionarCarros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.querysInnerJoinDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpAno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxModelo;
        private System.Windows.Forms.Label label1;
        private QuerysInnerJoinDataSet1 querysInnerJoinDataSet1;
        private System.Windows.Forms.BindingSource marcasBindingSource;
        private QuerysInnerJoinDataSet1TableAdapters.MarcasTableAdapter marcasTableAdapter;
    }
}