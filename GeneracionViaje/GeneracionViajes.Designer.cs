namespace FrbaCrucero.GeneracionViaje
{
    partial class GeneracionViajes
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
            this.labelFin = new System.Windows.Forms.Label();
            this.comboRecorrido = new System.Windows.Forms.ComboBox();
            this.comboCrucero = new System.Windows.Forms.ComboBox();
            this.cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtInicio
            // 
            this.dtInicio.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInicio.Location = new System.Drawing.Point(192, 54);
            this.dtInicio.MinDate = new System.DateTime(2019, 6, 27, 0, 0, 0, 0);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(151, 20);
            this.dtInicio.TabIndex = 0;
            this.dtInicio.Value = new System.DateTime(2019, 7, 7, 0, 0, 0, 0);
            this.dtInicio.CloseUp += new System.EventHandler(this.dtInicio_CloseUp);
            // 
            // dtFin
            // 
            this.dtFin.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFin.Location = new System.Drawing.Point(194, 96);
            this.dtFin.MinDate = new System.DateTime(2019, 6, 27, 0, 0, 0, 0);
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(149, 20);
            this.dtFin.TabIndex = 1;
            this.dtFin.Value = new System.DateTime(2019, 7, 7, 0, 0, 0, 0);
            this.dtFin.CloseUp += new System.EventHandler(this.dtFin_CloseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha Inicio";
            // 
            // labelFin
            // 
            this.labelFin.AutoSize = true;
            this.labelFin.Location = new System.Drawing.Point(43, 103);
            this.labelFin.Name = "labelFin";
            this.labelFin.Size = new System.Drawing.Size(54, 13);
            this.labelFin.TabIndex = 3;
            this.labelFin.Text = "Fecha Fin";
            // 
            // comboRecorrido
            // 
            this.comboRecorrido.FormattingEnabled = true;
            this.comboRecorrido.Location = new System.Drawing.Point(192, 141);
            this.comboRecorrido.Name = "comboRecorrido";
            this.comboRecorrido.Size = new System.Drawing.Size(151, 21);
            this.comboRecorrido.TabIndex = 4;
            // 
            // comboCrucero
            // 
            this.comboCrucero.FormattingEnabled = true;
            this.comboCrucero.Location = new System.Drawing.Point(192, 181);
            this.comboCrucero.Name = "comboCrucero";
            this.comboCrucero.Size = new System.Drawing.Size(151, 21);
            this.comboCrucero.TabIndex = 5;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(219, 257);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(124, 26);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Recorrido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Crucero";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(46, 257);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(107, 25);
            this.save.TabIndex = 9;
            this.save.Text = "Guardar";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // GeneracionViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 295);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.comboCrucero);
            this.Controls.Add(this.comboRecorrido);
            this.Controls.Add(this.labelFin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFin);
            this.Controls.Add(this.dtInicio);
            this.Name = "GeneracionViajes";
            this.Text = "GeneracionViaje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFin;
        private System.Windows.Forms.ComboBox comboRecorrido;
        private System.Windows.Forms.ComboBox comboCrucero;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button save;
    }
}