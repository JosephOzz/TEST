namespace Caso1.Views
{
    partial class Main
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
            menuStrip1 = new MenuStrip();
            MainOption1 = new ToolStripMenuItem();
            MainOption2 = new ToolStripMenuItem();
            MainOption3 = new ToolStripMenuItem();
            MainOption4 = new ToolStripMenuItem();
            MainOption5 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { MainOption1, MainOption2, MainOption3, MainOption4, MainOption5 });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.Flow;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(510, 29);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // MainOption1
            // 
            MainOption1.Name = "MainOption1";
            MainOption1.Size = new Size(68, 25);
            MainOption1.Text = "Form1";
            MainOption1.Click += MainOption1_Click;
            // 
            // MainOption2
            // 
            MainOption2.Name = "MainOption2";
            MainOption2.Size = new Size(68, 25);
            MainOption2.Text = "Form2";
            MainOption2.Click += MainOption2_Click;
            // 
            // MainOption3
            // 
            MainOption3.Name = "MainOption3";
            MainOption3.Size = new Size(68, 25);
            MainOption3.Text = "Form3";
            MainOption3.Click += MainOption3_Click;
            // 
            // MainOption4
            // 
            MainOption4.Name = "MainOption4";
            MainOption4.Size = new Size(68, 25);
            MainOption4.Text = "Form4";
            MainOption4.Click += MainOption4_Click;
            // 
            // MainOption5
            // 
            MainOption5.Name = "MainOption5";
            MainOption5.Size = new Size(68, 25);
            MainOption5.Text = "Form5";
            MainOption5.Click += MainOption5_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(2500, 2500);
            MinimumSize = new Size(526, 489);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += Main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MainOption1;
        private ToolStripMenuItem MainOption2;
        private ToolStripMenuItem MainOption3;
        private ToolStripMenuItem MainOption4;
        private ToolStripMenuItem MainOption5;
    }
}