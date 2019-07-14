namespace FrbaCrucero.AbmCrucero
{
    partial class Cabinas
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
            this.textSuite = new System.Windows.Forms.TextBox();
            this.textBalcon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textStandar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textExterior = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textEjecutivo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad Cabinas Suite por piso";
            // 
            // textSuite
            // 
            this.textSuite.Location = new System.Drawing.Point(60, 35);
            this.textSuite.Name = "textSuite";
            this.textSuite.Size = new System.Drawing.Size(123, 20);
            this.textSuite.TabIndex = 2;
            // 
            // textBalcon
            // 
            this.textBalcon.Location = new System.Drawing.Point(60, 136);
            this.textBalcon.Name = "textBalcon";
            this.textBalcon.Size = new System.Drawing.Size(123, 20);
            this.textBalcon.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad Cabinas Balcon por piso";
            // 
            // textStandar
            // 
            this.textStandar.Location = new System.Drawing.Point(274, 35);
            this.textStandar.Name = "textStandar";
            this.textStandar.Size = new System.Drawing.Size(123, 20);
            this.textStandar.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad Cabinas Standar por piso";
            // 
            // textExterior
            // 
            this.textExterior.Location = new System.Drawing.Point(274, 136);
            this.textExterior.Name = "textExterior";
            this.textExterior.Size = new System.Drawing.Size(123, 20);
            this.textExterior.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cantidad Cabinas Exterior por piso";
            // 
            // textEjecutivo
            // 
            this.textEjecutivo.Location = new System.Drawing.Point(170, 230);
            this.textEjecutivo.Name = "textEjecutivo";
            this.textEjecutivo.Size = new System.Drawing.Size(123, 20);
            this.textEjecutivo.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cantidad Cabinas Ejecutivo por piso";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(72, 275);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(83, 26);
            this.save.TabIndex = 15;
            this.save.Text = "Guardar";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(268, 275);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(89, 26);
            this.cancel.TabIndex = 16;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Cabinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 318);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.textEjecutivo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textExterior);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textStandar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBalcon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textSuite);
            this.Controls.Add(this.label1);
            this.Name = "Cabinas";
            this.Text = "Cabinas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSuite;
        private System.Windows.Forms.TextBox textBalcon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textStandar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textExterior;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textEjecutivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
    }
}