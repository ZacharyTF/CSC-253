
namespace WinFormEmployeeClass
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
            this.employeeInfoTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.idNumberTextBox = new System.Windows.Forms.TextBox();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.DisplayInfoButton = new System.Windows.Forms.Button();
            this.EmployeePosition = new System.Windows.Forms.Label();
            this.DepartmentLabel = new System.Windows.Forms.Label();
            this.EmployeeIDNumberLabel = new System.Windows.Forms.Label();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeeInfoTextBox
            // 
            this.employeeInfoTextBox.Location = new System.Drawing.Point(12, 198);
            this.employeeInfoTextBox.Multiline = true;
            this.employeeInfoTextBox.Name = "employeeInfoTextBox";
            this.employeeInfoTextBox.Size = new System.Drawing.Size(291, 118);
            this.employeeInfoTextBox.TabIndex = 23;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(100, 162);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(63, 30);
            this.ClearButton.TabIndex = 22;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // positionTextBox
            // 
            this.positionTextBox.Location = new System.Drawing.Point(129, 128);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(174, 22);
            this.positionTextBox.TabIndex = 21;
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.Location = new System.Drawing.Point(129, 91);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(174, 22);
            this.departmentTextBox.TabIndex = 20;
            // 
            // idNumberTextBox
            // 
            this.idNumberTextBox.Location = new System.Drawing.Point(129, 50);
            this.idNumberTextBox.Name = "idNumberTextBox";
            this.idNumberTextBox.Size = new System.Drawing.Size(174, 22);
            this.idNumberTextBox.TabIndex = 19;
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(129, 9);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(174, 22);
            this.employeeNameTextBox.TabIndex = 18;
            // 
            // DisplayInfoButton
            // 
            this.DisplayInfoButton.Location = new System.Drawing.Point(12, 162);
            this.DisplayInfoButton.Name = "DisplayInfoButton";
            this.DisplayInfoButton.Size = new System.Drawing.Size(82, 30);
            this.DisplayInfoButton.TabIndex = 17;
            this.DisplayInfoButton.Text = "Display";
            this.DisplayInfoButton.UseVisualStyleBackColor = true;
            this.DisplayInfoButton.Click += new System.EventHandler(this.DisplayInfoButton_Click);
            // 
            // EmployeePosition
            // 
            this.EmployeePosition.AutoSize = true;
            this.EmployeePosition.Location = new System.Drawing.Point(12, 133);
            this.EmployeePosition.Name = "EmployeePosition";
            this.EmployeePosition.Size = new System.Drawing.Size(58, 17);
            this.EmployeePosition.TabIndex = 16;
            this.EmployeePosition.Text = "Position";
            // 
            // DepartmentLabel
            // 
            this.DepartmentLabel.AutoSize = true;
            this.DepartmentLabel.Location = new System.Drawing.Point(12, 91);
            this.DepartmentLabel.Name = "DepartmentLabel";
            this.DepartmentLabel.Size = new System.Drawing.Size(82, 17);
            this.DepartmentLabel.TabIndex = 15;
            this.DepartmentLabel.Text = "Department";
            // 
            // EmployeeIDNumberLabel
            // 
            this.EmployeeIDNumberLabel.AutoSize = true;
            this.EmployeeIDNumberLabel.Location = new System.Drawing.Point(12, 50);
            this.EmployeeIDNumberLabel.Name = "EmployeeIDNumberLabel";
            this.EmployeeIDNumberLabel.Size = new System.Drawing.Size(75, 17);
            this.EmployeeIDNumberLabel.TabIndex = 14;
            this.EmployeeIDNumberLabel.Text = "ID Number";
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(12, 9);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(111, 17);
            this.EmployeeNameLabel.TabIndex = 13;
            this.EmployeeNameLabel.Text = "Employee Name";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(169, 162);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(61, 30);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 332);
            this.Controls.Add(this.employeeInfoTextBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(this.departmentTextBox);
            this.Controls.Add(this.idNumberTextBox);
            this.Controls.Add(this.employeeNameTextBox);
            this.Controls.Add(this.DisplayInfoButton);
            this.Controls.Add(this.EmployeePosition);
            this.Controls.Add(this.DepartmentLabel);
            this.Controls.Add(this.EmployeeIDNumberLabel);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Controls.Add(this.ExitButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox employeeInfoTextBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.TextBox idNumberTextBox;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.Button DisplayInfoButton;
        private System.Windows.Forms.Label EmployeePosition;
        private System.Windows.Forms.Label DepartmentLabel;
        private System.Windows.Forms.Label EmployeeIDNumberLabel;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.Button ExitButton;
    }
}

