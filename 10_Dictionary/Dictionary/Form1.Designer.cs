namespace Dictionary
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
            buttonLuoDictionary = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxKey = new TextBox();
            label4 = new Label();
            textBoxValue = new TextBox();
            buttonAddKeyVal = new Button();
            label5 = new Label();
            textBoxSearchKey = new TextBox();
            buttonSearch = new Button();
            label6 = new Label();
            label7 = new Label();
            labelShowValue = new Label();
            SuspendLayout();
            // 
            // buttonLuoDictionary
            // 
            buttonLuoDictionary.Location = new Point(247, 61);
            buttonLuoDictionary.Name = "buttonLuoDictionary";
            buttonLuoDictionary.Size = new Size(156, 34);
            buttonLuoDictionary.TabIndex = 0;
            buttonLuoDictionary.Text = "Luo dictionary";
            buttonLuoDictionary.UseVisualStyleBackColor = true;
            buttonLuoDictionary.Click += buttonLuoDictionary_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(247, 22);
            label1.Name = "label1";
            label1.Size = new Size(167, 25);
            label1.TabIndex = 1;
            label1.Text = "Luodaan dictionary:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(247, 143);
            label2.Name = "label2";
            label2.Size = new Size(175, 25);
            label2.TabIndex = 2;
            label2.Text = "Lisätään elementtejä:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(182, 194);
            label3.Name = "label3";
            label3.Size = new Size(44, 25);
            label3.TabIndex = 3;
            label3.Text = "Key:";
            // 
            // textBoxKey
            // 
            textBoxKey.Location = new Point(254, 188);
            textBoxKey.Name = "textBoxKey";
            textBoxKey.Size = new Size(150, 31);
            textBoxKey.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(168, 240);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 5;
            label4.Text = "Value:";
            // 
            // textBoxValue
            // 
            textBoxValue.Location = new Point(254, 234);
            textBoxValue.Name = "textBoxValue";
            textBoxValue.Size = new Size(150, 31);
            textBoxValue.TabIndex = 6;
            // 
            // buttonAddKeyVal
            // 
            buttonAddKeyVal.Location = new Point(434, 191);
            buttonAddKeyVal.Name = "buttonAddKeyVal";
            buttonAddKeyVal.Size = new Size(126, 74);
            buttonAddKeyVal.TabIndex = 7;
            buttonAddKeyVal.Text = "Lisää\r\narvopari";
            buttonAddKeyVal.UseVisualStyleBackColor = true;
            buttonAddKeyVal.Click += buttonAddKeyVal_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(247, 299);
            label5.Name = "label5";
            label5.Size = new Size(177, 25);
            label5.TabIndex = 8;
            label5.Text = "Haetaan elementtejä:";
            // 
            // textBoxSearchKey
            // 
            textBoxSearchKey.Location = new Point(253, 336);
            textBoxSearchKey.Name = "textBoxSearchKey";
            textBoxSearchKey.Size = new Size(150, 31);
            textBoxSearchKey.TabIndex = 9;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(434, 336);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(101, 34);
            buttonSearch.TabIndex = 10;
            buttonSearch.Text = "Hae";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(182, 342);
            label6.Name = "label6";
            label6.Size = new Size(44, 25);
            label6.TabIndex = 11;
            label6.Text = "Key:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(168, 388);
            label7.Name = "label7";
            label7.Size = new Size(58, 25);
            label7.TabIndex = 12;
            label7.Text = "Value:";
            // 
            // labelShowValue
            // 
            labelShowValue.AutoSize = true;
            labelShowValue.Location = new Point(254, 388);
            labelShowValue.Name = "labelShowValue";
            labelShowValue.Size = new Size(85, 25);
            labelShowValue.TabIndex = 13;
            labelShowValue.Text = "* * * * * *";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelShowValue);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearchKey);
            Controls.Add(label5);
            Controls.Add(buttonAddKeyVal);
            Controls.Add(textBoxValue);
            Controls.Add(label4);
            Controls.Add(textBoxKey);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonLuoDictionary);
            Name = "Form1";
            Text = "Dictionary";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLuoDictionary;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxKey;
        private Label label4;
        private TextBox textBoxValue;
        private Button buttonAddKeyVal;
        private Label label5;
        private TextBox textBoxSearchKey;
        private Button buttonSearch;
        private Label label6;
        private Label label7;
        private Label labelShowValue;
    }
}
