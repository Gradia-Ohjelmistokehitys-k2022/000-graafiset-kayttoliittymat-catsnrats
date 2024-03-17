namespace ListForeach
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
            buttonLuoLista = new Button();
            label1 = new Label();
            label2 = new Label();
            buttonAddString = new Button();
            textBoxAddString = new TextBox();
            label3 = new Label();
            buttonHaeLista = new Button();
            comboBoxList = new ComboBox();
            SuspendLayout();
            // 
            // buttonLuoLista
            // 
            buttonLuoLista.Location = new Point(151, 102);
            buttonLuoLista.Name = "buttonLuoLista";
            buttonLuoLista.Size = new Size(112, 34);
            buttonLuoLista.TabIndex = 0;
            buttonLuoLista.Text = "Luo lista";
            buttonLuoLista.UseVisualStyleBackColor = true;
            buttonLuoLista.Click += buttonLuoLista_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 57);
            label1.Name = "label1";
            label1.Size = new Size(177, 25);
            label1.TabIndex = 1;
            label1.Text = "Luo string-tyypi lista:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 171);
            label2.Name = "label2";
            label2.Size = new Size(203, 25);
            label2.TabIndex = 2;
            label2.Text = "Lisää listaan merkkijono:";
            // 
            // buttonAddString
            // 
            buttonAddString.Location = new Point(355, 204);
            buttonAddString.Name = "buttonAddString";
            buttonAddString.Size = new Size(174, 34);
            buttonAddString.TabIndex = 3;
            buttonAddString.Text = "Lisää merkkijono";
            buttonAddString.UseVisualStyleBackColor = true;
            buttonAddString.Click += buttonAddString_Click;
            // 
            // textBoxAddString
            // 
            textBoxAddString.Location = new Point(151, 207);
            textBoxAddString.Name = "textBoxAddString";
            textBoxAddString.Size = new Size(187, 31);
            textBoxAddString.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 275);
            label3.Name = "label3";
            label3.Size = new Size(174, 25);
            label3.TabIndex = 5;
            label3.Text = "Hakee listan sisällön:";
            // 
            // buttonHaeLista
            // 
            buttonHaeLista.Location = new Point(355, 311);
            buttonHaeLista.Name = "buttonHaeLista";
            buttonHaeLista.Size = new Size(112, 34);
            buttonHaeLista.TabIndex = 6;
            buttonHaeLista.Text = "Hae lista";
            buttonHaeLista.UseVisualStyleBackColor = true;
            buttonHaeLista.Click += buttonHaeLista_Click;
            // 
            // comboBoxList
            // 
            comboBoxList.FormattingEnabled = true;
            comboBoxList.Location = new Point(151, 313);
            comboBoxList.Name = "comboBoxList";
            comboBoxList.Size = new Size(182, 33);
            comboBoxList.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxList);
            Controls.Add(buttonHaeLista);
            Controls.Add(label3);
            Controls.Add(textBoxAddString);
            Controls.Add(buttonAddString);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonLuoLista);
            Name = "Form1";
            Text = "String-tyypin lista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLuoLista;
        private Label label1;
        private Label label2;
        private Button buttonAddString;
        private TextBox textBoxAddString;
        private Label label3;
        private Button buttonHaeLista;
        private ComboBox comboBoxList;
    }
}
