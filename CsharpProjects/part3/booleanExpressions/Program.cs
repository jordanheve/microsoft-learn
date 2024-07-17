//Code challenge: write code to display the result of a coin flip
 

Random coinFlip = new Random();

int flip = coinFlip.Next(1,3);

Console.WriteLine( flip == 2 ? "Heads" : "Tails");

//Permission and lavel values challenge

string permission = "Admin|Manager";
int level = 55;


if (permission.Contains("Admin")){
    if(level > 55)
        Console.WriteLine("Welcome, Super Admin user");
    else 
        Console.WriteLine("Welcome, Admin user");
} else if(permission.Contains("Manager")){
    if (level >= 20)
        Console.WriteLine("Contact an Admin for access");
    else 
        Console.WriteLine("You do not have sufficient privileges");
}

// Code challenge: update problematic code in the code editor
int[] numbers = [4, 8, 15, 16, 23, 42];
bool found = false;
int total = 0;
foreach (int number in numbers)
{

    total += number;

    if (number == 42)
    {
       found = true;

    }

}

if (found) 
{
    Console.WriteLine("Set contains 42");

}

Console.WriteLine($"Total: {total}");