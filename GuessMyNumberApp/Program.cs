Random random = new Random();
int randomNumber = random.Next(1, 11);
Console.WriteLine("Guess my number between 1 and 10");

int score = 0;
int userGuess = 0;

while (userGuess != randomNumber)
{
    userGuess = int.Parse(Console.ReadLine());
    if (userGuess < randomNumber)
    {
        Console.WriteLine("Too low. Try again!");
        
        score++;
    } else if (userGuess > randomNumber)
    {
        Console.WriteLine("Too high. Try again!");
        score++;
    }
    else
    {
        Console.WriteLine($"You guessed it! The Number was {randomNumber} :-) \nYour score is: {score}");
    }




}
Console.ReadKey();
