namespace DataGridViewExample
{
    partial class Lixeira
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lixeiraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.querysInnerJoinDataSet1 = new DataGridViewExample.QuerysInnerJoinDataSet1();
            this.lixeiraTableAdapter = new DataGridViewExample.QuerysInnerJoinDataSet1TableAdapters.LixeiraTableAdapter();
            this.carrosTableAdapter1 = new DataGridViewExample.QuerysInnerJoinDataSet1TableAdapters.CarrosTableAdapter();
            this.marcasTableAdapter1 = new DataGridViewExample.QuerysInnerJoinDataSet1TableAdapters.MarcasTableAdapter();
            this.usuariosTableAdapter1 = new DataGridViewExample.QuerysInnerJoinDataSet1TableAdapters.UsuariosTableAdapter();
            this.vendasTableAdapter1 = new DataGridViewExample.QuerysInnerJoinDataSet1TableAdapters.VendasTableAdapter();
            this.RecoverCommand = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabelaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lixeiraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.querysInnerJoinDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RecoverCommand,
            this.idDataGridViewTextBoxColumn,
            this.tabelaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lixeiraBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // lixeiraBindingSource
            // 
            this.lixeiraBindingSource.DataMember = "Lixeira";
            this.lixeiraBindingSource.DataSource = this.querysInnerJoinDataSet1;
            // 
            // querysInnerJoinDataSet1
            // 
            this.querysInnerJoinDataSet1.DataSetName = "QuerysInnerJoinDataSet1";
            this.querysInnerJoinDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lixeiraTableAdapter
            // 
            this.lixeiraTableAdapter.ClearBeforeFill = true;
            // 
            // carrosTableAdapter1
            // 
            this.carrosTableAdapter1.ClearBeforeFill = true;
            // 
            // marcasTableAdapter1
            // 
            this.marcasTableAdapter1.ClearBeforeFill = true;
            // 
            // usuariosTableAdapter1
            // 
            this.usuariosTableAdapter1.ClearBeforeFill = true;
            // 
            // vendasTableAdapter1
            // 
            this.vendasTableAdapter1.ClearBeforeFill = true;
            // 
            // RecoverCommand
            // 
            this.RecoverCommand.DataPropertyName = "RecoverCommand";
            this.RecoverCommand.HeaderText = "Restaurar";
            this.RecoverCommand.MinimumWidth = 6;
            this.RecoverCommand.Name = "RecoverCommand";
            this.RecoverCommand.ReadOnly = true;
            this.RecoverCommand.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RecoverCommand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.RecoverCommand.Text = "Restaurar";
            this.RecoverCommand.UseColumnTextForButtonValue = true;
            this.RecoverCommand.Width = 125;
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
            // tabelaDataGridViewTextBoxColumn
            // 
            this.tabelaDataGridViewTextBoxColumn.DataPropertyName = "Tabela";
            this.tabelaDataGridViewTextBoxColumn.HeaderText = "Tabela";
            this.tabelaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tabelaDataGridViewTextBoxColumn.Name = "tabelaDataGridViewTextBoxColumn";
            this.tabelaDataGridViewTextBoxColumn.ReadOnly = true;
            this.tabelaDataGridViewTextBoxColumn.Width = 125;
            // 
            // Lixeira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Lixeira";
            this.Text = "Lixeira";
            this.Load += new System.EventHandler(this.Lixeira_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lixeiraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.querysInnerJoinDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private QuerysInnerJoinDataSet1 querysInnerJoinDataSet1;
        private System.Windows.Forms.BindingSource lixeiraBindingSource;
        private QuerysInnerJoinDataSet1TableAdapters.LixeiraTableAdapter lixeiraTableAdapter;
        private QuerysInnerJoinDataSet1TableAdapters.CarrosTableAdapter carrosTableAdapter1;
        private QuerysInnerJoinDataSet1TableAdapters.MarcasTableAdapter marcasTableAdapter1;
        private QuerysInnerJoinDataSet1TableAdapters.UsuariosTableAdapter usuariosTableAdapter1;
        private QuerysInnerJoinDataSet1TableAdapters.VendasTableAdapter vendasTableAdapter1;
        private System.Windows.Forms.DataGridViewButtonColumn RecoverCommand;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tabelaDataGridViewTextBoxColumn;
    }
}