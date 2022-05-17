
namespace SınavModuluProje
{
    partial class SoruEkleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbxSoruMetni = new System.Windows.Forms.RichTextBox();
            this.rtbxSecenekA = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbxSecenekB = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbxSecenekC = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbxSecenekDogruSık = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxKategori = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(608, 189);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(117, 72);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Ekle";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Soru Metni";
            // 
            // rtbxSoruMetni
            // 
            this.rtbxSoruMetni.Location = new System.Drawing.Point(99, 19);
            this.rtbxSoruMetni.Name = "rtbxSoruMetni";
            this.rtbxSoruMetni.Size = new System.Drawing.Size(445, 80);
            this.rtbxSoruMetni.TabIndex = 3;
            this.rtbxSoruMetni.Text = "";
            // 
            // rtbxSecenekA
            // 
            this.rtbxSecenekA.Location = new System.Drawing.Point(99, 105);
            this.rtbxSecenekA.Name = "rtbxSecenekA";
            this.rtbxSecenekA.Size = new System.Drawing.Size(445, 80);
            this.rtbxSecenekA.TabIndex = 5;
            this.rtbxSecenekA.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "SecenekA:";
            // 
            // rtbxSecenekB
            // 
            this.rtbxSecenekB.Location = new System.Drawing.Point(99, 202);
            this.rtbxSecenekB.Name = "rtbxSecenekB";
            this.rtbxSecenekB.Size = new System.Drawing.Size(445, 80);
            this.rtbxSecenekB.TabIndex = 7;
            this.rtbxSecenekB.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "SecenekB:";
            // 
            // rtbxSecenekC
            // 
            this.rtbxSecenekC.Location = new System.Drawing.Point(99, 299);
            this.rtbxSecenekC.Name = "rtbxSecenekC";
            this.rtbxSecenekC.Size = new System.Drawing.Size(445, 80);
            this.rtbxSecenekC.TabIndex = 9;
            this.rtbxSecenekC.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "SecenekC:";
            // 
            // rtbxSecenekDogruSık
            // 
            this.rtbxSecenekDogruSık.Location = new System.Drawing.Point(99, 423);
            this.rtbxSecenekDogruSık.Name = "rtbxSecenekDogruSık";
            this.rtbxSecenekDogruSık.Size = new System.Drawing.Size(445, 80);
            this.rtbxSecenekDogruSık.TabIndex = 11;
            this.rtbxSecenekDogruSık.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dogru Şık:";
            // 
            // cbxKategori
            // 
            this.cbxKategori.FormattingEnabled = true;
            this.cbxKategori.Items.AddRange(new object[] {
            "Fen",
            "Hayat Bilgisi",
            "Matematik",
            "Türkçe"});
            this.cbxKategori.Location = new System.Drawing.Point(636, 48);
            this.cbxKategori.Name = "cbxKategori";
            this.cbxKategori.Size = new System.Drawing.Size(151, 28);
            this.cbxKategori.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(550, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Kategori:";
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(708, 452);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(95, 51);
            this.btnGeri.TabIndex = 14;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // SoruEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 515);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxKategori);
            this.Controls.Add(this.rtbxSecenekDogruSık);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtbxSecenekC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbxSecenekB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbxSecenekA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbxSoruMetni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKaydet);
            this.Name = "SoruEkleForm";
            this.Text = "SoruEkleForm";
            this.Load += new System.EventHandler(this.SoruEkleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbxSoruMetni;
        private System.Windows.Forms.RichTextBox rtbxSecenekA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbxSecenekB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbxSecenekC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbxSecenekDogruSık;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxKategori;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGeri;
    }
}