namespace FrbaCrucero.AbmCrucero
{
    partial class Cruceros
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
            this.dgvCruise = new System.Windows.Forms.DataGridView();
            this.comboModelo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textIdentificador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboFabricante = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.newCruise = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.idCrucero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdFabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadCabinas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCruise)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCruise
            // 
            this.dgvCruise.AllowUserToAddRows = false;
            this.dgvCruise.AllowUserToDeleteRows = false;
            this.dgvCruise.AllowUserToResizeRows = false;
            this.dgvCruise.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvCruise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCruise.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCrucero,
            this.Activo,
            this.Modelo,
            this.Identificador,
            this.IdFabricante,
            this.Fabricante,
            this.CantidadCabinas,
            this.FechaAlta});
            this.dgvCruise.Location = new System.Drawing.Point(46, 156);
            this.dgvCruise.MultiSelect = false;
            this.dgvCruise.Name = "dgvCruise";
            this.dgvCruise.ReadOnly = true;
            this.dgvCruise.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCruise.Size = new System.Drawing.Size(543, 203);
            this.dgvCruise.TabIndex = 0;
            this.dgvCruise.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCruise_CellMouseDoubleClick);
            // 
            // comboModelo
            // 
            this.comboModelo.FormattingEnabled = true;
            this.comboModelo.Location = new System.Drawing.Point(109, 34);
            this.comboModelo.Name = "comboModelo";
            this.comboModelo.Size = new System.Drawing.Size(121, 21);
            this.comboModelo.TabIndex = 1;
            this.comboModelo.Text = "Seleccione Modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Modelo";
            // 
            // textIdentificador
            // 
            this.textIdentificador.Location = new System.Drawing.Point(399, 31);
            this.textIdentificador.Name = "textIdentificador";
            this.textIdentificador.Size = new System.Drawing.Size(144, 20);
            this.textIdentificador.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Identificador";
            // 
            // comboFabricante
            // 
            this.comboFabricante.FormattingEnabled = true;
            this.comboFabricante.Location = new System.Drawing.Point(109, 93);
            this.comboFabricante.Name = "comboFabricante";
            this.comboFabricante.Size = new System.Drawing.Size(118, 21);
            this.comboFabricante.TabIndex = 5;
            this.comboFabricante.Text = "Seleccione Fabricante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fabricante";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(399, 96);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(144, 21);
            this.search.TabIndex = 7;
            this.search.Text = "Buscar";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // newCruise
            // 
            this.newCruise.Location = new System.Drawing.Point(80, 399);
            this.newCruise.Name = "newCruise";
            this.newCruise.Size = new System.Drawing.Size(134, 31);
            this.newCruise.TabIndex = 8;
            this.newCruise.Text = "Alta";
            this.newCruise.UseVisualStyleBackColor = true;
            this.newCruise.Click += new System.EventHandler(this.newCruise_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(315, 399);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(143, 26);
            this.cancel.TabIndex = 9;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // idCrucero
            // 
            this.idCrucero.DataPropertyName = "idCrucero";
            this.idCrucero.HeaderText = "idCrucero";
            this.idCrucero.Name = "idCrucero";
            this.idCrucero.ReadOnly = true;
            this.idCrucero.Visible = false;
            // 
            // Activo
            // 
            this.Activo.DataPropertyName = "Activo";
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Visible = false;
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "Modelo";
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // Identificador
            // 
            this.Identificador.DataPropertyName = "Identificador";
            this.Identificador.HeaderText = "Identificador";
            this.Identificador.Name = "Identificador";
            this.Identificador.ReadOnly = true;
            // 
            // IdFabricante
            // 
            this.IdFabricante.DataPropertyName = "IdFabricante";
            this.IdFabricante.HeaderText = "IdFabricante";
            this.IdFabricante.Name = "IdFabricante";
            this.IdFabricante.ReadOnly = true;
            this.IdFabricante.Visible = false;
            // 
            // Fabricante
            // 
            this.Fabricante.DataPropertyName = "Fabricante";
            this.Fabricante.HeaderText = "Fabricante";
            this.Fabricante.Name = "Fabricante";
            this.Fabricante.ReadOnly = true;
            // 
            // CantidadCabinas
            // 
            this.CantidadCabinas.DataPropertyName = "CantidadCabinas";
            this.CantidadCabinas.HeaderText = "CantidadCabinas";
            this.CantidadCabinas.Name = "CantidadCabinas";
            this.CantidadCabinas.ReadOnly = true;
            // 
            // FechaAlta
            // 
            this.FechaAlta.DataPropertyName = "FechaAlta";
            this.FechaAlta.HeaderText = "FechaAlta";
            this.FechaAlta.Name = "FechaAlta";
            this.FechaAlta.ReadOnly = true;
            // 
            // Cruceros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 466);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.newCruise);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboFabricante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textIdentificador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboModelo);
            this.Controls.Add(this.dgvCruise);
            this.Name = "Cruceros";
            this.Text = "Cruceros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCruise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCruise;
        private System.Windows.Forms.ComboBox comboModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textIdentificador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboFabricante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button newCruise;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCrucero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadCabinas;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAlta;
    }
}