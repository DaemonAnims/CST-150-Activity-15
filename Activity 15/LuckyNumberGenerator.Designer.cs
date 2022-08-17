namespace Activity_15
{
    partial class LuckyNumberGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LuckyNumberGenerator));
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.vacationLabel = new System.Windows.Forms.Label();
            this.countryCombo = new System.Windows.Forms.ComboBox();
            this.countryLabel = new System.Windows.Forms.Label();
            this.luckyNumButton = new System.Windows.Forms.Button();
            this.cityCombo = new System.Windows.Forms.ComboBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorLabel = new System.Windows.Forms.Label();
            this.colorButton = new System.Windows.Forms.Button();
            this.titlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("titlePanel.BackgroundImage")));
            this.titlePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titlePanel.Location = new System.Drawing.Point(-3, -12);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(413, 219);
            this.titlePanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(3, 33);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(407, 36);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "What\'s Your Lucky Number?";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // vacationLabel
            // 
            this.vacationLabel.AutoSize = true;
            this.vacationLabel.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vacationLabel.Location = new System.Drawing.Point(0, 233);
            this.vacationLabel.Name = "vacationLabel";
            this.vacationLabel.Size = new System.Drawing.Size(212, 15);
            this.vacationLabel.TabIndex = 1;
            this.vacationLabel.Text = "Where would your perfect vacation be?";
            // 
            // countryCombo
            // 
            this.countryCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryCombo.FormattingEnabled = true;
            this.countryCombo.Location = new System.Drawing.Point(12, 266);
            this.countryCombo.Name = "countryCombo";
            this.countryCombo.Size = new System.Drawing.Size(173, 23);
            this.countryCombo.Sorted = true;
            this.countryCombo.TabIndex = 2;
            this.countryCombo.SelectedIndexChanged += new System.EventHandler(this.countryCombo_SelectedIndexChanged);
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countryLabel.Location = new System.Drawing.Point(12, 248);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(93, 15);
            this.countryLabel.TabIndex = 3;
            this.countryLabel.Text = "Choose a Country:";
            // 
            // luckyNumButton
            // 
            this.luckyNumButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.luckyNumButton.Location = new System.Drawing.Point(0, 384);
            this.luckyNumButton.Name = "luckyNumButton";
            this.luckyNumButton.Size = new System.Drawing.Size(407, 39);
            this.luckyNumButton.TabIndex = 4;
            this.luckyNumButton.Text = "Get Your Lucky Number!";
            this.luckyNumButton.UseVisualStyleBackColor = true;
            this.luckyNumButton.Click += new System.EventHandler(this.luckyNumButton_Click);
            // 
            // cityCombo
            // 
            this.cityCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityCombo.FormattingEnabled = true;
            this.cityCombo.Location = new System.Drawing.Point(12, 310);
            this.cityCombo.Name = "cityCombo";
            this.cityCombo.Size = new System.Drawing.Size(173, 23);
            this.cityCombo.Sorted = true;
            this.cityCombo.TabIndex = 5;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cityLabel.Location = new System.Drawing.Point(12, 292);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(75, 15);
            this.cityLabel.TabIndex = 6;
            this.cityLabel.Text = "Choose a City:";
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.colorLabel.Location = new System.Drawing.Point(251, 274);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(144, 15);
            this.colorLabel.TabIndex = 7;
            this.colorLabel.Text = "Choose Your Favorite Color:";
            // 
            // colorButton
            // 
            this.colorButton.BackColor = System.Drawing.Color.Black;
            this.colorButton.Location = new System.Drawing.Point(301, 292);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(33, 28);
            this.colorButton.TabIndex = 8;
            this.colorButton.UseVisualStyleBackColor = false;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // LuckyNumberGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(407, 423);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.cityCombo);
            this.Controls.Add(this.luckyNumButton);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.countryCombo);
            this.Controls.Add(this.vacationLabel);
            this.Controls.Add(this.titlePanel);
            this.Name = "LuckyNumberGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lucky Number Generator";
            this.Load += new System.EventHandler(this.LuckyNumberGenerator_Load);
            this.titlePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel titlePanel;
        private Label titleLabel;
        private Label vacationLabel;
        private ComboBox countryCombo;
        private Label countryLabel;
        private Button luckyNumButton;
        private ComboBox cityCombo;
        private Label cityLabel;
        private ColorDialog colorDialog1;
        private Label colorLabel;
        private Button colorButton;
    }
}