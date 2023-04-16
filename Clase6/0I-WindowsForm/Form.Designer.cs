namespace _0I_WindowsForm
{
    partial class Form
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
            Btn_Saludar = new Button();
            Tb_Nombre = new TextBox();
            Tb_Apellido = new TextBox();
            Label_Nombre = new Label();
            Label_Apellido = new Label();
            Cb_Materia = new ComboBox();
            Label_Materia = new Label();
            SuspendLayout();
            // 
            // Btn_Saludar
            // 
            Btn_Saludar.Location = new Point(403, 301);
            Btn_Saludar.Name = "Btn_Saludar";
            Btn_Saludar.Size = new Size(150, 34);
            Btn_Saludar.TabIndex = 0;
            Btn_Saludar.Text = "Saludar";
            Btn_Saludar.UseVisualStyleBackColor = true;
            Btn_Saludar.Click += Btn_Saludar_Click;
            // 
            // Tb_Nombre
            // 
            Tb_Nombre.Location = new Point(180, 165);
            Tb_Nombre.Name = "Tb_Nombre";
            Tb_Nombre.Size = new Size(150, 31);
            Tb_Nombre.TabIndex = 1;
            // 
            // Tb_Apellido
            // 
            Tb_Apellido.Location = new Point(403, 165);
            Tb_Apellido.Name = "Tb_Apellido";
            Tb_Apellido.Size = new Size(150, 31);
            Tb_Apellido.TabIndex = 2;
            // 
            // Label_Nombre
            // 
            Label_Nombre.AutoSize = true;
            Label_Nombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Label_Nombre.Location = new Point(180, 127);
            Label_Nombre.Name = "Label_Nombre";
            Label_Nombre.Size = new Size(81, 25);
            Label_Nombre.TabIndex = 3;
            Label_Nombre.Text = "Nombre";
            // 
            // Label_Apellido
            // 
            Label_Apellido.AutoSize = true;
            Label_Apellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Label_Apellido.Location = new Point(403, 127);
            Label_Apellido.Name = "Label_Apellido";
            Label_Apellido.Size = new Size(83, 25);
            Label_Apellido.TabIndex = 4;
            Label_Apellido.Text = "Apellido";
            // 
            // Cb_Materia
            // 
            Cb_Materia.FormattingEnabled = true;
            Cb_Materia.Items.AddRange(new object[] { "Programación II", "Legislación", "Organización contable de la empresa" });
            Cb_Materia.Location = new Point(180, 253);
            Cb_Materia.Name = "Cb_Materia";
            Cb_Materia.Size = new Size(373, 33);
            Cb_Materia.TabIndex = 5;
            Cb_Materia.Text = "Programación II";
            Cb_Materia.UseWaitCursor = true;
            // 
            // Label_Materia
            // 
            Label_Materia.AutoSize = true;
            Label_Materia.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Label_Materia.Location = new Point(180, 213);
            Label_Materia.Name = "Label_Materia";
            Label_Materia.Size = new Size(150, 25);
            Label_Materia.TabIndex = 6;
            Label_Materia.Text = "Materia favorita";
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Label_Materia);
            Controls.Add(Cb_Materia);
            Controls.Add(Label_Apellido);
            Controls.Add(Label_Nombre);
            Controls.Add(Tb_Apellido);
            Controls.Add(Tb_Nombre);
            Controls.Add(Btn_Saludar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "¡Hola, Windows Forms!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Saludar;
        private TextBox Tb_Nombre;
        private TextBox Tb_Apellido;
        private Label Label_Nombre;
        private Label Label_Apellido;
        private ComboBox Cb_Materia;
        private Label Label_Materia;
    }
}