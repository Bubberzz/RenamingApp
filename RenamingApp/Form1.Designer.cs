namespace RenamingApp
{
    sealed partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.renameButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.listViewDisplay = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxOptions = new System.Windows.Forms.ComboBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelInstance = new System.Windows.Forms.Label();
            this.comboBoxInstance = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // renameButton
            // 
            this.renameButton.Location = new System.Drawing.Point(729, 496);
            this.renameButton.Margin = new System.Windows.Forms.Padding(4);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(100, 28);
            this.renameButton.TabIndex = 1;
            this.renameButton.Text = "Rename";
            this.renameButton.UseVisualStyleBackColor = true;
            this.renameButton.Click += new System.EventHandler(this.Rename_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(621, 496);
            this.openButton.Margin = new System.Windows.Forms.Padding(4);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(100, 28);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.Open_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Cursor = System.Windows.Forms.Cursors.Default;
            this.label.Location = new System.Drawing.Point(232, 450);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 17);
            this.label.TabIndex = 4;
            // 
            // listViewDisplay
            // 
            this.listViewDisplay.AllowDrop = true;
            this.listViewDisplay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewDisplay.Location = new System.Drawing.Point(16, 15);
            this.listViewDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.listViewDisplay.Name = "listViewDisplay";
            this.listViewDisplay.Size = new System.Drawing.Size(799, 421);
            this.listViewDisplay.TabIndex = 5;
            this.listViewDisplay.UseCompatibleStateImageBehavior = false;
            this.listViewDisplay.View = System.Windows.Forms.View.Details;
            this.listViewDisplay.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListView_DragDrop);
            this.listViewDisplay.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListView_DragEnter);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File name";
            this.columnHeader1.Width = 695;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 457);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Options:";
            // 
            // comboBoxOptions
            // 
            this.comboBoxOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOptions.FormattingEnabled = true;
            this.comboBoxOptions.Location = new System.Drawing.Point(95, 453);
            this.comboBoxOptions.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxOptions.Name = "comboBoxOptions";
            this.comboBoxOptions.Size = new System.Drawing.Size(208, 24);
            this.comboBoxOptions.TabIndex = 7;
            this.comboBoxOptions.SelectedIndexChanged += new System.EventHandler(this.ComboBoxOptions_SelectedIndexChanged);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(304, 495);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(76, 22);
            this.textBoxInput.TabIndex = 8;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(25, 498);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(0, 17);
            this.labelDescription.TabIndex = 9;
            // 
            // labelInstance
            // 
            this.labelInstance.AutoSize = true;
            this.labelInstance.Location = new System.Drawing.Point(393, 498);
            this.labelInstance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInstance.Name = "labelInstance";
            this.labelInstance.Size = new System.Drawing.Size(65, 17);
            this.labelInstance.TabIndex = 10;
            this.labelInstance.Text = "Instance:";
            // 
            // comboBoxInstance
            // 
            this.comboBoxInstance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInstance.FormattingEnabled = true;
            this.comboBoxInstance.Location = new System.Drawing.Point(466, 495);
            this.comboBoxInstance.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxInstance.Name = "comboBoxInstance";
            this.comboBoxInstance.Size = new System.Drawing.Size(52, 24);
            this.comboBoxInstance.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 539);
            this.Controls.Add(this.comboBoxInstance);
            this.Controls.Add(this.labelInstance);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.comboBoxOptions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewDisplay);
            this.Controls.Add(this.label);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.renameButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renaming App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button renameButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ListView listViewDisplay;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxOptions;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelInstance;
        private System.Windows.Forms.ComboBox comboBoxInstance;
    }
}

