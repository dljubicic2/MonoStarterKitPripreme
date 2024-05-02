let age;

const myText  = document.getElementById("myText");
const myBtn = document.getElementById("myBtn");
const myResault = document.getElementById("resaultElement");

myBtn.onclick = function() {
    age = myText.value;
    age = Number(age);

    if(age >= 100){
        myResault.textContent = `You are to old to enter this site!`;
    }
    else if(age == 0){
        myResault.textContent = `You can't enter this site, you were just born!`;
    }
    else if(age >= 18){
        myResault.textContent = `You are old enough to enter this site!`;
    }
    else if(age < 0){
        myResault.textContent = `You can't enter this site, you are not born yet!`;
    }
    else{
        myResault.textContent = `You must be atleast 18+ years old to enter this site!`;
    }
}



