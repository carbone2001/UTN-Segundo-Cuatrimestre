namespace Clase06.WF
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
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPaletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearTemperaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbPaleta = new System.Windows.Forms.GroupBox();
            this.lsbPaleta = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.grbPaleta.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administracionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearPaletaToolStripMenuItem});
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.administracionToolStripMenuItem.Text = "Administracion";
            // 
            // crearPaletaToolStripMenuItem
            // 
            this.crearPaletaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearTemperaToolStripMenuItem});
            this.crearPaletaToolStripMenuItem.Name = "crearPaletaToolStripMenuItem";
            this.crearPaletaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.crearPaletaToolStripMenuItem.Text = "Crear Paleta";
            this.crearPaletaToolStripMenuItem.Click += new System.EventHandler(this.crearPaletaToolStripMenuItem_Click);
            // 
            // crearTemperaToolStripMenuItem
            // 
            this.crearTemperaToolStripMenuItem.Name = "crearTemperaToolStripMenuItem";
            this.crearTemperaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.crearTemperaToolStripMenuItem.Text = "Crear Tempera";
            this.crearTemperaToolStripMenuItem.Click += new System.EventHandler(this.crearTemperaToolStripMenuItem_Click);
            // 
            // grbPaleta
            // 
            this.grbPaleta.Controls.Add(this.lsbPaleta);
            this.grbPaleta.Location = new System.Drawing.Point(260, 58);
            this.grbPaleta.Name = "grbPaleta";
            this.grbPaleta.Size = new System.Drawing.Size(528, 239);
            this.grbPaleta.TabIndex = 1;
            this.grbPaleta.TabStop = false;
            this.grbPaleta.Text = "Paleta";
            // 
            // lsbPaleta
            // 
            this.lsbPaleta.FormattingEnabled = true;
            this.lsbPaleta.Location = new System.Drawing.Point(6, 19);
            this.lsbPaleta.Name = "lsbPaleta";
            this.lsbPaleta.Size = new System.Drawing.Size(516, 212);
            this.lsbPaleta.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 323);
            this.Controls.Add(this.grbPaleta);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grbPaleta.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearPaletaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearTemperaToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbPaleta;
        private System.Windows.Forms.ListBox lsbPaleta;
    }
}

