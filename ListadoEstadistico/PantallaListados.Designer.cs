namespace FrbaCrucero.ListadoEstadistico
{
    partial class PantallaListados
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboSemestre = new System.Windows.Forms.ComboBox();
            this.comboTipoListado = new System.Windows.Forms.ComboBox();
            this.textFecha = new System.Windows.Forms.TextBox();
            this.genListado = new System.Windows.Forms.Button();
            this.listadosGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.listadosGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Semestre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo de Listado";
            // 
            // comboSemestre
            // 
            this.comboSemestre.FormattingEnabled = true;
            this.comboSemestre.Items.AddRange(new object[] {
            "Primer semestre",
            "Segundo semestre"});
            this.comboSemestre.Location = new System.Drawing.Point(78, 49);
            this.comboSemestre.Name = "comboSemestre";
            this.comboSemestre.Size = new System.Drawing.Size(162, 21);
            this.comboSemestre.TabIndex = 4;
            this.comboSemestre.Text = "Seleccione un Semestre";
            // 
            // comboTipoListado
            // 
            this.comboTipoListado.FormattingEnabled = true;
            this.comboTipoListado.Items.AddRange(new object[] {
            "Recorridos con mayor cantidad de pasajes comprados",
            "Recorridos con mas cabinas libres en cada viaje realizado",
            "Cruceros con mayor cantidad de dias fuera de servicio"});
            this.comboTipoListado.Location = new System.Drawing.Point(116, 85);
            this.comboTipoListado.Name = "comboTipoListado";
            this.comboTipoListado.Size = new System.Drawing.Size(428, 21);
            this.comboTipoListado.TabIndex = 5;
            this.comboTipoListado.Text = "Seleccione un Listado de los siguientes:";
            // 
            // textFecha
            // 
            this.textFecha.Location = new System.Drawing.Point(78, 10);
            this.textFecha.Name = "textFecha";
            this.textFecha.Size = new System.Drawing.Size(162, 20);
            this.textFecha.TabIndex = 6;
            // 
            // genListado
            // 
            this.genListado.Location = new System.Drawing.Point(387, 19);
            this.genListado.Name = "genListado";
            this.genListado.Size = new System.Drawing.Size(213, 34);
            this.genListado.TabIndex = 8;
            this.genListado.Text = "Generar Listado";
            this.genListado.UseVisualStyleBackColor = true;
            this.genListado.Click += new System.EventHandler(this.genListado_Click);
            // 
            // listadosGrid
            // 
            this.listadosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadosGrid.Location = new System.Drawing.Point(15, 134);
            this.listadosGrid.Name = "listadosGrid";
            this.listadosGrid.Size = new System.Drawing.Size(639, 367);
            this.listadosGrid.TabIndex = 9;
            // 
            // PantallaListados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 513);
            this.Controls.Add(this.listadosGrid);
            this.Controls.Add(this.genListado);
            this.Controls.Add(this.textFecha);
            this.Controls.Add(this.comboTipoListado);
            this.Controls.Add(this.comboSemestre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PantallaListados";
            this.Text = "Listados Estadisticos";
            ((System.ComponentModel.ISupportInitialize)(this.listadosGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboSemestre;
        private System.Windows.Forms.ComboBox comboTipoListado;
        private System.Windows.Forms.TextBox textFecha;
        private System.Windows.Forms.Button genListado;
        private System.Windows.Forms.DataGridView listadosGrid;
    }
}