namespace Clase6
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_login = new Button();
            tb_usuario = new TextBox();
            tb_contrasena = new TextBox();
            cb_mostrarContrasena = new CheckBox();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.Control;
            btn_login.Location = new Point(313, 255);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(112, 34);
            btn_login.TabIndex = 0;
            btn_login.Text = "Entrar";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // tb_usuario
            // 
            tb_usuario.BackColor = SystemColors.InactiveBorder;
            tb_usuario.ForeColor = SystemColors.ControlText;
            tb_usuario.Location = new Point(269, 107);
            tb_usuario.Name = "tb_usuario";
            tb_usuario.PlaceholderText = "Usuario";
            tb_usuario.Size = new Size(194, 31);
            tb_usuario.TabIndex = 1;
            tb_usuario.TextAlign = HorizontalAlignment.Center;
            // 
            // tb_contrasena
            // 
            tb_contrasena.BackColor = SystemColors.InactiveBorder;
            tb_contrasena.Location = new Point(269, 158);
            tb_contrasena.Name = "tb_contrasena";
            tb_contrasena.PasswordChar = '*';
            tb_contrasena.PlaceholderText = "Contraseña";
            tb_contrasena.Size = new Size(194, 31);
            tb_contrasena.TabIndex = 2;
            tb_contrasena.TextAlign = HorizontalAlignment.Center;
            // 
            // cb_mostrarContrasena
            // 
            cb_mostrarContrasena.AutoSize = true;
            cb_mostrarContrasena.BackColor = SystemColors.Control;
            cb_mostrarContrasena.Location = new Point(269, 208);
            cb_mostrarContrasena.Name = "cb_mostrarContrasena";
            cb_mostrarContrasena.Size = new Size(194, 29);
            cb_mostrarContrasena.TabIndex = 3;
            cb_mostrarContrasena.Text = "Mostrar Contraseña";
            cb_mostrarContrasena.UseVisualStyleBackColor = false;
            cb_mostrarContrasena.CheckedChanged += cb_mostrarContrasena_CheckedChanged;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cb_mostrarContrasena);
            Controls.Add(tb_contrasena);
            Controls.Add(tb_usuario);
            Controls.Add(btn_login);
            Name = "FormLogin";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        private TextBox tb_usuario;
        private TextBox tb_contrasena;
        private CheckBox cb_mostrarContrasena;
    }
}