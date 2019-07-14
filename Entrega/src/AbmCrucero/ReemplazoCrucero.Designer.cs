namespace FrbaCrucero.AbmCrucero
{
    partial class ReemplazoCrucero
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
            this.dgvViaje = new System.Windows.Forms.DataGridView();
            this.cancel = new System.Windows.Forms.Button();
            this.idViaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recorrido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViaje)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViaje
            // 
            this.dgvViaje.AllowUserToAddRows = false;
            this.dgvViaje.AllowUserToDeleteRows = false;
            this.dgvViaje.AllowUserToResizeRows = false;
            this.dgvViaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViaje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idViaje,
            this.FechaInicio,
            this.FechaFin,
            this.Recorrido});
            this.dgvViaje.Location = new System.Drawing.Point(92, 77);
            this.dgvViaje.Name = "dgvViaje";
            this.dgvViaje.Size = new System.Drawing.Size(346, 238);
            this.dgvViaje.TabIndex = 0;
            this.dgvViaje.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvViaje_CellMouseDoubleClick);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(201, 343);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(125, 38);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Volver";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // idViaje
            // 
            this.idViaje.DataPropertyName = "idViaje";
            this.idViaje.HeaderText = "idViaje";
            this.idViaje.Name = "idViaje";
            this.idViaje.Visible = false;
            // 
            // FechaInicio
            // 
            this.FechaInicio.DataPropertyName = "FechaInicio";
            this.FechaInicio.HeaderText = "Fecha de Inicio";
            this.FechaInicio.Name = "FechaInicio";
            // 
            // FechaFin
            // 
            this.FechaFin.DataPropertyName = "FechaFin";
            this.FechaFin.HeaderText = "Fecha de Fin";
            this.FechaFin.Name = "FechaFin";
            // 
            // Recorrido
            // 
            this.Recorrido.DataPropertyName = "Recorrido";
            this.Recorrido.HeaderText = "Recorrido";
            this.Recorrido.Name = "Recorrido";
            // 
            // ReemplazoCrucero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 405);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.dgvViaje);
            this.Name = "ReemplazoCrucero";
            this.Text = "ReemplazoCrucero";
            ((System.ComponentModel.ISupportInitialize)(this.dgvViaje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViaje;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idViaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recorrido;
    }
}