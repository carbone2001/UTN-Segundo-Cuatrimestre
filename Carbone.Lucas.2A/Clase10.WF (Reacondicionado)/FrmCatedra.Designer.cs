namespace Clase10.WF
{
    partial class FrmCatedra
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbTipoOrden = new System.Windows.Forms.ComboBox();
            this.lsbAlumnos = new System.Windows.Forms.ListBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCalificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsbAlumnosCalificados = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbTipoOrden);
            this.groupBox1.Controls.Add(this.lsbAlumnos);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnCalificar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alumnos";
            // 
            // cmbTipoOrden
            // 
            this.cmbTipoOrden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoOrden.FormattingEnabled = true;
            this.cmbTipoOrden.Location = new System.Drawing.Point(7, 188);
            this.cmbTipoOrden.Name = "cmbTipoOrden";
            this.cmbTipoOrden.Size = new System.Drawing.Size(474, 21);
            this.cmbTipoOrden.TabIndex = 4;
            this.cmbTipoOrden.SelectedIndexChanged += new System.EventHandler(this.CmbTipoOrden_SelectedIndexChanged);
            // 
            // lsbAlumnos
            // 
            this.lsbAlumnos.FormattingEnabled = true;
            this.lsbAlumnos.Location = new System.Drawing.Point(6, 48);
            this.lsbAlumnos.Name = "lsbAlumnos";
            this.lsbAlumnos.Size = new System.Drawing.Size(475, 134);
            this.lsbAlumnos.TabIndex = 3;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(406, 19);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // btnCalificar
            // 
            this.btnCalificar.Location = new System.Drawing.Point(202, 19);
            this.btnCalificar.Name = "btnCalificar";
            this.btnCalificar.Size = new System.Drawing.Size(75, 23);
            this.btnCalificar.TabIndex = 1;
            this.btnCalificar.Text = "Calificar";
            this.btnCalificar.UseVisualStyleBackColor = true;
            this.btnCalificar.Click += new System.EventHandler(this.BtnCalificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(6, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsbAlumnosCalificados);
            this.groupBox2.Location = new System.Drawing.Point(12, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 150);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alumnos Calificados";
            // 
            // lsbAlumnosCalificados
            // 
            this.lsbAlumnosCalificados.FormattingEnabled = true;
            this.lsbAlumnosCalificados.Location = new System.Drawing.Point(7, 19);
            this.lsbAlumnosCalificados.Name = "lsbAlumnosCalificados";
            this.lsbAlumnosCalificados.Size = new System.Drawing.Size(475, 134);
            this.lsbAlumnosCalificados.TabIndex = 5;
            // 
            // FrmCatedra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 408);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCatedra";
            this.Text = "FrmCatedra";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbTipoOrden;
        private System.Windows.Forms.ListBox lsbAlumnos;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCalificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lsbAlumnosCalificados;
    }
}