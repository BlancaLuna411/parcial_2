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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTNOM = new System.Windows.Forms.TextBox();
            this.TXTID = new System.Windows.Forms.TextBox();
            this.BTNBUSCAR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTNREG = new System.Windows.Forms.Button();
            this.BTNACT = new System.Windows.Forms.Button();
            this.BTNELIM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 42);
            this.label3.TabIndex = 11;
            this.label3.Text = "Almacen";
            // 
            // TXTNOM
            // 
            this.TXTNOM.Location = new System.Drawing.Point(450, 97);
            this.TXTNOM.Name = "TXTNOM";
            this.TXTNOM.Size = new System.Drawing.Size(100, 26);
            this.TXTNOM.TabIndex = 10;
            // 
            // TXTID
            // 
            this.TXTID.Location = new System.Drawing.Point(132, 97);
            this.TXTID.Name = "TXTID";
            this.TXTID.Size = new System.Drawing.Size(100, 26);
            this.TXTID.TabIndex = 9;
            // 
            // BTNBUSCAR
            // 
            this.BTNBUSCAR.Location = new System.Drawing.Point(36, 192);
            this.BTNBUSCAR.Name = "BTNBUSCAR";
            this.BTNBUSCAR.Size = new System.Drawing.Size(134, 54);
            this.BTNBUSCAR.TabIndex = 8;
            this.BTNBUSCAR.Text = "Buscar";
            this.BTNBUSCAR.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID";
            // 
            // BTNREG
            // 
            this.BTNREG.Location = new System.Drawing.Point(190, 192);
            this.BTNREG.Name = "BTNREG";
            this.BTNREG.Size = new System.Drawing.Size(134, 54);
            this.BTNREG.TabIndex = 12;
            this.BTNREG.Text = "Registrar";
            this.BTNREG.UseVisualStyleBackColor = true;
            // 
            // BTNACT
            // 
            this.BTNACT.Location = new System.Drawing.Point(357, 192);
            this.BTNACT.Name = "BTNACT";
            this.BTNACT.Size = new System.Drawing.Size(134, 54);
            this.BTNACT.TabIndex = 13;
            this.BTNACT.Text = "Actualizar";
            this.BTNACT.UseVisualStyleBackColor = true;
            // 
            // BTNELIM
            // 
            this.BTNELIM.Location = new System.Drawing.Point(532, 192);
            this.BTNELIM.Name = "BTNELIM";
            this.BTNELIM.Size = new System.Drawing.Size(134, 54);
            this.BTNELIM.TabIndex = 14;
            this.BTNELIM.Text = "Eliminar";
            this.BTNELIM.UseVisualStyleBackColor = true;
            // 
            // Almacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(731, 321);
            this.Controls.Add(this.BTNELIM);
            this.Controls.Add(this.BTNACT);
            this.Controls.Add(this.BTNREG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTNOM);
            this.Controls.Add(this.TXTID);
            this.Controls.Add(this.BTNBUSCAR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Almacen";
            this.Text = "Almacen.Fm1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTNOM;
        private System.Windows.Forms.TextBox TXTID;
        private System.Windows.Forms.Button BTNBUSCAR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTNREG;
        private System.Windows.Forms.Button BTNACT;
        private System.Windows.Forms.Button BTNELIM;
    }
}

