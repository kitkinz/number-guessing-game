# Number Guessing Game Application
A simple command-line number guessing game built in C#. The computer randomly selects a number between 1 and 100,
and the user tries to guess it within a limited number of attempts based on the selected difficulty level.

[Project Task on Roadmap.sh](https://roadmap.sh/projects/number-guessing-game)

## How It Works
1. The game starts with a welcome message and displays the rules.
2. The computer randomly selects a number between 1 and 100.
3. The user selects a difficulty level:
    - Easy (10 chances)
    - Medium (5 chances)
    - Hard (3 chances)
4. The user makes guesses via the CLI.
5. After each guess:
    - If correct: Congratulatory message with attempt count
    - If incorrect: Hint whether the number is higher of lower
6. The game ends when the user:
    - Guesses the number correctly, or
    - Runs out of chances

## Installation
Follow these steps to run this application:
1. Clone this repository:
```
git clone https://github.com/kitkinz/expense-tracker.git
```
2. Navigate to the project directory:
```
cd ExpenseTracker
```
3. Restore dependencies:
```
dotnet restore
```
4. Build the project:
```
dotnet build
```
5. Run the app:
```
dotnet run
```

## Usage
### Example
```
Welcome to the Number Guessing Game!
I'm thinking of a number between 1 and 100.
You have 5 chances to guess the correct number.

Please select the difficulty level:
1. Easy (10 chances)
2. Medium (5 chances)
3. Hard (3 chances)

Enter your choice: 2

Great! You have selected the Medium difficulty level.
Let's start the game!

Enter your guess: 50
Incorrect! The number is less than 50.

Enter your guess: 25
Incorrect! The number is greater than 25.

Enter your guess: 35
Incorrect! The number is less than 35.

Enter your guess: 30
Congratulations! You guessed the correct number in 4 attempts.
```