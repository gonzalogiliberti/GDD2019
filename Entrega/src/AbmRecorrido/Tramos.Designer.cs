namespace FrbaCrucero.AbmRecorrido
{
    partial class Tramos
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
            this.idTramo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPuertoOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puertoOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPuertoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puertoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crearTramo = new System.Windows.Forms.Button();
            this.comboOrigen = new System.Windows.Forms.ComboBox();
            this.comboDestino = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
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
            this.dgvTramo.Location = new System.Drawing.Point(71, 152);
            this.dgvTramo.MultiSelect = false;
            this.dgvTramo.Name = "dgvTramo";
            this.dgvTramo.ReadOnly = true;
            this.dgvTramo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTramo.Size = new System.Drawing.Size(346, 214);
            this.dgvTramo.TabIndex = 2;
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
            // crearTramo
            // 
            this.crearTramo.Location = new System.Drawing.Point(71, 396);
            this.crearTramo.Name = "crearTramo";
            this.crearTramo.Size = new System.Drawing.Size(103, 27);
            this.crearTramo.TabIndex = 3;
            this.crearTramo.Text = "Crear Tramo";
            this.crearTramo.UseVisualStyleBackColor = true;
            this.crearTramo.Click += new System.EventHandler(this.crearTramo_Click);
            // 
            // comboOrigen
            // 
            this.comboOrigen.FormattingEnabled = true;
            this.comboOrigen.Location = new System.Drawing.Point(174, 41);
            this.comboOrigen.Name = "comboOrigen";
            this.comboOrigen.Size = new System.Drawing.Size(149, 21);
            this.comboOrigen.TabIndex = 5;
            // 
            // comboDestino
            // 
            this.comboDestino.FormattingEnabled = true;
            this.comboDestino.Location = new System.Drawing.Point(174, 81);
            this.comboDestino.Name = "comboDestino";
            this.comboDestino.Size = new System.Drawing.Size(149, 21);
            this.comboDestino.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Puerto Origen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Puerto Destino";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(369, 57);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(105, 30);
            this.search.TabIndex = 9;
            this.search.Text = "Buscar";
            this.search.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Seleccione el Tramo que desea Agregar";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(313, 397);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(104, 25);
            this.cancel.TabIndex = 11;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Tramos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 451);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboDestino);
            this.Controls.Add(this.comboOrigen);
            this.Controls.Add(this.crearTramo);
            this.Controls.Add(this.dgvTramo);
            this.Name = "Tramos";
            this.Text = "Tramos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTramo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTramo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTramo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPuertoOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn puertoOrigen;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPuertoDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn puertoDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Button crearTramo;
        private System.Windows.Forms.ComboBox comboOrigen;
        private System.Windows.Forms.ComboBox comboDestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancel;
    }
}