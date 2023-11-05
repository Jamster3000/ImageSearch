namespace DNDImageSearch
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.backButton = new System.Windows.Forms.Button();
            this.largePreviewBox = new System.Windows.Forms.PictureBox();
            this.downloadButton = new System.Windows.Forms.Button();
            this.imagePathLabel = new System.Windows.Forms.Label();
            this.keywordsLabel = new System.Windows.Forms.Label();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.successLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.largePreviewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(2, 1);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 59);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "◄";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // largePreviewBox
            // 
            this.largePreviewBox.Location = new System.Drawing.Point(22, 66);
            this.largePreviewBox.Name = "largePreviewBox";
            this.largePreviewBox.Size = new System.Drawing.Size(494, 372);
            this.largePreviewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.largePreviewBox.TabIndex = 13;
            this.largePreviewBox.TabStop = false;
            // 
            // downloadButton
            // 
            this.downloadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.downloadButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.downloadButton.FlatAppearance.BorderSize = 2;
            this.downloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadButton.ForeColor = System.Drawing.Color.White;
            this.downloadButton.Location = new System.Drawing.Point(536, 383);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(252, 55);
            this.downloadButton.TabIndex = 2;
            this.downloadButton.Text = "Download";
            this.downloadButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.downloadButton.UseVisualStyleBackColor = false;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            this.downloadButton.MouseEnter += new System.EventHandler(this.downloadButton_MouseEnter);
            this.downloadButton.MouseLeave += new System.EventHandler(this.downloadButton_MouseLeave);
            // 
            // imagePathLabel
            // 
            this.imagePathLabel.AutoSize = true;
            this.imagePathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagePathLabel.ForeColor = System.Drawing.Color.White;
            this.imagePathLabel.Location = new System.Drawing.Point(518, 67);
            this.imagePathLabel.MaximumSize = new System.Drawing.Size(280, 0);
            this.imagePathLabel.Name = "imagePathLabel";
            this.imagePathLabel.Size = new System.Drawing.Size(94, 25);
            this.imagePathLabel.TabIndex = 15;
            this.imagePathLabel.Text = "File Path:";
            // 
            // keywordsLabel
            // 
            this.keywordsLabel.AutoSize = true;
            this.keywordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keywordsLabel.ForeColor = System.Drawing.Color.White;
            this.keywordsLabel.Location = new System.Drawing.Point(518, 212);
            this.keywordsLabel.MaximumSize = new System.Drawing.Size(280, 0);
            this.keywordsLabel.Name = "keywordsLabel";
            this.keywordsLabel.Size = new System.Drawing.Size(110, 25);
            this.keywordsLabel.TabIndex = 16;
            this.keywordsLabel.Text = "Keywords: ";
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeLabel.ForeColor = System.Drawing.Color.White;
            this.sizeLabel.Location = new System.Drawing.Point(518, 328);
            this.sizeLabel.MaximumSize = new System.Drawing.Size(280, 0);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(62, 25);
            this.sizeLabel.TabIndex = 17;
            this.sizeLabel.Text = "Size: ";
            // 
            // successLabel
            // 
            this.successLabel.AutoSize = true;
            this.successLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.successLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.successLabel.Location = new System.Drawing.Point(329, 9);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(0, 32);
            this.successLabel.TabIndex = 18;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.successLabel);
            this.Controls.Add(this.sizeLabel);
            this.Controls.Add(this.keywordsLabel);
            this.Controls.Add(this.imagePathLabel);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.largePreviewBox);
            this.Controls.Add(this.backButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.largePreviewBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.PictureBox largePreviewBox;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Label imagePathLabel;
        private System.Windows.Forms.Label keywordsLabel;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label successLabel;
    }
}