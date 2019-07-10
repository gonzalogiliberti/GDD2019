namespace FrbaCrucero.CompraReservaPasaje
{
    partial class IngresoCliente
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
            this.textDNI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelLast = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.labelDir = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.textMail = new System.Windows.Forms.TextBox();
            this.labelNac = new System.Windows.Forms.Label();
            this.dtNac = new System.Windows.Forms.DateTimePicker();
            this.saveClient = new System.Windows.Forms.Button();
            this.pay = new System.Windows.Forms.Button();
            this.reserve = new System.Windows.Forms.Button();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(146, 260);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(102, 27);
            this.cancel.TabIndex = 0;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // textDNI
            // 
            this.textDNI.Location = new System.Drawing.Point(140, 59);
            this.textDNI.Name = "textDNI";
            this.textDNI.Size = new System.Drawing.Size(114, 20);
            this.textDNI.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese Su DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DNI";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(293, 59);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(102, 20);
            this.search.TabIndex = 4;
            this.search.Text = "Buscar";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(140, 85);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(114, 20);
            this.textNombre.TabIndex = 5;
            this.textNombre.Visible = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 92);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 13);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Nombre";
            this.labelName.Visible = false;
            // 
            // labelLast
            // 
            this.labelLast.AutoSize = true;
            this.labelLast.Location = new System.Drawing.Point(12, 120);
            this.labelLast.Name = "labelLast";
            this.labelLast.Size = new System.Drawing.Size(44, 13);
            this.labelLast.TabIndex = 7;
            this.labelLast.Text = "Apellido";
            this.labelLast.Visible = false;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(140, 113);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(114, 20);
            this.textApellido.TabIndex = 8;
            this.textApellido.Visible = false;
            // 
            // textDireccion
            // 
            this.textDireccion.Location = new System.Drawing.Point(140, 138);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(114, 20);
            this.textDireccion.TabIndex = 10;
            this.textDireccion.Visible = false;
            // 
            // labelDir
            // 
            this.labelDir.AutoSize = true;
            this.labelDir.Location = new System.Drawing.Point(12, 145);
            this.labelDir.Name = "labelDir";
            this.labelDir.Size = new System.Drawing.Size(52, 13);
            this.labelDir.TabIndex = 9;
            this.labelDir.Text = "Direccion";
            this.labelDir.Visible = false;
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(12, 169);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(26, 13);
            this.labelMail.TabIndex = 11;
            this.labelMail.Text = "Mail";
            this.labelMail.Visible = false;
            // 
            // textMail
            // 
            this.textMail.Location = new System.Drawing.Point(140, 163);
            this.textMail.Name = "textMail";
            this.textMail.Size = new System.Drawing.Size(114, 20);
            this.textMail.TabIndex = 12;
            this.textMail.Visible = false;
            // 
            // labelNac
            // 
            this.labelNac.AutoSize = true;
            this.labelNac.Location = new System.Drawing.Point(12, 193);
            this.labelNac.Name = "labelNac";
            this.labelNac.Size = new System.Drawing.Size(93, 13);
            this.labelNac.TabIndex = 13;
            this.labelNac.Text = "Fecha Nacimiento";
            this.labelNac.Visible = false;
            // 
            // dtNac
            // 
            this.dtNac.CustomFormat = "dd-mm-yyyy";
            this.dtNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNac.Location = new System.Drawing.Point(140, 189);
            this.dtNac.Name = "dtNac";
            this.dtNac.Size = new System.Drawing.Size(114, 20);
            this.dtNac.TabIndex = 14;
            this.dtNac.Visible = false;
            // 
            // saveClient
            // 
            this.saveClient.Location = new System.Drawing.Point(28, 260);
            this.saveClient.Name = "saveClient";
            this.saveClient.Size = new System.Drawing.Size(87, 27);
            this.saveClient.TabIndex = 15;
            this.saveClient.Text = "Guardar Datos";
            this.saveClient.UseVisualStyleBackColor = true;
            this.saveClient.Visible = false;
            this.saveClient.Click += new System.EventHandler(this.saveClient_Click);
            // 
            // pay
            // 
            this.pay.Location = new System.Drawing.Point(282, 240);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(96, 24);
            this.pay.TabIndex = 16;
            this.pay.Text = "Pagar";
            this.pay.UseVisualStyleBackColor = true;
            this.pay.Visible = false;
            this.pay.Click += new System.EventHandler(this.pay_Click);
            // 
            // reserve
            // 
            this.reserve.Location = new System.Drawing.Point(283, 275);
            this.reserve.Name = "reserve";
            this.reserve.Size = new System.Drawing.Size(94, 25);
            this.reserve.TabIndex = 17;
            this.reserve.Text = "Reservar";
            this.reserve.UseVisualStyleBackColor = true;
            this.reserve.Visible = false;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(12, 216);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(49, 13);
            this.labelTelefono.TabIndex = 18;
            this.labelTelefono.Text = "Telefono";
            this.labelTelefono.Visible = false;
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(140, 216);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(114, 20);
            this.textTelefono.TabIndex = 19;
            this.textTelefono.Visible = false;
            // 
            // IngresoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 314);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.reserve);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.saveClient);
            this.Controls.Add(this.dtNac);
            this.Controls.Add(this.labelNac);
            this.Controls.Add(this.textMail);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.textDireccion);
            this.Controls.Add(this.labelDir);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.labelLast);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textDNI);
            this.Controls.Add(this.cancel);
            this.Name = "IngresoCliente";
            this.Text = "IngresoCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox textDNI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLast;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.Label labelDir;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.TextBox textMail;
        private System.Windows.Forms.Label labelNac;
        private System.Windows.Forms.DateTimePicker dtNac;
        private System.Windows.Forms.Button saveClient;
        private System.Windows.Forms.Button pay;
        private System.Windows.Forms.Button reserve;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox textTelefono;
    }
}