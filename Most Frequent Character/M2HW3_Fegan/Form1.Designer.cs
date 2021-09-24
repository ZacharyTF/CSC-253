
namespace M2HW3_Fegan
{
    partial class frequentWordFrom
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
            this.frequentWordButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.frequentWordTitleLabel = new System.Windows.Forms.Label();
            this.frequentWordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // frequentWordButton
            // 
            this.frequentWordButton.Location = new System.Drawing.Point(70, 95);
            this.frequentWordButton.Name = "frequentWordButton";
            this.frequentWordButton.Size = new System.Drawing.Size(79, 52);
            this.frequentWordButton.TabIndex = 0;
            this.frequentWordButton.Text = "Frequent Word";
            this.frequentWordButton.UseVisualStyleBackColor = true;
            this.frequentWordButton.Click += new System.EventHandler(this.frequentWordButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(205, 103);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(79, 37);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(110, 17);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Enter a phrase: ";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(128, 9);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(217, 22);
            this.inputTextBox.TabIndex = 3;
            // 
            // frequentWordTitleLabel
            // 
            this.frequentWordTitleLabel.AutoSize = true;
            this.frequentWordTitleLabel.Location = new System.Drawing.Point(12, 53);
            this.frequentWordTitleLabel.Name = "frequentWordTitleLabel";
            this.frequentWordTitleLabel.Size = new System.Drawing.Size(137, 17);
            this.frequentWordTitleLabel.TabIndex = 4;
            this.frequentWordTitleLabel.Text = "Most frequent word: ";
            // 
            // frequentWordLabel
            // 
            this.frequentWordLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.frequentWordLabel.Location = new System.Drawing.Point(155, 53);
            this.frequentWordLabel.Name = "frequentWordLabel";
            this.frequentWordLabel.Size = new System.Drawing.Size(190, 22);
            this.frequentWordLabel.TabIndex = 5;
            // 
            // frequentWordFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 177);
            this.Controls.Add(this.frequentWordLabel);
            this.Controls.Add(this.frequentWordTitleLabel);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.frequentWordButton);
            this.Name = "frequentWordFrom";
            this.Text = "Most Frequent Word";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button frequentWordButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label frequentWordTitleLabel;
        private System.Windows.Forms.Label frequentWordLabel;
    }
}

