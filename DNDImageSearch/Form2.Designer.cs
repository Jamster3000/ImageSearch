namespace imageSearch
{
    partial class addDataWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addDataWindow));
            this.addTitle = new System.Windows.Forms.Label();
            this.imagePathLabel = new System.Windows.Forms.Label();
            this.keywordsLabel = new System.Windows.Forms.Label();
            this.imagePathTextBox = new System.Windows.Forms.TextBox();
            this.keywordsTextBox = new System.Windows.Forms.TextBox();
            this.imageDialogeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.discardButton = new System.Windows.Forms.Button();
            this.imageToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.updateLabel = new System.Windows.Forms.Label();
            this.previewBox = new System.Windows.Forms.PictureBox();
            this.previousImageLabel = new System.Windows.Forms.Label();
            this.previousKeywordLabel = new System.Windows.Forms.Label();
            this.underline = new System.Windows.Forms.Label();
            this.imageURLTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // addTitle
            // 
            this.addTitle.AutoSize = true;
            this.addTitle.BackColor = System.Drawing.Color.Transparent;
            this.addTitle.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTitle.ForeColor = System.Drawing.Color.White;
            this.addTitle.Location = new System.Drawing.Point(307, 9);
            this.addTitle.Name = "addTitle";
            this.addTitle.Size = new System.Drawing.Size(157, 80);
            this.addTitle.TabIndex = 1;
            this.addTitle.Text = "Add";
            // 
            // imagePathLabel
            // 
            this.imagePathLabel.AutoSize = true;
            this.imagePathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagePathLabel.ForeColor = System.Drawing.Color.White;
            this.imagePathLabel.Location = new System.Drawing.Point(7, 113);
            this.imagePathLabel.Name = "imagePathLabel";
            this.imagePathLabel.Size = new System.Drawing.Size(176, 36);
            this.imagePathLabel.TabIndex = 4;
            this.imagePathLabel.Text = "Image Path*";
            // 
            // keywordsLabel
            // 
            this.keywordsLabel.AutoSize = true;
            this.keywordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keywordsLabel.ForeColor = System.Drawing.Color.White;
            this.keywordsLabel.Location = new System.Drawing.Point(6, 207);
            this.keywordsLabel.Name = "keywordsLabel";
            this.keywordsLabel.Size = new System.Drawing.Size(175, 38);
            this.keywordsLabel.TabIndex = 5;
            this.keywordsLabel.Text = "Keywords*";
            // 
            // imagePathTextBox
            // 
            this.imagePathTextBox.AllowDrop = true;
            this.imagePathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagePathTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.imagePathTextBox.Location = new System.Drawing.Point(199, 116);
            this.imagePathTextBox.Name = "imagePathTextBox";
            this.imagePathTextBox.Size = new System.Drawing.Size(246, 30);
            this.imagePathTextBox.TabIndex = 3;
            this.imagePathTextBox.TextChanged += new System.EventHandler(this.imagePathTextBox_TextChanged);
            this.imagePathTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.imagePathTextBox_DragDrop);
            this.imagePathTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.imagePathTextBox_DragEnter);
            this.imagePathTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.imagePathTextBox_KeyPress);
            // 
            // keywordsTextBox
            // 
            this.keywordsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keywordsTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.keywordsTextBox.Location = new System.Drawing.Point(199, 215);
            this.keywordsTextBox.Name = "keywordsTextBox";
            this.keywordsTextBox.Size = new System.Drawing.Size(247, 30);
            this.keywordsTextBox.TabIndex = 5;
            this.keywordsTextBox.Enter += new System.EventHandler(this.keywordsTextBox_Enter);
            this.keywordsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keywordsTextBox_KeyPress);
            // 
            // imageDialogeButton
            // 
            this.imageDialogeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.imageDialogeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.imageDialogeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageDialogeButton.Location = new System.Drawing.Point(451, 115);
            this.imageDialogeButton.Name = "imageDialogeButton";
            this.imageDialogeButton.Size = new System.Drawing.Size(22, 34);
            this.imageDialogeButton.TabIndex = 4;
            this.imageDialogeButton.Text = "⋮";
            this.imageDialogeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.imageToolTip.SetToolTip(this.imageDialogeButton, "Open the file picker for you to select your image file.");
            this.imageDialogeButton.UseVisualStyleBackColor = true;
            this.imageDialogeButton.Click += new System.EventHandler(this.imageDialogeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.saveButton.FlatAppearance.BorderSize = 2;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(671, 392);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(117, 46);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            this.saveButton.MouseEnter += new System.EventHandler(this.saveButton_MouseEnter);
            this.saveButton.MouseLeave += new System.EventHandler(this.saveButton_MouseLeave);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(1, -1);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 59);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "◄";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // discardButton
            // 
            this.discardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.discardButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.discardButton.FlatAppearance.BorderSize = 2;
            this.discardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.discardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discardButton.ForeColor = System.Drawing.Color.White;
            this.discardButton.Location = new System.Drawing.Point(12, 392);
            this.discardButton.Name = "discardButton";
            this.discardButton.Size = new System.Drawing.Size(201, 46);
            this.discardButton.TabIndex = 6;
            this.discardButton.Text = "Discard";
            this.discardButton.UseVisualStyleBackColor = false;
            this.discardButton.Click += new System.EventHandler(this.DiscardButton);
            this.discardButton.MouseEnter += new System.EventHandler(this.discardButton_MouseEnter);
            this.discardButton.MouseLeave += new System.EventHandler(this.discardButton_MouseLeave);
            // 
            // imageToolTip
            // 
            this.imageToolTip.AutomaticDelay = 750;
            this.imageToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.imageToolTip.ToolTipTitle = "File Dialog";
            // 
            // updateLabel
            // 
            this.updateLabel.AutoSize = true;
            this.updateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateLabel.ForeColor = System.Drawing.Color.White;
            this.updateLabel.Location = new System.Drawing.Point(231, 397);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(282, 36);
            this.updateLabel.TabIndex = 12;
            this.updateLabel.Text = "Saved Successfully!";
            this.updateLabel.Visible = false;
            // 
            // previewBox
            // 
            this.previewBox.Location = new System.Drawing.Point(480, 67);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(308, 292);
            this.previewBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previewBox.TabIndex = 13;
            this.previewBox.TabStop = false;
            // 
            // previousImageLabel
            // 
            this.previousImageLabel.AutoSize = true;
            this.previousImageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousImageLabel.ForeColor = System.Drawing.Color.White;
            this.previousImageLabel.Location = new System.Drawing.Point(181, 150);
            this.previousImageLabel.MaximumSize = new System.Drawing.Size(300, 80);
            this.previousImageLabel.Name = "previousImageLabel";
            this.previousImageLabel.Size = new System.Drawing.Size(90, 22);
            this.previousImageLabel.TabIndex = 15;
            this.previousImageLabel.Text = "Previous: ";
            // 
            // previousKeywordLabel
            // 
            this.previousKeywordLabel.AutoSize = true;
            this.previousKeywordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousKeywordLabel.ForeColor = System.Drawing.Color.White;
            this.previousKeywordLabel.Location = new System.Drawing.Point(181, 249);
            this.previousKeywordLabel.MaximumSize = new System.Drawing.Size(300, 90);
            this.previousKeywordLabel.Name = "previousKeywordLabel";
            this.previousKeywordLabel.Size = new System.Drawing.Size(90, 22);
            this.previousKeywordLabel.TabIndex = 16;
            this.previousKeywordLabel.Text = "Previous: ";
            // 
            // underline
            // 
            this.underline.AutoSize = true;
            this.underline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.underline.Enabled = false;
            this.underline.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.2F);
            this.underline.Location = new System.Drawing.Point(318, 85);
            this.underline.Name = "underline";
            this.underline.Size = new System.Drawing.Size(104, 7);
            this.underline.TabIndex = 17;
            this.underline.Text = "                                                  ";
            // 
            // imageURLTextBox
            // 
            this.imageURLTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageURLTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.imageURLTextBox.Location = new System.Drawing.Point(199, 324);
            this.imageURLTextBox.Name = "imageURLTextBox";
            this.imageURLTextBox.Size = new System.Drawing.Size(247, 30);
            this.imageURLTextBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 38);
            this.label1.TabIndex = 19;
            this.label1.Text = "Image URL";
            // 
            // addDataWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageURLTextBox);
            this.Controls.Add(this.underline);
            this.Controls.Add(this.previousKeywordLabel);
            this.Controls.Add(this.previousImageLabel);
            this.Controls.Add(this.previewBox);
            this.Controls.Add(this.updateLabel);
            this.Controls.Add(this.discardButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.imageDialogeButton);
            this.Controls.Add(this.keywordsTextBox);
            this.Controls.Add(this.imagePathTextBox);
            this.Controls.Add(this.keywordsLabel);
            this.Controls.Add(this.imagePathLabel);
            this.Controls.Add(this.addTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addDataWindow";
            this.Text = "Add Image Data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.addDataWindow_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addTitle;
        private System.Windows.Forms.Label imagePathLabel;
        private System.Windows.Forms.Label keywordsLabel;
        private System.Windows.Forms.TextBox imagePathTextBox;
        private System.Windows.Forms.TextBox keywordsTextBox;
        private System.Windows.Forms.Button imageDialogeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button discardButton;
        private System.Windows.Forms.ToolTip imageToolTip;
        private System.Windows.Forms.Label updateLabel;
        private System.Windows.Forms.PictureBox previewBox;
        private System.Windows.Forms.Label previousImageLabel;
        private System.Windows.Forms.Label previousKeywordLabel;
        private System.Windows.Forms.Label underline;
        private System.Windows.Forms.TextBox imageURLTextBox;
        private System.Windows.Forms.Label label1;
    }
}