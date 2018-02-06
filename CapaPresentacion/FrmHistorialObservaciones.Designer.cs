namespace CapaPresentacion
{
    partial class FrmHistorialObservaciones
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarH = new System.Windows.Forms.Button();
            this.btnGenerarReporteH = new System.Windows.Forms.Button();
            this.dtpFinBusquedaH = new System.Windows.Forms.DateTimePicker();
            this.dtpInicioBusquedaH = new System.Windows.Forms.DateTimePicker();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvObGenerales = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvObCaja = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObGenerales)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObCaja)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarH);
            this.groupBox1.Controls.Add(this.btnGenerarReporteH);
            this.groupBox1.Controls.Add(this.dtpFinBusquedaH);
            this.groupBox1.Controls.Add(this.dtpInicioBusquedaH);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1168, 287);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // btnBuscarH
            // 
            this.btnBuscarH.Image = global::CapaPresentacion.Properties.Resources.search;
            this.btnBuscarH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarH.Location = new System.Drawing.Point(602, 200);
            this.btnBuscarH.Name = "btnBuscarH";
            this.btnBuscarH.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnBuscarH.Size = new System.Drawing.Size(213, 50);
            this.btnBuscarH.TabIndex = 7;
            this.btnBuscarH.Text = "Buscar";
            this.btnBuscarH.UseVisualStyleBackColor = true;
            this.btnBuscarH.Click += new System.EventHandler(this.btnBuscarH_Click);
            // 
            // btnGenerarReporteH
            // 
            this.btnGenerarReporteH.Enabled = false;
            this.btnGenerarReporteH.Image = global::CapaPresentacion.Properties.Resources.add1;
            this.btnGenerarReporteH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarReporteH.Location = new System.Drawing.Point(869, 198);
            this.btnGenerarReporteH.Name = "btnGenerarReporteH";
            this.btnGenerarReporteH.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnGenerarReporteH.Size = new System.Drawing.Size(278, 50);
            this.btnGenerarReporteH.TabIndex = 6;
            this.btnGenerarReporteH.Text = "Generar Reporte";
            this.btnGenerarReporteH.UseVisualStyleBackColor = true;
            this.btnGenerarReporteH.Click += new System.EventHandler(this.btnGenerarReporteH_Click);
            // 
            // dtpFinBusquedaH
            // 
            this.dtpFinBusquedaH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinBusquedaH.Location = new System.Drawing.Point(832, 143);
            this.dtpFinBusquedaH.Name = "dtpFinBusquedaH";
            this.dtpFinBusquedaH.Size = new System.Drawing.Size(315, 26);
            this.dtpFinBusquedaH.TabIndex = 5;
            // 
            // dtpInicioBusquedaH
            // 
            this.dtpInicioBusquedaH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicioBusquedaH.Location = new System.Drawing.Point(248, 143);
            this.dtpInicioBusquedaH.Name = "dtpInicioBusquedaH";
            this.dtpInicioBusquedaH.Size = new System.Drawing.Size(315, 26);
            this.dtpInicioBusquedaH.TabIndex = 4;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(146, 80);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(452, 26);
            this.txtUsuario.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha final de busqueda :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha inicio de busqueda :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Usuario :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvObGenerales);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1168, 258);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Historial de Observaciones Generales";
            // 
            // dgvObGenerales
            // 
            this.dgvObGenerales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObGenerales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvObGenerales.Location = new System.Drawing.Point(3, 22);
            this.dgvObGenerales.Name = "dgvObGenerales";
            this.dgvObGenerales.Size = new System.Drawing.Size(1162, 233);
            this.dgvObGenerales.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvObCaja);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(8, 591);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1168, 258);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Historial de Observaciones de Caja";
            // 
            // dgvObCaja
            // 
            this.dgvObCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObCaja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvObCaja.Location = new System.Drawing.Point(3, 22);
            this.dgvObCaja.Name = "dgvObCaja";
            this.dgvObCaja.Size = new System.Drawing.Size(1162, 233);
            this.dgvObCaja.TabIndex = 0;
            // 
            // FrmHistorialObservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 861);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmHistorialObservaciones";
            this.Text = "FrmHistorialObservaciones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObGenerales)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObCaja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarH;
        private System.Windows.Forms.Button btnGenerarReporteH;
        private System.Windows.Forms.DateTimePicker dtpFinBusquedaH;
        private System.Windows.Forms.DateTimePicker dtpInicioBusquedaH;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvObGenerales;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvObCaja;
    }
}