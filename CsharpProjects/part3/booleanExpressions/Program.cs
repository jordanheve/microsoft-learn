//Code challenge: write code to display the result of a coin flip
 

Random coinFlip = new Random();

int flip = coinFlip.Next(1,3);

Console.WriteLine( flip == 2 ? "Heads" : "Tails");
