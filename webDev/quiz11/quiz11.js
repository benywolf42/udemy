// create secretNumber
var secretNumber = 4;

do  {
    var guess = prompt("Guess a number");
    
    if (guess > secretNumber)
        alert("Too high. Try again.");

    else if ( guess < secretNumber) 
        alert("Too low. Try again.");

} while (guess != secretNumber)

alert("You guessed right.")