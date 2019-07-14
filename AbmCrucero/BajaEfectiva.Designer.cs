namespace FrbaCrucero.AbmCrucero
{
    partial class BajaEfectiva
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
            this.devolucion = new System.Windows.Forms.Button();
            this.replace = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.corrimiento = new System.Windows.Forms.Button();
            this.dtBaja = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.labelAlta = new System.Windows.Forms.Label();
            this.dtAlta = new System.Windows.Forms.DateTimePicker();
            this.baja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccion la operacion a realizar";
            // 
            // devolucion
            // 
            this.devolucion.Location = new System.Drawing.Point(12, 270);
            this.devolucion.Name = "devolucion";
            this.devolucion.Size = new System.Drawing.Size(85, 36);
            this.devolucion.TabIndex = 1;
            this.devolucion.Text = "Devolver los pasajes";
            this.devolucion.UseVisualStyleBackColor = true;
            this.devolucion.Click += new System.EventHandler(this.devolucion_Click);
            // 
            // replace
            // 
            this.replace.Location = new System.Drawing.Point(72, 215);
            this.replace.Name = "replace";
            this.replace.Size = new System.Drawing.Size(85, 36);
            this.replace.TabIndex = 2;
            this.replace.Text = "Reemplazar el crucero";
            this.replace.UseVisualStyleBackColor = true;
            this.replace.Click += new System.EventHandler(this.replace_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(236, 270);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(85, 36);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // corrimiento
            // 
            this.corrimiento.Location = new System.Drawing.Point(194, 215);
            this.corrimiento.Name = "corrimiento";
            this.corrimiento.Size = new System.Drawing.Size(85, 36);
            this.corrimiento.TabIndex = 4;
            this.corrimiento.Text = "Reprogramar Viaje";
            this.corrimiento.UseVisualStyleBackColor = true;
            this.corrimiento.Click += new System.EventHandler(this.corrimiento_Click);
            // 
            // dtBaja
            // 
            this.dtBaja.CustomFormat = "dd-MM-yyyy";
            this.dtBaja.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtBaja.Location = new System.Drawing.Point(155, 101);
            this.dtBaja.Name = "dtBaja";
            this.dtBaja.Size = new System.Drawing.Size(139, 20);
            this.dtBaja.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha Baja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descripcion";
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(155, 136);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(138, 20);
            this.textDescripcion.TabIndex = 8;
            // 
            // labelAlta
            // 
            this.labelAlta.AutoSize = true;
            this.labelAlta.Location = new System.Drawing.Point(58, 170);
            this.labelAlta.Name = "labelAlta";
            this.labelAlta.Size = new System.Drawing.Size(73, 13);
            this.labelAlta.TabIndex = 9;
            this.labelAlta.Text = "Fecha de Alta";
            // 
            // dtAlta
            // 
            this.dtAlta.CustomFormat = "dd-MM-yyyy";
            this.dtAlta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtAlta.Location = new System.Drawing.Point(155, 170);
            this.dtAlta.Name = "dtAlta";
            this.dtAlta.Size = new System.Drawing.Size(139, 20);
            this.dtAlta.TabIndex = 10;
            // 
            // baja
            // 
            this.baja.Location = new System.Drawing.Point(122, 270);
            this.baja.Name = "baja";
            this.baja.Size = new System.Drawing.Size(92, 34);
            this.baja.TabIndex = 11;
            this.baja.Text = "Confirmar Baja";
            this.baja.UseVisualStyleBackColor = true;
            this.baja.Click += new System.EventHandler(this.baja_Click);
            // 
            // BajaEfectiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 342);
            this.Controls.Add(this.baja);
            this.Controls.Add(this.dtAlta);
            this.Controls.Add(this.labelAlta);
            this.Controls.Add(this.textDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtBaja);
            this.Controls.Add(this.corrimiento);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.replace);
            this.Controls.Add(this.devolucion);
            this.Controls.Add(this.label1);
            this.Name = "BajaEfectiva";
            this.Text = "BajaVidaUtil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button devolucion;
        private System.Windows.Forms.Button replace;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button corrimiento;
        private System.Windows.Forms.DateTimePicker dtBaja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.Label labelAlta;
        private System.Windows.Forms.DateTimePicker dtAlta;
        private System.Windows.Forms.Button baja;
    }
}