
namespace UnitTuitionIncrease
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
            this.yearsTextBox = new System.Windows.Forms.TextBox();
            this.increaseTextBox = new System.Windows.Forms.TextBox();
            this.tuitionTextBox = new System.Windows.Forms.TextBox();
            this.yearTitleLabel = new System.Windows.Forms.Label();
            this.increaseTitleLabel = new System.Windows.Forms.Label();
            this.tuitionTitleLabel = new System.Windows.Forms.Label();
            this.calculateTuitionButton = new System.Windows.Forms.Button();
            this.projectedOutputListBox = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yearsTextBox
            // 
            this.yearsTextBox.Location = new System.Drawing.Point(17, 150);
            this.yearsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.yearsTextBox.Name = "yearsTextBox";
            this.yearsTextBox.Size = new System.Drawing.Size(167, 22);
            this.yearsTextBox.TabIndex = 16;
            // 
            // increaseTextBox
            // 
            this.increaseTextBox.Location = new System.Drawing.Point(17, 88);
            this.increaseTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.increaseTextBox.Name = "increaseTextBox";
            this.increaseTextBox.Size = new System.Drawing.Size(167, 22);
            this.increaseTextBox.TabIndex = 15;
            // 
            // tuitionTextBox
            // 
            this.tuitionTextBox.Location = new System.Drawing.Point(17, 28);
            this.tuitionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.tuitionTextBox.Name = "tuitionTextBox";
            this.tuitionTextBox.Size = new System.Drawing.Size(167, 22);
            this.tuitionTextBox.TabIndex = 14;
            // 
            // yearTitleLabel
            // 
            this.yearTitleLabel.AutoSize = true;
            this.yearTitleLabel.Location = new System.Drawing.Point(13, 131);
            this.yearTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yearTitleLabel.Name = "yearTitleLabel";
            this.yearTitleLabel.Size = new System.Drawing.Size(286, 17);
            this.yearTitleLabel.TabIndex = 13;
            this.yearTitleLabel.Text = "Enter the course of the increase over years:";
            // 
            // increaseTitleLabel
            // 
            this.increaseTitleLabel.AutoSize = true;
            this.increaseTitleLabel.Location = new System.Drawing.Point(13, 68);
            this.increaseTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.increaseTitleLabel.Name = "increaseTitleLabel";
            this.increaseTitleLabel.Size = new System.Drawing.Size(196, 17);
            this.increaseTitleLabel.TabIndex = 12;
            this.increaseTitleLabel.Text = "Enter the percent of increase:";
            // 
            // tuitionTitleLabel
            // 
            this.tuitionTitleLabel.AutoSize = true;
            this.tuitionTitleLabel.Location = new System.Drawing.Point(13, 9);
            this.tuitionTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tuitionTitleLabel.Name = "tuitionTitleLabel";
            this.tuitionTitleLabel.Size = new System.Drawing.Size(176, 17);
            this.tuitionTitleLabel.TabIndex = 11;
            this.tuitionTitleLabel.Text = "Enter your price for tuition:";
            // 
            // calculateTuitionButton
            // 
            this.calculateTuitionButton.Location = new System.Drawing.Point(13, 195);
            this.calculateTuitionButton.Margin = new System.Windows.Forms.Padding(4);
            this.calculateTuitionButton.Name = "calculateTuitionButton";
            this.calculateTuitionButton.Size = new System.Drawing.Size(85, 38);
            this.calculateTuitionButton.TabIndex = 10;
            this.calculateTuitionButton.Text = "Calculate";
            this.calculateTuitionButton.UseVisualStyleBackColor = true;
            this.calculateTuitionButton.Click += new System.EventHandler(this.calculateTuitionButton_Click);
            // 
            // projectedOutputListBox
            // 
            this.projectedOutputListBox.FormattingEnabled = true;
            this.projectedOutputListBox.ItemHeight = 16;
            this.projectedOutputListBox.Location = new System.Drawing.Point(321, 9);
            this.projectedOutputListBox.Margin = new System.Windows.Forms.Padding(4);
            this.projectedOutputListBox.Name = "projectedOutputListBox";
            this.projectedOutputListBox.Size = new System.Drawing.Size(483, 180);
            this.projectedOutputListBox.TabIndex = 9;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(711, 197);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(93, 38);
            this.exitButton.TabIndex = 17;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 242);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.yearsTextBox);
            this.Controls.Add(this.increaseTextBox);
            this.Controls.Add(this.tuitionTextBox);
            this.Controls.Add(this.yearTitleLabel);
            this.Controls.Add(this.increaseTitleLabel);
            this.Controls.Add(this.tuitionTitleLabel);
            this.Controls.Add(this.calculateTuitionButton);
            this.Controls.Add(this.projectedOutputListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox yearsTextBox;
        private System.Windows.Forms.TextBox increaseTextBox;
        private System.Windows.Forms.TextBox tuitionTextBox;
        private System.Windows.Forms.Label yearTitleLabel;
        private System.Windows.Forms.Label increaseTitleLabel;
        private System.Windows.Forms.Label tuitionTitleLabel;
        private System.Windows.Forms.Button calculateTuitionButton;
        private System.Windows.Forms.ListBox projectedOutputListBox;
        private System.Windows.Forms.Button exitButton;
    }
}

