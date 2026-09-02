namespace prySP03
{
    partial class ingresoRepuestos
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
            this.lblMarca = new System.Windows.Forms.Label();
            this.cmbBoxMarcas = new System.Windows.Forms.ComboBox();
            this.lblOrigDeRepuesto = new System.Windows.Forms.Label();
            this.cmbBoxOrigenDeRepuesto = new System.Windows.Forms.ComboBox();
            this.lblNumeroDeRepuesto = new System.Windows.Forms.Label();
            this.txtBoxNumeroDeRepuestos = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtboxDescripcion = new System.Windows.Forms.TextBox();
            this.btnIngresarRepuesto = new System.Windows.Forms.Button();
            this.lblFiltrarMarca = new System.Windows.Forms.Label();
            this.lblFiltrarOrigen = new System.Windows.Forms.Label();
            this.cmbBoxFiltrarMarca = new System.Windows.Forms.ComboBox();
            this.btnConsultarRepuestos = new System.Windows.Forms.Button();
            this.lstBoxConsulta = new System.Windows.Forms.ListBox();
            this.rbtnNacional = new System.Windows.Forms.RadioButton();
            this.rbtnImportado = new System.Windows.Forms.RadioButton();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtBoxPrecio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblMarca.Location = new System.Drawing.Point(12, 47);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(45, 15);
            this.lblMarca.TabIndex = 0;
            this.lblMarca.Text = "Marca:";
            // 
            // cmbBoxMarcas
            // 
            this.cmbBoxMarcas.FormattingEnabled = true;
            this.cmbBoxMarcas.Items.AddRange(new object[] {
            "P(Peugeot)",
            "F(Fiat)",
            "R(Renault)"});
            this.cmbBoxMarcas.Location = new System.Drawing.Point(156, 43);
            this.cmbBoxMarcas.Name = "cmbBoxMarcas";
            this.cmbBoxMarcas.Size = new System.Drawing.Size(51, 21);
            this.cmbBoxMarcas.TabIndex = 1;
            // 
            // lblOrigDeRepuesto
            // 
            this.lblOrigDeRepuesto.AutoSize = true;
            this.lblOrigDeRepuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblOrigDeRepuesto.Location = new System.Drawing.Point(11, 82);
            this.lblOrigDeRepuesto.Name = "lblOrigDeRepuesto";
            this.lblOrigDeRepuesto.Size = new System.Drawing.Size(47, 15);
            this.lblOrigDeRepuesto.TabIndex = 2;
            this.lblOrigDeRepuesto.Text = "Origen:";
            // 
            // cmbBoxOrigenDeRepuesto
            // 
            this.cmbBoxOrigenDeRepuesto.FormattingEnabled = true;
            this.cmbBoxOrigenDeRepuesto.Items.AddRange(new object[] {
            "N(Nacional)",
            "I(Importado)"});
            this.cmbBoxOrigenDeRepuesto.Location = new System.Drawing.Point(156, 78);
            this.cmbBoxOrigenDeRepuesto.Name = "cmbBoxOrigenDeRepuesto";
            this.cmbBoxOrigenDeRepuesto.Size = new System.Drawing.Size(51, 21);
            this.cmbBoxOrigenDeRepuesto.TabIndex = 3;
            // 
            // lblNumeroDeRepuesto
            // 
            this.lblNumeroDeRepuesto.AutoSize = true;
            this.lblNumeroDeRepuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblNumeroDeRepuesto.Location = new System.Drawing.Point(11, 117);
            this.lblNumeroDeRepuesto.Name = "lblNumeroDeRepuesto";
            this.lblNumeroDeRepuesto.Size = new System.Drawing.Size(123, 15);
            this.lblNumeroDeRepuesto.TabIndex = 4;
            this.lblNumeroDeRepuesto.Text = "Numero de repuesto:";
            // 
            // txtBoxNumeroDeRepuestos
            // 
            this.txtBoxNumeroDeRepuestos.Location = new System.Drawing.Point(156, 116);
            this.txtBoxNumeroDeRepuestos.MaxLength = 6;
            this.txtBoxNumeroDeRepuestos.Name = "txtBoxNumeroDeRepuestos";
            this.txtBoxNumeroDeRepuestos.Size = new System.Drawing.Size(62, 20);
            this.txtBoxNumeroDeRepuestos.TabIndex = 5;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 149);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 6;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // txtboxDescripcion
            // 
            this.txtboxDescripcion.Location = new System.Drawing.Point(93, 142);
            this.txtboxDescripcion.MaxLength = 50;
            this.txtboxDescripcion.Name = "txtboxDescripcion";
            this.txtboxDescripcion.Size = new System.Drawing.Size(224, 20);
            this.txtboxDescripcion.TabIndex = 7;
            // 
            // btnIngresarRepuesto
            // 
            this.btnIngresarRepuesto.Location = new System.Drawing.Point(114, 205);
            this.btnIngresarRepuesto.Name = "btnIngresarRepuesto";
            this.btnIngresarRepuesto.Size = new System.Drawing.Size(149, 46);
            this.btnIngresarRepuesto.TabIndex = 8;
            this.btnIngresarRepuesto.Text = "Ingresar Repuesto";
            this.btnIngresarRepuesto.UseVisualStyleBackColor = true;
            this.btnIngresarRepuesto.Click += new System.EventHandler(this.btnIngresarRepuesto_Click);
            // 
            // lblFiltrarMarca
            // 
            this.lblFiltrarMarca.AutoSize = true;
            this.lblFiltrarMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblFiltrarMarca.Location = new System.Drawing.Point(5, 279);
            this.lblFiltrarMarca.Name = "lblFiltrarMarca";
            this.lblFiltrarMarca.Size = new System.Drawing.Size(79, 15);
            this.lblFiltrarMarca.TabIndex = 9;
            this.lblFiltrarMarca.Text = "Filtrar Marca:";
            // 
            // lblFiltrarOrigen
            // 
            this.lblFiltrarOrigen.AutoSize = true;
            this.lblFiltrarOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblFiltrarOrigen.Location = new System.Drawing.Point(4, 336);
            this.lblFiltrarOrigen.Name = "lblFiltrarOrigen";
            this.lblFiltrarOrigen.Size = new System.Drawing.Size(81, 15);
            this.lblFiltrarOrigen.TabIndex = 10;
            this.lblFiltrarOrigen.Text = "Filtrar Origen:";
            // 
            // cmbBoxFiltrarMarca
            // 
            this.cmbBoxFiltrarMarca.FormattingEnabled = true;
            this.cmbBoxFiltrarMarca.Items.AddRange(new object[] {
            "P(Peugeot)",
            "F(Fiat)",
            "R(Renault)"});
            this.cmbBoxFiltrarMarca.Location = new System.Drawing.Point(109, 278);
            this.cmbBoxFiltrarMarca.Name = "cmbBoxFiltrarMarca";
            this.cmbBoxFiltrarMarca.Size = new System.Drawing.Size(51, 21);
            this.cmbBoxFiltrarMarca.TabIndex = 11;
            // 
            // btnConsultarRepuestos
            // 
            this.btnConsultarRepuestos.Location = new System.Drawing.Point(109, 363);
            this.btnConsultarRepuestos.Name = "btnConsultarRepuestos";
            this.btnConsultarRepuestos.Size = new System.Drawing.Size(149, 46);
            this.btnConsultarRepuestos.TabIndex = 13;
            this.btnConsultarRepuestos.Text = "Consultar Repuestos";
            this.btnConsultarRepuestos.UseVisualStyleBackColor = true;
            this.btnConsultarRepuestos.Click += new System.EventHandler(this.btnConsultarRepuestos_Click);
            // 
            // lstBoxConsulta
            // 
            this.lstBoxConsulta.FormattingEnabled = true;
            this.lstBoxConsulta.Location = new System.Drawing.Point(15, 422);
            this.lstBoxConsulta.Name = "lstBoxConsulta";
            this.lstBoxConsulta.Size = new System.Drawing.Size(356, 82);
            this.lstBoxConsulta.TabIndex = 14;
            // 
            // rbtnNacional
            // 
            this.rbtnNacional.AutoSize = true;
            this.rbtnNacional.Location = new System.Drawing.Point(100, 336);
            this.rbtnNacional.Name = "rbtnNacional";
            this.rbtnNacional.Size = new System.Drawing.Size(67, 17);
            this.rbtnNacional.TabIndex = 15;
            this.rbtnNacional.TabStop = true;
            this.rbtnNacional.Text = "Nacional";
            this.rbtnNacional.UseVisualStyleBackColor = true;
            // 
            // rbtnImportado
            // 
            this.rbtnImportado.AutoSize = true;
            this.rbtnImportado.Location = new System.Drawing.Point(191, 336);
            this.rbtnImportado.Name = "rbtnImportado";
            this.rbtnImportado.Size = new System.Drawing.Size(72, 17);
            this.rbtnImportado.TabIndex = 16;
            this.rbtnImportado.TabStop = true;
            this.rbtnImportado.Text = "Importado";
            this.rbtnImportado.UseVisualStyleBackColor = true;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(11, 184);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 17;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtBoxPrecio
            // 
            this.txtBoxPrecio.Location = new System.Drawing.Point(93, 179);
            this.txtBoxPrecio.MaxLength = 50;
            this.txtBoxPrecio.Name = "txtBoxPrecio";
            this.txtBoxPrecio.Size = new System.Drawing.Size(224, 20);
            this.txtBoxPrecio.TabIndex = 18;
            // 
            // ingresoRepuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 526);
            this.Controls.Add(this.txtBoxPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.rbtnImportado);
            this.Controls.Add(this.rbtnNacional);
            this.Controls.Add(this.lstBoxConsulta);
            this.Controls.Add(this.btnConsultarRepuestos);
            this.Controls.Add(this.cmbBoxFiltrarMarca);
            this.Controls.Add(this.lblFiltrarOrigen);
            this.Controls.Add(this.lblFiltrarMarca);
            this.Controls.Add(this.btnIngresarRepuesto);
            this.Controls.Add(this.txtboxDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtBoxNumeroDeRepuestos);
            this.Controls.Add(this.lblNumeroDeRepuesto);
            this.Controls.Add(this.cmbBoxOrigenDeRepuesto);
            this.Controls.Add(this.lblOrigDeRepuesto);
            this.Controls.Add(this.cmbBoxMarcas);
            this.Controls.Add(this.lblMarca);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ingresoRepuestos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INGRESO REPUESTOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cmbBoxMarcas;
        private System.Windows.Forms.Label lblOrigDeRepuesto;
        private System.Windows.Forms.ComboBox cmbBoxOrigenDeRepuesto;
        private System.Windows.Forms.Label lblNumeroDeRepuesto;
        private System.Windows.Forms.TextBox txtBoxNumeroDeRepuestos;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtboxDescripcion;
        private System.Windows.Forms.Button btnIngresarRepuesto;
        private System.Windows.Forms.Label lblFiltrarMarca;
        private System.Windows.Forms.Label lblFiltrarOrigen;
        private System.Windows.Forms.ComboBox cmbBoxFiltrarMarca;
        private System.Windows.Forms.Button btnConsultarRepuestos;
        private System.Windows.Forms.ListBox lstBoxConsulta;
        private System.Windows.Forms.RadioButton rbtnNacional;
        private System.Windows.Forms.RadioButton rbtnImportado;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtBoxPrecio;
    }
}