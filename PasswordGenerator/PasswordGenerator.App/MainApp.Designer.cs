
namespace PasswordGenerator.App
{
    partial class MainApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.gpOptions = new System.Windows.Forms.GroupBox();
            this.gpMultiple = new System.Windows.Forms.GroupBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblMultiplePath = new System.Windows.Forms.Label();
            this.btnPath = new System.Windows.Forms.Button();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.cbMultiplePasswords = new System.Windows.Forms.CheckBox();
            this.lblPasswordSize = new System.Windows.Forms.Label();
            this.txtPasswordSize = new System.Windows.Forms.TextBox();
            this.cbLowercase = new System.Windows.Forms.CheckBox();
            this.cbUppercase = new System.Windows.Forms.CheckBox();
            this.cbSpecialCharacters = new System.Windows.Forms.CheckBox();
            this.cbNumber = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.gpPassword = new System.Windows.Forms.GroupBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.gpOptions.SuspendLayout();
            this.gpMultiple.SuspendLayout();
            this.gpPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpOptions
            // 
            this.gpOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpOptions.Controls.Add(this.gpMultiple);
            this.gpOptions.Controls.Add(this.cbMultiplePasswords);
            this.gpOptions.Controls.Add(this.lblPasswordSize);
            this.gpOptions.Controls.Add(this.txtPasswordSize);
            this.gpOptions.Controls.Add(this.cbLowercase);
            this.gpOptions.Controls.Add(this.cbUppercase);
            this.gpOptions.Controls.Add(this.cbSpecialCharacters);
            this.gpOptions.Controls.Add(this.cbNumber);
            this.gpOptions.Location = new System.Drawing.Point(12, 12);
            this.gpOptions.Name = "gpOptions";
            this.gpOptions.Size = new System.Drawing.Size(538, 323);
            this.gpOptions.TabIndex = 0;
            this.gpOptions.TabStop = false;
            this.gpOptions.Text = "Options";
            // 
            // gpMultiple
            // 
            this.gpMultiple.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpMultiple.Controls.Add(this.txtQuantity);
            this.gpMultiple.Controls.Add(this.lblMultiplePath);
            this.gpMultiple.Controls.Add(this.btnPath);
            this.gpMultiple.Controls.Add(this.lblQuantity);
            this.gpMultiple.Controls.Add(this.txtPath);
            this.gpMultiple.Location = new System.Drawing.Point(7, 187);
            this.gpMultiple.Name = "gpMultiple";
            this.gpMultiple.Size = new System.Drawing.Size(525, 116);
            this.gpMultiple.TabIndex = 12;
            this.gpMultiple.TabStop = false;
            this.gpMultiple.Text = "Passwords Manager";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(11, 22);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(64, 23);
            this.txtQuantity.TabIndex = 10;
            // 
            // lblMultiplePath
            // 
            this.lblMultiplePath.AutoSize = true;
            this.lblMultiplePath.Location = new System.Drawing.Point(11, 63);
            this.lblMultiplePath.Name = "lblMultiplePath";
            this.lblMultiplePath.Size = new System.Drawing.Size(295, 15);
            this.lblMultiplePath.TabIndex = 7;
            this.lblMultiplePath.Text = "Output path to place the .txt containing the passwords";
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(310, 81);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(35, 23);
            this.btnPath.TabIndex = 9;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(81, 25);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(246, 15);
            this.lblQuantity.TabIndex = 11;
            this.lblQuantity.Text = "How many passwords you want to generate ?";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(11, 81);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(293, 23);
            this.txtPath.TabIndex = 8;
            // 
            // cbMultiplePasswords
            // 
            this.cbMultiplePasswords.AutoSize = true;
            this.cbMultiplePasswords.Location = new System.Drawing.Point(7, 158);
            this.cbMultiplePasswords.Name = "cbMultiplePasswords";
            this.cbMultiplePasswords.Size = new System.Drawing.Size(178, 19);
            this.cbMultiplePasswords.TabIndex = 6;
            this.cbMultiplePasswords.Text = "Generate Multiple Passwords";
            this.cbMultiplePasswords.UseVisualStyleBackColor = true;
            this.cbMultiplePasswords.CheckedChanged += new System.EventHandler(this.cbMultiplePasswords_CheckedChanged);
            // 
            // lblPasswordSize
            // 
            this.lblPasswordSize.AutoSize = true;
            this.lblPasswordSize.Location = new System.Drawing.Point(76, 126);
            this.lblPasswordSize.Name = "lblPasswordSize";
            this.lblPasswordSize.Size = new System.Drawing.Size(80, 15);
            this.lblPasswordSize.TabIndex = 5;
            this.lblPasswordSize.Text = "Password Size";
            // 
            // txtPasswordSize
            // 
            this.txtPasswordSize.Location = new System.Drawing.Point(7, 123);
            this.txtPasswordSize.Name = "txtPasswordSize";
            this.txtPasswordSize.Size = new System.Drawing.Size(63, 23);
            this.txtPasswordSize.TabIndex = 4;
            // 
            // cbLowercase
            // 
            this.cbLowercase.AutoSize = true;
            this.cbLowercase.Location = new System.Drawing.Point(7, 98);
            this.cbLowercase.Name = "cbLowercase";
            this.cbLowercase.Size = new System.Drawing.Size(140, 19);
            this.cbLowercase.TabIndex = 3;
            this.cbLowercase.Text = "Lowercase Characters";
            this.cbLowercase.UseVisualStyleBackColor = true;
            // 
            // cbUppercase
            // 
            this.cbUppercase.AutoSize = true;
            this.cbUppercase.Location = new System.Drawing.Point(7, 73);
            this.cbUppercase.Name = "cbUppercase";
            this.cbUppercase.Size = new System.Drawing.Size(140, 19);
            this.cbUppercase.TabIndex = 2;
            this.cbUppercase.Text = "Uppercase Characters";
            this.cbUppercase.UseVisualStyleBackColor = true;
            // 
            // cbSpecialCharacters
            // 
            this.cbSpecialCharacters.AutoSize = true;
            this.cbSpecialCharacters.Location = new System.Drawing.Point(7, 48);
            this.cbSpecialCharacters.Name = "cbSpecialCharacters";
            this.cbSpecialCharacters.Size = new System.Drawing.Size(122, 19);
            this.cbSpecialCharacters.TabIndex = 1;
            this.cbSpecialCharacters.Text = "Special Characters";
            this.cbSpecialCharacters.UseVisualStyleBackColor = true;
            // 
            // cbNumber
            // 
            this.cbNumber.AutoSize = true;
            this.cbNumber.Location = new System.Drawing.Point(7, 23);
            this.cbNumber.Name = "cbNumber";
            this.cbNumber.Size = new System.Drawing.Size(75, 19);
            this.cbNumber.TabIndex = 0;
            this.cbNumber.Text = "Numbers";
            this.cbNumber.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPassword.Location = new System.Drawing.Point(7, 23);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(231, 23);
            this.txtPassword.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(423, 22);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(109, 26);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // gpPassword
            // 
            this.gpPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpPassword.Controls.Add(this.btnCopy);
            this.gpPassword.Controls.Add(this.txtPassword);
            this.gpPassword.Controls.Add(this.btnGenerate);
            this.gpPassword.Location = new System.Drawing.Point(12, 341);
            this.gpPassword.Name = "gpPassword";
            this.gpPassword.Size = new System.Drawing.Size(538, 64);
            this.gpPassword.TabIndex = 3;
            this.gpPassword.TabStop = false;
            this.gpPassword.Text = "Password";
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(245, 22);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(172, 26);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 417);
            this.Controls.Add(this.gpPassword);
            this.Controls.Add(this.gpOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordGenerator";
            this.gpOptions.ResumeLayout(false);
            this.gpOptions.PerformLayout();
            this.gpMultiple.ResumeLayout(false);
            this.gpMultiple.PerformLayout();
            this.gpPassword.ResumeLayout(false);
            this.gpPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpOptions;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.GroupBox gpPassword;
        private System.Windows.Forms.Label lblPasswordSize;
        private System.Windows.Forms.TextBox txtPasswordSize;
        private System.Windows.Forms.CheckBox cbLowercase;
        private System.Windows.Forms.CheckBox cbUppercase;
        private System.Windows.Forms.CheckBox cbSpecialCharacters;
        private System.Windows.Forms.CheckBox cbNumber;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblMultiplePath;
        private System.Windows.Forms.CheckBox cbMultiplePasswords;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.GroupBox gpMultiple;
    }
}

