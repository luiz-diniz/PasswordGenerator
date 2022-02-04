
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
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
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
            this.gpPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpOptions
            // 
            this.gpOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpOptions.Controls.Add(this.txtQuantity);
            this.gpOptions.Controls.Add(this.lblQuantity);
            this.gpOptions.Controls.Add(this.lblPasswordSize);
            this.gpOptions.Controls.Add(this.txtPasswordSize);
            this.gpOptions.Controls.Add(this.cbLowercase);
            this.gpOptions.Controls.Add(this.cbUppercase);
            this.gpOptions.Controls.Add(this.cbSpecialCharacters);
            this.gpOptions.Controls.Add(this.cbNumber);
            this.gpOptions.Location = new System.Drawing.Point(12, 12);
            this.gpOptions.Name = "gpOptions";
            this.gpOptions.Size = new System.Drawing.Size(431, 231);
            this.gpOptions.TabIndex = 0;
            this.gpOptions.TabStop = false;
            this.gpOptions.Text = "Options";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(10, 191);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(63, 23);
            this.txtQuantity.TabIndex = 10;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(7, 173);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(111, 15);
            this.lblQuantity.TabIndex = 11;
            this.lblQuantity.Text = "Passwords Quantity";
            // 
            // lblPasswordSize
            // 
            this.lblPasswordSize.AutoSize = true;
            this.lblPasswordSize.Location = new System.Drawing.Point(7, 125);
            this.lblPasswordSize.Name = "lblPasswordSize";
            this.lblPasswordSize.Size = new System.Drawing.Size(80, 15);
            this.lblPasswordSize.TabIndex = 5;
            this.lblPasswordSize.Text = "Password Size";
            // 
            // txtPasswordSize
            // 
            this.txtPasswordSize.Location = new System.Drawing.Point(10, 143);
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
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(8, 22);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPassword.Size = new System.Drawing.Size(231, 90);
            this.txtPassword.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(245, 86);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(180, 26);
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
            this.gpPassword.Location = new System.Drawing.Point(12, 249);
            this.gpPassword.Name = "gpPassword";
            this.gpPassword.Size = new System.Drawing.Size(431, 128);
            this.gpPassword.TabIndex = 3;
            this.gpPassword.TabStop = false;
            this.gpPassword.Text = "Password";
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(245, 54);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(82, 26);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 389);
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
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
    }
}

