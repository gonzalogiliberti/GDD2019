﻿namespace FrbaCrucero
{
    partial class PaginaPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.puertos = new System.Windows.Forms.Button();
            this.roles = new System.Windows.Forms.Button();
            this.recorrido = new System.Windows.Forms.Button();
            this.crucero = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.genViaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // puertos
            // 
            this.puertos.Location = new System.Drawing.Point(118, 29);
            this.puertos.Name = "puertos";
            this.puertos.Size = new System.Drawing.Size(75, 23);
            this.puertos.TabIndex = 0;
            this.puertos.Text = "Puertos";
            this.puertos.UseVisualStyleBackColor = true;
            this.puertos.Click += new System.EventHandler(this.puertos_Click);
            // 
            // roles
            // 
            this.roles.Location = new System.Drawing.Point(12, 29);
            this.roles.Name = "roles";
            this.roles.Size = new System.Drawing.Size(75, 23);
            this.roles.TabIndex = 1;
            this.roles.Text = "Roles";
            this.roles.UseVisualStyleBackColor = true;
            this.roles.Click += new System.EventHandler(this.roles_Click);
            // 
            // recorrido
            // 
            this.recorrido.Location = new System.Drawing.Point(216, 29);
            this.recorrido.Name = "recorrido";
            this.recorrido.Size = new System.Drawing.Size(75, 23);
            this.recorrido.TabIndex = 2;
            this.recorrido.Text = "Recorridos";
            this.recorrido.UseVisualStyleBackColor = true;
            this.recorrido.Click += new System.EventHandler(this.recorrido_Click);
            // 
            // crucero
            // 
            this.crucero.Location = new System.Drawing.Point(315, 29);
            this.crucero.Name = "crucero";
            this.crucero.Size = new System.Drawing.Size(75, 23);
            this.crucero.TabIndex = 3;
            this.crucero.Text = "Crucero";
            this.crucero.UseVisualStyleBackColor = true;
            this.crucero.Click += new System.EventHandler(this.crucero_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(89, 141);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Login";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(216, 141);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Comprar/Reservar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // genViaje
            // 
            this.genViaje.Location = new System.Drawing.Point(163, 75);
            this.genViaje.Name = "genViaje";
            this.genViaje.Size = new System.Drawing.Size(75, 23);
            this.genViaje.TabIndex = 6;
            this.genViaje.Text = "Viajes";
            this.genViaje.UseVisualStyleBackColor = true;
            this.genViaje.Click += new System.EventHandler(this.genViaje_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 186);
            this.Controls.Add(this.genViaje);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.crucero);
            this.Controls.Add(this.recorrido);
            this.Controls.Add(this.roles);
            this.Controls.Add(this.puertos);
            this.Name = "Form1";
            this.Text = "FrbaCrucero";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button puertos;
        private System.Windows.Forms.Button roles;
        private System.Windows.Forms.Button recorrido;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button genViaje;
        private System.Windows.Forms.Button crucero;
    }
}
