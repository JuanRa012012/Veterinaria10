namespace Veterinaria2
{
    partial class Admin
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
            label1 = new Label();
            btnUser = new Button();
            btnVeterinarios = new Button();
            btnEspecies = new Button();
            btnRazas = new Button();
            btnServicios = new Button();
            btnClientes = new Button();
            btnMascotas = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(186, 24);
            label1.Name = "label1";
            label1.Size = new Size(184, 73);
            label1.TabIndex = 0;
            label1.Text = "MENU";
            // 
            // btnUser
            // 
            btnUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUser.Location = new Point(214, 115);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(122, 48);
            btnUser.TabIndex = 1;
            btnUser.Text = "GESTIONAR USUARIOS";
            btnUser.UseVisualStyleBackColor = true;
            btnUser.Click += button1_Click;
            // 
            // btnVeterinarios
            // 
            btnVeterinarios.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVeterinarios.Location = new Point(214, 182);
            btnVeterinarios.Name = "btnVeterinarios";
            btnVeterinarios.Size = new Size(122, 48);
            btnVeterinarios.TabIndex = 1;
            btnVeterinarios.Text = "GESTIONAR VETERINARIOS";
            btnVeterinarios.UseVisualStyleBackColor = true;
            btnVeterinarios.Click += btnVeterinarios_Click;
            // 
            // btnEspecies
            // 
            btnEspecies.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEspecies.Location = new Point(214, 249);
            btnEspecies.Name = "btnEspecies";
            btnEspecies.Size = new Size(122, 48);
            btnEspecies.TabIndex = 1;
            btnEspecies.Text = "GESTIONAR ESPECIES";
            btnEspecies.UseVisualStyleBackColor = true;
            btnEspecies.Click += btnEspecies_Click;
            // 
            // btnRazas
            // 
            btnRazas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRazas.Location = new Point(214, 315);
            btnRazas.Name = "btnRazas";
            btnRazas.Size = new Size(122, 48);
            btnRazas.TabIndex = 1;
            btnRazas.Text = "GESTIONAR RAZAS";
            btnRazas.UseVisualStyleBackColor = true;
            btnRazas.Click += btnRazas_Click;
            // 
            // btnServicios
            // 
            btnServicios.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnServicios.Location = new Point(214, 384);
            btnServicios.Name = "btnServicios";
            btnServicios.Size = new Size(122, 48);
            btnServicios.TabIndex = 1;
            btnServicios.Text = "GESTIONAR SERVICIOS";
            btnServicios.UseVisualStyleBackColor = true;
            btnServicios.Click += btnServicios_Click;
            // 
            // btnClientes
            // 
            btnClientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.Location = new Point(214, 449);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(122, 48);
            btnClientes.TabIndex = 1;
            btnClientes.Text = "GESTIONAR CLIENTES";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnMascotas
            // 
            btnMascotas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMascotas.Location = new Point(214, 514);
            btnMascotas.Name = "btnMascotas";
            btnMascotas.Size = new Size(122, 48);
            btnMascotas.TabIndex = 1;
            btnMascotas.Text = "GESTIONAR MASCOTAS";
            btnMascotas.UseVisualStyleBackColor = true;
            btnMascotas.Click += btnMascotas_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(454, 575);
            button8.Name = "button8";
            button8.Size = new Size(81, 30);
            button8.TabIndex = 1;
            button8.Text = "SALIR";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(547, 617);
            ControlBox = false;
            Controls.Add(button8);
            Controls.Add(btnMascotas);
            Controls.Add(btnClientes);
            Controls.Add(btnServicios);
            Controls.Add(btnRazas);
            Controls.Add(btnEspecies);
            Controls.Add(btnVeterinarios);
            Controls.Add(btnUser);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administrador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnUser;
        private Button btnVeterinarios;
        private Button btnEspecies;
        private Button btnRazas;
        private Button btnServicios;
        private Button btnClientes;
        private Button btnMascotas;
        private Button button8;
    }
}