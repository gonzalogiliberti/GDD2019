namespace FrbaCrucero.GeneracionViaje
{
    partial class GenearcionViaje
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
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboCrucero = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboRecorrido = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtInicio
            // 
            this.dtInicio.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtInicio.Location = new System.Drawing.Point(184, 29);
            this.dtInicio.MinDate = new System.DateTime(2019, 6, 25, 22, 3, 40, 0);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(152, 20);
            this.dtInicio.TabIndex = 0;
            this.dtInicio.Value = new System.DateTime(2019, 6, 25, 22, 6, 21, 0);
            // 
            // dtFin
            // 
            this.dtFin.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtFin.Location = new System.Drawing.Point(184, 67);
            this.dtFin.MinDate = new System.DateTime(2019, 6, 25, 22, 7, 8, 0);
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(152, 20);
            this.dtFin.TabIndex = 1;
            this.dtFin.Value = new System.DateTime(2019, 6, 25, 22, 7, 8, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha de Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de fin";
            // 
            // comboCrucero
            // 
            this.comboCrucero.FormattingEnabled = true;
            this.comboCrucero.Location = new System.Drawing.Point(184, 128);
            this.comboCrucero.Name = "comboCrucero";
            this.comboCrucero.Size = new System.Drawing.Size(152, 21);
            this.comboCrucero.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Crucero";
            // 
            // comboRecorrido
            // 
            this.comboRecorrido.FormattingEnabled = true;
            this.comboRecorrido.Location = new System.Drawing.Point(184, 178);
            this.comboRecorrido.Name = "comboRecorrido";
            this.comboRecorrido.Size = new System.Drawing.Size(151, 21);
            this.comboRecorrido.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Recorrido";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(69, 229);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(102, 22);
            this.save.TabIndex = 8;
            this.save.Text = "Guardar";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(203, 229);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(99, 21);
            this.cancel.TabIndex = 9;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // GenearcionViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 261);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboRecorrido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboCrucero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFin);
            this.Controls.Add(this.dtInicio);
            this.Name = "GenearcionViaje";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboCrucero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboRecorrido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
    }
}