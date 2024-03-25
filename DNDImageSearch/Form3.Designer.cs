namespace imageSearch
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.noImagesLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.downloadedLabel = new System.Windows.Forms.Label();
            this.slideshowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // noImagesLabel
            // 
            this.noImagesLabel.AutoSize = true;
            this.noImagesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noImagesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.noImagesLabel.Location = new System.Drawing.Point(200, 190);
            this.noImagesLabel.Name = "noImagesLabel";
            this.noImagesLabel.Size = new System.Drawing.Size(399, 36);
            this.noImagesLabel.TabIndex = 0;
            this.noImagesLabel.Text = "No Images Matching Query";
            this.noImagesLabel.Visible = false;
            // 
            // backButton
            // 
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(0, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 59);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "◄";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // downloadedLabel
            // 
            this.downloadedLabel.AutoSize = true;
            this.downloadedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadedLabel.ForeColor = System.Drawing.Color.White;
            this.downloadedLabel.Location = new System.Drawing.Point(202, 9);
            this.downloadedLabel.Name = "downloadedLabel";
            this.downloadedLabel.Size = new System.Drawing.Size(391, 38);
            this.downloadedLabel.TabIndex = 12;
            this.downloadedLabel.Text = "Successfully Downloaded";
            this.downloadedLabel.Visible = false;
            // 
            // slideshowButton
            // 
            this.slideshowButton.FlatAppearance.BorderSize = 0;
            this.slideshowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slideshowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slideshowButton.ForeColor = System.Drawing.Color.White;
            this.slideshowButton.Location = new System.Drawing.Point(836, 9);
            this.slideshowButton.Name = "slideshowButton";
            this.slideshowButton.Size = new System.Drawing.Size(75, 59);
            this.slideshowButton.TabIndex = 13;
            this.slideshowButton.Text = "🎬";
            this.slideshowButton.UseVisualStyleBackColor = true;
            this.slideshowButton.Click += new System.EventHandler(this.slideshowButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(923, 450);
            this.Controls.Add(this.slideshowButton);
            this.Controls.Add(this.downloadedLabel);
            this.Controls.Add(this.noImagesLabel);
            this.Controls.Add(this.backButton);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Image Results";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Form3_Scroll);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label noImagesLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label downloadedLabel;
        private System.Windows.Forms.Button slideshowButton;
    }
}