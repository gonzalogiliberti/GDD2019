namespace FrbaCrucero.AbmCrucero
{
    partial class HistorialBaja
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
            this.dgvBaja = new System.Windows.Forms.DataGridView();
            this.cancel = new System.Windows.Forms.Button();
            this.idBaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoBaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaBaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRestauracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaja)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBaja
            // 
            this.dgvBaja.AllowUserToAddRows = false;
            this.dgvBaja.AllowUserToDeleteRows = false;
            this.dgvBaja.AllowUserToResizeRows = false;
            this.dgvBaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBaja,
            this.TipoBaja,
            this.FechaBaja,
            this.FechaRestauracion,
            this.Descripcion});
            this.dgvBaja.Location = new System.Drawing.Point(21, 83);
            this.dgvBaja.Name = "dgvBaja";
            this.dgvBaja.Size = new System.Drawing.Size(451, 237);
            this.dgvBaja.TabIndex = 0;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(175, 340);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(155, 36);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // idBaja
            // 
            this.idBaja.DataPropertyName = "idBaja";
            this.idBaja.HeaderText = "idBaja";
            this.idBaja.Name = "idBaja";
            this.idBaja.Visible = false;
            // 
            // TipoBaja
            // 
            this.TipoBaja.DataPropertyName = "Nombre";
            this.TipoBaja.HeaderText = "Tipo de Baja";
            this.TipoBaja.Name = "TipoBaja";
            // 
            // FechaBaja
            // 
            this.FechaBaja.DataPropertyName = "FechaBaja";
            this.FechaBaja.HeaderText = "FechaBaja";
            this.FechaBaja.Name = "FechaBaja";
            // 
            // FechaRestauracion
            // 
            this.FechaRestauracion.DataPropertyName = "FechaAlta";
            this.FechaRestauracion.HeaderText = "FechaRestauracion";
            this.FechaRestauracion.Name = "FechaRestauracion";
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // HistorialBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 390);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.dgvBaja);
            this.Name = "HistorialBaja";
            this.Text = "HistorialBaja";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCrucero;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRestauracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}