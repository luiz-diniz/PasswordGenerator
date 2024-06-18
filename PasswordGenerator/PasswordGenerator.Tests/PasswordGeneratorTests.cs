namespace PasswordGenerator.Tests;

public class PasswordGeneratorTests
{
    private readonly Mock<IStringGenerator> _stringGeneratorMock;

    public PasswordGeneratorTests()
    {
        _stringGeneratorMock = new Mock<IStringGenerator>(MockBehavior.Strict);
    }

    #region Input Validations

    [Fact]
    public void GeneratePasswords_PasswordsOptionsNull_Test()
    {
        var instance = GetInstance();

        Assert.Throws<ArgumentNullException>(() => instance.GeneratePasswords(null));
    }

    [Fact]
    public void GeneratePasswords_NegativeQuantity_Test()
    {
        var passwordOptions = new PasswordOptions
        {
            Quantity = -1
        };

        var instance = GetInstance();

        Assert.Throws<ArgumentOutOfRangeException>(() => instance.GeneratePasswords(passwordOptions));
    }

    [Fact]
    public void GeneratePasswords_OverMaxQuantity_Test()
    {
        var passwordOptions = new PasswordOptions
        {
            Quantity = 101
        };

        var instance = GetInstance();

        Assert.Throws<ArgumentOutOfRangeException>(() => instance.GeneratePasswords(passwordOptions));
    }

    [Fact]
    public void GeneratePasswords_NegativeSize_Test()
    {
        var passwordOptions = new PasswordOptions
        {
            Quantity = 1,
            Size = -1
        };

        var instance = GetInstance();

        Assert.Throws<ArgumentOutOfRangeException>(() => instance.GeneratePasswords(passwordOptions));
    }

    [Fact]
    public void GeneratePasswords_OverMaxSize_Test()
    {
        var passwordOptions = new PasswordOptions
        {
            Quantity = 1,
            Size = 101
        };

        var instance = GetInstance();

        Assert.Throws<ArgumentOutOfRangeException>(() => instance.GeneratePasswords(passwordOptions));
    }

    [Fact]
    public void GeneratePassword_AllOptionsFalse_Test()
    {
        var passwordOptions = new PasswordOptions
        {
            Quantity = 1,
            Size = 10,
            Numbers = false,
            LowerCaseCharacters = false,
            UpperCaseCharacters = false,
            SpecialCharacters = false
        };

        var instance = GetInstance();

        Assert.Throws<InvalidCharactersOptionsSelected>(() => instance.GeneratePasswords(passwordOptions));
    }

    #endregion

    #region Quantity and Size Validations

    [Fact]
    public void GeneratePassword_QuantityOne_SizeTen_Test()
    {
        var passwordOptions = new PasswordOptions
        {
            Quantity = 1,
            Size = 10,
            Numbers = true,
            SpecialCharacters = true,
            LowerCaseCharacters = true,
            UpperCaseCharacters = true
        };

        _stringGeneratorMock.SetupProperty(x => x.StringSize, passwordOptions.Size);

        _stringGeneratorMock.Setup(x => x.GenerateStringNumbers()).Returns("0123456789");
        _stringGeneratorMock.Setup(x => x.GenerateString(33, 43)).Returns("!&$&$%)+!!");
        _stringGeneratorMock.Setup(x => x.GenerateString(65, 90)).Returns("ABCDEFGHIJ");
        _stringGeneratorMock.Setup(x => x.GenerateString(97, 122)).Returns("abcdefghij");

        var instance = GetInstance();

        var passwords = instance.GeneratePasswords(passwordOptions).ToArray();               

        Assert.Single(passwords);
        Assert.Equal(10, passwords[0].Length);
    }

    [Fact]
    public void GeneratePassword_QuantityTwo_SizeTen_Test()
    {
        var passwordOptions = new PasswordOptions
        {
            Quantity = 2,
            Size = 10,
            Numbers = true,
            SpecialCharacters = true,
            LowerCaseCharacters = true,
            UpperCaseCharacters = true
        };

        _stringGeneratorMock.SetupProperty(x => x.StringSize, passwordOptions.Size);

        _stringGeneratorMock.Setup(x => x.GenerateStringNumbers()).Returns("0123456789");
        _stringGeneratorMock.Setup(x => x.GenerateString(33, 43)).Returns("!&$&$%)+!!");
        _stringGeneratorMock.Setup(x => x.GenerateString(65, 90)).Returns("ABCDEFGHIJ");
        _stringGeneratorMock.Setup(x => x.GenerateString(97, 122)).Returns("abcdefghij");

        var instance = GetInstance();

        var passwords = instance.GeneratePasswords(passwordOptions).ToArray();

        Assert.Equal(2, passwords.Length);

        foreach (var password in passwords)
            Assert.Equal(10, password.Length);

        VerifyMocks();
    }

    #endregion    

    private void VerifyMocks()
    {
        _stringGeneratorMock.VerifyAll();
    }

    private Core.PasswordGenerator GetInstance()
    {
        return new Core.PasswordGenerator(_stringGeneratorMock.Object);
    }
}