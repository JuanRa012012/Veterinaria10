namespace Veterinaria2
{
    partial class Veterinarios
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
            grdVeterinarios = new DataGridView();
            txtDireccion = new TextBox();
            label5 = new Label();
            txtTelefono = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            txtCorreo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cmdAnular = new Button();
            cmdModificar = new Button();
            cmdSalir = new Button();
            cmdGuardar = new Button();
            textBox1 = new TextBox();
            label8 = new Label();
            cmdCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)grdVeterinarios).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 327);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 51;
            label6.Text = "Lista de Veterinarios:";
            // 
            // grdVeterinarios
            // 
            grdVeterinarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdVeterinarios.Location = new Point(10, 345);
            grdVeterinarios.Name = "grdVeterinarios";
            grdVeterinarios.Size = new Size(495, 203);
            grdVeterinarios.TabIndex = 50;
            grdVeterinarios.CellClick += grdVeterinarios_CellClick;
            grdVeterinarios.CellContentClick += grdVeterinarios_CellContentClick;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(7, 210);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(495, 23);
            txtDireccion.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 192);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 48;
            label5.Text = "Dirección:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(7, 143);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(221, 23);
            txtTelefono.TabIndex = 4;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 125);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 44;
            label3.Text = "Teléfono:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(7, 73);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(495, 23);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(281, 143);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(221, 23);
            txtCorreo.TabIndex = 5;
            txtCorreo.KeyPress += txtCorreo_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 55);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 41;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(281, 125);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 40;
            label1.Text = "Correo:";
            // 
            // cmdAnular
            // 
            cmdAnular.Location = new Point(349, 571);
            cmdAnular.Name = "cmdAnular";
            cmdAnular.Size = new Size(75, 23);
            cmdAnular.TabIndex = 9;
            cmdAnular.Text = "Anular";
            cmdAnular.UseVisualStyleBackColor = true;
            cmdAnular.Click += cmdAnular_Click;
            // 
            // cmdModificar
            // 
            cmdModificar.Location = new Point(268, 571);
            cmdModificar.Name = "cmdModificar";
            cmdModificar.Size = new Size(75, 23);
            cmdModificar.TabIndex = 8;
            cmdModificar.Text = "Modificar";
            cmdModificar.UseVisualStyleBackColor = true;
            cmdModificar.Click += cmdModificar_Click;
            // 
            // cmdSalir
            // 
            cmdSalir.Location = new Point(430, 571);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(75, 23);
            cmdSalir.TabIndex = 10;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = true;
            cmdSalir.Click += cmdSalir_Click;
            // 
            // cmdGuardar
            // 
            cmdGuardar.Location = new Point(187, 571);
            cmdGuardar.Name = "cmdGuardar";
            cmdGuardar.Size = new Size(75, 23);
            cmdGuardar.TabIndex = 7;
            cmdGuardar.Text = "Guardar";
            cmdGuardar.UseVisualStyleBackColor = true;
            cmdGuardar.Click += cmdGuardar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 292);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(493, 23);
            textBox1.TabIndex = 67;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 274);
            label8.Name = "label8";
            label8.Size = new Size(98, 15);
            label8.TabIndex = 68;
            label8.Text = "Búsqueda rápida:";
            // 
            // cmdCancelar
            // 
            cmdCancelar.Location = new Point(427, 239);
            cmdCancelar.Name = "cmdCancelar";
            cmdCancelar.Size = new Size(75, 23);
            cmdCancelar.TabIndex = 69;
            cmdCancelar.Text = "Cancelar";
            cmdCancelar.UseVisualStyleBackColor = true;
            cmdCancelar.Visible = false;
            cmdCancelar.Click += cmdCancelar_Click;
            // 
            // Veterinarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 605);
            ControlBox = false;
            Controls.Add(cmdCancelar);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(cmdAnular);
            Controls.Add(cmdModificar);
            Controls.Add(cmdSalir);
            Controls.Add(cmdGuardar);
            Controls.Add(label6);
            Controls.Add(grdVeterinarios);
            Controls.Add(txtDireccion);
            Controls.Add(label5);
            Controls.Add(txtTelefono);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(txtCorreo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Veterinarios";
            Text = "Veterinarios";
            Load += Veterinarios_Load;
            ((System.ComponentModel.ISupportInitialize)grdVeterinarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private DataGridView grdVeterinarios;
        private TextBox txtDireccion;
        private Label label5;
        private TextBox txtTelefono;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtCorreo;
        private Label label2;
        private Label label1;
        private Button cmdAnular;
        private Button cmdModificar;
        private Button cmdSalir;
        private Button cmdGuardar;
        private TextBox textBox1;
        private Label label8;
        private Button cmdCancelar;
    }
}