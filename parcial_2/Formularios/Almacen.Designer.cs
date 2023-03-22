namespace parcial_2
{
    partial class Almacen
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTNOM = new System.Windows.Forms.TextBox();
            this.TXTID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTNREG = new System.Windows.Forms.Button();
            this.BTNACT = new System.Windows.Forms.Button();
            this.BTNELIM = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aLIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLNOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aLMACENESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENTASDataSet = new parcial_2.VENTASDataSet();
            this.aLMACENESTableAdapter = new parcial_2.VENTASDataSetTableAdapters.ALMACENESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLMACENESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Almacen";
            // 
            // TXTNOM
            // 
            this.TXTNOM.Location = new System.Drawing.Point(258, 50);
            this.TXTNOM.Margin = new System.Windows.Forms.Padding(2);
            this.TXTNOM.Name = "TXTNOM";
            this.TXTNOM.Size = new System.Drawing.Size(68, 20);
            this.TXTNOM.TabIndex = 10;
            // 
            // TXTID
            // 
            this.TXTID.Location = new System.Drawing.Point(70, 50);
            this.TXTID.Margin = new System.Windows.Forms.Padding(2);
            this.TXTID.Name = "TXTID";
            this.TXTID.Size = new System.Drawing.Size(68, 20);
            this.TXTID.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID";
            // 
            // BTNREG
            // 
            this.BTNREG.Location = new System.Drawing.Point(382, 42);
            this.BTNREG.Margin = new System.Windows.Forms.Padding(2);
            this.BTNREG.Name = "BTNREG";
            this.BTNREG.Size = new System.Drawing.Size(89, 35);
            this.BTNREG.TabIndex = 12;
            this.BTNREG.Text = "Registrar";
            this.BTNREG.UseVisualStyleBackColor = true;
            this.BTNREG.Click += new System.EventHandler(this.BTNREG_Click);
            // 
            // BTNACT
            // 
            this.BTNACT.Location = new System.Drawing.Point(552, 18);
            this.BTNACT.Margin = new System.Windows.Forms.Padding(2);
            this.BTNACT.Name = "BTNACT";
            this.BTNACT.Size = new System.Drawing.Size(89, 35);
            this.BTNACT.TabIndex = 13;
            this.BTNACT.Text = "Actualizar";
            this.BTNACT.UseVisualStyleBackColor = true;
            // 
            // BTNELIM
            // 
            this.BTNELIM.Location = new System.Drawing.Point(552, 105);
            this.BTNELIM.Margin = new System.Windows.Forms.Padding(2);
            this.BTNELIM.Name = "BTNELIM";
            this.BTNELIM.Size = new System.Drawing.Size(89, 35);
            this.BTNELIM.TabIndex = 14;
            this.BTNELIM.Text = "Eliminar";
            this.BTNELIM.UseVisualStyleBackColor = true;
            this.BTNELIM.Click += new System.EventHandler(this.BTNELIM_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aLIDDataGridViewTextBoxColumn,
            this.aLNOMBREDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aLMACENESBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(70, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(371, 151);
            this.dataGridView1.TabIndex = 15;
            // 
            // aLIDDataGridViewTextBoxColumn
            // 
            this.aLIDDataGridViewTextBoxColumn.DataPropertyName = "AL_ID";
            this.aLIDDataGridViewTextBoxColumn.HeaderText = "AL_ID";
            this.aLIDDataGridViewTextBoxColumn.Name = "aLIDDataGridViewTextBoxColumn";
            // 
            // aLNOMBREDataGridViewTextBoxColumn
            // 
            this.aLNOMBREDataGridViewTextBoxColumn.DataPropertyName = "AL_NOMBRE";
            this.aLNOMBREDataGridViewTextBoxColumn.HeaderText = "AL_NOMBRE";
            this.aLNOMBREDataGridViewTextBoxColumn.Name = "aLNOMBREDataGridViewTextBoxColumn";
            // 
            // aLMACENESBindingSource
            // 
            this.aLMACENESBindingSource.DataMember = "ALMACENES";
            this.aLMACENESBindingSource.DataSource = this.vENTASDataSet;
            // 
            // vENTASDataSet
            // 
            this.vENTASDataSet.DataSetName = "VENTASDataSet";
            this.vENTASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aLMACENESTableAdapter
            // 
            this.aLMACENESTableAdapter.ClearBeforeFill = true;
            // 
            // Almacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(669, 446);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTNELIM);
            this.Controls.Add(this.BTNACT);
            this.Controls.Add(this.BTNREG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTNOM);
            this.Controls.Add(this.TXTID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Almacen";
            this.Text = "Almacen.Fm1";
            this.Load += new System.EventHandler(this.Almacen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aLMACENESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTNOM;
        private System.Windows.Forms.TextBox TXTID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTNREG;
        private System.Windows.Forms.Button BTNACT;
        private System.Windows.Forms.Button BTNELIM;
        private System.Windows.Forms.DataGridView dataGridView1;
        private VENTASDataSet vENTASDataSet;
        private System.Windows.Forms.BindingSource aLMACENESBindingSource;
        private VENTASDataSetTableAdapters.ALMACENESTableAdapter aLMACENESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aLNOMBREDataGridViewTextBoxColumn;
    }
}

