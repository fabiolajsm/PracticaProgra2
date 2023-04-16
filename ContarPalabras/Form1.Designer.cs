namespace ContarPalabras
{
    partial class Form1
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
            RichTextBox = new RichTextBox();
            Titulo = new Label();
            Btn_Calcular = new Button();
            SuspendLayout();
            // 
            // RichTextBox
            // 
            RichTextBox.Location = new Point(34, 77);
            RichTextBox.Name = "RichTextBox";
            RichTextBox.Size = new Size(717, 275);
            RichTextBox.TabIndex = 0;
            RichTextBox.Text = "";
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Location = new Point(34, 34);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(144, 25);
            Titulo.TabIndex = 1;
            Titulo.Text = "Ingrese un texto:";
            // 
            // Btn_Calcular
            // 
            Btn_Calcular.Location = new Point(639, 377);
            Btn_Calcular.Name = "Btn_Calcular";
            Btn_Calcular.Size = new Size(112, 34);
            Btn_Calcular.TabIndex = 2;
            Btn_Calcular.Text = "Calcular";
            Btn_Calcular.UseVisualStyleBackColor = true;
            Btn_Calcular.Click += Btn_Calcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Btn_Calcular);
            Controls.Add(Titulo);
            Controls.Add(RichTextBox);
            Name = "Form1";
            Text = "Contador de Palabras";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox RichTextBox;
        private Label Titulo;
        private Button Btn_Calcular;
    }
}