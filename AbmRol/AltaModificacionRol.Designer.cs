namespace FrbaCrucero.AbmRol
{
    partial class AltaModificacionRol
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
            this.label1 = new System.Windows.Forms.Label();
            this.textRol = new System.Windows.Forms.TextBox();
            this.dgvFuncionalidad = new System.Windows.Forms.DataGridView();
            this.save = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.idFuncionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funcionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addFunction = new System.Windows.Forms.Button();
            this.deleteFuncionalidad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionalidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rol";
            // 
            // textRol
            // 
            this.textRol.Location = new System.Drawing.Point(145, 34);
            this.textRol.Name = "textRol";
            this.textRol.Size = new System.Drawing.Size(133, 20);
            this.textRol.TabIndex = 1;
            // 
            // dgvFuncionalidad
            // 
            this.dgvFuncionalidad.AllowUserToAddRows = false;
            this.dgvFuncionalidad.AllowUserToDeleteRows = false;
            this.dgvFuncionalidad.AllowUserToResizeRows = false;
            this.dgvFuncionalidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionalidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFuncionalidad,
            this.Funcionalidad});
            this.dgvFuncionalidad.Location = new System.Drawing.Point(95, 89);
            this.dgvFuncionalidad.Name = "dgvFuncionalidad";
            this.dgvFuncionalidad.Size = new System.Drawing.Size(144, 133);
            this.dgvFuncionalidad.TabIndex = 2;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(20, 246);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(88, 30);
            this.save.TabIndex = 3;
            this.save.Text = "Guardar";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(132, 246);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(85, 30);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(237, 246);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(78, 30);
            this.delete.TabIndex = 5;
            this.delete.Text = "Eliminar";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // idFuncionalidad
            // 
            this.idFuncionalidad.DataPropertyName = "idFuncionalidad";
            this.idFuncionalidad.HeaderText = "idFuncionalidad";
            this.idFuncionalidad.Name = "idFuncionalidad";
            this.idFuncionalidad.Visible = false;
            // 
            // Funcionalidad
            // 
            this.Funcionalidad.DataPropertyName = "Funcionalidad";
            this.Funcionalidad.HeaderText = "Funcionalidad";
            this.Funcionalidad.Name = "Funcionalidad";
            // 
            // addFunction
            // 
            this.addFunction.Location = new System.Drawing.Point(20, 281);
            this.addFunction.Name = "addFunction";
            this.addFunction.Size = new System.Drawing.Size(146, 28);
            this.addFunction.TabIndex = 6;
            this.addFunction.Text = "Agregar Funcionalidad";
            this.addFunction.UseVisualStyleBackColor = true;
            this.addFunction.Click += new System.EventHandler(this.addFunction_Click);
            // 
            // deleteFuncionalidad
            // 
            this.deleteFuncionalidad.Location = new System.Drawing.Point(190, 282);
            this.deleteFuncionalidad.Name = "deleteFuncionalidad";
            this.deleteFuncionalidad.Size = new System.Drawing.Size(125, 27);
            this.deleteFuncionalidad.TabIndex = 7;
            this.deleteFuncionalidad.Text = "Eliminar Funcionalidad";
            this.deleteFuncionalidad.UseVisualStyleBackColor = true;
            this.deleteFuncionalidad.Click += new System.EventHandler(this.deleteFuncionalidad_Click);
            // 
            // AltaModificacionRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 310);
            this.Controls.Add(this.deleteFuncionalidad);
            this.Controls.Add(this.addFunction);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.save);
            this.Controls.Add(this.dgvFuncionalidad);
            this.Controls.Add(this.textRol);
            this.Controls.Add(this.label1);
            this.Name = "AltaModificacionRol";
            this.Text = "Alta Modificacion Rol";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionalidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textRol;
        private System.Windows.Forms.DataGridView dgvFuncionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFuncionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionalidad;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button addFunction;
        private System.Windows.Forms.Button deleteFuncionalidad;
    }
}