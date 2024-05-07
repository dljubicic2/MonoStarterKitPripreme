// While petlja

// Primjer: 1
/*
let username = "";

while(username === ""){  // Beskonaćna petlja
    console.log("You didn't enter your username! ");
}

console.log(`Hello ${username}`);
*/

// Primjer: 2
/*
let username = "";

while(username === ""){  
    username = window.prompt("Enter your username: ");
}

console.log(`Hello ${username}`);
*/

// Primjer: 3
/*
let username = "";

while(username === "" || username === null){
    username = window.prompt("Enter your username: ");
}

console.group(`Hello ${username}`);
*/


// Primjer: 4  Do While petlja
/*
let username;

do{
    username = window.prompt("Enter your username: ");
}while(username === "" || username === null)

console.log(`Hello ${username}`);
*/

// Primjer: 5


let loggedin = false;
let username;
let password;

/*
while(!loggedin){
    username = window.prompt("Enter your username: ");
    password = window.prompt("Enter your password");

    if(username === "myUsername" && password === "myPasword"){
        loggedin = true;

        console.log("You are logged in! ");
    }else{
        console.log("Invalid, please try again! ");
    }
}
*/

do{
    username = window.prompt("Enter your username: ");
    password = window.prompt("Enter your password");

    if(username === "myUsername" && password === "myPassword"){
        loggedin = true;

        console.log("You are logged in! ");
    }else{
        console.log("Invalid, please try again! ");
    }
}while(!loggedin)


    // For petlja

    // Primjer: 1

    for(let i = 0; i <= 2; i++){
        console.log("Hello world");
    }

    for(let i = 2; i <= 10; i+=2){   // Možemo inkrementirati više od 1 
        console.log("Hello world");
    }

    // Primjer: 2

    for(let i = 10; i > 0; i--){
        console.log(i);
    }

    console.log("Hello World");

    // Primjer: 3 // Continue and break

    for(let i = 1; i <= 20; i++ ){
        if(i == 13){
            continue;
        }else{
            console.log(i);
        }
        
    }

    for(let i = 1; i <= 20; i++ ){
        if(i == 13){
            break;
        }else{
            console.log(i);
        }
        
    }

