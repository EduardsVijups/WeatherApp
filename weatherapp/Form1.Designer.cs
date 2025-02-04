namespace weatherapp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tMax = new TextBox();
            tMin = new TextBox();
            wSpd = new TextBox();
            mitr = new TextBox();
            city = new TextBox();
            press = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            showButtn = new Button();
            label5 = new Label();
            mnF = new TextBox();
            pictureIcon = new PictureBox();
            apraksts = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureIcon).BeginInit();
            SuspendLayout();
            // 
            // tMax
            // 
            tMax.Location = new Point(179, 60);
            tMax.Name = "tMax";
            tMax.Size = new Size(100, 23);
            tMax.TabIndex = 0;
            // 
            // tMin
            // 
            tMin.Location = new Point(179, 89);
            tMin.Name = "tMin";
            tMin.Size = new Size(100, 23);
            tMin.TabIndex = 1;
            // 
            // wSpd
            // 
            wSpd.Location = new Point(179, 147);
            wSpd.Name = "wSpd";
            wSpd.Size = new Size(100, 23);
            wSpd.TabIndex = 3;
            // 
            // mitr
            // 
            mitr.Location = new Point(179, 118);
            mitr.Name = "mitr";
            mitr.Size = new Size(100, 23);
            mitr.TabIndex = 2;
            // 
            // city
            // 
            city.Location = new Point(496, 60);
            city.Name = "city";
            city.Size = new Size(100, 23);
            city.TabIndex = 5;
            // 
            // press
            // 
            press.Location = new Point(179, 176);
            press.Name = "press";
            press.Size = new Size(100, 23);
            press.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 63);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 8;
            label1.Text = "temp MAX";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 92);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 9;
            label2.Text = "temp MIN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 150);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 11;
            label3.Text = "veja atrums";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 121);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 10;
            label4.Text = "mitrums";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(407, 63);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 13;
            label7.Text = "pilseta";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(90, 179);
            label8.Name = "label8";
            label8.Size = new Size(56, 15);
            label8.TabIndex = 12;
            label8.Text = "spiediens";
            // 
            // showButtn
            // 
            showButtn.Location = new Point(407, 92);
            showButtn.Name = "showButtn";
            showButtn.Size = new Size(189, 23);
            showButtn.TabIndex = 14;
            showButtn.Text = "radit";
            showButtn.UseVisualStyleBackColor = true;
            showButtn.Click += showButtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(90, 208);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 16;
            label5.Text = "meness faze";
            // 
            // mnF
            // 
            mnF.Location = new Point(179, 205);
            mnF.Name = "mnF";
            mnF.Size = new Size(100, 23);
            mnF.TabIndex = 15;
            // 
            // pictureIcon
            // 
            pictureIcon.BackColor = Color.White;
            pictureIcon.Image = (Image)resources.GetObject("pictureIcon.Image");
            pictureIcon.Location = new Point(407, 134);
            pictureIcon.Name = "pictureIcon";
            pictureIcon.Size = new Size(128, 128);
            pictureIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureIcon.TabIndex = 17;
            pictureIcon.TabStop = false;
            // 
            // apraksts
            // 
            apraksts.Font = new Font("Segoe UI", 13F);
            apraksts.Location = new Point(83, 248);
            apraksts.Name = "apraksts";
            apraksts.Size = new Size(196, 90);
            apraksts.TabIndex = 18;
            apraksts.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(840, 417);
            Controls.Add(apraksts);
            Controls.Add(pictureIcon);
            Controls.Add(label5);
            Controls.Add(mnF);
            Controls.Add(showButtn);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(city);
            Controls.Add(press);
            Controls.Add(wSpd);
            Controls.Add(mitr);
            Controls.Add(tMin);
            Controls.Add(tMax);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Laika Ziņas";
            ((System.ComponentModel.ISupportInitialize)pictureIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tMax;
        private TextBox tMin;
        private TextBox wSpd;
        private TextBox mitr;
        private TextBox city;
        private TextBox press;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label7;
        private Label label8;
        private Button showButtn;
        private Label label5;
        private TextBox mnF;
        private PictureBox pictureIcon;
        private RichTextBox apraksts;
    }
}
