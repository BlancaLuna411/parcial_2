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
            this.TXTDESC = new System.Windows.Forms.TextBox();
            this.TXTID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTNELIM = new System.Windows.Forms.Button();
            this.BTNACT = new System.Windows.Forms.Button();
            this.BTNREG = new System.Windows.Forms.Button();
            this.BTNBUSCAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXTDESC
            // 
            this.TXTDESC.Location = new System.Drawing.Point(162, 136);
            this.TXTDESC.Multiline = true;
            this.TXTDESC.Name = "TXTDESC";
            this.TXTDESC.Size = new System.Drawing.Size(607, 244);
            this.TXTDESC.TabIndex = 10;
            // 
            // TXTID
            // 
            this.TXTID.Location = new System.Drawing.Point(162, 71);
            this.TXTID.Name = "TXTID";
            this.TXTID.Size = new System.Drawing.Size(100, 26);
            this.TXTID.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descripcion ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Unidad";
            // 
            // BTNELIM
            // 
            this.BTNELIM.Location = new System.Drawing.Point(647, 418);
            this.BTNELIM.Name = "BTNELIM";
            this.BTNELIM.Size = new System.Drawing.Size(130, 45);
            this.BTNELIM.TabIndex = 60;
            this.BTNELIM.Text = "Eliminar";
            this.BTNELIM.UseVisualStyleBackColor = true;
            // 
            // BTNACT
            // 
            this.BTNACT.Location = new System.Drawing.Point(480, 418);
            this.BTNACT.Name = "BTNACT";
            this.BTNACT.Size = new System.Drawing.Size(130, 45);
            this.BTNACT.TabIndex = 59;
            this.BTNACT.Text = "Actualizar";
            this.BTNACT.UseVisualStyleBackColor = true;
            // 
            // BTNREG
            // 
            this.BTNREG.Location = new System.Drawing.Point(319, 418);
            this.BTNREG.Name = "BTNREG";
            this.BTNREG.Size = new System.Drawing.Size(130, 45);
            this.BTNREG.TabIndex = 58;
            this.BTNREG.Text = "Registrar ";
            this.BTNREG.UseVisualStyleBackColor = true;
            // 
            // BTNBUSCAR
            // 
            this.BTNBUSCAR.Location = new System.Drawing.Point(159, 418);
            this.BTNBUSCAR.Name = "BTNBUSCAR";
            this.BTNBUSCAR.Size = new System.Drawing.Size(130, 45);
            this.BTNBUSCAR.TabIndex = 57;
            this.BTNBUSCAR.Text = "Buscar";
            this.BTNBUSCAR.UseVisualStyleBackColor = true;
            // 
            // Unidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 557);
            this.Controls.Add(this.BTNELIM);
            this.Controls.Add(this.BTNACT);
            this.Controls.Add(this.BTNREG);
            this.Controls.Add(this.BTNBUSCAR);
            this.Controls.Add(this.TXTDESC);
            this.Controls.Add(this.TXTID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Unidad";
            this.Text = "Unidad";
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
    }
}