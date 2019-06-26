namespace FrbaCrucero.AbmRecorrido
{
    partial class AltaModificacionRecorrido
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
            this.dgvTramo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.addTramo = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.idTramo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPuertoOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puertoOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPuertoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puertoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTramo)).BeginInit();
            this.SuspendLayout();
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
            this.dgvTramo.Location = new System.Drawing.Point(83, 153);
            this.dgvTramo.MultiSelect = false;
            this.dgvTramo.Name = "dgvTramo";
            this.dgvTramo.ReadOnly = true;
            this.dgvTramo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTramo.Size = new System.Drawing.Size(346, 214);
            this.dgvTramo.TabIndex = 1;
            this.dgvTramo.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTramo_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo";
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(161, 44);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(152, 20);
            this.textCodigo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Precio Total";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(161, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 20);
            this.textBox2.TabIndex = 5;
            // 
            // addTramo
            // 
            this.addTramo.Location = new System.Drawing.Point(49, 412);
            this.addTramo.Name = "addTramo";
            this.addTramo.Size = new System.Drawing.Size(112, 27);
            this.addTramo.TabIndex = 6;
            this.addTramo.Text = "Agregar Tramo";
            this.addTramo.UseVisualStyleBackColor = true;
            this.addTramo.Click += new System.EventHandler(this.addTramo_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(282, 413);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(76, 26);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(373, 413);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(86, 26);
            this.delete.TabIndex = 8;
            this.delete.Text = "Eliminar";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(181, 413);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(81, 25);
            this.save.TabIndex = 9;
            this.save.Text = "Guardar";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
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
            // AltaModificacionRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 450);
            this.Controls.Add(this.save);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.addTramo);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTramo);
            this.Name = "AltaModificacionRecorrido";
            this.Text = "AltaModificacionRecorrido";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTramo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTramo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button addTramo;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTramo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPuertoOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn puertoOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPuertoDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn puertoDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;

    }
}