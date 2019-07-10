namespace FrbaCrucero.AbmRecorrido
{
    partial class RemoverTramo
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
            this.dgvTramo = new System.Windows.Forms.DataGridView();
            this.idTramo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPuertoOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puertoOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPuertoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puertoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTramo)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(145, 285);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(114, 30);
            this.cancel.TabIndex = 0;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // dgvTramo
            // 
            this.dgvTramo.AllowUserToAddRows = false;
            this.dgvTramo.AllowUserToDeleteRows = false;
            this.dgvTramo.AllowUserToResizeRows = false;
            this.dgvTramo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTramo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTramo,
            this.idPuertoOrigen,
            this.puertoOrigen,
            this.idPuertoDestino,
            this.puertoDestino,
            this.Precio});
            this.dgvTramo.Location = new System.Drawing.Point(29, 65);
            this.dgvTramo.MultiSelect = false;
            this.dgvTramo.Name = "dgvTramo";
            this.dgvTramo.ReadOnly = true;
            this.dgvTramo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTramo.Size = new System.Drawing.Size(346, 214);
            this.dgvTramo.TabIndex = 3;
            this.dgvTramo.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTramo_CellMouseDoubleClick);
            // 
            // idTramo
            // 
            this.idTramo.DataPropertyName = "idTramo";
            this.idTramo.HeaderText = "idTramo";
            this.idTramo.Name = "idTramo";
            this.idTramo.ReadOnly = true;
            this.idTramo.Visible = false;
            // 
            // idPuertoOrigen
            // 
            this.idPuertoOrigen.DataPropertyName = "idPuertoOrigen";
            this.idPuertoOrigen.HeaderText = "idPuertoOrigen";
            this.idPuertoOrigen.Name = "idPuertoOrigen";
            this.idPuertoOrigen.ReadOnly = true;
            this.idPuertoOrigen.Visible = false;
            // 
            // puertoOrigen
            // 
            this.puertoOrigen.DataPropertyName = "puertoOrigen";
            this.puertoOrigen.HeaderText = "puertoOrigen";
            this.puertoOrigen.Name = "puertoOrigen";
            this.puertoOrigen.ReadOnly = true;
            // 
            // idPuertoDestino
            // 
            this.idPuertoDestino.DataPropertyName = "idPuertoDestino";
            this.idPuertoDestino.HeaderText = "idPuertoDestino";
            this.idPuertoDestino.Name = "idPuertoDestino";
            this.idPuertoDestino.ReadOnly = true;
            this.idPuertoDestino.Visible = false;
            // 
            // puertoDestino
            // 
            this.puertoDestino.DataPropertyName = "puertoDestino";
            this.puertoDestino.HeaderText = "puertoDestino";
            this.puertoDestino.Name = "puertoDestino";
            this.puertoDestino.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione el recorrido a borrar";
            // 
            // RemoverTramo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 347);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTramo);
            this.Controls.Add(this.cancel);
            this.Name = "RemoverTramo";
            this.Text = "RemoverTramo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTramo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.DataGridView dgvTramo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTramo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPuertoOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn puertoOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPuertoDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn puertoDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Label label1;
    }
}