namespace Finanzas
{
    partial class frmVerMensuales
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
            this.label67 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.cmbNombreTipo = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dtpFechaCarga = new System.Windows.Forms.DateTimePicker();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMes);
            this.groupBox1.Controls.Add(this.label67);
            this.groupBox1.Controls.Add(this.dtpFechaCarga);
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.cmbNombreTipo);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 201);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ver/Modificar";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.Location = new System.Drawing.Point(24, 162);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(45, 15);
            this.label67.TabIndex = 107;
            this.label67.Text = "Monto:";
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(168, 160);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(182, 21);
            this.txtMonto.TabIndex = 108;
            // 
            // cmbNombreTipo
            // 
            this.cmbNombreTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNombreTipo.FormattingEnabled = true;
            this.cmbNombreTipo.Items.AddRange(new object[] {
            "Abono telefono 1",
            "Abono telefono 2",
            "Alquiler",
            "Banco*",
            "Banco 1",
            "Banco 2",
            "Cable*",
            "Cochera*",
            "Cochera 1",
            "Cochera 2",
            "Colegio*",
            "Colegio 1",
            "Colegio 2",
            "Comida mensual",
            "Combustible",
            "Carrera",
            "Cooperativa/Luz",
            "Cooperativa/Telefono",
            "Cooperativa/Agua",
            "Cooperativa*",
            "Escuela*",
            "Escuela 1",
            "Escuela 2",
            "Gas",
            "Internet*",
            "Jardín",
            "Mutual*",
            "Mutual 1",
            "Mutual 2",
            "Prestamo*",
            "Prestamo1",
            "Prestamo2",
            "Prestamo3",
            "Seguro Auto*",
            "Seguro Auto 1",
            "Seguro Auto 2",
            "Seguro Auto 3",
            "Seguro Moto*",
            "Seguro Moto 1",
            "Seguro Moto 2",
            "Supermercado*",
            "Supermercado1",
            "Supermercado2",
            "Tarjeta de crédito 1",
            "Tarjeta de crédito 2",
            "Tarjeta de crédito 3",
            "Tarjeta de crédito 4",
            "Otro*"});
            this.cmbNombreTipo.Location = new System.Drawing.Point(168, 114);
            this.cmbNombreTipo.Name = "cmbNombreTipo";
            this.cmbNombreTipo.Size = new System.Drawing.Size(182, 23);
            this.cmbNombreTipo.TabIndex = 106;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(24, 117);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(81, 15);
            this.label20.TabIndex = 105;
            this.label20.Text = "Nombre/ tipo:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(24, 76);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 15);
            this.label19.TabIndex = 103;
            this.label19.Text = "Mes:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(24, 31);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 15);
            this.label18.TabIndex = 102;
            this.label18.Text = "Fecha de Carga:";
            // 
            // dtpFechaCarga
            // 
            this.dtpFechaCarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCarga.Location = new System.Drawing.Point(168, 28);
            this.dtpFechaCarga.Name = "dtpFechaCarga";
            this.dtpFechaCarga.Size = new System.Drawing.Size(182, 21);
            this.dtpFechaCarga.TabIndex = 101;
            // 
            // cmbMes
            // 
            this.cmbMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Items.AddRange(new object[] {
            "ENERO",
            "FEBRERO",
            "MARZO",
            "ABRIL",
            "MAYO",
            "JUNIO",
            "JULIO",
            "AGOSTO",
            "SEPTIEMBRE",
            "OCTUBRE",
            "NOVIEMBRE",
            "DICIEMBRE"});
            this.cmbMes.Location = new System.Drawing.Point(168, 70);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(182, 23);
            this.cmbMes.TabIndex = 104;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(308, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 111;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmVerMensuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 264);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmVerMensuales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVerMensuales";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.DateTimePicker dtpFechaCarga;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbNombreTipo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button2;
    }
}