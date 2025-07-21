namespace Veterinaria2
{
    partial class FormUsuarios
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
            txtNombre = new TextBox();
            txtCodigo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cboRoles = new ComboBox();
            label4 = new Label();
            txtClave = new TextBox();
            label3 = new Label();
            cmdAnular = new Button();
            cmdModificar = new Button();
            label5 = new Label();
            grdUsuarios = new DataGridView();
            cmdSalir = new Button();
            cmdGuardar = new Button();
            txtConfirmacionClave = new TextBox();
            label6 = new Label();
            cmdCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)grdUsuarios).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(260, 72);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(221, 23);
            txtNombre.TabIndex = 11;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(12, 72);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(221, 23);
            txtCodigo.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(260, 54);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 9;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 54);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 8;
            label1.Text = "Código:";
            // 
            // cboRoles
            // 
            cboRoles.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRoles.FormattingEnabled = true;
            cboRoles.Location = new Point(12, 205);
            cboRoles.Name = "cboRoles";
            cboRoles.Size = new Size(221, 23);
            cboRoles.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 187);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 14;
            label4.Text = "Rol:";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(12, 139);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(221, 23);
            txtClave.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 121);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 12;
            label3.Text = "Clave:";
            // 
            // cmdAnular
            // 
            cmdAnular.Location = new Point(324, 501);
            cmdAnular.Name = "cmdAnular";
            cmdAnular.Size = new Size(75, 23);
            cmdAnular.TabIndex = 23;
            cmdAnular.Text = "Anular";
            cmdAnular.UseVisualStyleBackColor = true;
            cmdAnular.Click += cmdAnular_Click;
            // 
            // cmdModificar
            // 
            cmdModificar.Location = new Point(243, 501);
            cmdModificar.Name = "cmdModificar";
            cmdModificar.Size = new Size(75, 23);
            cmdModificar.TabIndex = 22;
            cmdModificar.Text = "Modificar";
            cmdModificar.UseVisualStyleBackColor = true;
            cmdModificar.Click += cmdModificar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 253);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 21;
            label5.Text = "Lista de usuarios:";
            // 
            // grdUsuarios
            // 
            grdUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdUsuarios.Location = new Point(12, 271);
            grdUsuarios.Name = "grdUsuarios";
            grdUsuarios.Size = new Size(469, 220);
            grdUsuarios.TabIndex = 20;
            grdUsuarios.CellClick += grdUsuarios_CellClick;
            // 
            // cmdSalir
            // 
            cmdSalir.Location = new Point(405, 501);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(75, 23);
            cmdSalir.TabIndex = 19;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = true;
            cmdSalir.Click += cmdSalir_Click;
            // 
            // cmdGuardar
            // 
            cmdGuardar.Location = new Point(162, 501);
            cmdGuardar.Name = "cmdGuardar";
            cmdGuardar.Size = new Size(75, 23);
            cmdGuardar.TabIndex = 18;
            cmdGuardar.Text = "Guardar";
            cmdGuardar.UseVisualStyleBackColor = true;
            cmdGuardar.Click += cmdGuardar_Click;
            // 
            // txtConfirmacionClave
            // 
            txtConfirmacionClave.Location = new Point(260, 139);
            txtConfirmacionClave.Name = "txtConfirmacionClave";
            txtConfirmacionClave.PasswordChar = '*';
            txtConfirmacionClave.Size = new Size(221, 23);
            txtConfirmacionClave.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(260, 121);
            label6.Name = "label6";
            label6.Size = new Size(129, 15);
            label6.TabIndex = 24;
            label6.Text = "Confirmación de clave:";
            // 
            // cmdCancelar
            // 
            cmdCancelar.Location = new Point(406, 204);
            cmdCancelar.Name = "cmdCancelar";
            cmdCancelar.Size = new Size(75, 23);
            cmdCancelar.TabIndex = 70;
            cmdCancelar.Text = "Cancelar";
            cmdCancelar.UseVisualStyleBackColor = true;
            cmdCancelar.Visible = false;
            cmdCancelar.Click += cmdCancelar_Click;
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 532);
            ControlBox = false;
            Controls.Add(cmdCancelar);
            Controls.Add(txtConfirmacionClave);
            Controls.Add(label6);
            Controls.Add(cmdAnular);
            Controls.Add(cmdModificar);
            Controls.Add(label5);
            Controls.Add(grdUsuarios);
            Controls.Add(cmdSalir);
            Controls.Add(cmdGuardar);
            Controls.Add(cboRoles);
            Controls.Add(label4);
            Controls.Add(txtClave);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormUsuarios";
            Text = "Usuarios";
            Load += FormUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)grdUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtCodigo;
        private Label label2;
        private Label label1;
        private ComboBox cboRoles;
        private Label label4;
        private TextBox txtClave;
        private Label label3;
        private Button cmdAnular;
        private Button cmdModificar;
        private Label label5;
        private DataGridView grdUsuarios;
        private Button cmdSalir;
        private Button cmdGuardar;
        private TextBox txtConfirmacionClave;
        private Label label6;
        private Button cmdCancelar;
    }
}