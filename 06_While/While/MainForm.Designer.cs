﻿namespace While
{
    partial class MainForm
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
            buttonStartWhile = new Button();
            SuspendLayout();
            // 
            // buttonStartWhile
            // 
            buttonStartWhile.Location = new Point(78, 65);
            buttonStartWhile.Name = "buttonStartWhile";
            buttonStartWhile.Size = new Size(112, 34);
            buttonStartWhile.TabIndex = 0;
            buttonStartWhile.Text = "Start";
            buttonStartWhile.UseVisualStyleBackColor = true;
            buttonStartWhile.Click += buttonStartWhile_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonStartWhile);
            Name = "MainForm";
            Text = "While";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonStartWhile;
    }
}
