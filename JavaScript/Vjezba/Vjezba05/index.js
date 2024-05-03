// checked property

const myCheckBox = document.getElementById("myCheckBox");
const visaBtn = document.getElementById("visaBtn");
const mastercardBtn = document.getElementById("mastercardBtn");
const payPalBtn = document.getElementById("payPalBtn");
const mySubmit = document.getElementById("mySubmit");
const subResault = document.getElementById("subResault");
const paymentResault = document.getElementById("paymentResault");

mySubmit.onclick = function(){
    if(myCheckBox.checked){
        subResault.textContent  = "You are subscribed!";
    }
    else{
        subResault.textContent = "You are not subscribed!";
    }

    if(visaBtn.checked){
        paymentResault.textContent = "You are paying with Visa!";
    }
    else if(mastercardBtn.checked){
        paymentResault.textContent = "You are paying with Mastercard";
    }
    else if(payPalBtn.checked){
        paymentResault.textContent = "You are paying with PayPal!";
    }
    else{
        paymentResault.textContent = "You must select payment type!";
    }
}
