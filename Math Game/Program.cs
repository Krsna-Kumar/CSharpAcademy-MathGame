namespace Math_Game
{
    internal class Program
    {
        static readonly List<string> gameHistory = new List<string>();

        static void Main(string[] args)
        {
            string name = UserInput.GetStringInput(prompt: "Type your name", reaskPrompt: "Please enter your name", ClearConsoleOnError: true);

            bool shouldExit = false;
            do
            {
                DisplayMenuOptions();

                int selectedOption = UserInput.GetIntegerInput(prompt: "Enter a option", reaskPrompt: "Please select an option");

                switch (selectedOption)
                {
                    case 0:
                        ShowHistory();
                        break;
                    case 1:
                        AdditionQuestions();
                        break;
                    case 2:
                        SubtractionQuestions();
                        break;
                    case 3:
                        MutliplicationQuestions();
                        break;
                    case 4:
                        DivisionQuestions();
                        break;
                    case 5:
                        Console.Write("Press any to exit the program > ");
                        shouldExit = true;
                        break;
                    default:
                        Console.WriteLine("Please selection from options listed above");
                        Console.ReadKey();
                        break;
                }
            } while (!shouldExit);

            Console.ReadLine();

        }


        static void DisplayMenuOptions()
        {
            Console.Clear();
            Console.WriteLine("- - - - - - - - - - - - -");
            Console.WriteLine("Select a mode to start");
            Console.WriteLine("0. Show history");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Quit the game");
            Console.WriteLine("- - - - - - - - - - - - -");
        }

        static void ShowHistory()
        {
            Console.Clear();
            Console.WriteLine("Previous Game History");
            Console.WriteLine("- - - - - - - - - - -");

            if(gameHistory.Count > 0)
            {
                ShowMessage.Bright($"{"Date",-12} {"Game Mode",-15} {"Points",-8}");
                Console.WriteLine("- - - - - - - - - - - - - - - -");
                foreach (string item in gameHistory)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("There no history available.");
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
        static void AdditionQuestions()
        {
            int count = 0;
            int score = 0;
            while (count < 5)
            {
                Console.Clear();
                Console.WriteLine("Game Mode: Addition");
                Console.WriteLine("- - - - - - - - - - -");

                Random randomNum = new Random();
                int firstNum = randomNum.Next(1, 50);
                int secondNum = randomNum.Next(1, 50);
                int result = firstNum + secondNum;

                ShowMessage.Bright($"Que. {firstNum} + {secondNum} = ?");
                int userAnswer = UserInput.GetIntegerInput("Ans");
                bool isCorrect = userAnswer == result;
                if (isCorrect)
                {
                    ShowMessage.Success($"Correct! +{4} points");
                    score += 4;
                }
                else
                {
                    ShowMessage.Error($"Wrong! -{1} points");
                    score -= 1;
                }
                if (count < 4)
                {
                    Console.WriteLine("Press any key for next round");
                    Console.ReadKey();
                }
                count++;
                
            }
            gameHistory.Add($"{DateTime.Now.ToString("d"),-12} {"Addition",-15} {score,-8}");
            Console.WriteLine($"Your final score: {score}\nPress any key to continue...");
            Console.ReadKey();
        }

        static void SubtractionQuestions()
        {
            int count = 0;
            int score = 0;
            while (count < 5)
            {
                Console.Clear();
                Console.WriteLine("Game Mode: Subtraction");
                Console.WriteLine("- - - - - - - - - - -");

                Random randomNum = new Random();
                int firstNum = randomNum.Next(1, 50);
                int secondNum = randomNum.Next(1, 50);
                int result = secondNum - firstNum;

                ShowMessage.Bright($"Que. {secondNum} - {firstNum} = ?");
                int userAnswer = UserInput.GetIntegerInput("Ans");
                bool isCorrect = userAnswer == result;
                if (isCorrect)
                {
                    ShowMessage.Success($"Correct! +{4} points");
                    score += 4;
                }
                else
                {
                    ShowMessage.Error($"Wrong! -{1} points");
                    score -= 1;
                }
                if (count < 4)
                {
                    Console.WriteLine("Press any key for next round");
                    Console.ReadKey();
                }
                count++;
            }
            gameHistory.Add($"{DateTime.Now.ToString("d"),-12} {"Division",-15} {score,-8}");
            Console.WriteLine($"Your final score: {score}\nPress any key to continue...");
            Console.ReadKey();
        }

        static void MutliplicationQuestions()
        {
            int count = 0;
            int score = 0;
            while (count < 5)
            {
                Console.Clear();
                Console.WriteLine("Game Mode: Multiplication");
                Console.WriteLine("- - - - - - - - - - -");

                Random randomNum = new Random();
                int firstNum = randomNum.Next(1, 20);
                int secondNum = randomNum.Next(1, 20);
                int result = firstNum * secondNum;

                ShowMessage.Bright($"Que. {firstNum} x {secondNum} = ?");
                int userAnswer = UserInput.GetIntegerInput("Ans");
                bool isCorrect = userAnswer == result;
                if (isCorrect)
                {
                    ShowMessage.Success($"Correct! +{4} points");
                    score += 4;
                }
                else
                {
                    ShowMessage.Error($"Wrong! -{1} points");
                    score -= 1;
                }
                if (count < 4)
                {
                    Console.WriteLine("Press any key for next round");
                    Console.ReadKey();
                }
                count++;
            }
            gameHistory.Add($"{DateTime.Now.ToString("d"),-12} {"Multiply",-15} {score,-8}");
            Console.WriteLine($"Your final score: {score}\nPress any key to continue...");
            Console.ReadKey();
        }

        static void DivisionQuestions()
        {
            int count = 0;
            int score = 0;
            while (count < 5)
            {
                Console.Clear();
                Console.WriteLine("Game Mode: Division");
                Console.WriteLine("- - - - - - - - - - -");

                Random random = new Random();

                int dividend, divisor, result;

                while (true)
                {
                    divisor = random.Next(1, 100);
                    dividend = divisor * random.Next(1, 100);

                    if (dividend < 100)
                    {
                        ShowMessage.Bright($"Que. {dividend} ÷ {divisor} = ?");
                        break;
                    }
                }

                result = dividend / divisor;
                int userAnswer = UserInput.GetIntegerInput("Ans");
                bool isCorrect = userAnswer == result;
                if (isCorrect)
                {
                    ShowMessage.Success($"Correct! +{4} points");
                    score += 4;
                }
                else
                {
                    ShowMessage.Error($"Wrong! -{1} points");
                    score -= 1;
                }
                if (count < 4)
                {
                    Console.WriteLine("Press any key for next round");
                    Console.ReadKey();
                }
                count++;
            }
            gameHistory.Add($"{DateTime.Now.ToString("d"),-12} {"Division",-15} {score,-8}");
            Console.WriteLine($"Your final score: {score}\nPress any key to continue...");
            Console.ReadKey();
        }
    }

    internal class ShowMessage
    {
        private static void ChangeForeGroundColor(ConsoleColor consoleColor, string message)
        {
            ConsoleColor defaultColor = ConsoleColor.Gray;

            Console.ForegroundColor = consoleColor;
            Console.WriteLine(message);
            Console.ForegroundColor = defaultColor;
        }

        public static void Success(string message)
        {
            ChangeForeGroundColor(ConsoleColor.DarkGreen, message);
        }

        public static void Warning(string message)
        {
            ChangeForeGroundColor(ConsoleColor.DarkYellow, message);
        }

        public static void Error(string message)
        {
            ChangeForeGroundColor(ConsoleColor.DarkRed, message);
        }

        public static void Bright(string message)
        {
            ChangeForeGroundColor(ConsoleColor.White, message);
        }
    }

    internal class UserInput
    {
        private static void ClearConsole(bool enabled)
        {
            if (enabled) { Console.Clear(); }
        }

        public static int GetIntegerInput(string prompt = "Enter", string reaskPrompt = "Please Enter", bool ClearConsoleOnError = false)
        {
            while (true)
            {
                Console.Write($"{prompt}: ");
                string? userInput = Console.ReadLine();

                if (string.IsNullOrEmpty(userInput))
                {
                    ClearConsole(ClearConsoleOnError);
                    Console.WriteLine("This field cannot be empty!");
                    Console.WriteLine("- - - - - - - - - - - - - -");
                }
                else if (int.TryParse(userInput, out int numericValue))
                {
                    return numericValue;
                }
                else
                {
                    ClearConsole(ClearConsoleOnError);
                    Console.WriteLine("This field must be an integer!");
                    Console.WriteLine("- - - - - - - - - - - - - -");
                }

                prompt = reaskPrompt;
            }
        }


        public static string GetStringInput(string prompt = "Enter", string reaskPrompt = "Please Enter", bool ClearConsoleOnError = false)
        {
            Console.Write($"{prompt}: ");
            string userInput = Console.ReadLine() ?? string.Empty;
            bool isValid = false;

            do
            {
                if (!string.IsNullOrEmpty(userInput))
                {
                    isValid = true;
                }
                else
                {
                    ClearConsole(ClearConsoleOnError);
                    Console.WriteLine("This field can not be empty!");
                    Console.WriteLine("- - - - - - - - - - - - - -");
                    Console.Write($"{reaskPrompt}: ");
                    userInput = Console.ReadLine() ?? string.Empty;
                }
            }
            while (!isValid);

            return userInput;
        }
    }
}
