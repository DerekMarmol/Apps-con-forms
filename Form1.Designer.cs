namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtdistancia = new System.Windows.Forms.TextBox();
            this.txtgalones = new System.Windows.Forms.TextBox();
            this.lblrendimiento = new System.Windows.Forms.Label();
            this.lblgalonesconsumidos = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtdistancia
            // 
            this.txtdistancia.Location = new System.Drawing.Point(179, 64);
            this.txtdistancia.Name = "txtdistancia";
            this.txtdistancia.Size = new System.Drawing.Size(447, 20);
            this.txtdistancia.TabIndex = 0;
            this.txtdistancia.Text = "Agregue los kilometros recorridos";
            this.txtdistancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtdistancia.TextChanged += new System.EventHandler(this.txtdistancia_TextChanged);
            // 
            // txtgalones
            // 
            this.txtgalones.Location = new System.Drawing.Point(226, 110);
            this.txtgalones.Name = "txtgalones";
            this.txtgalones.Size = new System.Drawing.Size(353, 20);
            this.txtgalones.TabIndex = 1;
            this.txtgalones.Text = "Escriba los galones consumidos";
            this.txtgalones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblrendimiento
            // 
            this.lblrendimiento.AutoSize = true;
            this.lblrendimiento.Location = new System.Drawing.Point(395, 91);
            this.lblrendimiento.Name = "lblrendimiento";
            this.lblrendimiento.Size = new System.Drawing.Size(0, 13);
            this.lblrendimiento.TabIndex = 2;
            this.lblrendimiento.Click += new System.EventHandler(this.lblrendimiento_Click);
            // 
            // lblgalonesconsumidos
            // 
            this.lblgalonesconsumidos.AutoSize = true;
            this.lblgalonesconsumidos.Location = new System.Drawing.Point(398, 137);
            this.lblgalonesconsumidos.Name = "lblgalonesconsumidos";
            this.lblgalonesconsumidos.Size = new System.Drawing.Size(0, 13);
            this.lblgalonesconsumidos.TabIndex = 3;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(345, 280);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(152, 23);
            this.btncalcular.TabIndex = 4;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lblgalonesconsumidos);
            this.Controls.Add(this.lblrendimiento);
            this.Controls.Add(this.txtgalones);
            this.Controls.Add(this.txtdistancia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdistancia;
        private System.Windows.Forms.TextBox txtgalones;
        private System.Windows.Forms.Label lblrendimiento;
        private System.Windows.Forms.Label lblgalonesconsumidos;
        private System.Windows.Forms.Button btncalcular;
    }
}

