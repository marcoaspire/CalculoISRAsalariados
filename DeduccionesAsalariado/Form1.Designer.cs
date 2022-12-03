
namespace DeduccionesAsalariado
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ingresos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deducciones = new System.Windows.Forms.TextBox();
            this.ISR = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.isr1 = new System.Windows.Forms.TextBox();
            this.isr2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.saldo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Leer tabla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Carga la tabla";
            // 
            // ingresos
            // 
            this.ingresos.Location = new System.Drawing.Point(230, 87);
            this.ingresos.Name = "ingresos";
            this.ingresos.Size = new System.Drawing.Size(125, 27);
            this.ingresos.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingresa monto a deducir";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingresos anuales";
            // 
            // deducciones
            // 
            this.deducciones.Location = new System.Drawing.Point(230, 151);
            this.deducciones.Name = "deducciones";
            this.deducciones.Size = new System.Drawing.Size(125, 27);
            this.deducciones.TabIndex = 5;
            // 
            // ISR
            // 
            this.ISR.Location = new System.Drawing.Point(230, 206);
            this.ISR.Name = "ISR";
            this.ISR.Size = new System.Drawing.Size(94, 29);
            this.ISR.TabIndex = 6;
            this.ISR.Text = "Calcular ISR";
            this.ISR.UseVisualStyleBackColor = true;
            this.ISR.Click += new System.EventHandler(this.ISR_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "ISR sin deducciones";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "ISR despues de deducciones";
            // 
            // isr1
            // 
            this.isr1.Location = new System.Drawing.Point(639, 90);
            this.isr1.Name = "isr1";
            this.isr1.Size = new System.Drawing.Size(125, 27);
            this.isr1.TabIndex = 9;
            // 
            // isr2
            // 
            this.isr2.Location = new System.Drawing.Point(643, 151);
            this.isr2.Name = "isr2";
            this.isr2.Size = new System.Drawing.Size(125, 27);
            this.isr2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(440, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Diferencia";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // saldo
            // 
            this.saldo.Location = new System.Drawing.Point(639, 206);
            this.saldo.Name = "saldo";
            this.saldo.Size = new System.Drawing.Size(125, 27);
            this.saldo.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 281);
            this.Controls.Add(this.saldo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.isr2);
            this.Controls.Add(this.isr1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ISR);
            this.Controls.Add(this.deducciones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ingresos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calcular Saldo por deducciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ingresos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox deducciones;
        private System.Windows.Forms.Button ISR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox isr1;
        private System.Windows.Forms.TextBox isr2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox saldo;
    }
}

