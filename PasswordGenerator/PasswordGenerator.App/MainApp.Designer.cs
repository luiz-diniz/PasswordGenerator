
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
            gpOptions = new System.Windows.Forms.GroupBox();
            txtQuantity = new System.Windows.Forms.TextBox();
            lblQuantity = new System.Windows.Forms.Label();
            lblPasswordSize = new System.Windows.Forms.Label();
            txtPasswordSize = new System.Windows.Forms.TextBox();
            cbLowercase = new System.Windows.Forms.CheckBox();
            cbUppercase = new System.Windows.Forms.CheckBox();
            cbSpecialCharacters = new System.Windows.Forms.CheckBox();
            cbNumber = new System.Windows.Forms.CheckBox();
            txtPassword = new System.Windows.Forms.TextBox();
            btnGenerate = new System.Windows.Forms.Button();
            gpPassword = new System.Windows.Forms.GroupBox();
            btnCopy = new System.Windows.Forms.Button();
            gpOptions.SuspendLayout();
            gpPassword.SuspendLayout();
            SuspendLayout();
            // 
            // gpOptions
            // 
            gpOptions.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            gpOptions.Controls.Add(txtQuantity);
            gpOptions.Controls.Add(lblQuantity);
            gpOptions.Controls.Add(lblPasswordSize);
            gpOptions.Controls.Add(txtPasswordSize);
            gpOptions.Controls.Add(cbLowercase);
            gpOptions.Controls.Add(cbUppercase);
            gpOptions.Controls.Add(cbSpecialCharacters);
            gpOptions.Controls.Add(cbNumber);
            gpOptions.Location = new System.Drawing.Point(12, 12);
            gpOptions.Name = "gpOptions";
            gpOptions.Size = new System.Drawing.Size(431, 231);
            gpOptions.TabIndex = 0;
            gpOptions.TabStop = false;
            gpOptions.Text = "Options";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new System.Drawing.Point(10, 191);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new System.Drawing.Size(63, 23);
            txtQuantity.TabIndex = 10;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new System.Drawing.Point(7, 173);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new System.Drawing.Size(111, 15);
            lblQuantity.TabIndex = 11;
            lblQuantity.Text = "Passwords Quantity";
            // 
            // lblPasswordSize
            // 
            lblPasswordSize.AutoSize = true;
            lblPasswordSize.Location = new System.Drawing.Point(7, 125);
            lblPasswordSize.Name = "lblPasswordSize";
            lblPasswordSize.Size = new System.Drawing.Size(80, 15);
            lblPasswordSize.TabIndex = 5;
            lblPasswordSize.Text = "Password Size";
            // 
            // txtPasswordSize
            // 
            txtPasswordSize.Location = new System.Drawing.Point(10, 143);
            txtPasswordSize.Name = "txtPasswordSize";
            txtPasswordSize.Size = new System.Drawing.Size(63, 23);
            txtPasswordSize.TabIndex = 4;
            txtPasswordSize.TextChanged += txtPasswordSize_TextChanged;
            // 
            // cbLowercase
            // 
            cbLowercase.AutoSize = true;
            cbLowercase.Location = new System.Drawing.Point(7, 98);
            cbLowercase.Name = "cbLowercase";
            cbLowercase.Size = new System.Drawing.Size(140, 19);
            cbLowercase.TabIndex = 3;
            cbLowercase.Text = "Lowercase Characters";
            cbLowercase.UseVisualStyleBackColor = true;
            cbLowercase.CheckedChanged += cbLowercase_CheckedChanged;
            // 
            // cbUppercase
            // 
            cbUppercase.AutoSize = true;
            cbUppercase.Location = new System.Drawing.Point(7, 73);
            cbUppercase.Name = "cbUppercase";
            cbUppercase.Size = new System.Drawing.Size(140, 19);
            cbUppercase.TabIndex = 2;
            cbUppercase.Text = "Uppercase Characters";
            cbUppercase.UseVisualStyleBackColor = true;
            cbUppercase.CheckedChanged += cbUppercase_CheckedChanged;
            // 
            // cbSpecialCharacters
            // 
            cbSpecialCharacters.AutoSize = true;
            cbSpecialCharacters.Location = new System.Drawing.Point(7, 48);
            cbSpecialCharacters.Name = "cbSpecialCharacters";
            cbSpecialCharacters.Size = new System.Drawing.Size(122, 19);
            cbSpecialCharacters.TabIndex = 1;
            cbSpecialCharacters.Text = "Special Characters";
            cbSpecialCharacters.UseVisualStyleBackColor = true;
            cbSpecialCharacters.CheckedChanged += cbSpecialCharacters_CheckedChanged;
            // 
            // cbNumber
            // 
            cbNumber.AutoSize = true;
            cbNumber.Location = new System.Drawing.Point(7, 23);
            cbNumber.Name = "cbNumber";
            cbNumber.Size = new System.Drawing.Size(75, 19);
            cbNumber.TabIndex = 0;
            cbNumber.Text = "Numbers";
            cbNumber.UseVisualStyleBackColor = true;
            cbNumber.CheckedChanged += cbNumber_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            txtPassword.Font = new System.Drawing.Font("Segoe UI", 8F);
            txtPassword.Location = new System.Drawing.Point(8, 22);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = true;
            txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtPassword.Size = new System.Drawing.Size(231, 90);
            txtPassword.TabIndex = 0;
            // 
            // btnGenerate
            // 
            btnGenerate.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnGenerate.Location = new System.Drawing.Point(245, 86);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new System.Drawing.Size(180, 26);
            btnGenerate.TabIndex = 2;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // gpPassword
            // 
            gpPassword.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            gpPassword.Controls.Add(btnCopy);
            gpPassword.Controls.Add(txtPassword);
            gpPassword.Controls.Add(btnGenerate);
            gpPassword.Location = new System.Drawing.Point(12, 249);
            gpPassword.Name = "gpPassword";
            gpPassword.Size = new System.Drawing.Size(431, 128);
            gpPassword.TabIndex = 3;
            gpPassword.TabStop = false;
            gpPassword.Text = "Password";
            // 
            // btnCopy
            // 
            btnCopy.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnCopy.Location = new System.Drawing.Point(245, 54);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new System.Drawing.Size(82, 26);
            btnCopy.TabIndex = 1;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // MainApp
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(455, 389);
            Controls.Add(gpPassword);
            Controls.Add(gpOptions);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainApp";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "PasswordGenerator";
            gpOptions.ResumeLayout(false);
            gpOptions.PerformLayout();
            gpPassword.ResumeLayout(false);
            gpPassword.PerformLayout();
            ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
    }
}

