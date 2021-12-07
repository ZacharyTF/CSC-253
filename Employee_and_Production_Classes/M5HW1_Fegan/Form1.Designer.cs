
namespace M5HW1_Fegan
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
            this.exitButton = new System.Windows.Forms.Button();
            this.createObjectButton = new System.Windows.Forms.Button();
            this.objectGroupBox = new System.Windows.Forms.GroupBox();
            this.outputHourlyPayRateLabel = new System.Windows.Forms.Label();
            this.outputShiftNumberLabel = new System.Windows.Forms.Label();
            this.outputEmployeeNumberLabel = new System.Windows.Forms.Label();
            this.outputEmployeeNameLabel = new System.Windows.Forms.Label();
            this.hourlyPayRateLabel = new System.Windows.Forms.Label();
            this.shiftNumberLabel = new System.Windows.Forms.Label();
            this.employeeNumberLabel = new System.Windows.Forms.Label();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.hourlyPayRateTextBox = new System.Windows.Forms.TextBox();
            this.shiftNumberTextBox = new System.Windows.Forms.TextBox();
            this.employeeNumberTextBox = new System.Windows.Forms.TextBox();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.inputHourlyPayRateLabel = new System.Windows.Forms.Label();
            this.inputShiftNumberLabel = new System.Windows.Forms.Label();
            this.inputEmployeeNumberLabel = new System.Windows.Forms.Label();
            this.inputEmployeeNameLabel = new System.Windows.Forms.Label();
            this.objectGroupBox.SuspendLayout();
            this.inputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(168, 405);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 49);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // createObjectButton
            // 
            this.createObjectButton.Location = new System.Drawing.Point(60, 405);
            this.createObjectButton.Margin = new System.Windows.Forms.Padding(4);
            this.createObjectButton.Name = "createObjectButton";
            this.createObjectButton.Size = new System.Drawing.Size(100, 49);
            this.createObjectButton.TabIndex = 10;
            this.createObjectButton.Text = "Create Object";
            this.createObjectButton.UseVisualStyleBackColor = true;
            this.createObjectButton.Click += new System.EventHandler(this.createObjectButton_Click);
            // 
            // objectGroupBox
            // 
            this.objectGroupBox.Controls.Add(this.outputHourlyPayRateLabel);
            this.objectGroupBox.Controls.Add(this.outputShiftNumberLabel);
            this.objectGroupBox.Controls.Add(this.outputEmployeeNumberLabel);
            this.objectGroupBox.Controls.Add(this.outputEmployeeNameLabel);
            this.objectGroupBox.Controls.Add(this.hourlyPayRateLabel);
            this.objectGroupBox.Controls.Add(this.shiftNumberLabel);
            this.objectGroupBox.Controls.Add(this.employeeNumberLabel);
            this.objectGroupBox.Controls.Add(this.employeeNameLabel);
            this.objectGroupBox.Location = new System.Drawing.Point(13, 204);
            this.objectGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.objectGroupBox.Name = "objectGroupBox";
            this.objectGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.objectGroupBox.Size = new System.Drawing.Size(303, 181);
            this.objectGroupBox.TabIndex = 9;
            this.objectGroupBox.TabStop = false;
            this.objectGroupBox.Text = "Object Properties";
            // 
            // outputHourlyPayRateLabel
            // 
            this.outputHourlyPayRateLabel.AutoSize = true;
            this.outputHourlyPayRateLabel.Location = new System.Drawing.Point(18, 133);
            this.outputHourlyPayRateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputHourlyPayRateLabel.Name = "outputHourlyPayRateLabel";
            this.outputHourlyPayRateLabel.Size = new System.Drawing.Size(115, 17);
            this.outputHourlyPayRateLabel.TabIndex = 18;
            this.outputHourlyPayRateLabel.Text = "Hourly Pay Rate:";
            // 
            // outputShiftNumberLabel
            // 
            this.outputShiftNumberLabel.AutoSize = true;
            this.outputShiftNumberLabel.Location = new System.Drawing.Point(35, 101);
            this.outputShiftNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputShiftNumberLabel.Name = "outputShiftNumberLabel";
            this.outputShiftNumberLabel.Size = new System.Drawing.Size(94, 17);
            this.outputShiftNumberLabel.TabIndex = 17;
            this.outputShiftNumberLabel.Text = "Shift Number:";
            // 
            // outputEmployeeNumberLabel
            // 
            this.outputEmployeeNumberLabel.AutoSize = true;
            this.outputEmployeeNumberLabel.Location = new System.Drawing.Point(5, 69);
            this.outputEmployeeNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputEmployeeNumberLabel.Name = "outputEmployeeNumberLabel";
            this.outputEmployeeNumberLabel.Size = new System.Drawing.Size(128, 17);
            this.outputEmployeeNumberLabel.TabIndex = 16;
            this.outputEmployeeNumberLabel.Text = "Employee Number:";
            // 
            // outputEmployeeNameLabel
            // 
            this.outputEmployeeNameLabel.AutoSize = true;
            this.outputEmployeeNameLabel.Location = new System.Drawing.Point(18, 37);
            this.outputEmployeeNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputEmployeeNameLabel.Name = "outputEmployeeNameLabel";
            this.outputEmployeeNameLabel.Size = new System.Drawing.Size(115, 17);
            this.outputEmployeeNameLabel.TabIndex = 15;
            this.outputEmployeeNameLabel.Text = "Employee Name:";
            // 
            // hourlyPayRateLabel
            // 
            this.hourlyPayRateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hourlyPayRateLabel.Location = new System.Drawing.Point(141, 127);
            this.hourlyPayRateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hourlyPayRateLabel.Name = "hourlyPayRateLabel";
            this.hourlyPayRateLabel.Size = new System.Drawing.Size(133, 28);
            this.hourlyPayRateLabel.TabIndex = 13;
            this.hourlyPayRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shiftNumberLabel
            // 
            this.shiftNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shiftNumberLabel.Location = new System.Drawing.Point(141, 95);
            this.shiftNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shiftNumberLabel.Name = "shiftNumberLabel";
            this.shiftNumberLabel.Size = new System.Drawing.Size(133, 28);
            this.shiftNumberLabel.TabIndex = 12;
            this.shiftNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // employeeNumberLabel
            // 
            this.employeeNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employeeNumberLabel.Location = new System.Drawing.Point(141, 63);
            this.employeeNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.employeeNumberLabel.Name = "employeeNumberLabel";
            this.employeeNumberLabel.Size = new System.Drawing.Size(133, 28);
            this.employeeNumberLabel.TabIndex = 11;
            this.employeeNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employeeNameLabel.Location = new System.Drawing.Point(141, 31);
            this.employeeNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(133, 28);
            this.employeeNameLabel.TabIndex = 10;
            this.employeeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.hourlyPayRateTextBox);
            this.inputGroupBox.Controls.Add(this.shiftNumberTextBox);
            this.inputGroupBox.Controls.Add(this.employeeNumberTextBox);
            this.inputGroupBox.Controls.Add(this.employeeNameTextBox);
            this.inputGroupBox.Controls.Add(this.inputHourlyPayRateLabel);
            this.inputGroupBox.Controls.Add(this.inputShiftNumberLabel);
            this.inputGroupBox.Controls.Add(this.inputEmployeeNumberLabel);
            this.inputGroupBox.Controls.Add(this.inputEmployeeNameLabel);
            this.inputGroupBox.Location = new System.Drawing.Point(13, 13);
            this.inputGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.inputGroupBox.Size = new System.Drawing.Size(303, 170);
            this.inputGroupBox.TabIndex = 8;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Enter Employee Information";
            // 
            // hourlyPayRateTextBox
            // 
            this.hourlyPayRateTextBox.Location = new System.Drawing.Point(148, 123);
            this.hourlyPayRateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.hourlyPayRateTextBox.Name = "hourlyPayRateTextBox";
            this.hourlyPayRateTextBox.Size = new System.Drawing.Size(132, 22);
            this.hourlyPayRateTextBox.TabIndex = 8;
            // 
            // shiftNumberTextBox
            // 
            this.shiftNumberTextBox.Location = new System.Drawing.Point(149, 91);
            this.shiftNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.shiftNumberTextBox.Name = "shiftNumberTextBox";
            this.shiftNumberTextBox.Size = new System.Drawing.Size(132, 22);
            this.shiftNumberTextBox.TabIndex = 7;
            // 
            // employeeNumberTextBox
            // 
            this.employeeNumberTextBox.Location = new System.Drawing.Point(149, 59);
            this.employeeNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.employeeNumberTextBox.Name = "employeeNumberTextBox";
            this.employeeNumberTextBox.Size = new System.Drawing.Size(132, 22);
            this.employeeNumberTextBox.TabIndex = 6;
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(149, 27);
            this.employeeNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(132, 22);
            this.employeeNameTextBox.TabIndex = 5;
            // 
            // inputHourlyPayRateLabel
            // 
            this.inputHourlyPayRateLabel.AutoSize = true;
            this.inputHourlyPayRateLabel.Location = new System.Drawing.Point(17, 128);
            this.inputHourlyPayRateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputHourlyPayRateLabel.Name = "inputHourlyPayRateLabel";
            this.inputHourlyPayRateLabel.Size = new System.Drawing.Size(115, 17);
            this.inputHourlyPayRateLabel.TabIndex = 3;
            this.inputHourlyPayRateLabel.Text = "Hourly Pay Rate:";
            // 
            // inputShiftNumberLabel
            // 
            this.inputShiftNumberLabel.AutoSize = true;
            this.inputShiftNumberLabel.Location = new System.Drawing.Point(35, 94);
            this.inputShiftNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputShiftNumberLabel.Name = "inputShiftNumberLabel";
            this.inputShiftNumberLabel.Size = new System.Drawing.Size(94, 17);
            this.inputShiftNumberLabel.TabIndex = 2;
            this.inputShiftNumberLabel.Text = "Shift Number:";
            // 
            // inputEmployeeNumberLabel
            // 
            this.inputEmployeeNumberLabel.AutoSize = true;
            this.inputEmployeeNumberLabel.Location = new System.Drawing.Point(4, 62);
            this.inputEmployeeNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputEmployeeNumberLabel.Name = "inputEmployeeNumberLabel";
            this.inputEmployeeNumberLabel.Size = new System.Drawing.Size(128, 17);
            this.inputEmployeeNumberLabel.TabIndex = 1;
            this.inputEmployeeNumberLabel.Text = "Employee Number:";
            // 
            // inputEmployeeNameLabel
            // 
            this.inputEmployeeNameLabel.AutoSize = true;
            this.inputEmployeeNameLabel.Location = new System.Drawing.Point(15, 31);
            this.inputEmployeeNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.inputEmployeeNameLabel.Name = "inputEmployeeNameLabel";
            this.inputEmployeeNameLabel.Size = new System.Drawing.Size(115, 17);
            this.inputEmployeeNameLabel.TabIndex = 0;
            this.inputEmployeeNameLabel.Text = "Employee Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 469);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.createObjectButton);
            this.Controls.Add(this.objectGroupBox);
            this.Controls.Add(this.inputGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.objectGroupBox.ResumeLayout(false);
            this.objectGroupBox.PerformLayout();
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button createObjectButton;
        private System.Windows.Forms.GroupBox objectGroupBox;
        private System.Windows.Forms.Label outputHourlyPayRateLabel;
        private System.Windows.Forms.Label outputShiftNumberLabel;
        private System.Windows.Forms.Label outputEmployeeNumberLabel;
        private System.Windows.Forms.Label outputEmployeeNameLabel;
        private System.Windows.Forms.Label hourlyPayRateLabel;
        private System.Windows.Forms.Label shiftNumberLabel;
        private System.Windows.Forms.Label employeeNumberLabel;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.TextBox hourlyPayRateTextBox;
        private System.Windows.Forms.TextBox shiftNumberTextBox;
        private System.Windows.Forms.TextBox employeeNumberTextBox;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.Label inputHourlyPayRateLabel;
        private System.Windows.Forms.Label inputShiftNumberLabel;
        private System.Windows.Forms.Label inputEmployeeNumberLabel;
        private System.Windows.Forms.Label inputEmployeeNameLabel;
    }
}

