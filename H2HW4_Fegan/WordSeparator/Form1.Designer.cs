
namespace WordSeparator
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.outputTitleLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.sentenceTextBox = new System.Windows.Forms.TextBox();
            this.unscrableButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(396, 17);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Enter a Sentence with the beginning of each word capitalized:";
            // 
            // outputTitleLabel
            // 
            this.outputTitleLabel.AutoSize = true;
            this.outputTitleLabel.Location = new System.Drawing.Point(12, 70);
            this.outputTitleLabel.Name = "outputTitleLabel";
            this.outputTitleLabel.Size = new System.Drawing.Size(55, 17);
            this.outputTitleLabel.TabIndex = 1;
            this.outputTitleLabel.Text = "Output:";
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputLabel.Location = new System.Drawing.Point(15, 87);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(309, 22);
            this.outputLabel.TabIndex = 2;
            // 
            // sentenceTextBox
            // 
            this.sentenceTextBox.Location = new System.Drawing.Point(15, 29);
            this.sentenceTextBox.Name = "sentenceTextBox";
            this.sentenceTextBox.Size = new System.Drawing.Size(309, 22);
            this.sentenceTextBox.TabIndex = 3;
            // 
            // unscrableButton
            // 
            this.unscrableButton.Location = new System.Drawing.Point(15, 112);
            this.unscrableButton.Name = "unscrableButton";
            this.unscrableButton.Size = new System.Drawing.Size(97, 34);
            this.unscrableButton.TabIndex = 4;
            this.unscrableButton.Text = "Unscramble";
            this.unscrableButton.UseVisualStyleBackColor = true;
            this.unscrableButton.Click += new System.EventHandler(this.unscrableButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(118, 112);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(69, 34);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(193, 112);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(69, 34);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 159);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.unscrableButton);
            this.Controls.Add(this.sentenceTextBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.outputTitleLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label outputTitleLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox sentenceTextBox;
        private System.Windows.Forms.Button unscrableButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
    }
}

