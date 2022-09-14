const generateButton = document.getElementById('generate');
const numbersCheckBox = document.getElementById('numbers');
const specialCharactersCheckBox = document.getElementById('specialCharacters');
const upperCaseLettersCheckBox = document.getElementById('upperCaseLetters');
const lowerCaseLettersCheckBox = document.getElementById('lowerCaseLetters');
const passwordSizeTextInput = document.getElementById('passwordSize');
const passwordQuantityTextInput = document.getElementById('passwordQuantity');
const passwordsResultTextArea = document.getElementById('passwordsResult');
//const loading = document.querySelector('.loading-gif');


function ControlButton(){
    if((numbersCheckBox.checked ||
       specialCharactersCheckBox.checked ||
       upperCaseLettersCheckBox.checked ||
       lowerCaseLettersCheckBox.checked) &&
       passwordSizeTextInput.value > 0 && 
       passwordQuantityTextInput.value > 0)
    {
        generateButton.disabled = false;
    }
    else
    {
        generateButton.disabled = true;
    }
}

function CallPasswordGenerator(e){

    //loading.style.display = 'block';

    var passwordOptions = new PasswordOptions(
        passwordSizeTextInput.value, 
        numbersCheckBox.checked,
        specialCharactersCheckBox.checked,
        upperCaseLettersCheckBox.checked,
        lowerCaseLettersCheckBox.checked,
        passwordQuantityTextInput.value );

    var jsonPassswordOptions = JSON.stringify(passwordOptions);

    const xhr = new XMLHttpRequest();

    xhr.open('POST', 'myapi', true);

    xhr.setRequestHeader("Content-Type", "application/json");

    xhr.onreadystatechange = function () {
        if (xhr.readyState === 4 && xhr.status === 200) 
        {
            var json = JSON.parse(xhr.responseText);
            PopulatePasswordResultTextArea(json);
        }
        else
        {
            passwordsResultTextArea.value = 'Error obtaining password(s).';   
        }

        //loading.style.display = 'none';   
    };

    xhr.send(jsonPassswordOptions);
}

function PopulatePasswordResultTextArea(passwords){
    passwordsResultTextArea.value = '';

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