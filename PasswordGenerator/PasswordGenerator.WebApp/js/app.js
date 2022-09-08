var generateButton = document.getElementById('generate');
var numbersCheckBox = document.getElementById('numbers');
var specialCharactersCheckBox = document.getElementById('specialCharacters');
var upperCaseLettersCheckBox = document.getElementById('upperCaseLetters');
var lowerCaseLettersCheckBox = document.getElementById('lowerCaseLetters');
var passwordSizeTextInput = document.getElementById('passwordSize');
var passwordQuantityTextInput = document.getElementById('passwordQuantity');


function ControlButton(){
    console.log(passwordSizeTextInput.value);
    console.log(passwordQuantityTextInput.value);
    console.log(passwordSizeTextInput.value);
    console.log(passwordQuantityTextInput.value);

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