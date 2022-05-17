
namespace SınavModuluProje
{
    partial class SinavEksikModul
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
            this.rtbxSoru = new System.Windows.Forms.RichTextBox();
            this.rtbxA = new System.Windows.Forms.RichTextBox();
            this.SecenekA = new System.Windows.Forms.Button();
            this.rtbxC = new System.Windows.Forms.RichTextBox();
            this.SecenekC = new System.Windows.Forms.Button();
            this.rtbxB = new System.Windows.Forms.RichTextBox();
            this.SecenekB = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbxSoru
            // 
            this.rtbxSoru.Location = new System.Drawing.Point(78, 76);
            this.rtbxSoru.Name = "rtbxSoru";
            this.rtbxSoru.ReadOnly = true;
            this.rtbxSoru.Size = new System.Drawing.Size(784, 247);
            this.rtbxSoru.TabIndex = 21;
            this.rtbxSoru.Text = "DEFAULT";
            // 
            // rtbxA
            // 
            this.rtbxA.Location = new System.Drawing.Point(338, 341);
            this.rtbxA.Name = "rtbxA";
            this.rtbxA.ReadOnly = true;
            this.rtbxA.Size = new System.Drawing.Size(377, 98);
            this.rtbxA.TabIndex = 20;
            this.rtbxA.Text = "DEFAULT";
            // 
            // SecenekA
            // 
            this.SecenekA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SecenekA.Location = new System.Drawing.Point(276, 362);
            this.SecenekA.Name = "SecenekA";
            this.SecenekA.Size = new System.Drawing.Size(56, 51);
            this.SecenekA.TabIndex = 19;
            this.SecenekA.Text = "A";
            this.SecenekA.UseVisualStyleBackColor = true;
            this.SecenekA.Click += new System.EventHandler(this.SecenekA_Click);
            // 
            // rtbxC
            // 
            this.rtbxC.Location = new System.Drawing.Point(538, 445);
            this.rtbxC.Name = "rtbxC";
            this.rtbxC.ReadOnly = true;
            this.rtbxC.Size = new System.Drawing.Size(377, 98);
            this.rtbxC.TabIndex = 18;
            this.rtbxC.Text = "DEFAULT";
            // 
            // SecenekC
            // 
            this.SecenekC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SecenekC.Location = new System.Drawing.Point(476, 466);
            this.SecenekC.Name = "SecenekC";
            this.SecenekC.Size = new System.Drawing.Size(56, 51);
            this.SecenekC.TabIndex = 17;
            this.SecenekC.Text = "C";
            this.SecenekC.UseVisualStyleBackColor = true;
            this.SecenekC.Click += new System.EventHandler(this.SecenekC_Click);
            // 
            // rtbxB
            // 
            this.rtbxB.Location = new System.Drawing.Point(69, 445);
            this.rtbxB.Name = "rtbxB";
            this.rtbxB.ReadOnly = true;
            this.rtbxB.Size = new System.Drawing.Size(377, 98);
            this.rtbxB.TabIndex = 16;
            this.rtbxB.Text = "DEFAULT";
            // 
            // SecenekB
            // 
            this.SecenekB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SecenekB.Location = new System.Drawing.Point(7, 466);
            this.SecenekB.Name = "SecenekB";
            this.SecenekB.Size = new System.Drawing.Size(56, 51);
            this.SecenekB.TabIndex = 15;
            this.SecenekB.Text = "B";
            this.SecenekB.UseVisualStyleBackColor = true;
            this.SecenekB.Click += new System.EventHandler(this.SecenekB_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(12, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(99, 37);
            this.btnGeri.TabIndex = 22;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // SinavEksikModul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 554);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.rtbxSoru);
            this.Controls.Add(this.rtbxA);
            this.Controls.Add(this.SecenekA);
            this.Controls.Add(this.rtbxC);
            this.Controls.Add(this.SecenekC);
            this.Controls.Add(this.rtbxB);
            this.Controls.Add(this.SecenekB);
            this.Name = "SinavEksikModul";
            this.Text = "SinavEksikModul";
            this.Load += new System.EventHandler(this.SinavEksikModul_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbxSoru;
        private System.Windows.Forms.RichTextBox rtbxA;
        private System.Windows.Forms.Button SecenekA;
        private System.Windows.Forms.RichTextBox rtbxC;
        private System.Windows.Forms.Button SecenekC;
        private System.Windows.Forms.RichTextBox rtbxB;
        private System.Windows.Forms.Button SecenekB;
        private System.Windows.Forms.Button btnGeri;
    }
}