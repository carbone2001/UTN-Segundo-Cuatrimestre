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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnRestarTempera = new System.Windows.Forms.Button();
            this.btnSumarTempera = new System.Windows.Forms.Button();
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
            this.crearTemperaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.crearTemperaToolStripMenuItem.Text = "Crear Tempera";
            this.crearTemperaToolStripMenuItem.Click += new System.EventHandler(this.crearTemperaToolStripMenuItem_Click);
            // 
            // grbPaleta
            // 
            this.grbPaleta.Controls.Add(this.btnModificar);
            this.grbPaleta.Controls.Add(this.btnRestarTempera);
            this.grbPaleta.Controls.Add(this.btnSumarTempera);
            this.grbPaleta.Controls.Add(this.lsbPaleta);
            this.grbPaleta.Location = new System.Drawing.Point(62, 60);
            this.grbPaleta.Name = "grbPaleta";
            this.grbPaleta.Size = new System.Drawing.Size(672, 239);
            this.grbPaleta.TabIndex = 8;
            this.grbPaleta.TabStop = false;
            this.grbPaleta.Text = "Paleta";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(169, 199);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRestarTempera
            // 
            this.btnRestarTempera.Location = new System.Drawing.Point(88, 198);
            this.btnRestarTempera.Name = "btnRestarTempera";
            this.btnRestarTempera.Size = new System.Drawing.Size(75, 23);
            this.btnRestarTempera.TabIndex = 2;
            this.btnRestarTempera.Text = "-";
            this.btnRestarTempera.UseVisualStyleBackColor = true;
            this.btnRestarTempera.Click += new System.EventHandler(this.btnRestarTempera_Click);
            // 
            // btnSumarTempera
            // 
            this.btnSumarTempera.Location = new System.Drawing.Point(7, 199);
            this.btnSumarTempera.Name = "btnSumarTempera";
            this.btnSumarTempera.Size = new System.Drawing.Size(75, 23);
            this.btnSumarTempera.TabIndex = 1;
            this.btnSumarTempera.Text = "+";
            this.btnSumarTempera.UseVisualStyleBackColor = true;
            this.btnSumarTempera.Click += new System.EventHandler(this.btnSumarTempera_Click);
            // 
            // lsbPaleta
            // 
            this.lsbPaleta.FormattingEnabled = true;
            this.lsbPaleta.Location = new System.Drawing.Point(6, 19);
            this.lsbPaleta.Name = "lsbPaleta";
            this.lsbPaleta.Size = new System.Drawing.Size(660, 173);
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
        private System.Windows.Forms.Button btnRestarTempera;
        private System.Windows.Forms.Button btnSumarTempera;
        private System.Windows.Forms.Button btnModificar;
    }
}

