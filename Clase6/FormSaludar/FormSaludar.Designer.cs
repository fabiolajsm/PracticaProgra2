namespace Saludo;

partial class FormSaludar
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
        Label_Titulo = new Label();
        label1 = new Label();
        SuspendLayout();
        // 
        // Label_Titulo
        // 
        Label_Titulo.AutoSize = true;
        Label_Titulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
        Label_Titulo.Location = new Point(89, 81);
        Label_Titulo.Name = "Label_Titulo";
        Label_Titulo.Size = new Size(368, 45);
        Label_Titulo.TabIndex = 0;
        Label_Titulo.Text = "¡Hola, Windows Forms!";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label1.Location = new Point(89, 148);
        label1.Name = "label1";
        label1.Size = new Size(93, 32);
        label1.TabIndex = 1;
        label1.Text = "Soy yo!";
        // 
        // FormSaludar
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(label1);
        Controls.Add(Label_Titulo);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FormSaludar";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Saludo";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label Label_Titulo;
    private Label label1;
}