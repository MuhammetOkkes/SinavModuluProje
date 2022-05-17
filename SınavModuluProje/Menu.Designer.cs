
namespace SınavModuluProje
{
    partial class Menu
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
            this.btnOgrenciGiris = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnSinavSorum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOgrenciGiris
            // 
            this.btnOgrenciGiris.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOgrenciGiris.Location = new System.Drawing.Point(12, 27);
            this.btnOgrenciGiris.Name = "btnOgrenciGiris";
            this.btnOgrenciGiris.Size = new System.Drawing.Size(431, 118);
            this.btnOgrenciGiris.TabIndex = 0;
            this.btnOgrenciGiris.Text = "Öğrenci Giriş";
            this.btnOgrenciGiris.UseVisualStyleBackColor = true;
            this.btnOgrenciGiris.Click += new System.EventHandler(this.btnOgrenciGiris_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdmin.Location = new System.Drawing.Point(12, 189);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(431, 118);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "Admin Giriş";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnSinavSorum
            // 
            this.btnSinavSorum.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSinavSorum.Location = new System.Drawing.Point(12, 350);
            this.btnSinavSorum.Name = "btnSinavSorum";
            this.btnSinavSorum.Size = new System.Drawing.Size(431, 118);
            this.btnSinavSorum.TabIndex = 2;
            this.btnSinavSorum.Text = "Sınav Sorumlusu Giriş";
            this.btnSinavSorum.UseVisualStyleBackColor = true;
            this.btnSinavSorum.Click += new System.EventHandler(this.btnSinavSorum_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 497);
            this.Controls.Add(this.btnSinavSorum);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnOgrenciGiris);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOgrenciGiris;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnSinavSorum;
    }
}