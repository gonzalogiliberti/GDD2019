namespace FrbaCrucero.CompraReservaPasaje
{
    partial class Pago
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
            this.cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboMedioPago = new System.Windows.Forms.ComboBox();
            this.comboTarjeta = new System.Windows.Forms.ComboBox();
            this.labelTarjeta = new System.Windows.Forms.Label();
            this.labelCoutas = new System.Windows.Forms.Label();
            this.textCoutas = new System.Windows.Forms.TextBox();
            this.pay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(187, 220);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(95, 29);
            this.cancel.TabIndex = 0;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione Medio de Pago";
            // 
            // textPrecio
            // 
            this.textPrecio.Enabled = false;
            this.textPrecio.Location = new System.Drawing.Point(187, 39);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(108, 20);
            this.textPrecio.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total a Pagar";
            // 
            // comboMedioPago
            // 
            this.comboMedioPago.FormattingEnabled = true;
            this.comboMedioPago.Location = new System.Drawing.Point(187, 72);
            this.comboMedioPago.Name = "comboMedioPago";
            this.comboMedioPago.Size = new System.Drawing.Size(108, 21);
            this.comboMedioPago.TabIndex = 4;
            this.comboMedioPago.SelectedValueChanged += new System.EventHandler(this.comboMedioPago_SelectedValueChanged);
            // 
            // comboTarjeta
            // 
            this.comboTarjeta.FormattingEnabled = true;
            this.comboTarjeta.Location = new System.Drawing.Point(187, 133);
            this.comboTarjeta.Name = "comboTarjeta";
            this.comboTarjeta.Size = new System.Drawing.Size(107, 21);
            this.comboTarjeta.TabIndex = 5;
            this.comboTarjeta.Visible = false;
            // 
            // labelTarjeta
            // 
            this.labelTarjeta.AutoSize = true;
            this.labelTarjeta.Location = new System.Drawing.Point(22, 141);
            this.labelTarjeta.Name = "labelTarjeta";
            this.labelTarjeta.Size = new System.Drawing.Size(91, 13);
            this.labelTarjeta.TabIndex = 6;
            this.labelTarjeta.Text = "Tarjeta de Credito";
            this.labelTarjeta.Visible = false;
            // 
            // labelCoutas
            // 
            this.labelCoutas.AutoSize = true;
            this.labelCoutas.Location = new System.Drawing.Point(23, 172);
            this.labelCoutas.Name = "labelCoutas";
            this.labelCoutas.Size = new System.Drawing.Size(40, 13);
            this.labelCoutas.TabIndex = 7;
            this.labelCoutas.Text = "Cuotas";
            this.labelCoutas.Visible = false;
            // 
            // textCoutas
            // 
            this.textCoutas.Location = new System.Drawing.Point(187, 173);
            this.textCoutas.Name = "textCoutas";
            this.textCoutas.Size = new System.Drawing.Size(106, 20);
            this.textCoutas.TabIndex = 8;
            this.textCoutas.Visible = false;
            // 
            // pay
            // 
            this.pay.Location = new System.Drawing.Point(40, 220);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(87, 28);
            this.pay.TabIndex = 9;
            this.pay.Text = "Pagar";
            this.pay.UseVisualStyleBackColor = true;
            this.pay.Click += new System.EventHandler(this.pay_Click);
            // 
            // Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 261);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.textCoutas);
            this.Controls.Add(this.labelCoutas);
            this.Controls.Add(this.labelTarjeta);
            this.Controls.Add(this.comboTarjeta);
            this.Controls.Add(this.comboMedioPago);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel);
            this.Name = "Pago";
            this.Text = "Pago";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboMedioPago;
        private System.Windows.Forms.ComboBox comboTarjeta;
        private System.Windows.Forms.Label labelTarjeta;
        private System.Windows.Forms.Label labelCoutas;
        private System.Windows.Forms.TextBox textCoutas;
        private System.Windows.Forms.Button pay;
    }
}