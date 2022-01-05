using PasswordGenerator.Core;
using PasswordGenerator.Models;
using System;
using System.Windows.Forms;

namespace PasswordGenerator.App
{
    public partial class MainApp : Form
    {
        private IPasswordGeneratorManager _passwordGenerator;

        public MainApp()
        {
            InitializeComponent();

            _passwordGenerator = new PasswordGeneratorManager();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Generate();
        }

        private void Generate()
        {
            try
            {
                if (ValidateMaxSize())
                {
                    var passwordOptions = FillPasswordOptions();

                    var password = _passwordGenerator.Generate(passwordOptions);

                    txtPassword.Text = password.ToString();
                }                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error generating password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private bool ValidateMaxSize()
        {
            if (String.IsNullOrEmpty(txtMaxSize.Text))
                throw new Exception("Invalid number input");

            if (!cbNumber.Checked && !cbSpecialCharacters.Checked && !cbUppercase.Checked && !cbLowercase.Checked)
                throw new Exception("Select at least one option");

            var maxSize = Convert.ToInt32(txtMaxSize.Text);

            if (maxSize <= 0)
                throw new Exception("Max size must be higher than zero.");

            return true;
        }

        private PasswordOptions FillPasswordOptions()
        {
            var passwordOptions = new PasswordOptions();

            passwordOptions.MaxSize = Convert.ToInt32(txtMaxSize.Text);
            passwordOptions.Numbers = cbNumber.Checked;
            passwordOptions.SpecialCharacters = cbSpecialCharacters.Checked;
            passwordOptions.UpperCaseLetters = cbUppercase.Checked;
            passwordOptions.LowerCaseLetters = cbLowercase.Checked;

            return passwordOptions;
        }
    }
}
