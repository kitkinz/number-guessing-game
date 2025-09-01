Random random = new Random();
int randomNum = random.Next(1, 101);

var difficulties = new Dictionary<string, int>
{
    { "easy", 10 },
    { "medium", 5 },
    { "hard", 3 },
};

Console.WriteLine("Welcome to the Number Guessing Game!");
Console.WriteLine("I'm thinking of a number between 1 and 100.");
Console.WriteLine();
Console.WriteLine("Please select the difficulty level:");
Console.WriteLine("1. Easy (10 chances)");
Console.WriteLine("2. Medium (5 chances)");
Console.WriteLine("3. Hard (3 chances)");
Console.WriteLine();
Console.Write("Enter your choice (1-3): ");

string? difficulty;

// do-while loop for getting difficulty level
do
{
    string? userInput = Console.ReadLine()?.Trim();
    difficulty = userInput switch
    {
        "1" => "easy",
        "2" => "medium",
        "3" => "hard",
        _ => null
    };

    if (difficulty == null)
    {
        Console.Write("Invalid choice. Please choose between 1-3: ");
    }
} while (difficulty == null);

int chances = difficulties[difficulty];
Console.WriteLine();
Console.WriteLine($"Great! You have selected the {difficulty} difficulty level.");
Console.WriteLine("Let's start the game!");
Console.WriteLine();

bool guessedCorrectly = false;

for (int attempts = 0; attempts < chances;)
{

    Console.WriteLine("Enter your guess (1-100): ");
    string? guessInput = Console.ReadLine()?.Trim();

    if (string.IsNullOrWhiteSpace(guessInput))
    {
        continue;
    }

    try
    {
        if (!int.TryParse(guessInput, out int guess))
        {
            throw new FormatException("That wasn't a valid number.");
        }

        if (guess > 100 || guess <= 0)
        {
            throw new ArgumentException("Please enter a number between 1-100.");
        }

        attempts++;

        if (guess == randomNum)
        {
            Console.WriteLine($"Congratulations! You guessed the correct number in {attempts} attempts.");
            guessedCorrectly = true;
            break;
        }

        string hint = randomNum > guess ? "greater" : "less";
        Console.WriteLine($"Incorrect! The number is {hint} than {guess}");
        Console.WriteLine();
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine($"Invalid input. {ex.Message}");
    }
    catch (FormatException ex)
    {
        Console.WriteLine($"Invalid input. {ex.Message}");
    }
}

if (!guessedCorrectly)
{
    Console.WriteLine($"You've used all your chances. The number was {randomNum}.");
}