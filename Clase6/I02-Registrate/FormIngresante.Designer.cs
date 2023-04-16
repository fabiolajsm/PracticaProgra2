namespace I02_Registrate
{
    partial class FormIngresante
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
            Gb_DetallesUsuario = new GroupBox();
            NumericUpDown_Edad = new NumericUpDown();
            Label_Edad = new Label();
            Label_Direccion = new Label();
            Label_Nombre = new Label();
            Tb_Direccion = new TextBox();
            Tb_Nombre = new TextBox();
            Gb_Genero = new GroupBox();
            Rb_GeneroB = new RadioButton();
            Rb_GeneroF = new RadioButton();
            Rb_GeneroM = new RadioButton();
            Gb_Cursos = new GroupBox();
            Cb_Cursos3 = new CheckBox();
            Cb_Cursos2 = new CheckBox();
            Cb_Cursos1 = new CheckBox();
            Lb_Pais = new ListBox();
            Label_Pais = new Label();
            Btn_Ingresar = new Button();
            Gb_DetallesUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown_Edad).BeginInit();
            Gb_Genero.SuspendLayout();
            Gb_Cursos.SuspendLayout();
            SuspendLayout();
            // 
            // Gb_DetallesUsuario
            // 
            Gb_DetallesUsuario.BackColor = SystemColors.Control;
            Gb_DetallesUsuario.Controls.Add(NumericUpDown_Edad);
            Gb_DetallesUsuario.Controls.Add(Label_Edad);
            Gb_DetallesUsuario.Controls.Add(Label_Direccion);
            Gb_DetallesUsuario.Controls.Add(Label_Nombre);
            Gb_DetallesUsuario.Controls.Add(Tb_Direccion);
            Gb_DetallesUsuario.Controls.Add(Tb_Nombre);
            Gb_DetallesUsuario.Location = new Point(75, 24);
            Gb_DetallesUsuario.Name = "Gb_DetallesUsuario";
            Gb_DetallesUsuario.Size = new Size(311, 192);
            Gb_DetallesUsuario.TabIndex = 0;
            Gb_DetallesUsuario.TabStop = false;
            Gb_DetallesUsuario.Text = "Detalles del usuario";
            // 
            // NumericUpDown_Edad
            // 
            NumericUpDown_Edad.Location = new Point(126, 146);
            NumericUpDown_Edad.Maximum = new decimal(new int[] { 90, 0, 0, 0 });
            NumericUpDown_Edad.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            NumericUpDown_Edad.Name = "NumericUpDown_Edad";
            NumericUpDown_Edad.Size = new Size(150, 31);
            NumericUpDown_Edad.TabIndex = 5;
            NumericUpDown_Edad.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // Label_Edad
            // 
            Label_Edad.AutoSize = true;
            Label_Edad.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Label_Edad.Location = new Point(16, 148);
            Label_Edad.Name = "Label_Edad";
            Label_Edad.Size = new Size(52, 25);
            Label_Edad.TabIndex = 4;
            Label_Edad.Text = "Edad";
            // 
            // Label_Direccion
            // 
            Label_Direccion.AutoSize = true;
            Label_Direccion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Label_Direccion.Location = new Point(16, 92);
            Label_Direccion.Name = "Label_Direccion";
            Label_Direccion.Size = new Size(85, 25);
            Label_Direccion.TabIndex = 3;
            Label_Direccion.Text = "Dirección";
            // 
            // Label_Nombre
            // 
            Label_Nombre.AutoSize = true;
            Label_Nombre.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Label_Nombre.Location = new Point(16, 43);
            Label_Nombre.Name = "Label_Nombre";
            Label_Nombre.Size = new Size(78, 25);
            Label_Nombre.TabIndex = 2;
            Label_Nombre.Text = "Nombre";
            // 
            // Tb_Direccion
            // 
            Tb_Direccion.Location = new Point(126, 92);
            Tb_Direccion.Name = "Tb_Direccion";
            Tb_Direccion.Size = new Size(150, 31);
            Tb_Direccion.TabIndex = 1;
            // 
            // Tb_Nombre
            // 
            Tb_Nombre.Location = new Point(126, 43);
            Tb_Nombre.Name = "Tb_Nombre";
            Tb_Nombre.Size = new Size(150, 31);
            Tb_Nombre.TabIndex = 0;
            // 
            // Gb_Genero
            // 
            Gb_Genero.Controls.Add(Rb_GeneroB);
            Gb_Genero.Controls.Add(Rb_GeneroF);
            Gb_Genero.Controls.Add(Rb_GeneroM);
            Gb_Genero.Location = new Point(482, 24);
            Gb_Genero.Name = "Gb_Genero";
            Gb_Genero.Size = new Size(180, 162);
            Gb_Genero.TabIndex = 1;
            Gb_Genero.TabStop = false;
            Gb_Genero.Text = "Género";
            // 
            // Rb_GeneroB
            // 
            Rb_GeneroB.AutoSize = true;
            Rb_GeneroB.Location = new Point(21, 115);
            Rb_GeneroB.Name = "Rb_GeneroB";
            Rb_GeneroB.Size = new Size(121, 29);
            Rb_GeneroB.TabIndex = 2;
            Rb_GeneroB.TabStop = true;
            Rb_GeneroB.Text = "No binario";
            Rb_GeneroB.UseVisualStyleBackColor = true;
            Rb_GeneroB.CheckedChanged += Rb_GeneroB_CheckedChanged;
            // 
            // Rb_GeneroF
            // 
            Rb_GeneroF.AutoSize = true;
            Rb_GeneroF.Location = new Point(21, 77);
            Rb_GeneroF.Name = "Rb_GeneroF";
            Rb_GeneroF.Size = new Size(115, 29);
            Rb_GeneroF.TabIndex = 1;
            Rb_GeneroF.TabStop = true;
            Rb_GeneroF.Text = "Femenino";
            Rb_GeneroF.UseVisualStyleBackColor = true;
            Rb_GeneroF.CheckedChanged += Rb_GeneroF_CheckedChanged;
            // 
            // Rb_GeneroM
            // 
            Rb_GeneroM.AutoSize = true;
            Rb_GeneroM.Location = new Point(21, 42);
            Rb_GeneroM.Name = "Rb_GeneroM";
            Rb_GeneroM.Size = new Size(117, 29);
            Rb_GeneroM.TabIndex = 0;
            Rb_GeneroM.TabStop = true;
            Rb_GeneroM.Text = "Masculino\r\n";
            Rb_GeneroM.UseVisualStyleBackColor = true;
            Rb_GeneroM.CheckedChanged += Rb_GeneroM_CheckedChanged;
            // 
            // Gb_Cursos
            // 
            Gb_Cursos.Controls.Add(Cb_Cursos3);
            Gb_Cursos.Controls.Add(Cb_Cursos2);
            Gb_Cursos.Controls.Add(Cb_Cursos1);
            Gb_Cursos.Location = new Point(482, 207);
            Gb_Cursos.Name = "Gb_Cursos";
            Gb_Cursos.Size = new Size(180, 142);
            Gb_Cursos.TabIndex = 2;
            Gb_Cursos.TabStop = false;
            Gb_Cursos.Text = "Cursos";
            // 
            // Cb_Cursos3
            // 
            Cb_Cursos3.AutoSize = true;
            Cb_Cursos3.Location = new Point(17, 100);
            Cb_Cursos3.Name = "Cb_Cursos3";
            Cb_Cursos3.Size = new Size(116, 29);
            Cb_Cursos3.TabIndex = 3;
            Cb_Cursos3.Text = "JavaScript\r\n";
            Cb_Cursos3.UseVisualStyleBackColor = true;
            Cb_Cursos3.CheckedChanged += Cb_Cursos3_CheckedChanged;
            // 
            // Cb_Cursos2
            // 
            Cb_Cursos2.AutoSize = true;
            Cb_Cursos2.Location = new Point(17, 65);
            Cb_Cursos2.Name = "Cb_Cursos2";
            Cb_Cursos2.Size = new Size(73, 29);
            Cb_Cursos2.TabIndex = 3;
            Cb_Cursos2.Text = "C++";
            Cb_Cursos2.UseVisualStyleBackColor = true;
            Cb_Cursos2.CheckedChanged += Cb_Cursos2_CheckedChanged;
            // 
            // Cb_Cursos1
            // 
            Cb_Cursos1.AutoSize = true;
            Cb_Cursos1.Location = new Point(17, 30);
            Cb_Cursos1.Name = "Cb_Cursos1";
            Cb_Cursos1.Size = new Size(60, 29);
            Cb_Cursos1.TabIndex = 0;
            Cb_Cursos1.Text = "C#\r\n";
            Cb_Cursos1.UseVisualStyleBackColor = true;
            Cb_Cursos1.CheckedChanged += Cb_Cursos1_CheckedChanged;
            // 
            // Lb_Pais
            // 
            Lb_Pais.FormattingEnabled = true;
            Lb_Pais.ItemHeight = 25;
            Lb_Pais.Items.AddRange(new object[] { "Argentina", "Chile", "Uruguay" });
            Lb_Pais.Location = new Point(75, 275);
            Lb_Pais.Name = "Lb_Pais";
            Lb_Pais.Size = new Size(311, 129);
            Lb_Pais.TabIndex = 3;
            // 
            // Label_Pais
            // 
            Label_Pais.AutoSize = true;
            Label_Pais.Location = new Point(75, 236);
            Label_Pais.Name = "Label_Pais";
            Label_Pais.Size = new Size(42, 25);
            Label_Pais.TabIndex = 4;
            Label_Pais.Text = "País";
            // 
            // Btn_Ingresar
            // 
            Btn_Ingresar.BackColor = SystemColors.ButtonFace;
            Btn_Ingresar.Location = new Point(550, 370);
            Btn_Ingresar.Name = "Btn_Ingresar";
            Btn_Ingresar.Size = new Size(112, 34);
            Btn_Ingresar.TabIndex = 5;
            Btn_Ingresar.Text = "Ingresar";
            Btn_Ingresar.UseVisualStyleBackColor = false;
            Btn_Ingresar.Click += Btn_Ingresar_Click;
            // 
            // FormIngresante
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Btn_Ingresar);
            Controls.Add(Label_Pais);
            Controls.Add(Lb_Pais);
            Controls.Add(Gb_Cursos);
            Controls.Add(Gb_Genero);
            Controls.Add(Gb_DetallesUsuario);
            Name = "FormIngresante";
            Text = "Registro";
            Gb_DetallesUsuario.ResumeLayout(false);
            Gb_DetallesUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown_Edad).EndInit();
            Gb_Genero.ResumeLayout(false);
            Gb_Genero.PerformLayout();
            Gb_Cursos.ResumeLayout(false);
            Gb_Cursos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox Gb_DetallesUsuario;
        private NumericUpDown NumericUpDown_Edad;
        private Label Label_Edad;
        private Label Label_Direccion;
        private Label Label_Nombre;
        private TextBox Tb_Direccion;
        private TextBox Tb_Nombre;
        private GroupBox Gb_Genero;
        private RadioButton Rb_GeneroB;
        private RadioButton Rb_GeneroF;
        private RadioButton Rb_GeneroM;
        private GroupBox Gb_Cursos;
        private CheckBox Cb_Cursos1;
        private CheckBox Cb_Cursos3;
        private CheckBox Cb_Cursos2;
        private ListBox Lb_Pais;
        private Label Label_Pais;
        private Button Btn_Ingresar;
    }
}