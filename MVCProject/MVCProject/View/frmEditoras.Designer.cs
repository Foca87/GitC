namespace MVCProject.View
{
    partial class frmEditoras
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
            this.dgvEditoras = new System.Windows.Forms.DataGridView();
            this.gridButtonEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.sistemaBibliotecaDBDataSet = new MVCProject.SistemaBibliotecaDBDataSet();
            this.editorasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editorasTableAdapter = new MVCProject.SistemaBibliotecaDBDataSetTableAdapters.EditorasTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(11, 6);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(775, 47);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "ADICIONAR";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // dgvEditoras
            // 
            this.dgvEditoras.AllowUserToAddRows = false;
            this.dgvEditoras.AllowUserToDeleteRows = false;
            this.dgvEditoras.AutoGenerateColumns = false;
            this.dgvEditoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditoras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridButtonEditar,
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.dgvEditoras.DataSource = this.editorasBindingSource;
            this.dgvEditoras.Location = new System.Drawing.Point(0, 73);
            this.dgvEditoras.Name = "dgvEditoras";
            this.dgvEditoras.ReadOnly = true;
            this.dgvEditoras.RowHeadersWidth = 51;
            this.dgvEditoras.RowTemplate.Height = 24;
            this.dgvEditoras.Size = new System.Drawing.Size(800, 371);
            this.dgvEditoras.TabIndex = 3;
            this.dgvEditoras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEditoras_CellContentClick);
            // 
            // gridButtonEditar
            // 
            this.gridButtonEditar.DataPropertyName = "Editar";
            this.gridButtonEditar.HeaderText = "Editar";
            this.gridButtonEditar.MinimumWidth = 6;
            this.gridButtonEditar.Name = "gridButtonEditar";
            this.gridButtonEditar.ReadOnly = true;
            this.gridButtonEditar.Text = "Editar";
            this.gridButtonEditar.UseColumnTextForButtonValue = true;
            this.gridButtonEditar.Width = 125;
            // 
            // sistemaBibliotecaDBDataSet
            // 
            this.sistemaBibliotecaDBDataSet.DataSetName = "SistemaBibliotecaDBDataSet";
            this.sistemaBibliotecaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // editorasBindingSource
            // 
            this.editorasBindingSource.DataMember = "Editoras";
            this.editorasBindingSource.DataSource = this.sistemaBibliotecaDBDataSet;
            // 
            // editorasTableAdapter
            // 
            this.editorasTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // frmEditoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dgvEditoras);
            this.Name = "frmEditoras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditoras";
            this.Load += new System.EventHandler(this.FrmEditoras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editorasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dgvEditoras;
        private System.Windows.Forms.DataGridViewButtonColumn gridButtonEditar;
        private SistemaBibliotecaDBDataSet sistemaBibliotecaDBDataSet;
        private System.Windows.Forms.BindingSource editorasBindingSource;
        private SistemaBibliotecaDBDataSetTableAdapters.EditorasTableAdapter editorasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
    }
}