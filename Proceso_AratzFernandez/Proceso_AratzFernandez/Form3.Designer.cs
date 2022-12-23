namespace Proceso_AratzFernandez
{
    partial class Form3
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
            this.btnLinea = new System.Windows.Forms.Button();
            this.txtUnidades = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.cboProd = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.btnAlb = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.Label4 = new System.Windows.Forms.Label();
            this.grdLinAlb = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdLinAlb)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLinea
            // 
            this.btnLinea.Location = new System.Drawing.Point(138, 293);
            this.btnLinea.Name = "btnLinea";
            this.btnLinea.Size = new System.Drawing.Size(87, 29);
            this.btnLinea.TabIndex = 48;
            this.btnLinea.Text = "Añadir Línea";
            this.btnLinea.UseVisualStyleBackColor = true;
            this.btnLinea.Click += new System.EventHandler(this.btnLinea_Click);
            // 
            // txtUnidades
            // 
            this.txtUnidades.Location = new System.Drawing.Point(138, 250);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(100, 20);
            this.txtUnidades.TabIndex = 47;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(41, 253);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(52, 13);
            this.Label7.TabIndex = 46;
            this.Label7.Text = "Unidades";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(41, 215);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(50, 13);
            this.Label6.TabIndex = 45;
            this.Label6.Text = "Producto";
            // 
            // cboProd
            // 
            this.cboProd.FormattingEnabled = true;
            this.cboProd.Location = new System.Drawing.Point(138, 212);
            this.cboProd.Name = "cboProd";
            this.cboProd.Size = new System.Drawing.Size(121, 21);
            this.cboProd.TabIndex = 44;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(117, 172);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(94, 13);
            this.Label3.TabIndex = 41;
            this.Label3.Text = "Líneas de Albarán";
            // 
            // btnAlb
            // 
            this.btnAlb.Location = new System.Drawing.Point(138, 111);
            this.btnAlb.Name = "btnAlb";
            this.btnAlb.Size = new System.Drawing.Size(87, 32);
            this.btnAlb.TabIndex = 40;
            this.btnAlb.Text = "Crear Albarán";
            this.btnAlb.UseVisualStyleBackColor = true;
            this.btnAlb.Click += new System.EventHandler(this.btnAlb_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(117, 27);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(103, 13);
            this.Label2.TabIndex = 39;
            this.Label2.Text = "Creación de Albarán";
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(138, 74);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 20);
            this.dtFecha.TabIndex = 38;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(41, 80);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(91, 13);
            this.Label4.TabIndex = 37;
            this.Label4.Text = "Fecha de entrega";
            // 
            // grdLinAlb
            // 
            this.grdLinAlb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLinAlb.Location = new System.Drawing.Point(355, 74);
            this.grdLinAlb.Name = "grdLinAlb";
            this.grdLinAlb.Size = new System.Drawing.Size(337, 248);
            this.grdLinAlb.TabIndex = 49;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(355, 339);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(76, 42);
            this.btnSalir.TabIndex = 50;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(704, 393);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grdLinAlb);
            this.Controls.Add(this.btnLinea);
            this.Controls.Add(this.txtUnidades);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.cboProd);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.btnAlb);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.Label4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdLinAlb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnLinea;
        internal System.Windows.Forms.TextBox txtUnidades;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.ComboBox cboProd;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Button btnAlb;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.DateTimePicker dtFecha;
        internal System.Windows.Forms.Label Label4;
        private System.Windows.Forms.DataGridView grdLinAlb;
        private System.Windows.Forms.Button btnSalir;
    }
}