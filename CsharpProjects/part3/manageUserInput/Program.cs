// string? readResult;
// bool validEntry = false;
// Console.WriteLine("Enter a string containing at least three characters:");
// do
// {
//     readResult = Console.ReadLine();
//     if (readResult != null)
//     {
//         if (readResult.Length >= 3)
//         {
//             validEntry = true;
//         }
//         else
//         {
//             Console.WriteLine("Your input is invalid, please try again.");
//         }
//     }
// } while (validEntry == false);

//Code project 1 - write code that validates integer input
// Your solution must include either a do-while or while iteration.

// Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.

// Inside the iteration block:

// Your solution must use a Console.ReadLine() statement to obtain input from the user.
// Your solution must ensure that the input is a valid representation of an integer.
// If the integer value isn't between 5 and 10, your code must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
// Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration.
// Below (after) the iteration code block: your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.

int numericValue = 0;
bool validNumber = false;
bool validateEntry = false;
string? entryResult;
Console.WriteLine("Enter a number between 5 and 10");
do 
{
    entryResult = Console.ReadLine();
    validNumber = int.TryParse(entryResult, out numericValue);
    if(validNumber)
    {
        if(numericValue >= 5 && numericValue <= 10 ){
            Console.WriteLine($"Your input value {numericValue} has been accepted\n");	
            validateEntry = true;
        }else{
            Console.WriteLine($"Please enter a number between 5 and 10, {numericValue} is not valid");
        }
    }else 
    {
        Console.WriteLine("Please enter a valid number");
    }

}while(!validateEntry);

// Code project 2 - write code that validates string input
// Your solution must include either a do-while or while iteration.

// Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for one of three role names: Administrator, Manager, or User.

// Inside the iteration block:

// Your solution must use a Console.ReadLine() statement to obtain input from the user.
// Your solution must ensure that the value entered matches one of the three role options.
// Your solution should use the Trim() method on the input value to ignore leading and trailing space characters.
// Your solution should use the ToLower() method on the input value to ignore case.
// If the value entered isn't a match for one of the role options, your code must use a Console.WriteLine() statement to prompt the user for a valid entry.
// Below (after) the iteration code block: Your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.
 
string? entryRole;
bool validRole = false;

do
{
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

    entryRole = Console.ReadLine();

    string role = entryRole?.Trim().ToLower() ?? string.Empty;

    if(role == "manager" ||  role == "administrator" || role == "user")
    {
        Console.WriteLine($"Your input value ({entryRole}) has been accepted");
        validRole = true;
    }else {
         Console.WriteLine($"The role name that you entered \"{entryRole}\" is not valid. Enter your role name (Administrator, Manager, or User)" );

    }
    
}while(!validRole);




