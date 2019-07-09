namespace FrbaCrucero.CompraReservaPasaje
{
    partial class CompraReserva
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
            this.dgvViajes = new System.Windows.Forms.DataGridView();
            this.comboPuertoDest = new System.Windows.Forms.ComboBox();
            this.comboPuertoOri = new System.Windows.Forms.ComboBox();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.seleccion = new System.Windows.Forms.Label();
            this.idViaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCrucero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuertoOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPuertoOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuertoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPuertoDest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(196, 415);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(172, 43);
            this.cancel.TabIndex = 0;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // dgvViajes
            // 
            this.dgvViajes.AllowUserToAddRows = false;
            this.dgvViajes.AllowUserToResizeColumns = false;
            this.dgvViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idViaje,
            this.idCrucero,
            this.Identificador,
            this.PuertoOrigen,
            this.idPuertoOrigen,
            this.PuertoDestino,
            this.idPuertoDest,
            this.FechaInicio,
            this.FechaFin});
            this.dgvViajes.Location = new System.Drawing.Point(22, 215);
            this.dgvViajes.Name = "dgvViajes";
            this.dgvViajes.Size = new System.Drawing.Size(545, 186);
            this.dgvViajes.TabIndex = 1;
            this.dgvViajes.Visible = false;
            this.dgvViajes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvViajes_CellMouseDoubleClick);
            // 
            // comboPuertoDest
            // 
            this.comboPuertoDest.FormattingEnabled = true;
            this.comboPuertoDest.Location = new System.Drawing.Point(150, 146);
            this.comboPuertoDest.Name = "comboPuertoDest";
            this.comboPuertoDest.Size = new System.Drawing.Size(147, 21);
            this.comboPuertoDest.TabIndex = 3;
            // 
            // comboPuertoOri
            // 
            this.comboPuertoOri.FormattingEnabled = true;
            this.comboPuertoOri.Location = new System.Drawing.Point(150, 101);
            this.comboPuertoOri.Name = "comboPuertoOri";
            this.comboPuertoOri.Size = new System.Drawing.Size(147, 21);
            this.comboPuertoOri.TabIndex = 4;
            // 
            // dtInicio
            // 
            this.dtInicio.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInicio.Location = new System.Drawing.Point(151, 51);
            this.dtInicio.MinDate = new System.DateTime(2019, 7, 6, 0, 0, 0, 0);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(146, 20);
            this.dtInicio.TabIndex = 5;
            this.dtInicio.Value = new System.DateTime(2019, 7, 7, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha de Viaje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Puerto de Origen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Puerto de Destino";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(355, 88);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(102, 35);
            this.search.TabIndex = 11;
            this.search.Text = "Buscar";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // seleccion
            // 
            this.seleccion.AutoSize = true;
            this.seleccion.Location = new System.Drawing.Point(113, 189);
            this.seleccion.Name = "seleccion";
            this.seleccion.Size = new System.Drawing.Size(344, 13);
            this.seleccion.TabIndex = 12;
            this.seleccion.Text = "Seleccione el Viaje que desea comprar para ver las cabinas disponibles";
            this.seleccion.Visible = false;
            // 
            // idViaje
            // 
            this.idViaje.DataPropertyName = "idViaje";
            this.idViaje.HeaderText = "idViaje";
            this.idViaje.Name = "idViaje";
            this.idViaje.Visible = false;
            // 
            // idCrucero
            // 
            this.idCrucero.DataPropertyName = "idCrucero";
            this.idCrucero.HeaderText = "idCrucero";
            this.idCrucero.Name = "idCrucero";
            this.idCrucero.Visible = false;
            // 
            // Identificador
            // 
            this.Identificador.DataPropertyName = "Identificador";
            this.Identificador.HeaderText = "Crucero";
            this.Identificador.Name = "Identificador";
            // 
            // PuertoOrigen
            // 
            this.PuertoOrigen.DataPropertyName = "PuertoOri";
            this.PuertoOrigen.HeaderText = "Puerto Origen";
            this.PuertoOrigen.Name = "PuertoOrigen";
            // 
            // idPuertoOrigen
            // 
            this.idPuertoOrigen.DataPropertyName = "idPuertoOri";
            this.idPuertoOrigen.HeaderText = "idPuertoOrigen";
            this.idPuertoOrigen.Name = "idPuertoOrigen";
            this.idPuertoOrigen.Visible = false;
            // 
            // PuertoDestino
            // 
            this.PuertoDestino.DataPropertyName = "PuertoDest";
            this.PuertoDestino.HeaderText = "Puerto Destino";
            this.PuertoDestino.Name = "PuertoDestino";
            // 
            // idPuertoDest
            // 
            this.idPuertoDest.DataPropertyName = "idPuertoDest";
            this.idPuertoDest.HeaderText = "idPuertoDest";
            this.idPuertoDest.Name = "idPuertoDest";
            this.idPuertoDest.Visible = false;
            // 
            // FechaInicio
            // 
            this.FechaInicio.DataPropertyName = "FechaInicio";
            this.FechaInicio.HeaderText = "Fecha Inicio";
            this.FechaInicio.Name = "FechaInicio";
            // 
            // FechaFin
            // 
            this.FechaFin.DataPropertyName = "FechaFin";
            this.FechaFin.HeaderText = "Fecha Fin";
            this.FechaFin.Name = "FechaFin";
            // 
            // CompraReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 479);
            this.Controls.Add(this.seleccion);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.comboPuertoOri);
            this.Controls.Add(this.comboPuertoDest);
            this.Controls.Add(this.dgvViajes);
            this.Controls.Add(this.cancel);
            this.Name = "CompraReserva";
            this.Text = "CompraReserva";
            ((System.ComponentModel.ISupportInitialize)(this.dgvViajes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.DataGridView dgvViajes;
        private System.Windows.Forms.ComboBox comboPuertoDest;
        private System.Windows.Forms.ComboBox comboPuertoOri;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label seleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idViaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCrucero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuertoOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPuertoOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuertoDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPuertoDest;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
    }
}