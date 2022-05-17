
namespace SınavModuluProje
{
    partial class OgrenciMenu
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
            this.btnSinavModul = new System.Windows.Forms.Button();
            this.btnProfil = new System.Windows.Forms.Button();
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSinavModul
            // 
            this.btnSinavModul.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSinavModul.Location = new System.Drawing.Point(12, 12);
            this.btnSinavModul.Name = "btnSinavModul";
            this.btnSinavModul.Size = new System.Drawing.Size(433, 126);
            this.btnSinavModul.TabIndex = 0;
            this.btnSinavModul.Text = "Sinav Modülü";
            this.btnSinavModul.UseVisualStyleBackColor = true;
            this.btnSinavModul.Click += new System.EventHandler(this.btnSinavModul_Click);
            // 
            // btnProfil
            // 
            this.btnProfil.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProfil.Location = new System.Drawing.Point(12, 158);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(433, 126);
            this.btnProfil.TabIndex = 1;
            this.btnProfil.Text = "Profil";
            this.btnProfil.UseVisualStyleBackColor = true;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // btnRapor
            // 
            this.btnRapor.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRapor.Location = new System.Drawing.Point(12, 304);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(433, 126);
            this.btnRapor.TabIndex = 2;
            this.btnRapor.Text = "Analiz Sonuçları";
            this.btnRapor.UseVisualStyleBackColor = true;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGeri.Location = new System.Drawing.Point(166, 436);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(94, 44);
            this.btnGeri.TabIndex = 3;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // OgrenciMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 492);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnRapor);
            this.Controls.Add(this.btnProfil);
            this.Controls.Add(this.btnSinavModul);
            this.Name = "OgrenciMenu";
            this.Text = "OgrenciMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSinavModul;
        private System.Windows.Forms.Button btnProfil;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.Button btnGeri;
    }
}