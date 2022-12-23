namespace Proceso_AratzFernandez
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboProv = new System.Windows.Forms.ComboBox();
            this.cboProd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAñadirLinPed = new System.Windows.Forms.Button();
            this.btnCrearPed = new System.Windows.Forms.Button();
            this.grdLineas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdLineas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Provincia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DATOS PARA EL PEDIDO";
            // 
            // cboProv
            // 
            this.cboProv.FormattingEnabled = true;
            this.cboProv.Location = new System.Drawing.Point(87, 68);
            this.cboProv.Name = "cboProv";
            this.cboProv.Size = new System.Drawing.Size(130, 21);
            this.cboProv.TabIndex = 3;
            // 
            // cboProd
            // 
            this.cboProd.FormattingEnabled = true;
            this.cboProd.Location = new System.Drawing.Point(87, 107);
            this.cboProd.Name = "cboProd";
            this.cboProd.Size = new System.Drawing.Size(130, 21);
            this.cboProd.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Producto";
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(87, 148);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(100, 20);
            this.txtCant.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cantidad";
            // 
            // btnAñadirLinPed
            // 
            this.btnAñadirLinPed.Location = new System.Drawing.Point(34, 193);
            this.btnAñadirLinPed.Name = "btnAñadirLinPed";
            this.btnAñadirLinPed.Size = new System.Drawing.Size(100, 23);
            this.btnAñadirLinPed.TabIndex = 8;
            this.btnAñadirLinPed.Text = "Añadir Productos";
            this.btnAñadirLinPed.UseVisualStyleBackColor = true;
            this.btnAñadirLinPed.Click += new System.EventHandler(this.btnAñadirLinPed_Click);
            // 
            // btnCrearPed
            // 
            this.btnCrearPed.Location = new System.Drawing.Point(34, 233);
            this.btnCrearPed.Name = "btnCrearPed";
            this.btnCrearPed.Size = new System.Drawing.Size(100, 23);
            this.btnCrearPed.TabIndex = 10;
            this.btnCrearPed.Text = "Enviar Pedido";
            this.btnCrearPed.UseVisualStyleBackColor = true;
            this.btnCrearPed.Click += new System.EventHandler(this.btnCrearPed_Click);
            // 
            // grdLineas
            // 
            this.grdLineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLineas.Location = new System.Drawing.Point(254, 68);
            this.grdLineas.Name = "grdLineas";
            this.grdLineas.Size = new System.Drawing.Size(309, 188);
            this.grdLineas.TabIndex = 11;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(586, 299);
            this.Controls.Add(this.grdLineas);
            this.Controls.Add(this.btnCrearPed);
            this.Controls.Add(this.btnAñadirLinPed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboProd);
            this.Controls.Add(this.cboProv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdLineas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboProv;
        private System.Windows.Forms.ComboBox cboProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAñadirLinPed;
        private System.Windows.Forms.Button btnCrearPed;
        private System.Windows.Forms.DataGridView grdLineas;
    }
}