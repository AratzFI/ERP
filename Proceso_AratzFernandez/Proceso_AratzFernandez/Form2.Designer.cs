namespace Proceso_AratzFernandez
{
    partial class Form2
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
            this.btnLinAlb = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRechazar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.grdAlb = new System.Windows.Forms.DataGridView();
            this.grdLinAlb = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdAlb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLinAlb)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLinAlb
            // 
            this.btnLinAlb.Location = new System.Drawing.Point(38, 146);
            this.btnLinAlb.Name = "btnLinAlb";
            this.btnLinAlb.Size = new System.Drawing.Size(90, 41);
            this.btnLinAlb.TabIndex = 26;
            this.btnLinAlb.Text = "Abrir líneas de albarán";
            this.btnLinAlb.UseVisualStyleBackColor = true;
            this.btnLinAlb.Click += new System.EventHandler(this.btnLinAlb_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(38, 371);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 23);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRechazar
            // 
            this.btnRechazar.Location = new System.Drawing.Point(38, 85);
            this.btnRechazar.Name = "btnRechazar";
            this.btnRechazar.Size = new System.Drawing.Size(90, 35);
            this.btnRechazar.TabIndex = 24;
            this.btnRechazar.Text = "Rechazar ";
            this.btnRechazar.UseVisualStyleBackColor = true;
            this.btnRechazar.Click += new System.EventHandler(this.btnRechazar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(38, 31);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(90, 48);
            this.btnAceptar.TabIndex = 23;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // grdAlb
            // 
            this.grdAlb.BackgroundColor = System.Drawing.SystemColors.Info;
            this.grdAlb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAlb.Location = new System.Drawing.Point(171, 43);
            this.grdAlb.Name = "grdAlb";
            this.grdAlb.Size = new System.Drawing.Size(408, 163);
            this.grdAlb.TabIndex = 21;
            // 
            // grdLinAlb
            // 
            this.grdLinAlb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLinAlb.Location = new System.Drawing.Point(171, 236);
            this.grdLinAlb.Name = "grdLinAlb";
            this.grdLinAlb.Size = new System.Drawing.Size(408, 158);
            this.grdLinAlb.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "ALBARANES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "LINEAS DE ALBARAN";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(632, 447);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdLinAlb);
            this.Controls.Add(this.btnLinAlb);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRechazar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grdAlb);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAlb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdLinAlb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button btnLinAlb;
        internal System.Windows.Forms.Button btnSalir;
        internal System.Windows.Forms.Button btnRechazar;
        internal System.Windows.Forms.Button btnAceptar;
        internal System.Windows.Forms.DataGridView grdAlb;
        private System.Windows.Forms.DataGridView grdLinAlb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}