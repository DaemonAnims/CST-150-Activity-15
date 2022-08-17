namespace Activity_15
{
    partial class LuckyNumberDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LuckyNumberDisplay));
            this.titleLabel = new System.Windows.Forms.Label();
            this.luckyNumLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.titleLabel.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(403, 39);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Your Lucky Number is:";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // luckyNumLabel
            // 
            this.luckyNumLabel.BackColor = System.Drawing.Color.Transparent;
            this.luckyNumLabel.Font = new System.Drawing.Font("Jokerman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.luckyNumLabel.ForeColor = System.Drawing.Color.White;
            this.luckyNumLabel.Image = ((System.Drawing.Image)(resources.GetObject("luckyNumLabel.Image")));
            this.luckyNumLabel.Location = new System.Drawing.Point(12, 66);
            this.luckyNumLabel.Name = "luckyNumLabel";
            this.luckyNumLabel.Size = new System.Drawing.Size(403, 320);
            this.luckyNumLabel.TabIndex = 1;
            this.luckyNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LuckyNumberDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(427, 427);
            this.Controls.Add(this.luckyNumLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "LuckyNumberDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Your Lucky Number!";
            this.ResumeLayout(false);

        }

        #endregion

        private Label titleLabel;
        public Label luckyNumLabel;
    }
}