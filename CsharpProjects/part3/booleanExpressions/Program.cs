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

// refactor to if else to switch 
// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch(product[0])
{
    case "01":
    type = "Sweat shirt";
    break;
    case "02":
    type =  "T-Shirt";
    break;
    case "03":
    type = "Sweat pants";
    break;
    default:
    type = "Other";
    break;
}

switch(product[1])
{
    case "BL":
    color = "Black";
    break;
    case "MN":
    color = "Maroon";
    break;
    default:
    color = "White";
    break;
}

switch(product[2]){
    case "S":
    size = "Small";
    break;
    case "M":
    size = "Large";
    break;
    default: 
    size = "One Size Fits All";
    break;
}



Console.WriteLine($"Product: {size} {color} {type}");




