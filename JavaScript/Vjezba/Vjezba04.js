// IF, else and else IF statement

// Primjer: 1

/*
let age = 13;

if(age >= 18){
    console.log("You are old enough to enter this site");
}
else{
    console.log("You are not old enouhg to enter this site");
}
*/

/*
let time = 14;

if(time < 12){
    console.log("Good morning!");
}
else{
    console.log("Good afternoon!")
}
*/

// Primjer: 2 bool vrijednosti

/*
let isStudent = false;

if(isStudent){
    console.log("You are a student!");
}
else{
    console.log("You are not a student!");
}
*/

// Primjer: 3 ugnjeđivanje 

/*
let age = 18;
let hasLicence = true;

if(age >= 18){
    console.log("You are old enough to drive");

    if(hasLicence){
        console.log("You have your licence");
    }
    else{
        console.log("You do not have your licence yet!");
    }
}
else{
    console.log("You must have atleast 18 years to have licence");
}
*/

let age = 0;

if(age >= 100){
    console.log("You are to old to enter this site!");
}
else if(age == 0){
    console.log("You can't enter you were just born");
}
else if(age >= 18){
    console.log("You are old enough to enter this site");
}
else if(age < 0){
    console.log("Your age can't be below 0");
}

else{
    console.log("You are not old enough to enter this site");
}