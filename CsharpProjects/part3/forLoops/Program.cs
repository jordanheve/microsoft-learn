// for loops

// inseat using foreach use for loop to iterate through the array
string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}

// foreach loops cant update values in the used array

// foreach (var name in names)
// {
//     Can't do this:
//     if (name == "David") name = "Sammy";
// }

Console.WriteLine("------ Other loop ------");

for (int i = 0; i < names.Length; i++)
    if (names[i] == "David") names[i] = "Sammy";


foreach(var name in names) Console.WriteLine(name);

// FizzBuzz Challenge

Console.WriteLine("---FizzBuzz challenge---");

// Output values from 1 to 100, one number per line, inside the code block of an iteration statement.
// When the current value is divisible by 3, print the term Fizz next to the number.
// When the current value is divisible by 5, print the term Buzz next to the number.
// When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number.

for(int i = 1; i <= 100; i++)
{   
    string message = $"{i}";

    if(i % 3 == 0 && i % 5 == 0)
         message += " - FizzBuzz";
    else if (i % 3 == 0)
        message += " - Fizz";
    else if (i % 5 == 0)
        message += " - Buzz";

    Console.WriteLine(message);    


}