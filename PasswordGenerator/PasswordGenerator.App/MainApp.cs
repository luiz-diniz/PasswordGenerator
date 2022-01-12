using PasswordGenerator.Core;
using PasswordGenerator.Models;
using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace PasswordGenerator.App
{
    public partial class MainApp : Form
    {
        private IPasswordGeneratorManager _passwordGenerator;

        public MainApp()
        {
            InitializeComponent();
            InitializeControllers();

            _passwordGenerator = new PasswordGeneratorManager();
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
                if (ValidateUserInput())
                {
                    var passwordOptions = FillPasswordOptions();

                    var password = _passwordGenerator.GeneratePassword(passwordOptions);

                    FillTextBox(password);
                    btnCopy.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error generating password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateUserInput()
        {
            if (!cbNumber.Checked && !cbSpecialCharacters.Checked && !cbUppercase.Checked && !cbLowercase.Checked)
                throw new Exception("Select at least one option.");

            var output = 0;
            if (String.IsNullOrEmpty(txtPasswordSize.Text) || !int.TryParse(txtPasswordSize.Text, out output) || Convert.ToInt32(txtPasswordSize.Text) <= 0)
                throw new Exception("Invalid number input.\nPassword size must be higher than zero.");

            if(String.IsNullOrEmpty(txtQuantity.Text) || !int.TryParse(txtPasswordSize.Text, out output) || Convert.ToInt32(txtPasswordSize.Text) <= 0)
                throw new Exception("Invalid number input.\nQuantity must be higher than zero.");

            return true;
        }

        private PasswordOptions FillPasswordOptions()
        {
            var passwordOptions = new PasswordOptions();

            passwordOptions.Size = Convert.ToInt32(txtPasswordSize.Text);
            passwordOptions.Numbers = cbNumber.Checked;
            passwordOptions.SpecialCharacters = cbSpecialCharacters.Checked;
            passwordOptions.UpperCaseLetters = cbUppercase.Checked;
            passwordOptions.LowerCaseLetters = cbLowercase.Checked;
            passwordOptions.Quantity = Convert.ToInt32(txtQuantity.Text);

            return passwordOptions;
        }

        private void FillTextBox(string[] passwords)
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
