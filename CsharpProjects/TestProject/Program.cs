// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello C#!");

// declare a new isntance of the Random class
Random dice = new Random();

// invike the method to generate a random number between 1 and 6
int roll = dice.Next(1, 7);


Console.WriteLine(roll);


//Exercise - Return values and parameters of methods

int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

// Code challenge: Implement a method of the Math class that returns the larger of two numbers

int firstValue = 500;
int secondValue = 600;
int largerValue;

largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine("The higher value is "+largerValue);


// Add decision logic to your code using `if`, `else`, and `else if` statements in C#

int gameRoll1 = dice.Next(1, 7);
int gameRoll2 = dice.Next(1, 7);
int gameRoll3 = dice.Next(1, 7);

int total = gameRoll1 + gameRoll2 + gameRoll3;

Console.WriteLine($"Dice roll: {gameRoll1} + {gameRoll2} + {gameRoll3} = {total}");

if ((gameRoll1 == gameRoll2) || (gameRoll2 == gameRoll3) || (gameRoll1 == gameRoll3))
{
   if ((gameRoll1 == gameRoll2) && (gameRoll2 == gameRoll3)) 
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    }else{
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }

}

if (total >= 16)
{
    Console.WriteLine("You win! a new car!");
}
else if (total >= 10) {
    Console.WriteLine("You win a new gaming laptop!");
} 
else if ( total == 7)
{
    Console.WriteLine("You win a new pair of dice!");
}
else
{
    Console.WriteLine("Sorry, you lose.");
}    


