
namespace TetrisGame
{
    partial class Tetris
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
            labelLines = new Label();
            SuspendLayout();
            // 
            // labelLines
            // 
            labelLines.AutoSize = true;
            labelLines.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLines.Location = new Point(325, 41);
            labelLines.Name = "labelLines";
            labelLines.Size = new Size(113, 44);
            labelLines.TabIndex = 1;
            labelLines.Text = "lines";
            // 
            // Tetris
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 601);
            Controls.Add(labelLines);
            Name = "Tetris";
            Text = "Tetris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelLines;
    }
}
