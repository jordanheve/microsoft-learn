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
            Console.WriteLine("Success");
            validateEntry = true;
        }else{
            Console.WriteLine("Please enter a number between 5 and 10");
        }
    }else 
    {
        Console.WriteLine("Please enter a valid number");
    }

}while(!validateEntry);