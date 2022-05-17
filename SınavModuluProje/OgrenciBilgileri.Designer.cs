
namespace SınavModuluProje
{
    partial class OgrenciBilgileri
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
            this.dgwOgrenci = new System.Windows.Forms.DataGridView();
            this.btnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgrenci)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwOgrenci
            // 
            this.dgwOgrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwOgrenci.Location = new System.Drawing.Point(12, 21);
            this.dgwOgrenci.Name = "dgwOgrenci";
            this.dgwOgrenci.RowHeadersWidth = 51;
            this.dgwOgrenci.RowTemplate.Height = 29;
            this.dgwOgrenci.Size = new System.Drawing.Size(776, 346);
            this.dgwOgrenci.TabIndex = 0;
            this.dgwOgrenci.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwOgrenci_CellClick);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(676, 387);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(96, 51);
            this.btnGeri.TabIndex = 1;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // OgrenciBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.dgwOgrenci);
            this.Name = "OgrenciBilgileri";
            this.Text = "OgrenciBilgileri";
            this.Load += new System.EventHandler(this.OgrenciBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwOgrenci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwOgrenci;
        private System.Windows.Forms.Button btnGeri;
    }
}