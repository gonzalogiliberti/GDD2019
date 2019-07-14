namespace FrbaCrucero.AbmRol
{
    partial class Funcionalidades
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
            this.cancel = new System.Windows.Forms.Button();
            this.dgvFunc = new System.Windows.Forms.DataGridView();
            this.idFuncionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Funcionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(214, 247);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(97, 34);
            this.cancel.TabIndex = 0;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
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
            this.dgvFunc.Location = new System.Drawing.Point(114, 98);
            this.dgvFunc.Name = "dgvFunc";
            this.dgvFunc.Size = new System.Drawing.Size(146, 131);
            this.dgvFunc.TabIndex = 1;
            this.dgvFunc.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFunc_CellMouseDoubleClick);
            // 
            // idFuncionalidad
            // 
            this.idFuncionalidad.DataPropertyName = "idFuncion";
            this.idFuncionalidad.HeaderText = "idFuncionalidad";
            this.idFuncionalidad.Name = "idFuncionalidad";
            this.idFuncionalidad.Visible = false;
            // 
            // Funcionalidad
            // 
            this.Funcionalidad.DataPropertyName = "nombre";
            this.Funcionalidad.HeaderText = "Funcionalidades Disponibles";
            this.Funcionalidad.Name = "Funcionalidad";
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(61, 247);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(84, 35);
            this.create.TabIndex = 2;
            this.create.Text = "Crear Funcionalidad";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 4;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(276, 18);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(84, 31);
            this.search.TabIndex = 5;
            this.search.Text = "Buscar";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seleccione la Funcionalidad a Agregar";
            // 
            // Funcionalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 311);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.create);
            this.Controls.Add(this.dgvFunc);
            this.Controls.Add(this.cancel);
            this.Name = "Funcionalidades";
            this.Text = "Funcionalidades";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.DataGridView dgvFunc;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFuncionalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Funcionalidad;
    }
}