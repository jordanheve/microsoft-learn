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