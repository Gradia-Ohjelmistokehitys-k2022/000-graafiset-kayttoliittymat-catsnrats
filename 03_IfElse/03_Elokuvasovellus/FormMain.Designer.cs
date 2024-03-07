namespace Elokuvasovellus
{
    partial class FormMain
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
            menuStrip1 = new MenuStrip();
            tiedostoToolStripMenuItem = new ToolStripMenuItem();
            poistuToolStripMenuItem = new ToolStripMenuItem();
            tietojaToolStripMenuItem = new ToolStripMenuItem();
            testaaTietokantayhteyttäToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            buttonSeuraava = new Button();
            buttonEdellinen = new Button();
            textBoxKesto = new TextBox();
            textBoxJulkaisuvuosi = new TextBox();
            textBoxNimi = new TextBox();
            textBoxID = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            buttonPoista = new Button();
            buttonTallenna = new Button();
            buttonUusiTietue = new Button();
            groupBox3 = new GroupBox();
            numericUpDown2 = new NumericUpDown();
            labelArvosana = new Label();
            numericUpDown1 = new NumericUpDown();
            richTextBoxArvio = new RichTextBox();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tiedostoToolStripMenuItem, tietojaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(924, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            tiedostoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { poistuToolStripMenuItem });
            tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            tiedostoToolStripMenuItem.Size = new Size(97, 29);
            tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // poistuToolStripMenuItem
            // 
            poistuToolStripMenuItem.Name = "poistuToolStripMenuItem";
            poistuToolStripMenuItem.Size = new Size(162, 34);
            poistuToolStripMenuItem.Text = "Poistu";
            poistuToolStripMenuItem.Click += poistuToolStripMenuItem_Click;
            // 
            // tietojaToolStripMenuItem
            // 
            tietojaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { testaaTietokantayhteyttäToolStripMenuItem, infoToolStripMenuItem });
            tietojaToolStripMenuItem.Name = "tietojaToolStripMenuItem";
            tietojaToolStripMenuItem.Size = new Size(80, 29);
            tietojaToolStripMenuItem.Text = "Tietoja";
            // 
            // testaaTietokantayhteyttäToolStripMenuItem
            // 
            testaaTietokantayhteyttäToolStripMenuItem.Name = "testaaTietokantayhteyttäToolStripMenuItem";
            testaaTietokantayhteyttäToolStripMenuItem.Size = new Size(310, 34);
            testaaTietokantayhteyttäToolStripMenuItem.Text = "Testaa tietokantayhteyttä";
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(310, 34);
            infoToolStripMenuItem.Text = "Info";
            infoToolStripMenuItem.Click += infoToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonSeuraava);
            groupBox1.Controls.Add(buttonEdellinen);
            groupBox1.Controls.Add(textBoxKesto);
            groupBox1.Controls.Add(textBoxJulkaisuvuosi);
            groupBox1.Controls.Add(textBoxNimi);
            groupBox1.Controls.Add(textBoxID);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(22, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(470, 296);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Elokuvan tiedot";
            // 
            // buttonSeuraava
            // 
            buttonSeuraava.BackColor = SystemColors.Window;
            buttonSeuraava.FlatStyle = FlatStyle.System;
            buttonSeuraava.Location = new Point(206, 216);
            buttonSeuraava.Name = "buttonSeuraava";
            buttonSeuraava.Size = new Size(168, 58);
            buttonSeuraava.TabIndex = 9;
            buttonSeuraava.Text = "Seuraava";
            buttonSeuraava.UseVisualStyleBackColor = false;
            // 
            // buttonEdellinen
            // 
            buttonEdellinen.FlatStyle = FlatStyle.System;
            buttonEdellinen.Location = new Point(15, 216);
            buttonEdellinen.Name = "buttonEdellinen";
            buttonEdellinen.Size = new Size(155, 58);
            buttonEdellinen.TabIndex = 8;
            buttonEdellinen.Text = "Edellinen";
            buttonEdellinen.UseVisualStyleBackColor = true;
            // 
            // textBoxKesto
            // 
            textBoxKesto.Location = new Point(152, 154);
            textBoxKesto.Name = "textBoxKesto";
            textBoxKesto.Size = new Size(150, 31);
            textBoxKesto.TabIndex = 7;
            textBoxKesto.Click += textBoxKesto_Click;
            textBoxKesto.Leave += textBoxKesto_Leave;
            // 
            // textBoxJulkaisuvuosi
            // 
            textBoxJulkaisuvuosi.Location = new Point(152, 114);
            textBoxJulkaisuvuosi.Name = "textBoxJulkaisuvuosi";
            textBoxJulkaisuvuosi.Size = new Size(150, 31);
            textBoxJulkaisuvuosi.TabIndex = 6;
            textBoxJulkaisuvuosi.Click += textBoxJulkaisuvuosi_Click;
            textBoxJulkaisuvuosi.Leave += textBoxJulkaisuvuosi_Leave;
            // 
            // textBoxNimi
            // 
            textBoxNimi.Location = new Point(152, 75);
            textBoxNimi.Name = "textBoxNimi";
            textBoxNimi.Size = new Size(231, 31);
            textBoxNimi.TabIndex = 5;
            textBoxNimi.Click += textBoxNimi_Click;
            textBoxNimi.Leave += textBoxNimi_Leave;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(152, 36);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(150, 31);
            textBoxID.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 157);
            label4.Name = "label4";
            label4.Size = new Size(105, 25);
            label4.TabIndex = 3;
            label4.Text = "Kesto (min):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 120);
            label3.Name = "label3";
            label3.Size = new Size(118, 25);
            label3.TabIndex = 2;
            label3.Text = "Julkaisuvuosi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 81);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 1;
            label2.Text = "Nimi:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 42);
            label1.Name = "label1";
            label1.Size = new Size(34, 25);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonPoista);
            groupBox2.Controls.Add(buttonTallenna);
            groupBox2.Controls.Add(buttonUusiTietue);
            groupBox2.Location = new Point(509, 47);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(389, 630);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Toiminnallisuus";
            // 
            // buttonPoista
            // 
            buttonPoista.BackColor = Color.Red;
            buttonPoista.FlatStyle = FlatStyle.Popup;
            buttonPoista.ForeColor = SystemColors.WindowText;
            buttonPoista.Location = new Point(34, 194);
            buttonPoista.Name = "buttonPoista";
            buttonPoista.Size = new Size(329, 58);
            buttonPoista.TabIndex = 12;
            buttonPoista.Text = "Poista";
            buttonPoista.UseVisualStyleBackColor = false;
            // 
            // buttonTallenna
            // 
            buttonTallenna.BackColor = Color.FromArgb(128, 255, 128);
            buttonTallenna.FlatStyle = FlatStyle.Popup;
            buttonTallenna.ForeColor = SystemColors.WindowText;
            buttonTallenna.Location = new Point(34, 120);
            buttonTallenna.Name = "buttonTallenna";
            buttonTallenna.Size = new Size(329, 58);
            buttonTallenna.TabIndex = 11;
            buttonTallenna.Text = "Tallenna";
            buttonTallenna.UseVisualStyleBackColor = false;
            buttonTallenna.Click += buttonTallenna_Click;
            // 
            // buttonUusiTietue
            // 
            buttonUusiTietue.BackColor = SystemColors.Window;
            buttonUusiTietue.FlatStyle = FlatStyle.System;
            buttonUusiTietue.Location = new Point(34, 48);
            buttonUusiTietue.Name = "buttonUusiTietue";
            buttonUusiTietue.Size = new Size(329, 58);
            buttonUusiTietue.TabIndex = 10;
            buttonUusiTietue.Text = "Uusi tietue";
            buttonUusiTietue.UseVisualStyleBackColor = false;
            buttonUusiTietue.Click += buttonUusiTietue_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(numericUpDown2);
            groupBox3.Controls.Add(labelArvosana);
            groupBox3.Controls.Add(numericUpDown1);
            groupBox3.Controls.Add(richTextBoxArvio);
            groupBox3.Location = new Point(22, 360);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(470, 317);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Arvio";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(224, 262);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(78, 31);
            numericUpDown2.TabIndex = 3;
            // 
            // labelArvosana
            // 
            labelArvosana.AutoSize = true;
            labelArvosana.Location = new Point(20, 268);
            labelArvosana.Name = "labelArvosana";
            labelArvosana.Size = new Size(90, 25);
            labelArvosana.TabIndex = 2;
            labelArvosana.Text = "Arvosana:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(129, 262);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(78, 31);
            numericUpDown1.TabIndex = 1;
            // 
            // richTextBoxArvio
            // 
            richTextBoxArvio.Location = new Point(20, 30);
            richTextBoxArvio.Name = "richTextBoxArvio";
            richTextBoxArvio.Size = new Size(427, 215);
            richTextBoxArvio.TabIndex = 0;
            richTextBoxArvio.Text = "";
            richTextBoxArvio.Click += richTextBoxArvio_Click;
            richTextBoxArvio.Leave += richTextBoxArvio_Leave;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(924, 705);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Name = "FormMain";
            Text = "Elokuvasovellus";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tiedostoToolStripMenuItem;
        private ToolStripMenuItem poistuToolStripMenuItem;
        private ToolStripMenuItem tietojaToolStripMenuItem;
        private ToolStripMenuItem testaaTietokantayhteyttäToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textBoxID;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxKesto;
        private TextBox textBoxJulkaisuvuosi;
        private TextBox textBoxNimi;
        private Button buttonSeuraava;
        private Button buttonEdellinen;
        private Button buttonUusiTietue;
        private Button buttonTallenna;
        private Button buttonPoista;
        private RichTextBox richTextBoxArvio;
        private NumericUpDown numericUpDown2;
        private Label labelArvosana;
        private NumericUpDown numericUpDown1;
    }
}
