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
            this.dgvPuertos = new System.Windows.Forms.DataGridView();
            this.idPuerto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puerto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboPuerto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuertos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPuertos
            // 
            this.dgvPuertos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuertos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPuerto,
            this.Puerto});
            this.dgvPuertos.Location = new System.Drawing.Point(68, 123);
            this.dgvPuertos.Name = "dgvPuertos";
            this.dgvPuertos.Size = new System.Drawing.Size(143, 43);
            this.dgvPuertos.TabIndex = 0;
            this.dgvPuertos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPuertos_CellContentClick);
            // 
            // idPuerto
            // 
            this.idPuerto.HeaderText = "idPuerto";
            this.idPuerto.Name = "idPuerto";
            this.idPuerto.Visible = false;
            // 
            // Puerto
            // 
            this.Puerto.HeaderText = "Puerto";
            this.Puerto.Name = "Puerto";
            // 
            // comboPuerto
            // 
            this.comboPuerto.FormattingEnabled = true;
            this.comboPuerto.Location = new System.Drawing.Point(88, 24);
            this.comboPuerto.Name = "comboPuerto";
            this.comboPuerto.Size = new System.Drawing.Size(154, 21);
            this.comboPuerto.TabIndex = 1;
            this.comboPuerto.Text = "Seleccione Puerto";
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
            // Puertos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 283);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboPuerto);
            this.Controls.Add(this.dgvPuertos);
            this.Name = "Puertos";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuertos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPuertos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPuerto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puerto;
        private System.Windows.Forms.ComboBox comboPuerto;
        private System.Windows.Forms.Label label1;

    }
}