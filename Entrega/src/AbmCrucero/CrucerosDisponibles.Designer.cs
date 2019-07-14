namespace FrbaCrucero.AbmCrucero
{
    partial class CrucerosDisponibles
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
            this.dgvCrucero = new System.Windows.Forms.DataGridView();
            this.create = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CantidadCabinas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCrucero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrucero)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCrucero
            // 
            this.dgvCrucero.AllowUserToAddRows = false;
            this.dgvCrucero.AllowUserToDeleteRows = false;
            this.dgvCrucero.AllowUserToResizeRows = false;
            this.dgvCrucero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCrucero.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCrucero,
            this.Identificador,
            this.Modelo,
            this.Fabricante,
            this.CantidadCabinas});
            this.dgvCrucero.Location = new System.Drawing.Point(26, 69);
            this.dgvCrucero.Name = "dgvCrucero";
            this.dgvCrucero.Size = new System.Drawing.Size(447, 200);
            this.dgvCrucero.TabIndex = 0;
            this.dgvCrucero.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCrucero_CellMouseDoubleClick);
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(98, 286);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(97, 34);
            this.create.TabIndex = 1;
            this.create.Text = "Crear Crucero";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(253, 286);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(91, 34);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione un crucero de la lista, si esta vacio debera crear un nuevo crucero";
            // 
            // CantidadCabinas
            // 
            this.CantidadCabinas.DataPropertyName = "CantidadCabinas";
            this.CantidadCabinas.HeaderText = "Cantidad de Cabinas";
            this.CantidadCabinas.Name = "CantidadCabinas";
            // 
            // Fabricante
            // 
            this.Fabricante.DataPropertyName = "Fabricante";
            this.Fabricante.HeaderText = "Fabricante";
            this.Fabricante.Name = "Fabricante";
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "Modelo";
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            // 
            // Identificador
            // 
            this.Identificador.DataPropertyName = "Identificador";
            this.Identificador.HeaderText = "Identificador";
            this.Identificador.Name = "Identificador";
            // 
            // idCrucero
            // 
            this.idCrucero.DataPropertyName = "intCrucero";
            this.idCrucero.HeaderText = "idCrucero";
            this.idCrucero.Name = "idCrucero";
            this.idCrucero.Visible = false;
            // 
            // CrucerosDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 337);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.create);
            this.Controls.Add(this.dgvCrucero);
            this.Name = "CrucerosDisponibles";
            this.Text = "CrucerosDisponibles";
            this.Load += new System.EventHandler(this.CrucerosDisponibles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCrucero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCrucero;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCrucero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadCabinas;
    }
}