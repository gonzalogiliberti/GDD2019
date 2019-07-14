namespace FrbaCrucero.CompraReservaPasaje
{
    partial class SeleccionCabina
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
            this.dgvCabinas = new System.Windows.Forms.DataGridView();
            this.labelCab = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.CantCabinas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.search = new System.Windows.Forms.Button();
            this.textCant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCabinas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCabinas
            // 
            this.dgvCabinas.AllowUserToAddRows = false;
            this.dgvCabinas.AllowUserToDeleteRows = false;
            this.dgvCabinas.AllowUserToResizeRows = false;
            this.dgvCabinas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCabinas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CantCabinas,
            this.idTipo,
            this.Tipo,
            this.Recargo});
            this.dgvCabinas.Location = new System.Drawing.Point(26, 116);
            this.dgvCabinas.Name = "dgvCabinas";
            this.dgvCabinas.Size = new System.Drawing.Size(347, 139);
            this.dgvCabinas.TabIndex = 0;
            this.dgvCabinas.Visible = false;
            this.dgvCabinas.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCabinas_CellMouseDoubleClick);
            // 
            // labelCab
            // 
            this.labelCab.AutoSize = true;
            this.labelCab.Location = new System.Drawing.Point(112, 85);
            this.labelCab.Name = "labelCab";
            this.labelCab.Size = new System.Drawing.Size(159, 13);
            this.labelCab.TabIndex = 1;
            this.labelCab.Text = "Seleccione la cabina que desea";
            this.labelCab.Visible = false;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(138, 260);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(106, 29);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // CantCabinas
            // 
            this.CantCabinas.DataPropertyName = "cantidadCabinas";
            this.CantCabinas.HeaderText = "Cabinas Disponibles";
            this.CantCabinas.Name = "CantCabinas";
            // 
            // idTipo
            // 
            this.idTipo.DataPropertyName = "idTipoCabina";
            this.idTipo.HeaderText = "idTipo";
            this.idTipo.Name = "idTipo";
            this.idTipo.Visible = false;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Nombre";
            this.Tipo.HeaderText = "Tipo de Cabina";
            this.Tipo.Name = "Tipo";
            // 
            // Recargo
            // 
            this.Recargo.DataPropertyName = "Recargo";
            this.Recargo.HeaderText = "Porcentaje de Recargo";
            this.Recargo.Name = "Recargo";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(296, 32);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(77, 39);
            this.search.TabIndex = 3;
            this.search.Text = "Buscar Cabinas";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // textCant
            // 
            this.textCant.Location = new System.Drawing.Point(142, 42);
            this.textCant.Name = "textCant";
            this.textCant.Size = new System.Drawing.Size(135, 20);
            this.textCant.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cantidad de Pasajeros";
            // 
            // SeleccionCabina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 296);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textCant);
            this.Controls.Add(this.search);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.labelCab);
            this.Controls.Add(this.dgvCabinas);
            this.Name = "SeleccionCabina";
            this.Text = "SeleccionCabina";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCabinas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCabinas;
        private System.Windows.Forms.Label labelCab;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantCabinas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recargo;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox textCant;
        private System.Windows.Forms.Label label2;
    }
}