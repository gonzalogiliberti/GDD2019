namespace FrbaCrucero.AbmRol
{
    partial class RemoverFuncionalidad
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
            this.dgvFunc = new System.Windows.Forms.DataGridView();
            this.idFuncionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funcionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFunc
            // 
            this.dgvFunc.AllowUserToAddRows = false;
            this.dgvFunc.AllowUserToDeleteRows = false;
            this.dgvFunc.AllowUserToResizeRows = false;
            this.dgvFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFuncionalidad,
            this.Funcionalidad});
            this.dgvFunc.Location = new System.Drawing.Point(69, 65);
            this.dgvFunc.Name = "dgvFunc";
            this.dgvFunc.Size = new System.Drawing.Size(146, 131);
            this.dgvFunc.TabIndex = 2;
            this.dgvFunc.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFunc_CellMouseDoubleClick);
            // 
            // idFuncionalidad
            // 
            this.idFuncionalidad.HeaderText = "idFuncionalidad";
            this.idFuncionalidad.Name = "idFuncionalidad";
            this.idFuncionalidad.Visible = false;
            // 
            // Funcionalidad
            // 
            this.Funcionalidad.HeaderText = "Funcionalidades Asignadas";
            this.Funcionalidad.Name = "Funcionalidad";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(103, 215);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(82, 34);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione la Funcionalidad a Remover del Rol";
            // 
            // RemoverFuncionalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.dgvFunc);
            this.Name = "RemoverFuncionalidad";
            this.Text = "RemoverFuncionalidad";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFuncionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionalidad;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label1;
    }
}