namespace Veterinaria2
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            cmd_cancelar = new Button();
            btnIngresar = new Button();
            pictureBox1 = new PictureBox();
            txtClave = new TextBox();
            txtUser = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmd_cancelar
            // 
            cmd_cancelar.Location = new Point(158, 372);
            cmd_cancelar.Name = "cmd_cancelar";
            cmd_cancelar.Size = new Size(75, 23);
            cmd_cancelar.TabIndex = 13;
            cmd_cancelar.Text = "Cancelar";
            cmd_cancelar.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(12, 372);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 12;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 179);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(12, 313);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(221, 23);
            txtClave.TabIndex = 10;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(12, 244);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(221, 23);
            txtUser.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 295);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 8;
            label2.Text = "Clave:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 226);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 7;
            label1.Text = "Usuario:";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 408);
            Controls.Add(cmd_cancelar);
            Controls.Add(btnIngresar);
            Controls.Add(pictureBox1);
            Controls.Add(txtClave);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmd_cancelar;
        private Button btnIngresar;
        private PictureBox pictureBox1;
        private TextBox txtClave;
        private TextBox txtUser;
        private Label label2;
        private Label label1;
    }
}