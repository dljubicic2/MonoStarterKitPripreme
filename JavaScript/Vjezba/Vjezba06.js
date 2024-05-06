// Method chaining - jedna metoda poziva drugu metodu u jednoj liniji koda

// Bez method chaining

let username = window.prompt("Enter your username: ");
let letter;

username = username.trim();
letter = username.charAt(0);
letter = letter.toUpperCase();

let extraChars;

extraChars = username.slice(1);
extraChars = extraChars.toLowerCase();
username = letter + extraChars;

// Sa method chaining-om

username = username.trim().charAt(0).toUpperCase() + username.trim().slice(1).toLowerCase();

console.log(username);