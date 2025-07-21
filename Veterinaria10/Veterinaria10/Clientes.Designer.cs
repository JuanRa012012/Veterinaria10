namespace Veterinaria2
{
    partial class Clientes
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
            cmdCancelar = new Button();
            txtEdad = new TextBox();
            label7 = new Label();
            label4 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            bttAnularClientes = new Button();
            bttModificarClientes = new Button();
            bttSalirClientes = new Button();
            bttGuardarClientes = new Button();
            lblListaClientes = new Label();
            grdClientes = new DataGridView();
            txtDireccion = new TextBox();
            lblDireccClientes = new Label();
            txtCorreo = new TextBox();
            lblCorreoCliente = new Label();
            txtTelefono = new TextBox();
            lblTelefonoClientes = new Label();
            txtNombre = new TextBox();
            lblNombreCliente = new Label();
            ((System.ComponentModel.ISupportInitialize)grdClientes).BeginInit();
            SuspendLayout();
            // 
            // cmdCancelar
            // 
            cmdCancelar.Location = new Point(432, 191);
            cmdCancelar.Name = "cmdCancelar";
            cmdCancelar.Size = new Size(75, 23);
            cmdCancelar.TabIndex = 89;
            cmdCancelar.Text = "Cancelar";
            cmdCancelar.UseVisualStyleBackColor = true;
            cmdCancelar.Visible = false;
            cmdCancelar.Click += cmdCancelar_Click;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(460, 36);
            txtEdad.Name = "txtEdad";
            txtEdad.ReadOnly = true;
            txtEdad.Size = new Size(47, 23);
            txtEdad.TabIndex = 86;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(460, 18);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 88;
            label7.Text = "Edad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(269, 18);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 87;
            label4.Text = "Fecha nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(270, 36);
            dtpFechaNacimiento.MaxDate = new DateTime(2010, 1, 1, 0, 0, 0, 0);
            dtpFechaNacimiento.MinDate = new DateTime(1960, 1, 1, 0, 0, 0, 0);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(184, 23);
            dtpFechaNacimiento.TabIndex = 85;
            dtpFechaNacimiento.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtpFechaNacimiento.ValueChanged += dtpFechaNacimiento_ValueChanged;
            // 
            // bttAnularClientes
            // 
            bttAnularClientes.Location = new Point(351, 458);
            bttAnularClientes.Name = "bttAnularClientes";
            bttAnularClientes.Size = new Size(75, 23);
            bttAnularClientes.TabIndex = 84;
            bttAnularClientes.Text = "Anular";
            bttAnularClientes.UseVisualStyleBackColor = true;
            bttAnularClientes.Click += bttAnularClientes_Click;
            // 
            // bttModificarClientes
            // 
            bttModificarClientes.Location = new Point(270, 458);
            bttModificarClientes.Name = "bttModificarClientes";
            bttModificarClientes.Size = new Size(75, 23);
            bttModificarClientes.TabIndex = 83;
            bttModificarClientes.Text = "Modificar";
            bttModificarClientes.UseVisualStyleBackColor = true;
            bttModificarClientes.Click += bttModificarClientes_Click;
            // 
            // bttSalirClientes
            // 
            bttSalirClientes.Location = new Point(432, 458);
            bttSalirClientes.Name = "bttSalirClientes";
            bttSalirClientes.Size = new Size(75, 23);
            bttSalirClientes.TabIndex = 82;
            bttSalirClientes.Text = "Salir";
            bttSalirClientes.UseVisualStyleBackColor = true;
            bttSalirClientes.Click += bttSalirClientes_Click;
            // 
            // bttGuardarClientes
            // 
            bttGuardarClientes.Location = new Point(189, 458);
            bttGuardarClientes.Name = "bttGuardarClientes";
            bttGuardarClientes.Size = new Size(75, 23);
            bttGuardarClientes.TabIndex = 81;
            bttGuardarClientes.Text = "Guardar";
            bttGuardarClientes.UseVisualStyleBackColor = true;
            bttGuardarClientes.Click += bttGuardarClientes_Click;
            // 
            // lblListaClientes
            // 
            lblListaClientes.AutoSize = true;
            lblListaClientes.Location = new Point(12, 231);
            lblListaClientes.Name = "lblListaClientes";
            lblListaClientes.Size = new Size(93, 15);
            lblListaClientes.TabIndex = 80;
            lblListaClientes.Text = "Lista de clientes:";
            // 
            // grdClientes
            // 
            grdClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdClientes.Location = new Point(12, 249);
            grdClientes.Name = "grdClientes";
            grdClientes.Size = new Size(495, 203);
            grdClientes.TabIndex = 79;
            grdClientes.CellClick += grdClientes_CellClick;
            grdClientes.CellContentClick += grdClientes_CellContentClick;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(12, 162);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(495, 23);
            txtDireccion.TabIndex = 78;
            txtDireccion.KeyPress += txtDireccion_KeyPress;
            // 
            // lblDireccClientes
            // 
            lblDireccClientes.AutoSize = true;
            lblDireccClientes.Location = new Point(12, 144);
            lblDireccClientes.Name = "lblDireccClientes";
            lblDireccClientes.Size = new Size(60, 15);
            lblDireccClientes.TabIndex = 77;
            lblDireccClientes.Text = "Dirección:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(269, 113);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(238, 23);
            txtCorreo.TabIndex = 76;
            txtCorreo.KeyPress += txtCorreo_KeyPress;
            // 
            // lblCorreoCliente
            // 
            lblCorreoCliente.AutoSize = true;
            lblCorreoCliente.Location = new Point(269, 95);
            lblCorreoCliente.Name = "lblCorreoCliente";
            lblCorreoCliente.Size = new Size(46, 15);
            lblCorreoCliente.TabIndex = 75;
            lblCorreoCliente.Text = "Correo:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(12, 113);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(221, 23);
            txtTelefono.TabIndex = 74;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // lblTelefonoClientes
            // 
            lblTelefonoClientes.AutoSize = true;
            lblTelefonoClientes.Location = new Point(12, 95);
            lblTelefonoClientes.Name = "lblTelefonoClientes";
            lblTelefonoClientes.Size = new Size(56, 15);
            lblTelefonoClientes.TabIndex = 73;
            lblTelefonoClientes.Text = "Teléfono:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 36);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(221, 23);
            txtNombre.TabIndex = 72;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Location = new Point(12, 15);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(54, 15);
            lblNombreCliente.TabIndex = 71;
            lblNombreCliente.Text = "Nombre:";
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 489);
            ControlBox = false;
            Controls.Add(cmdCancelar);
            Controls.Add(txtEdad);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(bttAnularClientes);
            Controls.Add(bttModificarClientes);
            Controls.Add(bttSalirClientes);
            Controls.Add(bttGuardarClientes);
            Controls.Add(lblListaClientes);
            Controls.Add(grdClientes);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccClientes);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreoCliente);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefonoClientes);
            Controls.Add(txtNombre);
            Controls.Add(lblNombreCliente);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Clientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clientes";
            Load += Clientes_Load_1;
            ((System.ComponentModel.ISupportInitialize)grdClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdCancelar;
        private TextBox txtEdad;
        private Label label7;
        private Label label4;
        private DateTimePicker dtpFechaNacimiento;
        private Button bttAnularClientes;
        private Button bttModificarClientes;
        private Button bttSalirClientes;
        private Button bttGuardarClientes;
        private Label lblListaClientes;
        private DataGridView grdClientes;
        private TextBox txtDireccion;
        private Label lblDireccClientes;
        private TextBox txtCorreo;
        private Label lblCorreoCliente;
        private TextBox txtTelefono;
        private Label lblTelefonoClientes;
        private TextBox txtNombre;
        private Label lblNombreCliente;
    }
}