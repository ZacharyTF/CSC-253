
namespace M2HW2_Fegan
{
    partial class averageWordForm
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
            this.averageButton = new System.Windows.Forms.Button();
            this.wordTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.countTitleLabel = new System.Windows.Forms.Label();
            this.averageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // averageButton
            // 
            this.averageButton.Location = new System.Drawing.Point(12, 133);
            this.averageButton.Name = "averageButton";
            this.averageButton.Size = new System.Drawing.Size(75, 34);
            this.averageButton.TabIndex = 0;
            this.averageButton.Text = "Average";
            this.averageButton.UseVisualStyleBackColor = true;
            this.averageButton.Click += new System.EventHandler(this.averageButton_Click);
            // 
            // wordTextBox
            // 
            this.wordTextBox.Location = new System.Drawing.Point(12, 29);
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.Size = new System.Drawing.Size(249, 22);
            this.wordTextBox.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(186, 133);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 34);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(9, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(161, 17);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Enter a word or phrase: ";
            // 
            // countTitleLabel
            // 
            this.countTitleLabel.AutoSize = true;
            this.countTitleLabel.Location = new System.Drawing.Point(9, 66);
            this.countTitleLabel.Name = "countTitleLabel";
            this.countTitleLabel.Size = new System.Drawing.Size(264, 17);
            this.countTitleLabel.TabIndex = 4;
            this.countTitleLabel.Text = "Average number of letters in each word: ";
            // 
            // averageLabel
            // 
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.averageLabel.Location = new System.Drawing.Point(77, 93);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(93, 22);
            this.averageLabel.TabIndex = 5;
            // 
            // averageWordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 181);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.countTitleLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.wordTextBox);
            this.Controls.Add(this.averageButton);
            this.Name = "averageWordForm";
            this.Text = "Average Word Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button averageButton;
        private System.Windows.Forms.TextBox wordTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label countTitleLabel;
        private System.Windows.Forms.Label averageLabel;
    }
}

