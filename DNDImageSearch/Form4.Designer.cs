﻿namespace DNDImageSearch
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
            ((System.ComponentModel.ISupportInitialize)(this.largePreviewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.backButton.Location = new System.Drawing.Point(2, 1);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 59);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "◄";
            this.backButton.UseVisualStyleBackColor = true;
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
            this.downloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.downloadButton.Location = new System.Drawing.Point(536, 392);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(252, 46);
            this.downloadButton.TabIndex = 14;
            this.downloadButton.Text = "Download";
            this.downloadButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.downloadButton.UseVisualStyleBackColor = true;
            // 
            // imagePathLabel
            // 
            this.imagePathLabel.AutoSize = true;
            this.imagePathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagePathLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
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
            this.keywordsLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
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
            this.sizeLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.sizeLabel.Location = new System.Drawing.Point(518, 328);
            this.sizeLabel.MaximumSize = new System.Drawing.Size(280, 0);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(62, 25);
            this.sizeLabel.TabIndex = 17;
            this.sizeLabel.Text = "Size: ";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}