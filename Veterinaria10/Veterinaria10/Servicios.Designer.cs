namespace Veterinaria2
{
    partial class Servicios
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
            txtPrecio = new TextBox();
            label1 = new Label();
            label6 = new Label();
            grdServicios = new DataGridView();
            txtNombre = new TextBox();
            label2 = new Label();
            cmdAnular = new Button();
            cmdModificar = new Button();
            cmdSalir = new Button();
            cmdGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)grdServicios).BeginInit();
            SuspendLayout();
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(11, 123);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(297, 23);
            txtPrecio.TabIndex = 69;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 105);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 68;
            label1.Text = "Precio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 175);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 67;
            label6.Text = "Lista:";
            // 
            // grdServicios
            // 
            grdServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdServicios.Location = new Point(12, 193);
            grdServicios.Name = "grdServicios";
            grdServicios.Size = new Size(297, 273);
            grdServicios.TabIndex = 66;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 66);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(297, 23);
            txtNombre.TabIndex = 65;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 64;
            label2.Text = "Nombre:";
            // 
            // cmdAnular
            // 
            cmdAnular.Location = new Point(171, 490);
            cmdAnular.Name = "cmdAnular";
            cmdAnular.Size = new Size(66, 23);
            cmdAnular.TabIndex = 73;
            cmdAnular.Text = "Anular";
            cmdAnular.UseVisualStyleBackColor = true;
            // 
            // cmdModificar
            // 
            cmdModificar.Location = new Point(99, 490);
            cmdModificar.Name = "cmdModificar";
            cmdModificar.Size = new Size(66, 23);
            cmdModificar.TabIndex = 72;
            cmdModificar.Text = "Modificar";
            cmdModificar.UseVisualStyleBackColor = true;
            // 
            // cmdSalir
            // 
            cmdSalir.Location = new Point(243, 490);
            cmdSalir.Name = "cmdSalir";
            cmdSalir.Size = new Size(66, 23);
            cmdSalir.TabIndex = 71;
            cmdSalir.Text = "Salir";
            cmdSalir.UseVisualStyleBackColor = true;
            cmdSalir.Click += cmdSalir_Click;
            // 
            // cmdGuardar
            // 
            cmdGuardar.Location = new Point(27, 490);
            cmdGuardar.Name = "cmdGuardar";
            cmdGuardar.Size = new Size(66, 23);
            cmdGuardar.TabIndex = 70;
            cmdGuardar.Text = "Guardar";
            cmdGuardar.UseVisualStyleBackColor = true;
            // 
            // Servicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 519);
            ControlBox = false;
            Controls.Add(cmdAnular);
            Controls.Add(cmdModificar);
            Controls.Add(cmdSalir);
            Controls.Add(cmdGuardar);
            Controls.Add(txtPrecio);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(grdServicios);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Name = "Servicios";
            Text = "Servicios";
            ((System.ComponentModel.ISupportInitialize)grdServicios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPrecio;
        private Label label1;
        private Label label6;
        private DataGridView grdServicios;
        private TextBox txtNombre;
        private Label label2;
        private Button cmdAnular;
        private Button cmdModificar;
        private Button cmdSalir;
        private Button cmdGuardar;
    }
}