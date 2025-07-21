namespace Veterinaria2
{
    partial class Mascotas
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
            label6 = new Label();
            grdMascotas = new DataGridView();
            cboEspecies = new ComboBox();
            label3 = new Label();
            cboRazas = new ComboBox();
            label2 = new Label();
            label5 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            cboClientes = new ComboBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            cmdAnular = new Button();
            cmdModificar = new Button();
            cmdSalir = new Button();
            cmdGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)grdMascotas).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 217);
            label6.Name = "label6";
            label6.Size = new Size(103, 15);
            label6.TabIndex = 39;
            label6.Text = "Lista de Mascotas:";
            // 
            // grdMascotas
            // 
            grdMascotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdMascotas.Location = new Point(12, 235);
            grdMascotas.Name = "grdMascotas";
            grdMascotas.Size = new Size(469, 203);
            grdMascotas.TabIndex = 38;
            // 
            // cboEspecies
            // 
            cboEspecies.FormattingEnabled = true;
            cboEspecies.Location = new Point(12, 180);
            cboEspecies.Name = "cboEspecies";
            cboEspecies.Size = new Size(221, 23);
            cboEspecies.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 162);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 36;
            label3.Text = "Especie:";
            // 
            // cboRazas
            // 
            cboRazas.FormattingEnabled = true;
            cboRazas.Location = new Point(260, 113);
            cboRazas.Name = "cboRazas";
            cboRazas.Size = new Size(221, 23);
            cboRazas.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(260, 95);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 34;
            label2.Text = "Raza:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(260, 28);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 33;
            label5.Text = "Fecha nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(260, 46);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(221, 23);
            dtpFechaNacimiento.TabIndex = 32;
            // 
            // cboClientes
            // 
            cboClientes.FormattingEnabled = true;
            cboClientes.Location = new Point(12, 113);
            cboClientes.Name = "cboClientes";
            cboClientes.Size = new Size(221, 23);
            cboClientes.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 95);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 30;
            label4.Text = "Cliente:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 46);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(221, 23);
            txtNombre.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 28;
            label1.Text = "Nombre:";
            // 
            // cmdAnular
            // 
            cmdAnular.Location = new Point(325, 460);
            cmdAnular.Name = "cmdAnular";
            cmdAnular.Size = new Size(75, 23);
            cmdAnular.TabIndex = 43;
            cmdAnular.Text = "Anular";
            cmdAnular.UseVisualStyleBackColor = true;
            // 
            // cmdModificar
            // 
            cmdModificar.Location = new Point(244, 460);
            cmdModificar.Name = "cmdModificar";
            cmdModificar.Size = new Size(75, 23);
            cmdModificar.TabIndex = 42;
            cmdModificar.Text = "Modificar";
            cmdModificar.UseVisualStyleBackColor = true;
            // 
            // cmdSalir
            // 
            cmdSalir.Location = new Point(406, 460);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(75, 23);
            cmdSalir.TabIndex = 41;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = true;
            cmdSalir.Click += cmdSalir_Click;
            // 
            // cmdGuardar
            // 
            cmdGuardar.Location = new Point(163, 460);
            cmdGuardar.Name = "cmdGuardar";
            cmdGuardar.Size = new Size(75, 23);
            cmdGuardar.TabIndex = 40;
            cmdGuardar.Text = "Guardar";
            cmdGuardar.UseVisualStyleBackColor = true;
            // 
            // Mascotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 490);
            ControlBox = false;
            Controls.Add(cmdAnular);
            Controls.Add(cmdModificar);
            Controls.Add(cmdSalir);
            Controls.Add(cmdGuardar);
            Controls.Add(label6);
            Controls.Add(grdMascotas);
            Controls.Add(cboEspecies);
            Controls.Add(label3);
            Controls.Add(cboRazas);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(cboClientes);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Mascotas";
            Text = "Mascotas";
            Load += Mascotas_Load;
            ((System.ComponentModel.ISupportInitialize)grdMascotas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private DataGridView grdMascotas;
        private ComboBox cboEspecies;
        private Label label3;
        private ComboBox cboRazas;
        private Label label2;
        private Label label5;
        private DateTimePicker dtpFechaNacimiento;
        private ComboBox cboClientes;
        private Label label4;
        private TextBox txtNombre;
        private Label label1;
        private Button cmdAnular;
        private Button cmdModificar;
        private Button cmdSalir;
        private Button cmdGuardar;
    }
}