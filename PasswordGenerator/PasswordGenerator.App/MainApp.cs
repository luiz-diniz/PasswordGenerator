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

        private void btnGenerate_Click(object sender, System.EventArgs e)
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
                }
                else
                {
                    throw new Exception("Password size can't be less or equal to 0.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error generating password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private bool ValidateMaxSize()
        {
            var maxSize = Convert.ToInt32(txtMaxSize.Text);

            if (maxSize <= 0)
                return false;

            return true;
        }

        private PasswordOptions FillPasswordOptions()
        {
            var passwordOptions = new PasswordOptions();

            passwordOptions.MaxSize = Convert.ToInt32(txtMaxSize.Text);
            passwordOptions.Numbers = cbNumber.Checked;
            passwordOptions.SpecialCharacters = cbSpecialCharacters.Checked;
            passwordOptions.UpperCaseLetters = cbUppercase.Checked;
            passwordOptions.UpperCaseLetters = cbLowercase.Checked;

            return passwordOptions;
        }
    }
}
