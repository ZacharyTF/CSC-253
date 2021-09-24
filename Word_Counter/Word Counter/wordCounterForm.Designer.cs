
namespace Word_Counter
{
    partial class wordCounterForm
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
            this.countButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.counterTitleLabel = new System.Windows.Forms.Label();
            this.counterLabel = new System.Windows.Forms.Label();
            this.wordTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(15, 106);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(86, 37);
            this.countButton.TabIndex = 0;
            this.countButton.Text = "Count";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(173, 17);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Enter a phrase or a word: ";
            // 
            // counterTitleLabel
            // 
            this.counterTitleLabel.AutoSize = true;
            this.counterTitleLabel.Location = new System.Drawing.Point(9, 76);
            this.counterTitleLabel.Name = "counterTitleLabel";
            this.counterTitleLabel.Size = new System.Drawing.Size(122, 17);
            this.counterTitleLabel.TabIndex = 2;
            this.counterTitleLabel.Text = "Word(s) counted: ";
            // 
            // counterLabel
            // 
            this.counterLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.counterLabel.Location = new System.Drawing.Point(134, 75);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(86, 22);
            this.counterLabel.TabIndex = 3;
            // 
            // wordTextBox
            // 
            this.wordTextBox.Location = new System.Drawing.Point(12, 29);
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.Size = new System.Drawing.Size(208, 22);
            this.wordTextBox.TabIndex = 4;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(134, 106);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(86, 37);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // wordCounterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 162);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.wordTextBox);
            this.Controls.Add(this.counterLabel);
            this.Controls.Add(this.counterTitleLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.countButton);
            this.Name = "wordCounterForm";
            this.Text = "Word Counter Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label counterTitleLabel;
        private System.Windows.Forms.Label counterLabel;
        private System.Windows.Forms.TextBox wordTextBox;
        private System.Windows.Forms.Button exitButton;
    }
}

