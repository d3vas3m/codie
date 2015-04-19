namespace TabTextEdit
{
    partial class CodieFindAndReplace
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
            this.findRepTabControl = new System.Windows.Forms.TabControl();
            this.findTab = new System.Windows.Forms.TabPage();
            this.ignoreCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.findResult = new System.Windows.Forms.Label();
            this.findCancelButton = new System.Windows.Forms.Button();
            this.findButton = new System.Windows.Forms.Button();
            this.findText = new System.Windows.Forms.TextBox();
            this.labelText = new System.Windows.Forms.Label();
            this.replaceTab = new System.Windows.Forms.TabPage();
            this.repCheckBox = new System.Windows.Forms.CheckBox();
            this.replaceResText = new System.Windows.Forms.Label();
            this.replaceAllButton = new System.Windows.Forms.Button();
            this.replaceButton = new System.Windows.Forms.Button();
            this.repText = new System.Windows.Forms.TextBox();
            this.repFindText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.findRepTabControl.SuspendLayout();
            this.findTab.SuspendLayout();
            this.replaceTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // findRepTabControl
            // 
            this.findRepTabControl.Controls.Add(this.findTab);
            this.findRepTabControl.Controls.Add(this.replaceTab);
            this.findRepTabControl.Location = new System.Drawing.Point(12, 12);
            this.findRepTabControl.Name = "findRepTabControl";
            this.findRepTabControl.SelectedIndex = 0;
            this.findRepTabControl.Size = new System.Drawing.Size(349, 200);
            this.findRepTabControl.TabIndex = 0;
            // 
            // findTab
            // 
            this.findTab.AllowDrop = true;
            this.findTab.Controls.Add(this.ignoreCaseCheckBox);
            this.findTab.Controls.Add(this.findResult);
            this.findTab.Controls.Add(this.findCancelButton);
            this.findTab.Controls.Add(this.findButton);
            this.findTab.Controls.Add(this.findText);
            this.findTab.Controls.Add(this.labelText);
            this.findTab.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.findTab.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.findTab.Location = new System.Drawing.Point(4, 22);
            this.findTab.Name = "findTab";
            this.findTab.Padding = new System.Windows.Forms.Padding(3);
            this.findTab.Size = new System.Drawing.Size(341, 174);
            this.findTab.TabIndex = 0;
            this.findTab.Text = "Find";
            this.findTab.UseVisualStyleBackColor = true;
            // 
            // ignoreCaseCheckBox
            // 
            this.ignoreCaseCheckBox.AutoSize = true;
            this.ignoreCaseCheckBox.Location = new System.Drawing.Point(99, 97);
            this.ignoreCaseCheckBox.Name = "ignoreCaseCheckBox";
            this.ignoreCaseCheckBox.Size = new System.Drawing.Size(83, 17);
            this.ignoreCaseCheckBox.TabIndex = 5;
            this.ignoreCaseCheckBox.Text = "Ignore Case";
            this.ignoreCaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // findResult
            // 
            this.findResult.AutoSize = true;
            this.findResult.Location = new System.Drawing.Point(96, 68);
            this.findResult.Name = "findResult";
            this.findResult.Size = new System.Drawing.Size(102, 13);
            this.findResult.TabIndex = 4;
            this.findResult.Text = "Enter text to search.";
            // 
            // findCancelButton
            // 
            this.findCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findCancelButton.Location = new System.Drawing.Point(211, 132);
            this.findCancelButton.Name = "findCancelButton";
            this.findCancelButton.Size = new System.Drawing.Size(75, 23);
            this.findCancelButton.TabIndex = 3;
            this.findCancelButton.Text = "Cancel";
            this.findCancelButton.UseVisualStyleBackColor = true;
            this.findCancelButton.Click += new System.EventHandler(this.findCancelButton_Click);
            // 
            // findButton
            // 
            this.findButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findButton.Location = new System.Drawing.Point(99, 132);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(75, 23);
            this.findButton.TabIndex = 2;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // findText
            // 
            this.findText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.findText.Location = new System.Drawing.Point(99, 28);
            this.findText.Name = "findText";
            this.findText.Size = new System.Drawing.Size(213, 20);
            this.findText.TabIndex = 1;
            this.findText.TextChanged += new System.EventHandler(this.findText_TextChanged);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.Location = new System.Drawing.Point(24, 30);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(40, 18);
            this.labelText.TabIndex = 0;
            this.labelText.Text = "Text:";
            // 
            // replaceTab
            // 
            this.replaceTab.Controls.Add(this.repCheckBox);
            this.replaceTab.Controls.Add(this.replaceResText);
            this.replaceTab.Controls.Add(this.replaceAllButton);
            this.replaceTab.Controls.Add(this.replaceButton);
            this.replaceTab.Controls.Add(this.repText);
            this.replaceTab.Controls.Add(this.repFindText);
            this.replaceTab.Controls.Add(this.label2);
            this.replaceTab.Controls.Add(this.label1);
            this.replaceTab.Location = new System.Drawing.Point(4, 22);
            this.replaceTab.Name = "replaceTab";
            this.replaceTab.Padding = new System.Windows.Forms.Padding(3);
            this.replaceTab.Size = new System.Drawing.Size(341, 174);
            this.replaceTab.TabIndex = 1;
            this.replaceTab.Text = "Replace";
            this.replaceTab.UseVisualStyleBackColor = true;
            // 
            // repCheckBox
            // 
            this.repCheckBox.AutoSize = true;
            this.repCheckBox.Location = new System.Drawing.Point(110, 97);
            this.repCheckBox.Name = "repCheckBox";
            this.repCheckBox.Size = new System.Drawing.Size(83, 17);
            this.repCheckBox.TabIndex = 5;
            this.repCheckBox.Text = "Ignore Case";
            this.repCheckBox.UseVisualStyleBackColor = true;
            // 
            // replaceResText
            // 
            this.replaceResText.AutoSize = true;
            this.replaceResText.Location = new System.Drawing.Point(110, 97);
            this.replaceResText.Name = "replaceResText";
            this.replaceResText.Size = new System.Drawing.Size(0, 13);
            this.replaceResText.TabIndex = 4;
            // 
            // replaceAllButton
            // 
            this.replaceAllButton.Location = new System.Drawing.Point(221, 133);
            this.replaceAllButton.Name = "replaceAllButton";
            this.replaceAllButton.Size = new System.Drawing.Size(75, 23);
            this.replaceAllButton.TabIndex = 3;
            this.replaceAllButton.Text = "Replace All";
            this.replaceAllButton.UseVisualStyleBackColor = true;
            // 
            // replaceButton
            // 
            this.replaceButton.Location = new System.Drawing.Point(110, 133);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(75, 23);
            this.replaceButton.TabIndex = 3;
            this.replaceButton.Text = "Replace";
            this.replaceButton.UseVisualStyleBackColor = true;
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // repText
            // 
            this.repText.Location = new System.Drawing.Point(110, 57);
            this.repText.Name = "repText";
            this.repText.Size = new System.Drawing.Size(216, 20);
            this.repText.TabIndex = 2;
            // 
            // repFindText
            // 
            this.repFindText.Location = new System.Drawing.Point(110, 19);
            this.repFindText.Name = "repFindText";
            this.repFindText.Size = new System.Drawing.Size(216, 20);
            this.repFindText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Replace With:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find What:";
            // 
            // CodieFindAndReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 224);
            this.Controls.Add(this.findRepTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CodieFindAndReplace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Find and Replace";
            this.findRepTabControl.ResumeLayout(false);
            this.findTab.ResumeLayout(false);
            this.findTab.PerformLayout();
            this.replaceTab.ResumeLayout(false);
            this.replaceTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabPage findTab;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox findText;
        public System.Windows.Forms.Button findCancelButton;
        public System.Windows.Forms.Button findButton;
        public System.Windows.Forms.TabControl findRepTabControl;
        public System.Windows.Forms.Label findResult;
        public System.Windows.Forms.TextBox repText;
        public System.Windows.Forms.TextBox repFindText;
        public System.Windows.Forms.Label replaceResText;
        public System.Windows.Forms.Button replaceAllButton;
        public System.Windows.Forms.Button replaceButton;
        public System.Windows.Forms.TabPage replaceTab;
        private System.Windows.Forms.CheckBox ignoreCaseCheckBox;
        private System.Windows.Forms.CheckBox repCheckBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}