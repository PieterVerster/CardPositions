namespace CardPositions
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
            this.liBxCards = new System.Windows.Forms.ListBox();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.liBxShuffle1 = new System.Windows.Forms.ListBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // liBxCards
            // 
            this.liBxCards.FormattingEnabled = true;
            this.liBxCards.Location = new System.Drawing.Point(12, 12);
            this.liBxCards.Name = "liBxCards";
            this.liBxCards.Size = new System.Drawing.Size(155, 693);
            this.liBxCards.TabIndex = 0;
            // 
            // btnShuffle
            // 
            this.btnShuffle.Location = new System.Drawing.Point(177, 725);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(155, 38);
            this.btnShuffle.TabIndex = 1;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // liBxShuffle1
            // 
            this.liBxShuffle1.FormattingEnabled = true;
            this.liBxShuffle1.Location = new System.Drawing.Point(177, 12);
            this.liBxShuffle1.Name = "liBxShuffle1";
            this.liBxShuffle1.Size = new System.Drawing.Size(155, 693);
            this.liBxShuffle1.TabIndex = 2;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(12, 725);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(155, 38);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 775);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.liBxShuffle1);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.liBxCards);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox liBxCards;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.ListBox liBxShuffle1;
        private System.Windows.Forms.Button btnShow;
    }
}

