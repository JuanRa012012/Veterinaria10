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
            bttImprimirLF = new Button();
            bttSalirLF = new Button();
            bttNuevaLF = new Button();
            lblListasFacturas = new Label();
            dgvListasFacturas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvListasFacturas).BeginInit();
            SuspendLayout();
            // 
            // bttImprimirLF
            // 
            bttImprimirLF.Location = new Point(310, 400);
            bttImprimirLF.Name = "bttImprimirLF";
            bttImprimirLF.Size = new Size(75, 23);
            bttImprimirLF.TabIndex = 40;
            bttImprimirLF.Text = "Imprimir";
            bttImprimirLF.UseVisualStyleBackColor = true;
            // 
            // bttSalirLF
            // 
            bttSalirLF.Location = new Point(391, 400);
            bttSalirLF.Name = "bttSalirLF";
            bttSalirLF.Size = new Size(75, 23);
            bttSalirLF.TabIndex = 39;
            bttSalirLF.Text = "Salir";
            bttSalirLF.UseVisualStyleBackColor = true;
            // 
            // bttNuevaLF
            // 
            bttNuevaLF.Location = new Point(229, 400);
            bttNuevaLF.Name = "bttNuevaLF";
            bttNuevaLF.Size = new Size(75, 23);
            bttNuevaLF.TabIndex = 38;
            bttNuevaLF.Text = "Nueva";
            bttNuevaLF.UseVisualStyleBackColor = true;
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
            // dgvListasFacturas
            // 
            dgvListasFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListasFacturas.Location = new Point(12, 42);
            dgvListasFacturas.Name = "dgvListasFacturas";
            dgvListasFacturas.Size = new Size(486, 338);
            dgvListasFacturas.TabIndex = 36;
            // 
            // Facturas_Listados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 450);
            Controls.Add(bttImprimirLF);
            Controls.Add(bttSalirLF);
            Controls.Add(bttNuevaLF);
            Controls.Add(lblListasFacturas);
            Controls.Add(dgvListasFacturas);
            Name = "Facturas_Listados";
            Text = "Listados de Facturas";
            ((System.ComponentModel.ISupportInitialize)dgvListasFacturas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttImprimirLF;
        private Button bttSalirLF;
        private Button bttNuevaLF;
        private Label lblListasFacturas;
        private DataGridView dgvListasFacturas;
    }
}