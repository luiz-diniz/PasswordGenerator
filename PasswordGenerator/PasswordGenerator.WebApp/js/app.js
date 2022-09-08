var generateButton = document.getElementById('generate');
var numbersCheckBox = document.getElementById('numbers');
var specialCharactersCheckBox = document.getElementById('specialCharacters');
var upperCaseLettersCheckBox = document.getElementById('upperCaseLetters');
var lowerCaseLettersCheckBox = document.getElementById('lowerCaseLetters');
var passwordSizeTextInput = document.getElementById('passwordSize');
var passwordQuantityTextInput = document.getElementById('passwordQuantity');
var passwordsResultTextArea = document.getElementById('passwordsResult');


function ControlButton(){
    if((numbersCheckBox.checked ||
       specialCharactersCheckBox.checked ||
       upperCaseLettersCheckBox.checked ||
       lowerCaseLettersCheckBox.checked) &&
       passwordSizeTextInput.value > 0 && 
       passwordQuantityTextInput.value > 0)
    {
        console.log('desabilitado');
        console.log(passwordSizeTextInput.value);

        generateButton.disabled = false;
    }
    else
    {
        console.log('habiltiado');

        generateButton.disabled = true;
    }
}

function CallPasswordGenerator(){
    var passwordOptions = new PasswordOptions(
        passwordSizeTextInput.value, 
        numbersCheckBox.checked,
        specialCharactersCheckBox.checked,
        upperCaseLettersCheckBox.checked,
        lowerCaseLettersCheckBox.checked,
        passwordQuantityTextInput.value );

    var jsonPassswordOptions = JSON.stringify(passwordOptions);

    const xhr = new XMLHttpRequest();

    xhr.open('POST', 'https://localhost:44304/api/passwordgenerator/generate', true);

    xhr.setRequestHeader("Content-Type", "application/json");

    xhr.onreadystatechange = function () {
        if (xhr.readyState === 4 && xhr.status === 200) {
            var json = JSON.parse(xhr.responseText);
            console.log(json);
            PopulatePasswordResultTextArea(json);
        }
    };

    xhr.send(jsonPassswordOptions);
}

function PopulatePasswordResultTextArea(passwords){
    passwords.forEach(password => {
        passwordsResultTextArea.value += password + '\n\n';
    });
}

class PasswordOptions{
    constructor(size, numbers, specialCharacters, upperCaseLetters, lowerCaseLetters, quantity){
        this.size = size;
        this.numbers = numbers;
        this.specialCharacters = specialCharacters;
        this.upperCaseLetters = upperCaseLetters;
        this.lowerCaseLetters = lowerCaseLetters;
        this.quantity = quantity;
    }
}