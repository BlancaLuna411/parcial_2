namespace parcial_2.Formularios
{
    partial class Unidad
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
            this.TXTDESC = new System.Windows.Forms.TextBox();
            this.TXTID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNELIM = new System.Windows.Forms.Button();
            this.BTNACT = new System.Windows.Forms.Button();
            this.BTNREG = new System.Windows.Forms.Button();
            this.BTNBUSCAR = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uNIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNDESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNIDADBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENTASDataSet7 = new parcial_2.VENTASDataSet7();
            this.uNIDADTableAdapter = new parcial_2.VENTASDataSet7TableAdapters.UNIDADTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNIDADBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTDESC
            // 
            this.TXTDESC.Location = new System.Drawing.Point(208, 71);
            this.TXTDESC.Margin = new System.Windows.Forms.Padding(2);
            this.TXTDESC.Multiline = true;
            this.TXTDESC.Name = "TXTDESC";
            this.TXTDESC.Size = new System.Drawing.Size(194, 32);
            this.TXTDESC.TabIndex = 10;
            // 
            // TXTID
            // 
            this.TXTID.Location = new System.Drawing.Point(271, 26);
            this.TXTID.Margin = new System.Windows.Forms.Padding(2);
            this.TXTID.Name = "TXTID";
            this.TXTID.Size = new System.Drawing.Size(68, 20);
            this.TXTID.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "DESCRIPCION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Unidad";
            // 
            // BTNELIM
            // 
            this.BTNELIM.Location = new System.Drawing.Point(546, 185);
            this.BTNELIM.Margin = new System.Windows.Forms.Padding(2);
            this.BTNELIM.Name = "BTNELIM";
            this.BTNELIM.Size = new System.Drawing.Size(87, 29);
            this.BTNELIM.TabIndex = 60;
            this.BTNELIM.Text = "Eliminar";
            this.BTNELIM.UseVisualStyleBackColor = true;
            this.BTNELIM.Click += new System.EventHandler(this.BTNELIM_Click);
            // 
            // BTNACT
            // 
            this.BTNACT.Location = new System.Drawing.Point(546, 133);
            this.BTNACT.Margin = new System.Windows.Forms.Padding(2);
            this.BTNACT.Name = "BTNACT";
            this.BTNACT.Size = new System.Drawing.Size(87, 29);
            this.BTNACT.TabIndex = 59;
            this.BTNACT.Text = "Actualizar";
            this.BTNACT.UseVisualStyleBackColor = true;
            // 
            // BTNREG
            // 
            this.BTNREG.Location = new System.Drawing.Point(546, 74);
            this.BTNREG.Margin = new System.Windows.Forms.Padding(2);
            this.BTNREG.Name = "BTNREG";
            this.BTNREG.Size = new System.Drawing.Size(87, 29);
            this.BTNREG.TabIndex = 58;
            this.BTNREG.Text = "Registrar ";
            this.BTNREG.UseVisualStyleBackColor = true;
            this.BTNREG.Click += new System.EventHandler(this.BTNREG_Click);
            // 
            // BTNBUSCAR
            // 
            this.BTNBUSCAR.Location = new System.Drawing.Point(546, 21);
            this.BTNBUSCAR.Margin = new System.Windows.Forms.Padding(2);
            this.BTNBUSCAR.Name = "BTNBUSCAR";
            this.BTNBUSCAR.Size = new System.Drawing.Size(87, 29);
            this.BTNBUSCAR.TabIndex = 57;
            this.BTNBUSCAR.Text = "Buscar";
            this.BTNBUSCAR.UseVisualStyleBackColor = true;
            this.BTNBUSCAR.Click += new System.EventHandler(this.BTNBUSCAR_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uNIDDataGridViewTextBoxColumn,
            this.uNDESCRIPCIONDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uNIDADBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(177, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(251, 177);
            this.dataGridView1.TabIndex = 61;
            // 
            // uNIDDataGridViewTextBoxColumn
            // 
            this.uNIDDataGridViewTextBoxColumn.DataPropertyName = "UN_ID";
            this.uNIDDataGridViewTextBoxColumn.HeaderText = "UN_ID";
            this.uNIDDataGridViewTextBoxColumn.Name = "uNIDDataGridViewTextBoxColumn";
            // 
            // uNDESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.uNDESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "UN_DESCRIPCION";
            this.uNDESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "UN_DESCRIPCION";
            this.uNDESCRIPCIONDataGridViewTextBoxColumn.Name = "uNDESCRIPCIONDataGridViewTextBoxColumn";
            // 
            // uNIDADBindingSource
            // 
            this.uNIDADBindingSource.DataMember = "UNIDAD";
            this.uNIDADBindingSource.DataSource = this.vENTASDataSet7;
            // 
            // vENTASDataSet7
            // 
            this.vENTASDataSet7.DataSetName = "VENTASDataSet7";
            this.vENTASDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uNIDADTableAdapter
            // 
            this.uNIDADTableAdapter.ClearBeforeFill = true;
            // 
            // Unidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(651, 340);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTNELIM);
            this.Controls.Add(this.BTNACT);
            this.Controls.Add(this.BTNREG);
            this.Controls.Add(this.BTNBUSCAR);
            this.Controls.Add(this.TXTDESC);
            this.Controls.Add(this.TXTID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Unidad";
            this.Text = "Unidad";
            this.Load += new System.EventHandler(this.Unidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uNIDADBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TXTDESC;
        private System.Windows.Forms.TextBox TXTID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTNELIM;
        private System.Windows.Forms.Button BTNACT;
        private System.Windows.Forms.Button BTNREG;
        private System.Windows.Forms.Button BTNBUSCAR;
        private System.Windows.Forms.DataGridView dataGridView1;
        private VENTASDataSet7 vENTASDataSet7;
        private System.Windows.Forms.BindingSource uNIDADBindingSource;
        private VENTASDataSet7TableAdapters.UNIDADTableAdapter uNIDADTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNDESCRIPCIONDataGridViewTextBoxColumn;
    }
}