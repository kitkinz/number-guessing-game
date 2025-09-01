Random random = new Random();
int randomNum = random.Next(1, 101);
var difficulties = new Dictionary<string, int>
{
    { "easy", 10 },
    { "medium", 5 },
    { "hard", 3 },
};
int chances;

Console.WriteLine("Welcome to the Number Guessing Game!");
Console.WriteLine("I'm thinking of a number between 1 and 100.");
Console.WriteLine();
Console.WriteLine("Please select the difficulty level:");
Console.WriteLine("1. Easy (10 chances)");
Console.WriteLine("2. Medium (5 chances)");
Console.WriteLine("3. Hard (3 chances)");
Console.WriteLine();
Console.Write("Enter your choice (1-3): ");

do
{
    string? userInput = Console.ReadLine()?.Trim();

    string? difficulty = userInput switch
    {
        "1" => "easy",
        "2" => "medium",
        "3" => "hard",
        _ => null
    };

    if (difficulty == null)
    {
        Console.Write("Please choosed between 1-3: ");
        continue;
    }

    chances = difficulties[difficulty];
    Console.WriteLine();
    Console.WriteLine($"Great! You have selected the {difficulty} difficulty level.");
    Console.WriteLine("Let's start the game!");

    for (int validInput = 0; validInput < chances;)
    {
        try
        {
            Console.Write("Enter your guess: ");
            userInput = Console.ReadLine()?.Trim();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                continue;
            }

            if (int.TryParse(userInput, out int userGuess))
            {
                if (userGuess > 100 || userGuess <= 0)
                {
                    throw new ArgumentException("Please enter a number between 1-100.");
                }

                validInput++;

                if (userGuess == randomNum)
                {
                    Console.WriteLine($"Congratulations! You guessed the correct number in {validInput} attempts.");
                    break;
                }
                else
                {
                    string hint = randomNum > userGuess ? "greater" : "less";
                    Console.WriteLine($"Incorrect! The number is {hint} than {userGuess}");
                }
            }
            else
            {
                throw new FormatException("Please enter an integer.");
            }
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

    Console.WriteLine("You've run out of chances. Exiting the app...");
    break;
} while (true);