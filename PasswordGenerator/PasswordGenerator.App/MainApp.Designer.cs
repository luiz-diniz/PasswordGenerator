
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
            this.gpOptions = new System.Windows.Forms.GroupBox();
            this.lblMaxSize = new System.Windows.Forms.Label();
            this.txtMaxSize = new System.Windows.Forms.TextBox();
            this.cbLowercase = new System.Windows.Forms.CheckBox();
            this.cbUppercase = new System.Windows.Forms.CheckBox();
            this.cbSpecialCharacters = new System.Windows.Forms.CheckBox();
            this.cbNumber = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.gpPassword = new System.Windows.Forms.GroupBox();
            this.gpOptions.SuspendLayout();
            this.gpPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpOptions
            // 
            this.gpOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpOptions.Controls.Add(this.lblMaxSize);
            this.gpOptions.Controls.Add(this.txtMaxSize);
            this.gpOptions.Controls.Add(this.cbLowercase);
            this.gpOptions.Controls.Add(this.cbUppercase);
            this.gpOptions.Controls.Add(this.cbSpecialCharacters);
            this.gpOptions.Controls.Add(this.cbNumber);
            this.gpOptions.Location = new System.Drawing.Point(12, 12);
            this.gpOptions.Name = "gpOptions";
            this.gpOptions.Size = new System.Drawing.Size(395, 161);
            this.gpOptions.TabIndex = 0;
            this.gpOptions.TabStop = false;
            this.gpOptions.Text = "Options";
            // 
            // lblMaxSize
            // 
            this.lblMaxSize.AutoSize = true;
            this.lblMaxSize.Location = new System.Drawing.Point(46, 128);
            this.lblMaxSize.Name = "lblMaxSize";
            this.lblMaxSize.Size = new System.Drawing.Size(53, 15);
            this.lblMaxSize.TabIndex = 5;
            this.lblMaxSize.Text = "Max Size";
            // 
            // txtMaxSize
            // 
            this.txtMaxSize.Location = new System.Drawing.Point(7, 123);
            this.txtMaxSize.Name = "txtMaxSize";
            this.txtMaxSize.Size = new System.Drawing.Size(35, 23);
            this.txtMaxSize.TabIndex = 4;
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
            this.txtPassword.Size = new System.Drawing.Size(260, 23);
            this.txtPassword.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(281, 23);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(106, 25);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // gpPassword
            // 
            this.gpPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpPassword.Controls.Add(this.txtPassword);
            this.gpPassword.Controls.Add(this.btnGenerate);
            this.gpPassword.Location = new System.Drawing.Point(11, 179);
            this.gpPassword.Name = "gpPassword";
            this.gpPassword.Size = new System.Drawing.Size(396, 64);
            this.gpPassword.TabIndex = 3;
            this.gpPassword.TabStop = false;
            this.gpPassword.Text = "Password";
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 251);
            this.Controls.Add(this.gpPassword);
            this.Controls.Add(this.gpOptions);
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
        private System.Windows.Forms.Label lblMaxSize;
        private System.Windows.Forms.TextBox txtMaxSize;
        private System.Windows.Forms.CheckBox cbLowercase;
        private System.Windows.Forms.CheckBox cbUppercase;
        private System.Windows.Forms.CheckBox cbSpecialCharacters;
        private System.Windows.Forms.CheckBox cbNumber;
    }
}

