namespace FrbaCrucero.AbmPuerto
{
    partial class Puertos
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
            this.components = new System.ComponentModel.Container();
            this.dgvPuertos = new System.Windows.Forms.DataGridView();
            this.idPuerto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puerto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboPuerto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.altaPuerto = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.puertoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuertos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.puertoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPuertos
            // 
            this.dgvPuertos.AllowUserToAddRows = false;
            this.dgvPuertos.AllowUserToDeleteRows = false;
            this.dgvPuertos.AllowUserToResizeRows = false;
            this.dgvPuertos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvPuertos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuertos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPuerto,
            this.Puerto});
            this.dgvPuertos.Location = new System.Drawing.Point(88, 85);
            this.dgvPuertos.MultiSelect = false;
            this.dgvPuertos.Name = "dgvPuertos";
            this.dgvPuertos.ReadOnly = true;
            this.dgvPuertos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPuertos.Size = new System.Drawing.Size(154, 86);
            this.dgvPuertos.TabIndex = 13;
            this.dgvPuertos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPuertos_CellContentClick);
            this.dgvPuertos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvPuertos_CellMouseDoubleClick);
            // 
            // idPuerto
            // 
            this.idPuerto.DataPropertyName = "idPuerto";
            this.idPuerto.HeaderText = "idPuerto";
            this.idPuerto.Name = "idPuerto";
            this.idPuerto.ReadOnly = true;
            this.idPuerto.Visible = false;
            // 
            // Puerto
            // 
            this.Puerto.DataPropertyName = "Puerto";
            this.Puerto.HeaderText = "Puerto";
            this.Puerto.Name = "Puerto";
            this.Puerto.ReadOnly = true;
            // 
            // comboPuerto
            // 
            this.comboPuerto.FormattingEnabled = true;
            this.comboPuerto.Location = new System.Drawing.Point(88, 24);
            this.comboPuerto.Name = "comboPuerto";
            this.comboPuerto.Size = new System.Drawing.Size(154, 21);
            this.comboPuerto.TabIndex = 1;
            this.comboPuerto.Text = "Seleccione Puerto";
            this.comboPuerto.SelectedIndexChanged += new System.EventHandler(this.comboPuerto_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Puerto";
            // 
            // altaPuerto
            // 
            this.altaPuerto.Location = new System.Drawing.Point(39, 197);
            this.altaPuerto.Name = "altaPuerto";
            this.altaPuerto.Size = new System.Drawing.Size(105, 23);
            this.altaPuerto.TabIndex = 3;
            this.altaPuerto.Text = "Alta";
            this.altaPuerto.UseVisualStyleBackColor = true;
            this.altaPuerto.Click += new System.EventHandler(this.altaPuerto_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(161, 197);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(111, 23);
            this.cancel.TabIndex = 14;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // puertoBindingSource
            // 
            this.puertoBindingSource.DataSource = typeof(FrbaCrucero.AbmPuerto.Puerto);
            // 
            // Puertos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 283);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.altaPuerto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboPuerto);
            this.Controls.Add(this.dgvPuertos);
            this.Name = "Puertos";
            this.Text = "Puertos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuertos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.puertoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPuertos;
        private System.Windows.Forms.ComboBox comboPuerto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button altaPuerto;
        private System.Windows.Forms.BindingSource puertoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPuerto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puerto;
        private System.Windows.Forms.Button cancel;

    }
}