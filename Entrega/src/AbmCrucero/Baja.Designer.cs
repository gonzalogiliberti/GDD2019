namespace FrbaCrucero.AbmCrucero
{
    partial class Baja
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
            this.vidaUtil = new System.Windows.Forms.Button();
            this.fueraServicio = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vidaUtil
            // 
            this.vidaUtil.Location = new System.Drawing.Point(38, 110);
            this.vidaUtil.Name = "vidaUtil";
            this.vidaUtil.Size = new System.Drawing.Size(98, 42);
            this.vidaUtil.TabIndex = 0;
            this.vidaUtil.Text = "Por vida util";
            this.vidaUtil.UseVisualStyleBackColor = true;
            this.vidaUtil.Click += new System.EventHandler(this.vidaUtil_Click);
            // 
            // fueraServicio
            // 
            this.fueraServicio.Location = new System.Drawing.Point(153, 110);
            this.fueraServicio.Name = "fueraServicio";
            this.fueraServicio.Size = new System.Drawing.Size(95, 42);
            this.fueraServicio.TabIndex = 1;
            this.fueraServicio.Text = "Fuera Servicio";
            this.fueraServicio.UseVisualStyleBackColor = true;
            this.fueraServicio.Click += new System.EventHandler(this.fueraServicio_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(95, 202);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(103, 42);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecciones el tipo de baja";
            // 
            // Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.fueraServicio);
            this.Controls.Add(this.vidaUtil);
            this.Name = "Baja";
            this.Text = "Baja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button vidaUtil;
        private System.Windows.Forms.Button fueraServicio;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label1;
    }
}