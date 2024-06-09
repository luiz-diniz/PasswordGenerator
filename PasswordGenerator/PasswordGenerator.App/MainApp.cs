using PasswordGenerator.Core;
using PasswordGenerator.Core.Interfaces;
using PasswordGenerator.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator.App
{
    public partial class MainApp : Form
    {
        private IPasswordGenerator _passwordGenerator;

        public MainApp()
        {
            InitializeComponent();
            InitializeControllers();

            _passwordGenerator = new Core.PasswordGenerator(new StringGenerator());
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GeneratePassword();
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtPassword.Text);
        }

        public void InitializeControllers()
        {
            btnCopy.Enabled = false;
        }

        private void GeneratePassword()
        {
            try
            {
                var passwordOptions = FillPasswordOptions();

                var password = _passwordGenerator.GeneratePasswords(passwordOptions);

                FillTextBox(password);
                btnCopy.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error generating password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private PasswordOptions FillPasswordOptions()
        {
            var passwordOptions = new PasswordOptions();

            passwordOptions.Size = Convert.ToInt32(txtPasswordSize.Text);
            passwordOptions.Numbers = cbNumber.Checked;
            passwordOptions.SpecialCharacters = cbSpecialCharacters.Checked;
            passwordOptions.UpperCaseCharacters = cbUppercase.Checked;
            passwordOptions.LowerCaseCharacters = cbLowercase.Checked;
            passwordOptions.Quantity = Convert.ToInt32(txtQuantity.Text);

            return passwordOptions;
        }

        private void FillTextBox(IEnumerable<string> passwords)
        {
            txtPassword.Text = string.Empty;

            var builder = new StringBuilder();

            foreach (var password in passwords)
            {
                builder.AppendLine($"{password}");
                builder.AppendLine();
            }

            txtPassword.Text = builder.ToString();
        }
    }
}
