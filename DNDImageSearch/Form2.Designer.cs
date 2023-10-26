namespace DNDImageSearch
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
            this.addTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // addTitle
            // 
            this.addTitle.AutoSize = true;
            this.addTitle.BackColor = System.Drawing.Color.Transparent;
            this.addTitle.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addTitle.Location = new System.Drawing.Point(307, 9);
            this.addTitle.Name = "addTitle";
            this.addTitle.Size = new System.Drawing.Size(157, 80);
            this.addTitle.TabIndex = 1;
            this.addTitle.Text = "Add";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(161, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // idBox
            // 
            this.idBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBox.Location = new System.Drawing.Point(364, 134);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(265, 30);
            this.idBox.TabIndex = 3;
            this.idBox.Enter += new System.EventHandler(this.idBox_Enter);
            this.idBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idBox_KeyPress);
            // 
            // imagePathLabel
            // 
            this.imagePathLabel.AutoSize = true;
            this.imagePathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagePathLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.imagePathLabel.Location = new System.Drawing.Point(161, 209);
            this.imagePathLabel.Name = "imagePathLabel";
            this.imagePathLabel.Size = new System.Drawing.Size(182, 38);
            this.imagePathLabel.TabIndex = 4;
            this.imagePathLabel.Text = "Image Path";
            // 
            // keywordsLabel
            // 
            this.keywordsLabel.AutoSize = true;
            this.keywordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keywordsLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.keywordsLabel.Location = new System.Drawing.Point(161, 290);
            this.keywordsLabel.Name = "keywordsLabel";
            this.keywordsLabel.Size = new System.Drawing.Size(162, 38);
            this.keywordsLabel.TabIndex = 5;
            this.keywordsLabel.Text = "Keywords";
            // 
            // imagePathTextBox
            // 
            this.imagePathTextBox.AllowDrop = true;
            this.imagePathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagePathTextBox.Location = new System.Drawing.Point(364, 214);
            this.imagePathTextBox.Name = "imagePathTextBox";
            this.imagePathTextBox.Size = new System.Drawing.Size(265, 30);
            this.imagePathTextBox.TabIndex = 6;
            this.imagePathTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.imagePathTextBox_DragDrop);
            this.imagePathTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.imagePathTextBox_DragEnter);
            this.imagePathTextBox.Enter += new System.EventHandler(this.imagePathTextBox_Enter);
            this.imagePathTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.imagePathTextBox_KeyPress);
            // 
            // keywordsTextBox
            // 
            this.keywordsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keywordsTextBox.Location = new System.Drawing.Point(364, 290);
            this.keywordsTextBox.Name = "keywordsTextBox";
            this.keywordsTextBox.Size = new System.Drawing.Size(265, 30);
            this.keywordsTextBox.TabIndex = 7;
            this.keywordsTextBox.Enter += new System.EventHandler(this.keywordsTextBox_Enter);
            this.keywordsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keywordsTextBox_KeyPress);
            // 
            // imageDialogeButton
            // 
            this.imageDialogeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.imageDialogeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.imageDialogeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageDialogeButton.Location = new System.Drawing.Point(635, 214);
            this.imageDialogeButton.Name = "imageDialogeButton";
            this.imageDialogeButton.Size = new System.Drawing.Size(22, 34);
            this.imageDialogeButton.TabIndex = 8;
            this.imageDialogeButton.Text = "⋮";
            this.imageDialogeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.imageToolTip.SetToolTip(this.imageDialogeButton, "Open the file picker for you to select your image file.");
            this.imageDialogeButton.UseVisualStyleBackColor = true;
            this.imageDialogeButton.Click += new System.EventHandler(this.imageDialogeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(671, 392);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(117, 46);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // backButton
            // 
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.backButton.Location = new System.Drawing.Point(1, -1);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 59);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "◄";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // discardButton
            // 
            this.discardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discardButton.Location = new System.Drawing.Point(12, 392);
            this.discardButton.Name = "discardButton";
            this.discardButton.Size = new System.Drawing.Size(201, 46);
            this.discardButton.TabIndex = 11;
            this.discardButton.Text = "Discard";
            this.discardButton.UseVisualStyleBackColor = true;
            this.discardButton.Click += new System.EventHandler(this.DiscardButton);
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
            this.updateLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.updateLabel.Location = new System.Drawing.Point(294, 392);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(282, 36);
            this.updateLabel.TabIndex = 12;
            this.updateLabel.Text = "Saved Successfully!";
            this.updateLabel.Visible = false;
            // 
            // addDataWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateLabel);
            this.Controls.Add(this.discardButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.imageDialogeButton);
            this.Controls.Add(this.keywordsTextBox);
            this.Controls.Add(this.imagePathTextBox);
            this.Controls.Add(this.keywordsLabel);
            this.Controls.Add(this.imagePathLabel);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addTitle);
            this.Name = "addDataWindow";
            this.Text = "Add Image Data";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idBox;
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
    }
}