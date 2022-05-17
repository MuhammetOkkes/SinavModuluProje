
namespace SınavModuluProje
{
    partial class SinavModuluForm
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
            this.components = new System.ComponentModel.Container();
            this.SecenekB = new System.Windows.Forms.Button();
            this.rtbxB = new System.Windows.Forms.RichTextBox();
            this.rtbxC = new System.Windows.Forms.RichTextBox();
            this.SecenekC = new System.Windows.Forms.Button();
            this.SecenekA = new System.Windows.Forms.Button();
            this.rtbxSoru = new System.Windows.Forms.RichTextBox();
            this.label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.rtbxA = new System.Windows.Forms.RichTextBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SecenekB
            // 
            this.SecenekB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SecenekB.Location = new System.Drawing.Point(12, 442);
            this.SecenekB.Name = "SecenekB";
            this.SecenekB.Size = new System.Drawing.Size(56, 51);
            this.SecenekB.TabIndex = 1;
            this.SecenekB.Text = "B";
            this.SecenekB.UseVisualStyleBackColor = true;
            this.SecenekB.Click += new System.EventHandler(this.SecenekB_Click);
            // 
            // rtbxB
            // 
            this.rtbxB.Location = new System.Drawing.Point(74, 421);
            this.rtbxB.Name = "rtbxB";
            this.rtbxB.ReadOnly = true;
            this.rtbxB.Size = new System.Drawing.Size(377, 98);
            this.rtbxB.TabIndex = 7;
            this.rtbxB.Text = "DEFAULT";
            // 
            // rtbxC
            // 
            this.rtbxC.Location = new System.Drawing.Point(543, 421);
            this.rtbxC.Name = "rtbxC";
            this.rtbxC.ReadOnly = true;
            this.rtbxC.Size = new System.Drawing.Size(377, 98);
            this.rtbxC.TabIndex = 9;
            this.rtbxC.Text = "DEFAULT";
            // 
            // SecenekC
            // 
            this.SecenekC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SecenekC.Location = new System.Drawing.Point(481, 442);
            this.SecenekC.Name = "SecenekC";
            this.SecenekC.Size = new System.Drawing.Size(56, 51);
            this.SecenekC.TabIndex = 8;
            this.SecenekC.Text = "C";
            this.SecenekC.UseVisualStyleBackColor = true;
            this.SecenekC.Click += new System.EventHandler(this.SecenekC_Click);
            // 
            // SecenekA
            // 
            this.SecenekA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SecenekA.Location = new System.Drawing.Point(281, 338);
            this.SecenekA.Name = "SecenekA";
            this.SecenekA.Size = new System.Drawing.Size(56, 51);
            this.SecenekA.TabIndex = 10;
            this.SecenekA.Text = "A";
            this.SecenekA.UseVisualStyleBackColor = true;
            this.SecenekA.Click += new System.EventHandler(this.SecenekA_Click);
            // 
            // rtbxSoru
            // 
            this.rtbxSoru.Location = new System.Drawing.Point(136, 35);
            this.rtbxSoru.Name = "rtbxSoru";
            this.rtbxSoru.ReadOnly = true;
            this.rtbxSoru.Size = new System.Drawing.Size(784, 247);
            this.rtbxSoru.TabIndex = 12;
            this.rtbxSoru.Text = "DEFAULT";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(12, 162);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(118, 28);
            this.label.TabIndex = 13;
            this.label.Text = "Kalan Süre:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimer.Location = new System.Drawing.Point(21, 232);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(100, 23);
            this.lblTimer.TabIndex = 14;
            this.lblTimer.Text = "Kalan Süre:";
            // 
            // rtbxA
            // 
            this.rtbxA.Location = new System.Drawing.Point(343, 317);
            this.rtbxA.Name = "rtbxA";
            this.rtbxA.ReadOnly = true;
            this.rtbxA.Size = new System.Drawing.Size(377, 98);
            this.rtbxA.TabIndex = 11;
            this.rtbxA.Text = "DEFAULT";
            // 
            // btnGeri
            // 
            this.btnGeri.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGeri.Location = new System.Drawing.Point(21, 35);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(76, 39);
            this.btnGeri.TabIndex = 15;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // SinavModuluForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 544);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.label);
            this.Controls.Add(this.rtbxSoru);
            this.Controls.Add(this.rtbxA);
            this.Controls.Add(this.SecenekA);
            this.Controls.Add(this.rtbxC);
            this.Controls.Add(this.SecenekC);
            this.Controls.Add(this.rtbxB);
            this.Controls.Add(this.SecenekB);
            this.Name = "SinavModuluForm";
            this.Text = "SinavModuluForm";
            this.Load += new System.EventHandler(this.SinavModuluForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SecenekB;
        private System.Windows.Forms.RichTextBox rtbxB;
        private System.Windows.Forms.RichTextBox rtbxC;
        private System.Windows.Forms.Button SecenekC;
        private System.Windows.Forms.Button SecenekA;
        private System.Windows.Forms.RichTextBox rtbxSoru;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.RichTextBox rtbxA;
        private System.Windows.Forms.Button btnGeri;
    }
}