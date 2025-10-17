namespace ebob_ekok_bulma
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
            sayi1 = new TextBox();
            sayi2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ebob = new Button();
            ekok = new Button();
            ebobSonuc = new Label();
            ekokSonuc = new Label();
            temizle = new Button();
            SuspendLayout();
            // 
            // sayi1
            // 
            sayi1.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold);
            sayi1.Location = new Point(105, 12);
            sayi1.Multiline = true;
            sayi1.Name = "sayi1";
            sayi1.Size = new Size(306, 62);
            sayi1.TabIndex = 0;
            sayi1.TextAlign = HorizontalAlignment.Center;
            sayi1.TextChanged += sayi1_TextChanged;
            // 
            // sayi2
            // 
            sayi2.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold);
            sayi2.Location = new Point(105, 80);
            sayi2.Multiline = true;
            sayi2.Name = "sayi2";
            sayi2.Size = new Size(306, 62);
            sayi2.TabIndex = 1;
            sayi2.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Separat Bold", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(85, 32);
            label1.TabIndex = 2;
            label1.Text = "Sayı 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Separat Bold", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 89);
            label2.Name = "label2";
            label2.Size = new Size(89, 32);
            label2.TabIndex = 3;
            label2.Text = "Sayı 2:";
            // 
            // ebob
            // 
            ebob.AutoEllipsis = true;
            ebob.BackColor = Color.PaleVioletRed;
            ebob.BackgroundImageLayout = ImageLayout.None;
            ebob.Font = new Font("Lucida Calligraphy", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ebob.ForeColor = Color.Black;
            ebob.Location = new Point(417, 12);
            ebob.Name = "ebob";
            ebob.Size = new Size(124, 63);
            ebob.TabIndex = 4;
            ebob.Text = "EBOB";
            ebob.UseVisualStyleBackColor = false;
            ebob.Click += ebob_Click;
            // 
            // ekok
            // 
            ekok.AutoEllipsis = true;
            ekok.BackColor = Color.PaleVioletRed;
            ekok.Font = new Font("Lucida Calligraphy", 16.2F);
            ekok.Location = new Point(417, 79);
            ekok.Name = "ekok";
            ekok.Size = new Size(124, 63);
            ekok.TabIndex = 5;
            ekok.Text = "EKOK";
            ekok.UseVisualStyleBackColor = false;
            ekok.Click += button2_Click;
            // 
            // ebobSonuc
            // 
            ebobSonuc.BackColor = Color.Turquoise;
            ebobSonuc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ebobSonuc.ImageAlign = ContentAlignment.MiddleRight;
            ebobSonuc.Location = new Point(547, 13);
            ebobSonuc.Name = "ebobSonuc";
            ebobSonuc.Size = new Size(164, 62);
            ebobSonuc.TabIndex = 6;
            ebobSonuc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ekokSonuc
            // 
            ekokSonuc.BackColor = Color.Turquoise;
            ekokSonuc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ekokSonuc.Location = new Point(547, 76);
            ekokSonuc.Name = "ekokSonuc";
            ekokSonuc.Size = new Size(164, 62);
            ekokSonuc.TabIndex = 7;
            ekokSonuc.TextAlign = ContentAlignment.MiddleCenter;
            ekokSonuc.Click += ekokSonuc_Click;
            // 
            // temizle
            // 
            temizle.BackColor = Color.Red;
            temizle.Font = new Font("Segoe UI Black", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            temizle.Location = new Point(717, 11);
            temizle.Name = "temizle";
            temizle.Size = new Size(71, 131);
            temizle.TabIndex = 8;
            temizle.Text = "T\r\nE\r\nM\r\nİ\r\nZ\r\nL\r\nE";
            temizle.UseVisualStyleBackColor = false;
            temizle.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(800, 154);
            Controls.Add(temizle);
            Controls.Add(ekokSonuc);
            Controls.Add(ebobSonuc);
            Controls.Add(ekok);
            Controls.Add(ebob);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(sayi2);
            Controls.Add(sayi1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "EBOB ve EKOK Hesaplama!";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox sayi1;
        private TextBox sayi2;
        private Label label1;
        private Label label2;
        private Button ebob;
        private Button ekok;
        private Label ebobSonuc;
        private Label ekokSonuc;
        private Button temizle;
    }
}
