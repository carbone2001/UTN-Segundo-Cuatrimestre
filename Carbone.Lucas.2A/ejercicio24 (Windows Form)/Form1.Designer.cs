namespace ejercicio24__Windows_Form_
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
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.btnConvertFahrenheit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCelcius = new System.Windows.Forms.TextBox();
            this.txtKelvin = new System.Windows.Forms.TextBox();
            this.btnConverCelsius = new System.Windows.Forms.Button();
            this.btnConvertKelvin = new System.Windows.Forms.Button();
            this.txtKelvinAFahrenheit = new System.Windows.Forms.TextBox();
            this.txtCelsiusAFahrenheit = new System.Windows.Forms.TextBox();
            this.txtFahrenheitAFahrenheit = new System.Windows.Forms.TextBox();
            this.txtKelvinACelsius = new System.Windows.Forms.TextBox();
            this.txtCelsiusACelsius = new System.Windows.Forms.TextBox();
            this.txtFahrenheitACelsius = new System.Windows.Forms.TextBox();
            this.txtKelvinAKelvin = new System.Windows.Forms.TextBox();
            this.txtCelsiusAKelvin = new System.Windows.Forms.TextBox();
            this.txtFahrenheitAKelvin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(88, 33);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.txtFahrenheit.TabIndex = 0;
            // 
            // btnConvertFahrenheit
            // 
            this.btnConvertFahrenheit.Location = new System.Drawing.Point(194, 31);
            this.btnConvertFahrenheit.Name = "btnConvertFahrenheit";
            this.btnConvertFahrenheit.Size = new System.Drawing.Size(75, 23);
            this.btnConvertFahrenheit.TabIndex = 1;
            this.btnConvertFahrenheit.Text = "->";
            this.btnConvertFahrenheit.UseVisualStyleBackColor = true;
            this.btnConvertFahrenheit.Click += new System.EventHandler(this.BtnConvertFahrenheit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fahrenheit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Celsius";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kelvin";
            // 
            // txtCelcius
            // 
            this.txtCelcius.Location = new System.Drawing.Point(88, 61);
            this.txtCelcius.Name = "txtCelcius";
            this.txtCelcius.Size = new System.Drawing.Size(100, 20);
            this.txtCelcius.TabIndex = 5;
            // 
            // txtKelvin
            // 
            this.txtKelvin.Location = new System.Drawing.Point(88, 87);
            this.txtKelvin.Name = "txtKelvin";
            this.txtKelvin.Size = new System.Drawing.Size(100, 20);
            this.txtKelvin.TabIndex = 6;
            // 
            // btnConverCelsius
            // 
            this.btnConverCelsius.Location = new System.Drawing.Point(194, 61);
            this.btnConverCelsius.Name = "btnConverCelsius";
            this.btnConverCelsius.Size = new System.Drawing.Size(75, 23);
            this.btnConverCelsius.TabIndex = 7;
            this.btnConverCelsius.Text = "->";
            this.btnConverCelsius.UseVisualStyleBackColor = true;
            this.btnConverCelsius.Click += new System.EventHandler(this.BtnConverCelsius_Click);
            // 
            // btnConvertKelvin
            // 
            this.btnConvertKelvin.Location = new System.Drawing.Point(194, 87);
            this.btnConvertKelvin.Name = "btnConvertKelvin";
            this.btnConvertKelvin.Size = new System.Drawing.Size(75, 23);
            this.btnConvertKelvin.TabIndex = 8;
            this.btnConvertKelvin.Text = "->";
            this.btnConvertKelvin.UseVisualStyleBackColor = true;
            this.btnConvertKelvin.Click += new System.EventHandler(this.BtnConvertKelvin_Click);
            // 
            // txtKelvinAFahrenheit
            // 
            this.txtKelvinAFahrenheit.Location = new System.Drawing.Point(275, 87);
            this.txtKelvinAFahrenheit.Name = "txtKelvinAFahrenheit";
            this.txtKelvinAFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.txtKelvinAFahrenheit.TabIndex = 11;
            // 
            // txtCelsiusAFahrenheit
            // 
            this.txtCelsiusAFahrenheit.Location = new System.Drawing.Point(275, 61);
            this.txtCelsiusAFahrenheit.Name = "txtCelsiusAFahrenheit";
            this.txtCelsiusAFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.txtCelsiusAFahrenheit.TabIndex = 10;
            // 
            // txtFahrenheitAFahrenheit
            // 
            this.txtFahrenheitAFahrenheit.Location = new System.Drawing.Point(275, 33);
            this.txtFahrenheitAFahrenheit.Name = "txtFahrenheitAFahrenheit";
            this.txtFahrenheitAFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.txtFahrenheitAFahrenheit.TabIndex = 9;
            // 
            // txtKelvinACelsius
            // 
            this.txtKelvinACelsius.Location = new System.Drawing.Point(381, 87);
            this.txtKelvinACelsius.Name = "txtKelvinACelsius";
            this.txtKelvinACelsius.Size = new System.Drawing.Size(100, 20);
            this.txtKelvinACelsius.TabIndex = 14;
            // 
            // txtCelsiusACelsius
            // 
            this.txtCelsiusACelsius.Location = new System.Drawing.Point(381, 61);
            this.txtCelsiusACelsius.Name = "txtCelsiusACelsius";
            this.txtCelsiusACelsius.Size = new System.Drawing.Size(100, 20);
            this.txtCelsiusACelsius.TabIndex = 13;
            // 
            // txtFahrenheitACelsius
            // 
            this.txtFahrenheitACelsius.Location = new System.Drawing.Point(381, 33);
            this.txtFahrenheitACelsius.Name = "txtFahrenheitACelsius";
            this.txtFahrenheitACelsius.Size = new System.Drawing.Size(100, 20);
            this.txtFahrenheitACelsius.TabIndex = 12;
            // 
            // txtKelvinAKelvin
            // 
            this.txtKelvinAKelvin.Location = new System.Drawing.Point(487, 87);
            this.txtKelvinAKelvin.Name = "txtKelvinAKelvin";
            this.txtKelvinAKelvin.Size = new System.Drawing.Size(100, 20);
            this.txtKelvinAKelvin.TabIndex = 17;
            // 
            // txtCelsiusAKelvin
            // 
            this.txtCelsiusAKelvin.Location = new System.Drawing.Point(487, 61);
            this.txtCelsiusAKelvin.Name = "txtCelsiusAKelvin";
            this.txtCelsiusAKelvin.Size = new System.Drawing.Size(100, 20);
            this.txtCelsiusAKelvin.TabIndex = 16;
            // 
            // txtFahrenheitAKelvin
            // 
            this.txtFahrenheitAKelvin.Location = new System.Drawing.Point(487, 33);
            this.txtFahrenheitAKelvin.Name = "txtFahrenheitAKelvin";
            this.txtFahrenheitAKelvin.Size = new System.Drawing.Size(100, 20);
            this.txtFahrenheitAKelvin.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Fahrenheit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(415, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Celsius";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(518, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Kelvin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 128);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKelvinAKelvin);
            this.Controls.Add(this.txtCelsiusAKelvin);
            this.Controls.Add(this.txtFahrenheitAKelvin);
            this.Controls.Add(this.txtKelvinACelsius);
            this.Controls.Add(this.txtCelsiusACelsius);
            this.Controls.Add(this.txtFahrenheitACelsius);
            this.Controls.Add(this.txtKelvinAFahrenheit);
            this.Controls.Add(this.txtCelsiusAFahrenheit);
            this.Controls.Add(this.txtFahrenheitAFahrenheit);
            this.Controls.Add(this.btnConvertKelvin);
            this.Controls.Add(this.btnConverCelsius);
            this.Controls.Add(this.txtKelvin);
            this.Controls.Add(this.txtCelcius);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvertFahrenheit);
            this.Controls.Add(this.txtFahrenheit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.Button btnConvertFahrenheit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCelcius;
        private System.Windows.Forms.TextBox txtKelvin;
        private System.Windows.Forms.Button btnConverCelsius;
        private System.Windows.Forms.Button btnConvertKelvin;
        private System.Windows.Forms.TextBox txtKelvinAFahrenheit;
        private System.Windows.Forms.TextBox txtCelsiusAFahrenheit;
        private System.Windows.Forms.TextBox txtFahrenheitAFahrenheit;
        private System.Windows.Forms.TextBox txtKelvinACelsius;
        private System.Windows.Forms.TextBox txtCelsiusACelsius;
        private System.Windows.Forms.TextBox txtFahrenheitACelsius;
        private System.Windows.Forms.TextBox txtKelvinAKelvin;
        private System.Windows.Forms.TextBox txtCelsiusAKelvin;
        private System.Windows.Forms.TextBox txtFahrenheitAKelvin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

