namespace Proceso_AratzFernandez
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pedirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarAlbaranesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearAlbaránToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedirToolStripMenuItem,
            this.gestionarAlbaranesToolStripMenuItem,
            this.crearAlbaránToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pedirToolStripMenuItem
            // 
            this.pedirToolStripMenuItem.Name = "pedirToolStripMenuItem";
            this.pedirToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.pedirToolStripMenuItem.Text = "Hacer Pedido";
            this.pedirToolStripMenuItem.Click += new System.EventHandler(this.pedirToolStripMenuItem_Click);
            // 
            // gestionarAlbaranesToolStripMenuItem
            // 
            this.gestionarAlbaranesToolStripMenuItem.Name = "gestionarAlbaranesToolStripMenuItem";
            this.gestionarAlbaranesToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.gestionarAlbaranesToolStripMenuItem.Text = "Gestionar Albaranes";
            this.gestionarAlbaranesToolStripMenuItem.Click += new System.EventHandler(this.gestionarAlbaranesToolStripMenuItem_Click);
            // 
            // crearAlbaránToolStripMenuItem
            // 
            this.crearAlbaránToolStripMenuItem.Name = "crearAlbaránToolStripMenuItem";
            this.crearAlbaránToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.crearAlbaránToolStripMenuItem.Text = "Albaranes recibidos";
            this.crearAlbaránToolStripMenuItem.Click += new System.EventHandler(this.crearAlbaránToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(886, 476);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem crearAlbaránToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarAlbaranesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedirToolStripMenuItem;
    }
}

