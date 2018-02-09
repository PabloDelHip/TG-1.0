namespace CapaPresentacion
{
    partial class FrmIngresarRetirar
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
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.btnTipoMovimiento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Observacion :";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(148, 20);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(642, 26);
            this.txtCantidad.TabIndex = 2;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(148, 89);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(642, 102);
            this.txtObservacion.TabIndex = 3;
            // 
            // btnTipoMovimiento
            // 
            this.btnTipoMovimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoMovimiento.Image = global::CapaPresentacion.Properties.Resources.money_1;
            this.btnTipoMovimiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTipoMovimiento.Location = new System.Drawing.Point(560, 229);
            this.btnTipoMovimiento.Name = "btnTipoMovimiento";
            this.btnTipoMovimiento.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnTipoMovimiento.Size = new System.Drawing.Size(230, 50);
            this.btnTipoMovimiento.TabIndex = 4;
            this.btnTipoMovimiento.Text = "Ingresar";
            this.btnTipoMovimiento.UseVisualStyleBackColor = true;
            // 
            // FrmIngresarRetirar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 300);
            this.Controls.Add(this.btnTipoMovimiento);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmIngresarRetirar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Ingresar y Retirar";
            this.Load += new System.EventHandler(this.FrmIngresarRetirar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Button btnTipoMovimiento;
    }
}