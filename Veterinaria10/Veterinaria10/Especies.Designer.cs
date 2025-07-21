namespace Veterinaria2
{
    partial class Especies
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
            cmdAnularEspecies = new Button();
            cmdModificarEspecies = new Button();
            cmdSalirEspecies = new Button();
            cmdGuardarEspecies = new Button();
            lblListaEspecies = new Label();
            grdListaEspecies = new DataGridView();
            txtNombreEspecies = new TextBox();
            lblNombreEspecies = new Label();
            ((System.ComponentModel.ISupportInitialize)grdListaEspecies).BeginInit();
            SuspendLayout();
            // 
            // cmdAnularEspecies
            // 
            cmdAnularEspecies.Location = new Point(171, 389);
            cmdAnularEspecies.Name = "cmdAnularEspecies";
            cmdAnularEspecies.Size = new Size(66, 23);
            cmdAnularEspecies.TabIndex = 61;
            cmdAnularEspecies.Text = "Anular";
            cmdAnularEspecies.UseVisualStyleBackColor = true;
            cmdAnularEspecies.Click += bttAnularEspecies_Click;
            // 
            // cmdModificarEspecies
            // 
            cmdModificarEspecies.Location = new Point(99, 389);
            cmdModificarEspecies.Name = "cmdModificarEspecies";
            cmdModificarEspecies.Size = new Size(66, 23);
            cmdModificarEspecies.TabIndex = 60;
            cmdModificarEspecies.Text = "Modificar";
            cmdModificarEspecies.UseVisualStyleBackColor = true;
            cmdModificarEspecies.Click += bttModificarEspecies_Click;
            // 
            // cmdSalirEspecies
            // 
            cmdSalirEspecies.Location = new Point(243, 389);
            cmdSalirEspecies.Name = "cmdSalirEspecies";
            cmdSalirEspecies.Size = new Size(66, 23);
            cmdSalirEspecies.TabIndex = 59;
            cmdSalirEspecies.Text = "Salir";
            cmdSalirEspecies.UseVisualStyleBackColor = true;
            cmdSalirEspecies.Click += bttSalirEspecies_Click;
            // 
            // cmdGuardarEspecies
            // 
            cmdGuardarEspecies.Location = new Point(27, 389);
            cmdGuardarEspecies.Name = "cmdGuardarEspecies";
            cmdGuardarEspecies.Size = new Size(66, 23);
            cmdGuardarEspecies.TabIndex = 58;
            cmdGuardarEspecies.Text = "Guardar";
            cmdGuardarEspecies.UseVisualStyleBackColor = true;
            cmdGuardarEspecies.Click += bttGuardarEspecies_Click;
            // 
            // lblListaEspecies
            // 
            lblListaEspecies.AutoSize = true;
            lblListaEspecies.Location = new Point(12, 75);
            lblListaEspecies.Name = "lblListaEspecies";
            lblListaEspecies.Size = new Size(34, 15);
            lblListaEspecies.TabIndex = 57;
            lblListaEspecies.Text = "Lista:";
            // 
            // grdListaEspecies
            // 
            grdListaEspecies.AllowUserToAddRows = false;
            grdListaEspecies.AllowUserToDeleteRows = false;
            grdListaEspecies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdListaEspecies.Location = new Point(12, 93);
            grdListaEspecies.Name = "grdListaEspecies";
            grdListaEspecies.ReadOnly = true;
            grdListaEspecies.Size = new Size(297, 273);
            grdListaEspecies.TabIndex = 56;
            grdListaEspecies.CellContentClick += dgvListaEspecies_CellContentClick;
            // 
            // txtNombreEspecies
            // 
            txtNombreEspecies.Location = new Point(12, 34);
            txtNombreEspecies.Name = "txtNombreEspecies";
            txtNombreEspecies.Size = new Size(297, 23);
            txtNombreEspecies.TabIndex = 55;
            // 
            // lblNombreEspecies
            // 
            lblNombreEspecies.AutoSize = true;
            lblNombreEspecies.Location = new Point(12, 16);
            lblNombreEspecies.Name = "lblNombreEspecies";
            lblNombreEspecies.Size = new Size(54, 15);
            lblNombreEspecies.TabIndex = 54;
            lblNombreEspecies.Text = "Nombre:";
            // 
            // Especies
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 450);
            ControlBox = false;
            Controls.Add(cmdAnularEspecies);
            Controls.Add(cmdModificarEspecies);
            Controls.Add(cmdSalirEspecies);
            Controls.Add(cmdGuardarEspecies);
            Controls.Add(lblListaEspecies);
            Controls.Add(grdListaEspecies);
            Controls.Add(txtNombreEspecies);
            Controls.Add(lblNombreEspecies);
            Name = "Especies";
            Text = "Especies";
            Load += Especies_Load;
            ((System.ComponentModel.ISupportInitialize)grdListaEspecies).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdAnularEspecies;
        private Button cmdModificarEspecies;
        private Button cmdSalirEspecies;
        private Button cmdGuardarEspecies;
        private Label lblListaEspecies;
        private DataGridView grdListaEspecies;
        private TextBox txtNombreEspecies;
        private Label lblNombreEspecies;
    }
}