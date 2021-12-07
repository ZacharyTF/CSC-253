
namespace M6HW1_Fegan
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
            this.retailPriceTitleLabel = new System.Windows.Forms.Label();
            this.markupPercentTitleLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.salePriceTitleLabel = new System.Windows.Forms.Label();
            this.percentageTextBox = new System.Windows.Forms.TextBox();
            this.salePriceTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.retailPriceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // retailPriceTitleLabel
            // 
            this.retailPriceTitleLabel.AutoSize = true;
            this.retailPriceTitleLabel.Location = new System.Drawing.Point(138, 7);
            this.retailPriceTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.retailPriceTitleLabel.Name = "retailPriceTitleLabel";
            this.retailPriceTitleLabel.Size = new System.Drawing.Size(96, 13);
            this.retailPriceTitleLabel.TabIndex = 12;
            this.retailPriceTitleLabel.Text = "The Retail Price is:";
            // 
            // markupPercentTitleLabel
            // 
            this.markupPercentTitleLabel.AutoSize = true;
            this.markupPercentTitleLabel.Location = new System.Drawing.Point(7, 48);
            this.markupPercentTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.markupPercentTitleLabel.Name = "markupPercentTitleLabel";
            this.markupPercentTitleLabel.Size = new System.Drawing.Size(129, 13);
            this.markupPercentTitleLabel.TabIndex = 11;
            this.markupPercentTitleLabel.Text = "Enter Markup Percentage";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(9, 91);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(2);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(74, 22);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // salePriceTitleLabel
            // 
            this.salePriceTitleLabel.AutoSize = true;
            this.salePriceTitleLabel.Location = new System.Drawing.Point(9, 7);
            this.salePriceTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.salePriceTitleLabel.Name = "salePriceTitleLabel";
            this.salePriceTitleLabel.Size = new System.Drawing.Size(117, 13);
            this.salePriceTitleLabel.TabIndex = 9;
            this.salePriceTitleLabel.Text = "Enter Whole Sale Price";
            // 
            // percentageTextBox
            // 
            this.percentageTextBox.Location = new System.Drawing.Point(9, 67);
            this.percentageTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.percentageTextBox.Name = "percentageTextBox";
            this.percentageTextBox.Size = new System.Drawing.Size(116, 20);
            this.percentageTextBox.TabIndex = 8;
            // 
            // salePriceTextBox
            // 
            this.salePriceTextBox.Location = new System.Drawing.Point(9, 25);
            this.salePriceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.salePriceTextBox.Name = "salePriceTextBox";
            this.salePriceTextBox.Size = new System.Drawing.Size(116, 20);
            this.salePriceTextBox.TabIndex = 7;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(164, 91);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(74, 22);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // retailPriceLabel
            // 
            this.retailPriceLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.retailPriceLabel.Location = new System.Drawing.Point(138, 25);
            this.retailPriceLabel.Name = "retailPriceLabel";
            this.retailPriceLabel.Size = new System.Drawing.Size(96, 20);
            this.retailPriceLabel.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 120);
            this.Controls.Add(this.retailPriceLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.retailPriceTitleLabel);
            this.Controls.Add(this.markupPercentTitleLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.salePriceTitleLabel);
            this.Controls.Add(this.percentageTextBox);
            this.Controls.Add(this.salePriceTextBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label retailPriceTitleLabel;
        private System.Windows.Forms.Label markupPercentTitleLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label salePriceTitleLabel;
        private System.Windows.Forms.TextBox percentageTextBox;
        private System.Windows.Forms.TextBox salePriceTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label retailPriceLabel;
    }
}

