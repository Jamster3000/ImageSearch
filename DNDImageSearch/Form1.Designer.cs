namespace DNDImageSearch
{
    partial class mainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.searchTitle = new System.Windows.Forms.Label();
            this.querySearchBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.addButton = new System.Windows.Forms.Button();
            this.emptyDatabaseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchTitle
            // 
            this.searchTitle.AutoSize = true;
            this.searchTitle.BackColor = System.Drawing.Color.Transparent;
            this.searchTitle.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.searchTitle.Location = new System.Drawing.Point(215, 9);
            this.searchTitle.Name = "searchTitle";
            this.searchTitle.Size = new System.Drawing.Size(280, 80);
            this.searchTitle.TabIndex = 0;
            this.searchTitle.Text = "Search";
            // 
            // querySearchBox
            // 
            this.querySearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.querySearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.querySearchBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.querySearchBox.Font = new System.Drawing.Font("Bell MT", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.querySearchBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.querySearchBox.Location = new System.Drawing.Point(229, 233);
            this.querySearchBox.Name = "querySearchBox";
            this.querySearchBox.Size = new System.Drawing.Size(476, 48);
            this.querySearchBox.TabIndex = 1;
            this.querySearchBox.TabStop = false;
            this.querySearchBox.Text = "search images";
            this.querySearchBox.TextChanged += new System.EventHandler(this.querySearchBox_TextChanged);
            this.querySearchBox.Enter += new System.EventHandler(this.querySearchBox_Enter);
            this.querySearchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.querySearchBox_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.button1.Location = new System.Drawing.Point(157, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 63);
            this.button1.TabIndex = 2;
            this.button1.Text = "🔍︎";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.enterClick);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 438);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(3, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 438);
            this.splitter2.TabIndex = 4;
            this.splitter2.TabStop = false;
            // 
            // addButton
            // 
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.addButton.Location = new System.Drawing.Point(617, 9);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(88, 91);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "➕";
            this.addButton.UseCompatibleTextRendering = true;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // emptyDatabaseButton
            // 
            this.emptyDatabaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.emptyDatabaseButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyDatabaseButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.emptyDatabaseButton.Location = new System.Drawing.Point(9, 9);
            this.emptyDatabaseButton.Name = "emptyDatabaseButton";
            this.emptyDatabaseButton.Size = new System.Drawing.Size(88, 91);
            this.emptyDatabaseButton.TabIndex = 6;
            this.emptyDatabaseButton.Text = "X";
            this.emptyDatabaseButton.UseCompatibleTextRendering = true;
            this.emptyDatabaseButton.UseVisualStyleBackColor = true;
            this.emptyDatabaseButton.Click += new System.EventHandler(this.emptyDatabaseButton_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(717, 438);
            this.Controls.Add(this.emptyDatabaseButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.querySearchBox);
            this.Controls.Add(this.searchTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainWindow";
            this.Text = "Image Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label searchTitle;
        private System.Windows.Forms.TextBox querySearchBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button emptyDatabaseButton;
    }
}

