namespace Array
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            labelHakuTulos = new Label();
            textBoxKoko = new TextBox();
            textBoxTNum = new TextBox();
            textBoxTInd = new TextBox();
            textBoxHakuTInd = new TextBox();
            buttonLuoTaulukko = new Button();
            buttonTallenna = new Button();
            buttonHaku = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 34);
            label1.Name = "label1";
            label1.Size = new Size(166, 25);
            label1.TabIndex = 0;
            label1.Text = "TAULUKON LUONTI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 130);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 1;
            label2.Text = "TALLENNUS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 262);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 2;
            label3.Text = "HAKU";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 85);
            label4.Name = "label4";
            label4.Size = new Size(131, 25);
            label4.TabIndex = 3;
            label4.Text = "Taulukon koko:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 167);
            label5.Name = "label5";
            label5.Size = new Size(184, 25);
            label5.TabIndex = 4;
            label5.Text = "Tallennettava numero:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 215);
            label6.Name = "label6";
            label6.Size = new Size(185, 25);
            label6.TabIndex = 5;
            label6.Text = "Talletuspaikan indeksi:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 310);
            label7.Name = "label7";
            label7.Size = new Size(185, 25);
            label7.TabIndex = 6;
            label7.Text = "Talletuspaikan indeksi:";
            // 
            // labelHakuTulos
            // 
            labelHakuTulos.AutoSize = true;
            labelHakuTulos.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHakuTulos.Location = new Point(34, 381);
            labelHakuTulos.Name = "labelHakuTulos";
            labelHakuTulos.Size = new Size(226, 26);
            labelHakuTulos.TabIndex = 7;
            labelHakuTulos.Text = "HAETTU NUMERO";
            // 
            // textBoxKoko
            // 
            textBoxKoko.Location = new Point(236, 79);
            textBoxKoko.Name = "textBoxKoko";
            textBoxKoko.Size = new Size(57, 31);
            textBoxKoko.TabIndex = 8;
            // 
            // textBoxTNum
            // 
            textBoxTNum.Location = new Point(236, 161);
            textBoxTNum.Name = "textBoxTNum";
            textBoxTNum.Size = new Size(57, 31);
            textBoxTNum.TabIndex = 9;
            // 
            // textBoxTInd
            // 
            textBoxTInd.Location = new Point(236, 209);
            textBoxTInd.Name = "textBoxTInd";
            textBoxTInd.Size = new Size(57, 31);
            textBoxTInd.TabIndex = 10;
            // 
            // textBoxHakuTInd
            // 
            textBoxHakuTInd.Location = new Point(236, 304);
            textBoxHakuTInd.Name = "textBoxHakuTInd";
            textBoxHakuTInd.Size = new Size(57, 31);
            textBoxHakuTInd.TabIndex = 11;
            // 
            // buttonLuoTaulukko
            // 
            buttonLuoTaulukko.Location = new Point(325, 76);
            buttonLuoTaulukko.Name = "buttonLuoTaulukko";
            buttonLuoTaulukko.Size = new Size(155, 34);
            buttonLuoTaulukko.TabIndex = 12;
            buttonLuoTaulukko.Text = "Uusi taulukko";
            buttonLuoTaulukko.UseVisualStyleBackColor = true;
            buttonLuoTaulukko.Click += buttonLuoTaulukko_Click;
            // 
            // buttonTallenna
            // 
            buttonTallenna.Location = new Point(325, 206);
            buttonTallenna.Name = "buttonTallenna";
            buttonTallenna.Size = new Size(155, 34);
            buttonTallenna.TabIndex = 13;
            buttonTallenna.Text = "Tallenna";
            buttonTallenna.UseVisualStyleBackColor = true;
            buttonTallenna.Click += buttonTallenna_Click;
            // 
            // buttonHaku
            // 
            buttonHaku.Location = new Point(325, 301);
            buttonHaku.Name = "buttonHaku";
            buttonHaku.Size = new Size(155, 34);
            buttonHaku.TabIndex = 14;
            buttonHaku.Text = "Hae";
            buttonHaku.UseVisualStyleBackColor = true;
            buttonHaku.Click += buttonHaku_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 443);
            Controls.Add(buttonHaku);
            Controls.Add(buttonTallenna);
            Controls.Add(buttonLuoTaulukko);
            Controls.Add(textBoxHakuTInd);
            Controls.Add(textBoxTInd);
            Controls.Add(textBoxTNum);
            Controls.Add(textBoxKoko);
            Controls.Add(labelHakuTulos);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Taulukon luonti";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label labelHakuTulos;
        private TextBox textBoxKoko;
        private TextBox textBoxTNum;
        private TextBox textBoxTInd;
        private TextBox textBoxHakuTInd;
        private Button buttonLuoTaulukko;
        private Button buttonTallenna;
        private Button buttonHaku;
    }
}
