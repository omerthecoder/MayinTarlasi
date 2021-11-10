namespace MayinTarlasi
{
    partial class Form1
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
            this.flpMayinAlani = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnYeniOyun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpMayinAlani
            // 
            this.flpMayinAlani.Location = new System.Drawing.Point(0, 0);
            this.flpMayinAlani.Name = "flpMayinAlani";
            this.flpMayinAlani.Size = new System.Drawing.Size(260, 260);
            this.flpMayinAlani.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Skor:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(316, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 16);
            this.lblScore.TabIndex = 1;
            // 
            // btnYeniOyun
            // 
            this.btnYeniOyun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYeniOyun.Location = new System.Drawing.Point(269, 36);
            this.btnYeniOyun.Name = "btnYeniOyun";
            this.btnYeniOyun.Size = new System.Drawing.Size(103, 38);
            this.btnYeniOyun.TabIndex = 2;
            this.btnYeniOyun.Text = "Yeni Oyun";
            this.btnYeniOyun.UseVisualStyleBackColor = true;
            this.btnYeniOyun.Click += new System.EventHandler(this.btnYeniOyun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 260);
            this.Controls.Add(this.btnYeniOyun);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpMayinAlani);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mayın Tarlası";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMayinAlani;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnYeniOyun;
    }
}

