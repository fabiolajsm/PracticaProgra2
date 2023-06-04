namespace WinFormsApp
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
            MenuStrip = new MenuStrip();
            ToolStripMenuItem1 = new ToolStripMenuItem();
            ToolStripMenuItem2 = new ToolStripMenuItem();
            ToolStripMenuItem3 = new ToolStripMenuItem();
            StatusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            RichTextBox = new RichTextBox();
            MenuStrip.SuspendLayout();
            StatusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MenuStrip
            // 
            MenuStrip.ImageScalingSize = new Size(24, 24);
            MenuStrip.Items.AddRange(new ToolStripItem[] { ToolStripMenuItem1, ToolStripMenuItem2, ToolStripMenuItem3 });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(800, 33);
            MenuStrip.TabIndex = 0;
            MenuStrip.Text = "menuStrip1";
            // 
            // ToolStripMenuItem1
            // 
            ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            ToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.A;
            ToolStripMenuItem1.Size = new Size(67, 29);
            ToolStripMenuItem1.Text = "Abrir";
            ToolStripMenuItem1.Click += ToolStripMenuItem1_Click;
            // 
            // ToolStripMenuItem2
            // 
            ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            ToolStripMenuItem2.ShortcutKeys = Keys.Control | Keys.S;
            ToolStripMenuItem2.Size = new Size(91, 29);
            ToolStripMenuItem2.Text = "Guardar";
            ToolStripMenuItem2.Click += ToolStripMenuItem2_Click;
            // 
            // ToolStripMenuItem3
            // 
            ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            ToolStripMenuItem3.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            ToolStripMenuItem3.Size = new Size(154, 29);
            ToolStripMenuItem3.Text = "Guardar como...";
            ToolStripMenuItem3.Click += ToolStripMenuItem3_Click;
            // 
            // StatusStrip
            // 
            StatusStrip.ImageScalingSize = new Size(24, 24);
            StatusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            StatusStrip.Location = new Point(0, 418);
            StatusStrip.Name = "StatusStrip";
            StatusStrip.Size = new Size(800, 32);
            StatusStrip.TabIndex = 1;
            StatusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(210, 25);
            toolStripStatusLabel.Text = "Cantidad de caracteres: 0";
            // 
            // RichTextBox
            // 
            RichTextBox.Dock = DockStyle.Fill;
            RichTextBox.Location = new Point(0, 33);
            RichTextBox.Name = "RichTextBox";
            RichTextBox.Size = new Size(800, 385);
            RichTextBox.TabIndex = 2;
            RichTextBox.Text = "";
            RichTextBox.TextChanged += RichTextBox_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RichTextBox);
            Controls.Add(StatusStrip);
            Controls.Add(MenuStrip);
            MainMenuStrip = MenuStrip;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notepad";
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            StatusStrip.ResumeLayout(false);
            StatusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuStrip;
        private ToolStripMenuItem ToolStripMenuItem1;
        private ToolStripMenuItem ToolStripMenuItem2;
        private ToolStripMenuItem ToolStripMenuItem3;
        private StatusStrip StatusStrip;
        private ToolStripStatusLabel toolStripStatusLabel;
        private RichTextBox RichTextBox;
    }
}