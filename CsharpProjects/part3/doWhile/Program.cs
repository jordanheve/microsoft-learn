Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);

/*
while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
*/

Console.WriteLine("--------------");

//Code challenge - write code to implement the game rules

// You must use either the do-while statement or the while statement as an outer game loop.
// The hero and the monster start with 10 health points.
// All attacks are a value between 1 and 10.
// The hero attacks first.
// Print the amount of health the monster lost and their remaining health.
// If the monster's health is greater than 0, it can attack the hero.
// Print the amount of health the hero lost and their remaining health.
// Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
// Print the winner.

int heroHealth = 10;
int monsterHealth = 10;
do
{
    int heroAttack = random.Next(1, 11);
    int monsterAttack = random.Next(1, 11);

    monsterHealth -= heroAttack;

    Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {monsterHealth} health.");

    if(monsterHealth <= 0) continue;

    heroHealth -= monsterAttack;

    Console.WriteLine($"Hero was damaged and lost {monsterAttack} and nos has {heroHealth} health.");

}while(heroHealth > 0 && monsterHealth > 0);

string winner = heroHealth > 0 ? "Hero" : "Monster";

Console.WriteLine($"{winner} wins!");
