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
            buttonArpa = new Button();
            labelNumerot = new Label();
            groupBox1 = new GroupBox();
            labelTulos = new Label();
            textBoxRivi7 = new TextBox();
            textBoxRivi6 = new TextBox();
            textBoxRivi5 = new TextBox();
            textBoxRivi4 = new TextBox();
            textBoxRivi3 = new TextBox();
            textBoxRivi2 = new TextBox();
            textBoxRivi1 = new TextBox();
            label1 = new Label();
            buttonTarkista = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonArpa
            // 
            buttonArpa.Location = new Point(44, 73);
            buttonArpa.Name = "buttonArpa";
            buttonArpa.Size = new Size(200, 34);
            buttonArpa.TabIndex = 0;
            buttonArpa.Text = "Arvo lottonumerot";
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
            groupBox1.Controls.Add(labelTulos);
            groupBox1.Controls.Add(textBoxRivi7);
            groupBox1.Controls.Add(textBoxRivi6);
            groupBox1.Controls.Add(textBoxRivi5);
            groupBox1.Controls.Add(textBoxRivi4);
            groupBox1.Controls.Add(textBoxRivi3);
            groupBox1.Controls.Add(textBoxRivi2);
            groupBox1.Controls.Add(textBoxRivi1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(buttonTarkista);
            groupBox1.Location = new Point(375, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(364, 330);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lottorivit ja tarkistus";
            // 
            // labelTulos
            // 
            labelTulos.AutoSize = true;
            labelTulos.Location = new Point(159, 265);
            labelTulos.Name = "labelTulos";
            labelTulos.Size = new Size(176, 25);
            labelTulos.TabIndex = 9;
            labelTulos.Text = "OSUNEET NUMEROT";
            // 
            // textBoxRivi7
            // 
            textBoxRivi7.Location = new Point(185, 159);
            textBoxRivi7.Name = "textBoxRivi7";
            textBoxRivi7.Size = new Size(150, 31);
            textBoxRivi7.TabIndex = 8;
            // 
            // textBoxRivi6
            // 
            textBoxRivi6.Location = new Point(185, 113);
            textBoxRivi6.Name = "textBoxRivi6";
            textBoxRivi6.Size = new Size(150, 31);
            textBoxRivi6.TabIndex = 7;
            // 
            // textBoxRivi5
            // 
            textBoxRivi5.Location = new Point(185, 67);
            textBoxRivi5.Name = "textBoxRivi5";
            textBoxRivi5.Size = new Size(150, 31);
            textBoxRivi5.TabIndex = 6;
            // 
            // textBoxRivi4
            // 
            textBoxRivi4.Location = new Point(16, 205);
            textBoxRivi4.Name = "textBoxRivi4";
            textBoxRivi4.Size = new Size(150, 31);
            textBoxRivi4.TabIndex = 5;
            // 
            // textBoxRivi3
            // 
            textBoxRivi3.Location = new Point(16, 159);
            textBoxRivi3.Name = "textBoxRivi3";
            textBoxRivi3.Size = new Size(150, 31);
            textBoxRivi3.TabIndex = 4;
            // 
            // textBoxRivi2
            // 
            textBoxRivi2.Location = new Point(16, 113);
            textBoxRivi2.Name = "textBoxRivi2";
            textBoxRivi2.Size = new Size(150, 31);
            textBoxRivi2.TabIndex = 3;
            // 
            // textBoxRivi1
            // 
            textBoxRivi1.Location = new Point(16, 67);
            textBoxRivi1.Name = "textBoxRivi1";
            textBoxRivi1.Size = new Size(150, 31);
            textBoxRivi1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 39);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 1;
            label1.Text = "Lottorivisi:";
            // 
            // buttonTarkista
            // 
            buttonTarkista.Location = new Point(16, 265);
            buttonTarkista.Name = "buttonTarkista";
            buttonTarkista.Size = new Size(112, 34);
            buttonTarkista.TabIndex = 0;
            buttonTarkista.Text = "Tarkista rivit";
            buttonTarkista.UseVisualStyleBackColor = true;
            buttonTarkista.Click += buttonTarkista_Click;
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
        private Button buttonTarkista;
        private TextBox textBoxRivi4;
        private TextBox textBoxRivi3;
        private TextBox textBoxRivi2;
        private TextBox textBoxRivi1;
        private TextBox textBoxRivi7;
        private TextBox textBoxRivi6;
        private TextBox textBoxRivi5;
        private Label labelTulos;
    }
}
