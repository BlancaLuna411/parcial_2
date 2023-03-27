namespace parcial_2.Formularios
{
    partial class Existencias
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
            this.vENTASDataSet9BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENTASDataSet9 = new parcial_2.VENTASDataSet9();
            this.vENTASDataSet10 = new parcial_2.VENTASDataSet10();
            this.vENTASDataSet10BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vENTASDataSet11 = new parcial_2.VENTASDataSet11();
            this.vENTASDataSet11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet9BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet10BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet11BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(202, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(326, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // vENTASDataSet9BindingSource
            // 
            this.vENTASDataSet9BindingSource.DataSource = this.vENTASDataSet9;
            this.vENTASDataSet9BindingSource.Position = 0;
            // 
            // vENTASDataSet9
            // 
            this.vENTASDataSet9.DataSetName = "VENTASDataSet9";
            this.vENTASDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vENTASDataSet10
            // 
            this.vENTASDataSet10.DataSetName = "VENTASDataSet10";
            this.vENTASDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vENTASDataSet10BindingSource
            // 
            this.vENTASDataSet10BindingSource.DataSource = this.vENTASDataSet10;
            this.vENTASDataSet10BindingSource.Position = 0;
            // 
            // vENTASDataSet11
            // 
            this.vENTASDataSet11.DataSetName = "VENTASDataSet11";
            this.vENTASDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vENTASDataSet11BindingSource
            // 
            this.vENTASDataSet11BindingSource.DataSource = this.vENTASDataSet11;
            this.vENTASDataSet11BindingSource.Position = 0;
            // 
            // Existencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Existencias";
            this.Text = "Existencias";
            this.Load += new System.EventHandler(this.Existencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet9BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet10BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENTASDataSet11BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource vENTASDataSet9BindingSource;
        private VENTASDataSet9 vENTASDataSet9;
        private System.Windows.Forms.BindingSource vENTASDataSet10BindingSource;
        private VENTASDataSet10 vENTASDataSet10;
        private System.Windows.Forms.BindingSource vENTASDataSet11BindingSource;
        private VENTASDataSet11 vENTASDataSet11;
    }
}