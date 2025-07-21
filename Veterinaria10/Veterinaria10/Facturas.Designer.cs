namespace Veterinaria2
{
    partial class Facturas
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
            cbxVeterinarioCF = new ComboBox();
            lblVeterinarioCF = new Label();
            lblFechaEntregaCF = new Label();
            dtpFechaEntregaCF = new DateTimePicker();
            lblFechaEstimadaCF = new Label();
            dtpFechaEstimadaCF = new DateTimePicker();
            lblFechaInicioCF = new Label();
            dtpFechaInicioCF = new DateTimePicker();
            cbxMascotasCF = new ComboBox();
            lblMascotasCF = new Label();
            cbxClienteCF = new ComboBox();
            lblClienteCF = new Label();
            bttSalirCF = new Button();
            bttGuardarCF = new Button();
            gbxDetallesFactura = new GroupBox();
            MascotaDF = new Label();
            cbxMascotaDF = new ComboBox();
            bttAgregarDF = new Button();
            lblDescuentoDF = new Label();
            txtDescuentoDF = new TextBox();
            lblPrecioDF = new Label();
            txtPrecioDF = new TextBox();
            dgvServicios = new DataGridView();
            lblServicios = new Label();
            gbxDetallesFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServicios).BeginInit();
            SuspendLayout();
            // 
            // cbxVeterinarioCF
            // 
            cbxVeterinarioCF.FormattingEnabled = true;
            cbxVeterinarioCF.Location = new Point(255, 153);
            cbxVeterinarioCF.Name = "cbxVeterinarioCF";
            cbxVeterinarioCF.Size = new Size(221, 23);
            cbxVeterinarioCF.TabIndex = 62;
            // 
            // lblVeterinarioCF
            // 
            lblVeterinarioCF.AutoSize = true;
            lblVeterinarioCF.Location = new Point(255, 135);
            lblVeterinarioCF.Name = "lblVeterinarioCF";
            lblVeterinarioCF.Size = new Size(66, 15);
            lblVeterinarioCF.TabIndex = 61;
            lblVeterinarioCF.Text = "Veterinario:";
            // 
            // lblFechaEntregaCF
            // 
            lblFechaEntregaCF.AutoSize = true;
            lblFechaEntregaCF.Location = new Point(12, 135);
            lblFechaEntregaCF.Name = "lblFechaEntregaCF";
            lblFechaEntregaCF.Size = new Size(84, 15);
            lblFechaEntregaCF.TabIndex = 60;
            lblFechaEntregaCF.Text = "Fecha entrega:";
            // 
            // dtpFechaEntregaCF
            // 
            dtpFechaEntregaCF.Location = new Point(12, 153);
            dtpFechaEntregaCF.Name = "dtpFechaEntregaCF";
            dtpFechaEntregaCF.Size = new Size(221, 23);
            dtpFechaEntregaCF.TabIndex = 59;
            // 
            // lblFechaEstimadaCF
            // 
            lblFechaEstimadaCF.AutoSize = true;
            lblFechaEstimadaCF.Location = new Point(256, 81);
            lblFechaEstimadaCF.Name = "lblFechaEstimadaCF";
            lblFechaEstimadaCF.Size = new Size(151, 15);
            lblFechaEstimadaCF.TabIndex = 58;
            lblFechaEstimadaCF.Text = "Fecha estimada de entrega:";
            // 
            // dtpFechaEstimadaCF
            // 
            dtpFechaEstimadaCF.Location = new Point(256, 99);
            dtpFechaEstimadaCF.Name = "dtpFechaEstimadaCF";
            dtpFechaEstimadaCF.Size = new Size(221, 23);
            dtpFechaEstimadaCF.TabIndex = 57;
            // 
            // lblFechaInicioCF
            // 
            lblFechaInicioCF.AutoSize = true;
            lblFechaInicioCF.Location = new Point(12, 81);
            lblFechaInicioCF.Name = "lblFechaInicioCF";
            lblFechaInicioCF.Size = new Size(73, 15);
            lblFechaInicioCF.TabIndex = 56;
            lblFechaInicioCF.Text = "Fecha inicio:";
            // 
            // dtpFechaInicioCF
            // 
            dtpFechaInicioCF.Location = new Point(12, 99);
            dtpFechaInicioCF.Name = "dtpFechaInicioCF";
            dtpFechaInicioCF.Size = new Size(221, 23);
            dtpFechaInicioCF.TabIndex = 55;
            // 
            // cbxMascotasCF
            // 
            cbxMascotasCF.FormattingEnabled = true;
            cbxMascotasCF.Location = new Point(256, 45);
            cbxMascotasCF.Name = "cbxMascotasCF";
            cbxMascotasCF.Size = new Size(221, 23);
            cbxMascotasCF.TabIndex = 54;
            // 
            // lblMascotasCF
            // 
            lblMascotasCF.AutoSize = true;
            lblMascotasCF.Location = new Point(256, 27);
            lblMascotasCF.Name = "lblMascotasCF";
            lblMascotasCF.Size = new Size(55, 15);
            lblMascotasCF.TabIndex = 53;
            lblMascotasCF.Text = "Mascota:";
            // 
            // cbxClienteCF
            // 
            cbxClienteCF.FormattingEnabled = true;
            cbxClienteCF.Location = new Point(12, 45);
            cbxClienteCF.Name = "cbxClienteCF";
            cbxClienteCF.Size = new Size(221, 23);
            cbxClienteCF.TabIndex = 52;
            // 
            // lblClienteCF
            // 
            lblClienteCF.AutoSize = true;
            lblClienteCF.Location = new Point(12, 27);
            lblClienteCF.Name = "lblClienteCF";
            lblClienteCF.Size = new Size(47, 15);
            lblClienteCF.TabIndex = 51;
            lblClienteCF.Text = "Cliente:";
            // 
            // bttSalirCF
            // 
            bttSalirCF.Location = new Point(246, 525);
            bttSalirCF.Name = "bttSalirCF";
            bttSalirCF.Size = new Size(75, 23);
            bttSalirCF.TabIndex = 65;
            bttSalirCF.Text = "Salir";
            bttSalirCF.UseVisualStyleBackColor = true;
            // 
            // bttGuardarCF
            // 
            bttGuardarCF.Location = new Point(158, 525);
            bttGuardarCF.Name = "bttGuardarCF";
            bttGuardarCF.Size = new Size(75, 23);
            bttGuardarCF.TabIndex = 64;
            bttGuardarCF.Text = "Guardar";
            bttGuardarCF.UseVisualStyleBackColor = true;
            // 
            // gbxDetallesFactura
            // 
            gbxDetallesFactura.Controls.Add(MascotaDF);
            gbxDetallesFactura.Controls.Add(cbxMascotaDF);
            gbxDetallesFactura.Controls.Add(bttAgregarDF);
            gbxDetallesFactura.Controls.Add(lblDescuentoDF);
            gbxDetallesFactura.Controls.Add(txtDescuentoDF);
            gbxDetallesFactura.Controls.Add(lblPrecioDF);
            gbxDetallesFactura.Controls.Add(txtPrecioDF);
            gbxDetallesFactura.Controls.Add(dgvServicios);
            gbxDetallesFactura.Controls.Add(lblServicios);
            gbxDetallesFactura.Location = new Point(11, 192);
            gbxDetallesFactura.Name = "gbxDetallesFactura";
            gbxDetallesFactura.Size = new Size(465, 327);
            gbxDetallesFactura.TabIndex = 63;
            gbxDetallesFactura.TabStop = false;
            gbxDetallesFactura.Text = "Detalle de factura";
            // 
            // MascotaDF
            // 
            MascotaDF.AutoSize = true;
            MascotaDF.Location = new Point(12, 23);
            MascotaDF.Name = "MascotaDF";
            MascotaDF.Size = new Size(55, 15);
            MascotaDF.TabIndex = 52;
            MascotaDF.Text = "Mascota:";
            // 
            // cbxMascotaDF
            // 
            cbxMascotaDF.FormattingEnabled = true;
            cbxMascotaDF.Location = new Point(12, 41);
            cbxMascotaDF.Name = "cbxMascotaDF";
            cbxMascotaDF.Size = new Size(145, 23);
            cbxMascotaDF.TabIndex = 53;
            // 
            // bttAgregarDF
            // 
            bttAgregarDF.Location = new Point(384, 41);
            bttAgregarDF.Name = "bttAgregarDF";
            bttAgregarDF.Size = new Size(75, 23);
            bttAgregarDF.TabIndex = 35;
            bttAgregarDF.Text = "Agregar";
            bttAgregarDF.UseVisualStyleBackColor = true;
            // 
            // lblDescuentoDF
            // 
            lblDescuentoDF.AutoSize = true;
            lblDescuentoDF.Location = new Point(266, 23);
            lblDescuentoDF.Name = "lblDescuentoDF";
            lblDescuentoDF.Size = new Size(66, 15);
            lblDescuentoDF.TabIndex = 36;
            lblDescuentoDF.Text = "Descuento:";
            // 
            // txtDescuentoDF
            // 
            txtDescuentoDF.Location = new Point(266, 41);
            txtDescuentoDF.Name = "txtDescuentoDF";
            txtDescuentoDF.Size = new Size(100, 23);
            txtDescuentoDF.TabIndex = 37;
            // 
            // lblPrecioDF
            // 
            lblPrecioDF.AutoSize = true;
            lblPrecioDF.Location = new Point(160, 23);
            lblPrecioDF.Name = "lblPrecioDF";
            lblPrecioDF.Size = new Size(43, 15);
            lblPrecioDF.TabIndex = 35;
            lblPrecioDF.Text = "Precio:";
            // 
            // txtPrecioDF
            // 
            txtPrecioDF.Location = new Point(160, 41);
            txtPrecioDF.Name = "txtPrecioDF";
            txtPrecioDF.Size = new Size(100, 23);
            txtPrecioDF.TabIndex = 35;
            // 
            // dgvServicios
            // 
            dgvServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicios.Location = new Point(6, 88);
            dgvServicios.Name = "dgvServicios";
            dgvServicios.Size = new Size(450, 227);
            dgvServicios.TabIndex = 30;
            // 
            // lblServicios
            // 
            lblServicios.AutoSize = true;
            lblServicios.Location = new Point(6, 70);
            lblServicios.Name = "lblServicios";
            lblServicios.Size = new Size(286, 15);
            lblServicios.TabIndex = 31;
            lblServicios.Text = "Servicios brindados - doble clic para quitar de la lista:";
            // 
            // Facturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 562);
            ControlBox = false;
            Controls.Add(bttSalirCF);
            Controls.Add(bttGuardarCF);
            Controls.Add(gbxDetallesFactura);
            Controls.Add(cbxVeterinarioCF);
            Controls.Add(lblVeterinarioCF);
            Controls.Add(lblFechaEntregaCF);
            Controls.Add(dtpFechaEntregaCF);
            Controls.Add(lblFechaEstimadaCF);
            Controls.Add(dtpFechaEstimadaCF);
            Controls.Add(lblFechaInicioCF);
            Controls.Add(dtpFechaInicioCF);
            Controls.Add(cbxMascotasCF);
            Controls.Add(lblMascotasCF);
            Controls.Add(cbxClienteCF);
            Controls.Add(lblClienteCF);
            Name = "Facturas";
            Text = "Creacion de Facturas";
            gbxDetallesFactura.ResumeLayout(false);
            gbxDetallesFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvServicios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxVeterinarioCF;
        private Label lblVeterinarioCF;
        private Label lblFechaEntregaCF;
        private DateTimePicker dtpFechaEntregaCF;
        private Label lblFechaEstimadaCF;
        private DateTimePicker dtpFechaEstimadaCF;
        private Label lblFechaInicioCF;
        private DateTimePicker dtpFechaInicioCF;
        private ComboBox cbxMascotasCF;
        private Label lblMascotasCF;
        private ComboBox cbxClienteCF;
        private Label lblClienteCF;
        private Button bttSalirCF;
        private Button bttGuardarCF;
        private GroupBox gbxDetallesFactura;
        private Label MascotaDF;
        private ComboBox cbxMascotaDF;
        private Button bttAgregarDF;
        private Label lblDescuentoDF;
        private TextBox txtDescuentoDF;
        private Label lblPrecioDF;
        private TextBox txtPrecioDF;
        private DataGridView dgvServicios;
        private Label lblServicios;
    }
}