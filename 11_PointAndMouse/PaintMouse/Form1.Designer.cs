namespace PaintMouse
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
            buttonSetCoords = new Button();
            textBoxX = new TextBox();
            textBoxY = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // buttonSetCoords
            // 
            buttonSetCoords.Location = new Point(149, 37);
            buttonSetCoords.Name = "buttonSetCoords";
            buttonSetCoords.Size = new Size(146, 87);
            buttonSetCoords.TabIndex = 0;
            buttonSetCoords.Text = "Set \r\ncoordinates";
            buttonSetCoords.UseVisualStyleBackColor = true;
            buttonSetCoords.Click += buttonSetCoords_Click;
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(51, 37);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(77, 31);
            textBoxX.TabIndex = 1;
            // 
            // textBoxY
            // 
            textBoxY.Location = new Point(51, 93);
            textBoxY.Name = "textBoxY";
            textBoxY.Size = new Size(77, 31);
            textBoxY.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(27, 25);
            label1.TabIndex = 3;
            label1.Text = "X:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 99);
            label2.Name = "label2";
            label2.Size = new Size(26, 25);
            label2.TabIndex = 4;
            label2.Text = "Y:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 555);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxY);
            Controls.Add(textBoxX);
            Controls.Add(buttonSetCoords);
            Name = "Form1";
            Text = "Tikku-ukko";
            Paint += Form1_Paint;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSetCoords;
        private TextBox textBoxX;
        private TextBox textBoxY;
        private Label label1;
        private Label label2;
    }
}
