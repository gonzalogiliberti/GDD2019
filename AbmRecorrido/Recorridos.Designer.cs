namespace FrbaCrucero.AbmRecorrido
{
    partial class Recorridos
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
            this.dgvRecorrido = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.agregarRecorrido = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.idRecorrido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTramo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPuertoOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puertoOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPuertoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puertoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecorrido)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRecorrido
            // 
            this.dgvRecorrido.AllowUserToAddRows = false;
            this.dgvRecorrido.AllowUserToDeleteRows = false;
            this.dgvRecorrido.AllowUserToResizeRows = false;
            this.dgvRecorrido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecorrido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRecorrido,
            this.Estado,
            this.idTramo,
            this.Codigo,
            this.idPuertoOrigen,
            this.puertoOrigen,
            this.idPuertoDestino,
            this.puertoDestino,
            this.Precio});
            this.dgvRecorrido.Location = new System.Drawing.Point(105, 88);
            this.dgvRecorrido.Name = "dgvRecorrido";
            this.dgvRecorrido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecorrido.Size = new System.Drawing.Size(444, 214);
            this.dgvRecorrido.TabIndex = 0;
            this.dgvRecorrido.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRecorrido_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo";
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(224, 28);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(161, 20);
            this.textCodigo.TabIndex = 2;
            // 
            // agregarRecorrido
            // 
            this.agregarRecorrido.Location = new System.Drawing.Point(136, 345);
            this.agregarRecorrido.Name = "agregarRecorrido";
            this.agregarRecorrido.Size = new System.Drawing.Size(111, 23);
            this.agregarRecorrido.TabIndex = 5;
            this.agregarRecorrido.Text = "Agregar Recorrido";
            this.agregarRecorrido.UseVisualStyleBackColor = true;
            this.agregarRecorrido.Click += new System.EventHandler(this.agregarRecorrido_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(397, 345);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(113, 23);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(443, 28);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(154, 27);
            this.search.TabIndex = 8;
            this.search.Text = "Buscar";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // idRecorrido
            // 
            this.idRecorrido.DataPropertyName = "idRecorrido";
            this.idRecorrido.HeaderText = "idRecorrido";
            this.idRecorrido.Name = "idRecorrido";
            this.idRecorrido.Visible = false;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.Visible = false;
            // 
            // idTramo
            // 
            this.idTramo.DataPropertyName = "idTramo";
            this.idTramo.HeaderText = "idTramo";
            this.idTramo.Name = "idTramo";
            this.idTramo.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // idPuertoOrigen
            // 
            this.idPuertoOrigen.DataPropertyName = "idPuertoOrigen";
            this.idPuertoOrigen.HeaderText = "idPuertoOrigen";
            this.idPuertoOrigen.Name = "idPuertoOrigen";
            this.idPuertoOrigen.Visible = false;
            // 
            // puertoOrigen
            // 
            this.puertoOrigen.DataPropertyName = "puertoOrigen";
            this.puertoOrigen.HeaderText = "puertoOrigen";
            this.puertoOrigen.Name = "puertoOrigen";
            // 
            // idPuertoDestino
            // 
            this.idPuertoDestino.DataPropertyName = "idPuertoDestino";
            this.idPuertoDestino.HeaderText = "idPuertoDestino";
            this.idPuertoDestino.Name = "idPuertoDestino";
            this.idPuertoDestino.Visible = false;
            // 
            // puertoDestino
            // 
            this.puertoDestino.DataPropertyName = "puertoDestino";
            this.puertoDestino.HeaderText = "puertoDestino";
            this.puertoDestino.Name = "puertoDestino";
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Recorridos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 390);
            this.Controls.Add(this.search);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.agregarRecorrido);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvRecorrido);
            this.Name = "Recorridos";
            this.Text = "Recorrido";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecorrido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRecorrido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Button agregarRecorrido;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRecorrido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTramo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPuertoOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn puertoOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPuertoDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn puertoDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}