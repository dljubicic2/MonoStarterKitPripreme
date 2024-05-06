// Aritmetički operatori

let students = 20;

/*students = students +1;
students = students -1;
students = students * 2;
students = students / 2;
students = students ** 2;
let extraStudents = students % 3; */

// Jednostavniji način

students += 3;
students -=3;
students *= 2;
students /= 2;
students **= 2;
students %= 2;

// Inkrement i dekrement

students++;
students--;

// Redoslije aritmetičkih operatora
    /*
    1. Zagrade ()
    2. Eksponenti
    3. Množenje, djeljenje i modulo
    4. Zbrajanje i oduzimanje
    */

let resault = 1 + 2 * 3 + 4 ** 2;
console.log(resault);

let resault2 = 12 % 5 + 8 / 2;
console.log(resault2);




// Logički operatori

// Primjer: 1 AND = &&

const temperature = -250;

if(temperature > 0 && temperature <=30){
    console.log("Weather is good!");
}
else {
    console.log("The weather is bad!");
}

// Primjer: 2 OR = ||

if(temperature <= 0 || temperature > 30){
    console.log("Weather is good!");
}
else {
    console.log("The weather is bad!");
}

// Primjer 3 NOT = !

const isSunny = false;

if(!isSunny){
    console.log("It is sunny!");
}
else{
    console.log("It is cloudy!");
}
