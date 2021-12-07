
namespace StringExtentionMethods
{
    partial class Form1
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
            this.dateFormatTitleLabel = new System.Windows.Forms.Label();
            this.dateFormatTextBox = new System.Windows.Forms.TextBox();
            this.convertDateGroupBox = new System.Windows.Forms.GroupBox();
            this.outputConvertedDateLabel = new System.Windows.Forms.Label();
            this.convertionDateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.phoneNumberGroupBox = new System.Windows.Forms.GroupBox();
            this.formatPhoneNumberButton = new System.Windows.Forms.Button();
            this.phoneNumberTitleLabel = new System.Windows.Forms.Label();
            this.userPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.outputFormatedPhoneNumberLabel = new System.Windows.Forms.Label();
            this.reverseInputGroupBox = new System.Windows.Forms.GroupBox();
            this.reverseTitleLabel = new System.Windows.Forms.Label();
            this.reverseTextBox = new System.Windows.Forms.TextBox();
            this.reverseTextButton = new System.Windows.Forms.Button();
            this.outputReverseTextLabel = new System.Windows.Forms.Label();
            this.countGroupBox = new System.Windows.Forms.GroupBox();
            this.outputNumberOfWordsLabel = new System.Windows.Forms.Label();
            this.countWordsButton = new System.Windows.Forms.Button();
            this.inputWordsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.convertDateGroupBox.SuspendLayout();
            this.phoneNumberGroupBox.SuspendLayout();
            this.reverseInputGroupBox.SuspendLayout();
            this.countGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateFormatTitleLabel
            // 
            this.dateFormatTitleLabel.AutoSize = true;
            this.dateFormatTitleLabel.Location = new System.Drawing.Point(5, 15);
            this.dateFormatTitleLabel.Name = "dateFormatTitleLabel";
            this.dateFormatTitleLabel.Size = new System.Drawing.Size(136, 13);
            this.dateFormatTitleLabel.TabIndex = 0;
            this.dateFormatTitleLabel.Text = "Enter the date in dd/mm/yy";
            // 
            // dateFormatTextBox
            // 
            this.dateFormatTextBox.Location = new System.Drawing.Point(5, 32);
            this.dateFormatTextBox.Name = "dateFormatTextBox";
            this.dateFormatTextBox.Size = new System.Drawing.Size(140, 20);
            this.dateFormatTextBox.TabIndex = 1;
            // 
            // convertDateGroupBox
            // 
            this.convertDateGroupBox.Controls.Add(this.outputConvertedDateLabel);
            this.convertDateGroupBox.Controls.Add(this.convertionDateButton);
            this.convertDateGroupBox.Controls.Add(this.dateFormatTitleLabel);
            this.convertDateGroupBox.Controls.Add(this.dateFormatTextBox);
            this.convertDateGroupBox.Location = new System.Drawing.Point(9, 11);
            this.convertDateGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.convertDateGroupBox.Name = "convertDateGroupBox";
            this.convertDateGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.convertDateGroupBox.Size = new System.Drawing.Size(149, 106);
            this.convertDateGroupBox.TabIndex = 2;
            this.convertDateGroupBox.TabStop = false;
            this.convertDateGroupBox.Text = "Convert To Date";
            // 
            // outputConvertedDateLabel
            // 
            this.outputConvertedDateLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputConvertedDateLabel.Location = new System.Drawing.Point(8, 85);
            this.outputConvertedDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outputConvertedDateLabel.Name = "outputConvertedDateLabel";
            this.outputConvertedDateLabel.Size = new System.Drawing.Size(130, 16);
            this.outputConvertedDateLabel.TabIndex = 3;
            // 
            // convertionDateButton
            // 
            this.convertionDateButton.Location = new System.Drawing.Point(8, 55);
            this.convertionDateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.convertionDateButton.Name = "convertionDateButton";
            this.convertionDateButton.Size = new System.Drawing.Size(130, 28);
            this.convertionDateButton.TabIndex = 2;
            this.convertionDateButton.Text = "Convert to mm/dd/yy";
            this.convertionDateButton.UseVisualStyleBackColor = true;
            this.convertionDateButton.Click += new System.EventHandler(this.convertionDateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(9, 243);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(79, 40);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // phoneNumberGroupBox
            // 
            this.phoneNumberGroupBox.Controls.Add(this.outputFormatedPhoneNumberLabel);
            this.phoneNumberGroupBox.Controls.Add(this.userPhoneNumberTextBox);
            this.phoneNumberGroupBox.Controls.Add(this.phoneNumberTitleLabel);
            this.phoneNumberGroupBox.Controls.Add(this.formatPhoneNumberButton);
            this.phoneNumberGroupBox.Location = new System.Drawing.Point(172, 11);
            this.phoneNumberGroupBox.Name = "phoneNumberGroupBox";
            this.phoneNumberGroupBox.Size = new System.Drawing.Size(175, 123);
            this.phoneNumberGroupBox.TabIndex = 4;
            this.phoneNumberGroupBox.TabStop = false;
            this.phoneNumberGroupBox.Text = "Phone Number";
            // 
            // formatPhoneNumberButton
            // 
            this.formatPhoneNumberButton.Location = new System.Drawing.Point(9, 58);
            this.formatPhoneNumberButton.Name = "formatPhoneNumberButton";
            this.formatPhoneNumberButton.Size = new System.Drawing.Size(149, 34);
            this.formatPhoneNumberButton.TabIndex = 5;
            this.formatPhoneNumberButton.Text = "Format Phone Number (xxx)xxx-xxxx";
            this.formatPhoneNumberButton.UseVisualStyleBackColor = true;
            this.formatPhoneNumberButton.Click += new System.EventHandler(this.formatPhoneNumberButton_Click);
            // 
            // phoneNumberTitleLabel
            // 
            this.phoneNumberTitleLabel.AutoSize = true;
            this.phoneNumberTitleLabel.Location = new System.Drawing.Point(6, 15);
            this.phoneNumberTitleLabel.Name = "phoneNumberTitleLabel";
            this.phoneNumberTitleLabel.Size = new System.Drawing.Size(109, 13);
            this.phoneNumberTitleLabel.TabIndex = 6;
            this.phoneNumberTitleLabel.Text = "Enter Phone Number:";
            // 
            // userPhoneNumberTextBox
            // 
            this.userPhoneNumberTextBox.Location = new System.Drawing.Point(6, 32);
            this.userPhoneNumberTextBox.Name = "userPhoneNumberTextBox";
            this.userPhoneNumberTextBox.Size = new System.Drawing.Size(163, 20);
            this.userPhoneNumberTextBox.TabIndex = 7;
            // 
            // outputFormatedPhoneNumberLabel
            // 
            this.outputFormatedPhoneNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputFormatedPhoneNumberLabel.Location = new System.Drawing.Point(6, 95);
            this.outputFormatedPhoneNumberLabel.Name = "outputFormatedPhoneNumberLabel";
            this.outputFormatedPhoneNumberLabel.Size = new System.Drawing.Size(163, 20);
            this.outputFormatedPhoneNumberLabel.TabIndex = 8;
            // 
            // reverseInputGroupBox
            // 
            this.reverseInputGroupBox.Controls.Add(this.outputReverseTextLabel);
            this.reverseInputGroupBox.Controls.Add(this.reverseTextButton);
            this.reverseInputGroupBox.Controls.Add(this.reverseTextBox);
            this.reverseInputGroupBox.Controls.Add(this.reverseTitleLabel);
            this.reverseInputGroupBox.Location = new System.Drawing.Point(9, 122);
            this.reverseInputGroupBox.Name = "reverseInputGroupBox";
            this.reverseInputGroupBox.Size = new System.Drawing.Size(157, 115);
            this.reverseInputGroupBox.TabIndex = 5;
            this.reverseInputGroupBox.TabStop = false;
            this.reverseInputGroupBox.Text = "Reverse input";
            // 
            // reverseTitleLabel
            // 
            this.reverseTitleLabel.AutoSize = true;
            this.reverseTitleLabel.Location = new System.Drawing.Point(6, 16);
            this.reverseTitleLabel.Name = "reverseTitleLabel";
            this.reverseTitleLabel.Size = new System.Drawing.Size(55, 13);
            this.reverseTitleLabel.TabIndex = 0;
            this.reverseTitleLabel.Text = "Enter text:";
            // 
            // reverseTextBox
            // 
            this.reverseTextBox.Location = new System.Drawing.Point(6, 32);
            this.reverseTextBox.Name = "reverseTextBox";
            this.reverseTextBox.Size = new System.Drawing.Size(145, 20);
            this.reverseTextBox.TabIndex = 1;
            // 
            // reverseTextButton
            // 
            this.reverseTextButton.Location = new System.Drawing.Point(36, 55);
            this.reverseTextButton.Name = "reverseTextButton";
            this.reverseTextButton.Size = new System.Drawing.Size(82, 28);
            this.reverseTextButton.TabIndex = 2;
            this.reverseTextButton.Text = "Reverse Text";
            this.reverseTextButton.UseVisualStyleBackColor = true;
            this.reverseTextButton.Click += new System.EventHandler(this.reverseTextButton_Click);
            // 
            // outputReverseTextLabel
            // 
            this.outputReverseTextLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputReverseTextLabel.Location = new System.Drawing.Point(6, 86);
            this.outputReverseTextLabel.Name = "outputReverseTextLabel";
            this.outputReverseTextLabel.Size = new System.Drawing.Size(145, 20);
            this.outputReverseTextLabel.TabIndex = 3;
            // 
            // countGroupBox
            // 
            this.countGroupBox.Controls.Add(this.outputNumberOfWordsLabel);
            this.countGroupBox.Controls.Add(this.countWordsButton);
            this.countGroupBox.Controls.Add(this.inputWordsTextBox);
            this.countGroupBox.Controls.Add(this.label2);
            this.countGroupBox.Location = new System.Drawing.Point(172, 140);
            this.countGroupBox.Name = "countGroupBox";
            this.countGroupBox.Size = new System.Drawing.Size(157, 115);
            this.countGroupBox.TabIndex = 6;
            this.countGroupBox.TabStop = false;
            this.countGroupBox.Text = "Count Words";
            // 
            // outputNumberOfWordsLabel
            // 
            this.outputNumberOfWordsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputNumberOfWordsLabel.Location = new System.Drawing.Point(6, 86);
            this.outputNumberOfWordsLabel.Name = "outputNumberOfWordsLabel";
            this.outputNumberOfWordsLabel.Size = new System.Drawing.Size(145, 20);
            this.outputNumberOfWordsLabel.TabIndex = 3;
            // 
            // countWordsButton
            // 
            this.countWordsButton.Location = new System.Drawing.Point(36, 55);
            this.countWordsButton.Name = "countWordsButton";
            this.countWordsButton.Size = new System.Drawing.Size(82, 28);
            this.countWordsButton.TabIndex = 2;
            this.countWordsButton.Text = "Count Words";
            this.countWordsButton.UseVisualStyleBackColor = true;
            this.countWordsButton.Click += new System.EventHandler(this.countWordsButton_Click);
            // 
            // inputWordsTextBox
            // 
            this.inputWordsTextBox.Location = new System.Drawing.Point(6, 32);
            this.inputWordsTextBox.Name = "inputWordsTextBox";
            this.inputWordsTextBox.Size = new System.Drawing.Size(145, 20);
            this.inputWordsTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter text:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 293);
            this.Controls.Add(this.countGroupBox);
            this.Controls.Add(this.reverseInputGroupBox);
            this.Controls.Add(this.phoneNumberGroupBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertDateGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.convertDateGroupBox.ResumeLayout(false);
            this.convertDateGroupBox.PerformLayout();
            this.phoneNumberGroupBox.ResumeLayout(false);
            this.phoneNumberGroupBox.PerformLayout();
            this.reverseInputGroupBox.ResumeLayout(false);
            this.reverseInputGroupBox.PerformLayout();
            this.countGroupBox.ResumeLayout(false);
            this.countGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label dateFormatTitleLabel;
        private System.Windows.Forms.TextBox dateFormatTextBox;
        private System.Windows.Forms.GroupBox convertDateGroupBox;
        private System.Windows.Forms.Label outputConvertedDateLabel;
        private System.Windows.Forms.Button convertionDateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox phoneNumberGroupBox;
        private System.Windows.Forms.Label outputFormatedPhoneNumberLabel;
        private System.Windows.Forms.TextBox userPhoneNumberTextBox;
        private System.Windows.Forms.Label phoneNumberTitleLabel;
        private System.Windows.Forms.Button formatPhoneNumberButton;
        private System.Windows.Forms.GroupBox reverseInputGroupBox;
        private System.Windows.Forms.Label outputReverseTextLabel;
        private System.Windows.Forms.Button reverseTextButton;
        private System.Windows.Forms.TextBox reverseTextBox;
        private System.Windows.Forms.Label reverseTitleLabel;
        private System.Windows.Forms.GroupBox countGroupBox;
        private System.Windows.Forms.Label outputNumberOfWordsLabel;
        private System.Windows.Forms.Button countWordsButton;
        private System.Windows.Forms.TextBox inputWordsTextBox;
        private System.Windows.Forms.Label label2;
    }
}

