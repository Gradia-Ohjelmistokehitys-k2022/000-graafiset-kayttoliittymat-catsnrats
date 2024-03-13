namespace ArrayLotto
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
            components = new System.ComponentModel.Container();
            buttonArpa = new Button();
            labelNumerot = new Label();
            groupBox1 = new GroupBox();
            buttonTyhjennäRivit = new Button();
            richTextBox7 = new RichTextBox();
            richTextBox6 = new RichTextBox();
            richTextBox5 = new RichTextBox();
            richTextBox4 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonArpa
            // 
            buttonArpa.Location = new Point(44, 73);
            buttonArpa.Name = "buttonArpa";
            buttonArpa.Size = new Size(186, 78);
            buttonArpa.TabIndex = 0;
            buttonArpa.Text = "Arvo ja tarkista\r\nlottonumerot";
            buttonArpa.UseVisualStyleBackColor = true;
            buttonArpa.Click += buttonArpa_Click;
            // 
            // labelNumerot
            // 
            labelNumerot.AutoSize = true;
            labelNumerot.Location = new Point(44, 154);
            labelNumerot.Name = "labelNumerot";
            labelNumerot.Size = new Size(186, 25);
            labelNumerot.TabIndex = 1;
            labelNumerot.Text = "klikkaa 'arvo numerot'";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonTyhjennäRivit);
            groupBox1.Controls.Add(richTextBox7);
            groupBox1.Controls.Add(richTextBox6);
            groupBox1.Controls.Add(richTextBox5);
            groupBox1.Controls.Add(richTextBox4);
            groupBox1.Controls.Add(richTextBox3);
            groupBox1.Controls.Add(richTextBox2);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(475, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(241, 409);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lottorivit ja tarkistus";
            toolTip1.SetToolTip(groupBox1, "Anna lottorivit väliltä 1 - 40 pilkuilla eroteltuna.\r\nTyhjennä rivit ennen uuden rivin arpomista ja tarkistuksia.");
            // 
            // buttonTyhjennäRivit
            // 
            buttonTyhjennäRivit.Location = new Point(6, 348);
            buttonTyhjennäRivit.Name = "buttonTyhjennäRivit";
            buttonTyhjennäRivit.Size = new Size(159, 34);
            buttonTyhjennäRivit.TabIndex = 16;
            buttonTyhjennäRivit.Text = "Tyhjennä rivit";
            buttonTyhjennäRivit.UseVisualStyleBackColor = true;
            buttonTyhjennäRivit.Click += buttonTyhjennäRivit_Click;
            // 
            // richTextBox7
            // 
            richTextBox7.Location = new Point(6, 290);
            richTextBox7.MaxLength = 29;
            richTextBox7.Name = "richTextBox7";
            richTextBox7.Size = new Size(224, 31);
            richTextBox7.TabIndex = 15;
            richTextBox7.Text = "";
            // 
            // richTextBox6
            // 
            richTextBox6.Location = new Point(6, 253);
            richTextBox6.MaxLength = 29;
            richTextBox6.Name = "richTextBox6";
            richTextBox6.Size = new Size(224, 31);
            richTextBox6.TabIndex = 14;
            richTextBox6.Text = "";
            // 
            // richTextBox5
            // 
            richTextBox5.Location = new Point(6, 216);
            richTextBox5.MaxLength = 29;
            richTextBox5.Name = "richTextBox5";
            richTextBox5.Size = new Size(224, 31);
            richTextBox5.TabIndex = 13;
            richTextBox5.Text = "";
            // 
            // richTextBox4
            // 
            richTextBox4.Location = new Point(6, 179);
            richTextBox4.MaxLength = 29;
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(224, 31);
            richTextBox4.TabIndex = 12;
            richTextBox4.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(6, 142);
            richTextBox3.MaxLength = 29;
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(224, 31);
            richTextBox3.TabIndex = 11;
            richTextBox3.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(6, 104);
            richTextBox2.MaxLength = 29;
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(224, 31);
            richTextBox2.TabIndex = 10;
            richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 67);
            richTextBox1.MaxLength = 28;
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(224, 31);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 39);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 1;
            label1.Text = "Lottorivisi:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(labelNumerot);
            Controls.Add(buttonArpa);
            Name = "Form1";
            Text = "Lotto";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonArpa;
        private Label labelNumerot;
        private GroupBox groupBox1;
        private Label label1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox7;
        private RichTextBox richTextBox6;
        private RichTextBox richTextBox5;
        private RichTextBox richTextBox4;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox2;
        private Button buttonTyhjennäRivit;
        private ToolTip toolTip1;
    }
}
