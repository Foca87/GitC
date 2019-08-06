namespace MVCProject.View
{
    partial class frmLivros
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
            this.dgvLivros = new System.Windows.Forms.DataGridView();
            this.gridButtonDeletar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gridButtonEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generosTipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editorasNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sinopseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usuIncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuAltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datIncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datAltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.livrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaBibliotecaDBDataSet = new MVCProject.SistemaBibliotecaDBDataSet();
            this.livrosTableAdapter = new MVCProject.SistemaBibliotecaDBDataSetTableAdapters.LivrosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(13, 7);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(775, 47);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "ADICIONAR";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // dgvLivros
            // 
            this.dgvLivros.AllowUserToAddRows = false;
            this.dgvLivros.AllowUserToDeleteRows = false;
            this.dgvLivros.AutoGenerateColumns = false;
            this.dgvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridButtonDeletar,
            this.gridButtonEditar,
            this.idDataGridViewTextBoxColumn,
            this.registroDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.isbnDataGridViewTextBoxColumn,
            this.generosTipoDataGridViewTextBoxColumn,
            this.editorasNomeDataGridViewTextBoxColumn,
            this.sinopseDataGridViewTextBoxColumn,
            this.observacoesDataGridViewTextBoxColumn,
            this.ativoDataGridViewCheckBoxColumn,
            this.usuIncDataGridViewTextBoxColumn,
            this.usuAltDataGridViewTextBoxColumn,
            this.datIncDataGridViewTextBoxColumn,
            this.datAltDataGridViewTextBoxColumn});
            this.dgvLivros.DataSource = this.livrosBindingSource;
            this.dgvLivros.Location = new System.Drawing.Point(0, 73);
            this.dgvLivros.Name = "dgvLivros";
            this.dgvLivros.ReadOnly = true;
            this.dgvLivros.RowHeadersWidth = 51;
            this.dgvLivros.RowTemplate.Height = 24;
            this.dgvLivros.Size = new System.Drawing.Size(800, 371);
            this.dgvLivros.TabIndex = 2;
            this.dgvLivros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLivros_CellContentClick);
            // 
            // gridButtonDeletar
            // 
            this.gridButtonDeletar.DataPropertyName = "Deletar";
            this.gridButtonDeletar.HeaderText = "Deletar";
            this.gridButtonDeletar.MinimumWidth = 6;
            this.gridButtonDeletar.Name = "gridButtonDeletar";
            this.gridButtonDeletar.ReadOnly = true;
            this.gridButtonDeletar.Text = "Deletar";
            this.gridButtonDeletar.UseColumnTextForButtonValue = true;
            this.gridButtonDeletar.Width = 125;
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
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // registroDataGridViewTextBoxColumn
            // 
            this.registroDataGridViewTextBoxColumn.DataPropertyName = "Registro";
            this.registroDataGridViewTextBoxColumn.HeaderText = "Registro";
            this.registroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.registroDataGridViewTextBoxColumn.Name = "registroDataGridViewTextBoxColumn";
            this.registroDataGridViewTextBoxColumn.ReadOnly = true;
            this.registroDataGridViewTextBoxColumn.Width = 125;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.ReadOnly = true;
            this.tituloDataGridViewTextBoxColumn.Width = 125;
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            this.isbnDataGridViewTextBoxColumn.DataPropertyName = "Isbn";
            this.isbnDataGridViewTextBoxColumn.HeaderText = "Isbn";
            this.isbnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            this.isbnDataGridViewTextBoxColumn.ReadOnly = true;
            this.isbnDataGridViewTextBoxColumn.Width = 125;
            // 
            // generosTipoDataGridViewTextBoxColumn
            // 
            this.generosTipoDataGridViewTextBoxColumn.DataPropertyName = "Generos.Tipo";
            this.generosTipoDataGridViewTextBoxColumn.HeaderText = "Gêneros";
            this.generosTipoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.generosTipoDataGridViewTextBoxColumn.Name = "generosTipoDataGridViewTextBoxColumn";
            this.generosTipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.generosTipoDataGridViewTextBoxColumn.Width = 125;
            // 
            // editorasNomeDataGridViewTextBoxColumn
            // 
            this.editorasNomeDataGridViewTextBoxColumn.DataPropertyName = "Editoras.Nome";
            this.editorasNomeDataGridViewTextBoxColumn.HeaderText = "Editora";
            this.editorasNomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.editorasNomeDataGridViewTextBoxColumn.Name = "editorasNomeDataGridViewTextBoxColumn";
            this.editorasNomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.editorasNomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // sinopseDataGridViewTextBoxColumn
            // 
            this.sinopseDataGridViewTextBoxColumn.DataPropertyName = "Sinopse";
            this.sinopseDataGridViewTextBoxColumn.HeaderText = "Sinopse";
            this.sinopseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sinopseDataGridViewTextBoxColumn.Name = "sinopseDataGridViewTextBoxColumn";
            this.sinopseDataGridViewTextBoxColumn.ReadOnly = true;
            this.sinopseDataGridViewTextBoxColumn.Width = 125;
            // 
            // observacoesDataGridViewTextBoxColumn
            // 
            this.observacoesDataGridViewTextBoxColumn.DataPropertyName = "Observacoes";
            this.observacoesDataGridViewTextBoxColumn.HeaderText = "Observacoes";
            this.observacoesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.observacoesDataGridViewTextBoxColumn.Name = "observacoesDataGridViewTextBoxColumn";
            this.observacoesDataGridViewTextBoxColumn.ReadOnly = true;
            this.observacoesDataGridViewTextBoxColumn.Width = 125;
            // 
            // ativoDataGridViewCheckBoxColumn
            // 
            this.ativoDataGridViewCheckBoxColumn.DataPropertyName = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.HeaderText = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.ativoDataGridViewCheckBoxColumn.Name = "ativoDataGridViewCheckBoxColumn";
            this.ativoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.ativoDataGridViewCheckBoxColumn.Width = 125;
            // 
            // usuIncDataGridViewTextBoxColumn
            // 
            this.usuIncDataGridViewTextBoxColumn.DataPropertyName = "UsuInc";
            this.usuIncDataGridViewTextBoxColumn.HeaderText = "UsuInc";
            this.usuIncDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usuIncDataGridViewTextBoxColumn.Name = "usuIncDataGridViewTextBoxColumn";
            this.usuIncDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuIncDataGridViewTextBoxColumn.Width = 125;
            // 
            // usuAltDataGridViewTextBoxColumn
            // 
            this.usuAltDataGridViewTextBoxColumn.DataPropertyName = "UsuAlt";
            this.usuAltDataGridViewTextBoxColumn.HeaderText = "UsuAlt";
            this.usuAltDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usuAltDataGridViewTextBoxColumn.Name = "usuAltDataGridViewTextBoxColumn";
            this.usuAltDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuAltDataGridViewTextBoxColumn.Width = 125;
            // 
            // datIncDataGridViewTextBoxColumn
            // 
            this.datIncDataGridViewTextBoxColumn.DataPropertyName = "DatInc";
            this.datIncDataGridViewTextBoxColumn.HeaderText = "DatInc";
            this.datIncDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datIncDataGridViewTextBoxColumn.Name = "datIncDataGridViewTextBoxColumn";
            this.datIncDataGridViewTextBoxColumn.ReadOnly = true;
            this.datIncDataGridViewTextBoxColumn.Width = 125;
            // 
            // datAltDataGridViewTextBoxColumn
            // 
            this.datAltDataGridViewTextBoxColumn.DataPropertyName = "DatAlt";
            this.datAltDataGridViewTextBoxColumn.HeaderText = "DatAlt";
            this.datAltDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datAltDataGridViewTextBoxColumn.Name = "datAltDataGridViewTextBoxColumn";
            this.datAltDataGridViewTextBoxColumn.ReadOnly = true;
            this.datAltDataGridViewTextBoxColumn.Width = 125;
            // 
            // livrosBindingSource
            // 
            this.livrosBindingSource.DataMember = "Livros";
            this.livrosBindingSource.DataSource = this.sistemaBibliotecaDBDataSet;
            // 
            // sistemaBibliotecaDBDataSet
            // 
            this.sistemaBibliotecaDBDataSet.DataSetName = "SistemaBibliotecaDBDataSet";
            this.sistemaBibliotecaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // livrosTableAdapter
            // 
            this.livrosTableAdapter.ClearBeforeFill = true;
            // 
            // frmLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dgvLivros);
            this.Name = "frmLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Livros";
            this.Load += new System.EventHandler(this.FrmLivros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dgvLivros;
        private SistemaBibliotecaDBDataSet sistemaBibliotecaDBDataSet;
        private System.Windows.Forms.BindingSource livrosBindingSource;
        private SistemaBibliotecaDBDataSetTableAdapters.LivrosTableAdapter livrosTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn gridButtonDeletar;
        private System.Windows.Forms.DataGridViewButtonColumn gridButtonEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generosTipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editorasNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinopseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ativoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuIncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuAltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datIncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datAltDataGridViewTextBoxColumn;
    }
}