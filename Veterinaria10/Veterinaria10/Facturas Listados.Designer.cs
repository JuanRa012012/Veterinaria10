namespace Veterinaria2
{
    partial class Facturas_Listados
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
            cmdSalirLF = new Button();
            cmdNuevaLF = new Button();
            lblListasFacturas = new Label();
            grdListasFacturas = new DataGridView();
            cmdModificarLF = new Button();
            ((System.ComponentModel.ISupportInitialize)grdListasFacturas).BeginInit();
            SuspendLayout();
            // 
            // cmdSalirLF
            // 
            cmdSalirLF.Location = new Point(391, 400);
            cmdSalirLF.Name = "cmdSalirLF";
            cmdSalirLF.Size = new Size(75, 23);
            cmdSalirLF.TabIndex = 39;
            cmdSalirLF.Text = "Salir";
            cmdSalirLF.UseVisualStyleBackColor = true;
            cmdSalirLF.Click += cmdSalirLF_Click;
            // 
            // cmdNuevaLF
            // 
            cmdNuevaLF.Location = new Point(229, 400);
            cmdNuevaLF.Name = "cmdNuevaLF";
            cmdNuevaLF.Size = new Size(75, 23);
            cmdNuevaLF.TabIndex = 38;
            cmdNuevaLF.Text = "Nueva";
            cmdNuevaLF.UseVisualStyleBackColor = true;
            cmdNuevaLF.Click += cmdNuevaLF_Click;
            // 
            // lblListasFacturas
            // 
            lblListasFacturas.AutoSize = true;
            lblListasFacturas.Location = new Point(12, 24);
            lblListasFacturas.Name = "lblListasFacturas";
            lblListasFacturas.Size = new Size(95, 15);
            lblListasFacturas.TabIndex = 37;
            lblListasFacturas.Text = "Lista de facturas:";
            // 
            // grdListasFacturas
            // 
            grdListasFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdListasFacturas.Location = new Point(12, 42);
            grdListasFacturas.Name = "grdListasFacturas";
            grdListasFacturas.Size = new Size(692, 338);
            grdListasFacturas.TabIndex = 36;
            // 
            // cmdModificarLF
            // 
            cmdModificarLF.Location = new Point(310, 400);
            cmdModificarLF.Name = "cmdModificarLF";
            cmdModificarLF.Size = new Size(75, 23);
            cmdModificarLF.TabIndex = 40;
            cmdModificarLF.Text = "Modificar";
            cmdModificarLF.UseVisualStyleBackColor = true;
            cmdModificarLF.Click += cmdModificarLF_Click;
            // 
            // Facturas_Listados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 450);
            Controls.Add(cmdModificarLF);
            Controls.Add(cmdSalirLF);
            Controls.Add(cmdNuevaLF);
            Controls.Add(lblListasFacturas);
            Controls.Add(grdListasFacturas);
            Name = "Facturas_Listados";
            Text = "Listados de Facturas";
            Load += Facturas_Listados_Load;
            ((System.ComponentModel.ISupportInitialize)grdListasFacturas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button cmdSalirLF;
        private Button cmdNuevaLF;
        private Label lblListasFacturas;
        private DataGridView grdListasFacturas;
        private Button cmdModificarLF;
    }
}