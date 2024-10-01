using System;
using System.Linq;

public class Part5
{
    public static string GenerateBooleans()
    {

        Console.WriteLine("Devolver valores booleanos de métodos");
        Console.WriteLine("-------------------------------------");

        string[] words = { "racecar", "talented", "deified", "tent", "tenet" };

        Console.WriteLine("Is it a palindrome?");
        foreach (string word in words)
        {
            Console.WriteLine($"{word}: {IsPalindrome(word)}");
        }

        bool IsPalindrome(string word)
        {
            int start = 0;
            int end = word.Length - 1;

            while (start < end)
            {
                if (word[start] != word[end])
                {
                    return false;
                }
                start++;
                end--;
            }

            return true;
        }

        return $@"";
    }
    public static string GenerateEmailAddresses()
    {

        /*
        El desafío consiste en crear un método que muestre la dirección de correo electrónico correcta de los empleados internos
         y externos. Se le proporcionan listas de nombres de empleados internos y externos. La dirección de correo electrónico de
          un empleado consta de su nombre de usuario y nombre de dominio de la empresa.

        El formato del nombre de usuario está formado por los dos primeros caracteres del nombre del empleado seguido de su
         apellido. Por ejemplo, un empleado llamado "Robert Bavin" tendría el nombre de usuario "robavin". El dominio de los
          empleados internos es "contoso.com".

        En este desafío, se le proporciona un código de partida. Debe decidir cómo crear y llamar a un método para mostrar
         direcciones de correo electrónico.
        */

        Console.WriteLine("Desafío para mostrar direcciones de correo electrónico");
        Console.WriteLine("------------------------------------------------------");

        string[,] corporate =
            {
                {"Robert", "Bavin"}, {"Simon", "Bright"},
                {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
                {"Sarah", "Delucchi"}, {"Sinan", "Ali"}};

        string[,] external =
        {
                {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
                {"Shay", "Lawrence"}, {"Daren", "Valdes"}
            };

        string externalDomain = "hayworth.com";


        for (int i = 0; i < corporate.GetLength(0); i++)
        {
            DisplayEmail(first: corporate[i, 0], last: corporate[i, 1]);
        }

        for (int i = 0; i < external.GetLength(0); i++)
        {
            // display external email addresses
            DisplayEmail(first: external[i, 0], last: external[i, 1], domain: externalDomain);
        }

        void DisplayEmail(string first, string last, string domain = "contoso.com")
        {
            string email = first.Substring(0, 2) + last;
            email = email.ToLower();
            Console.WriteLine($"{email}@{domain}");
        }

        return $@"";
    }
    public static string GenerateReusedMethods()
    {

        Console.WriteLine("Crear métodos reutilizables");
        Console.WriteLine("---------------------------");

        int[] times = { 800, 1200, 1600, 2000 };
        int diff = 0;

        Console.WriteLine("Enter current GMT");
        int currentGMT = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Current Medicine Schedule:");
        DisplayTimes();

        Console.WriteLine("Enter new GMT");
        int newGMT = Convert.ToInt32(Console.ReadLine());

        if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
        {
            Console.WriteLine("Invalid GMT");
        }
        else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
        {
            diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
            AdjustTimes();
        }
        else
        {
            diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
            AdjustTimes();
        }

        Console.WriteLine("New Medicine Schedule:");
        DisplayTimes();

        void DisplayTimes()
        {
            /* Format and display medicine times */
            foreach (int val in times)
            {
                string time = val.ToString();
                int len = time.Length;

                if (len >= 3)
                {
                    time = time.Insert(len - 2, ":");
                }
                else if (len == 2)
                {
                    time = time.Insert(0, "0:");
                }
                else
                {
                    time = time.Insert(0, "0:0");
                }

                Console.Write($"{time} ");
            }
            Console.WriteLine();
        }

        void AdjustTimes()
        {
            /* Adjust the times by adding the difference, keeping the value within 24 hours */
            for (int i = 0; i < times.Length; i++)
            {
                times[i] = ((times[i] + diff)) % 2400;
            }
        }

        return $@"";
    }

    public static string GenerateIP()
    {

        Console.WriteLine("Build code with methods");
        Console.WriteLine("-----------------------");

        string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
        string[] address;
        bool validLength = false;
        bool validZeroes = false;
        bool validRange = false;

        foreach (string ip in ipv4Input)
        {
            address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

            ValidateLength();
            ValidateZeroes();
            ValidateRange();

            if (validLength && validZeroes && validRange)
            {
                Console.WriteLine($"{ip} is a valid IPv4 address");
            }
            else
            {
                Console.WriteLine($"{ip} is an invalid IPv4 address");
            }
        }

        void ValidateLength()
        {
            validLength = address.Length == 4;
        };

        void ValidateZeroes()
        {
            foreach (string number in address)
            {
                if (number.Length > 1 && number.StartsWith("0"))
                {
                    validZeroes = false;
                    return;
                }
            }

            validZeroes = true;
        }

        void ValidateRange()
        {
            foreach (string number in address)
            {
                int value = int.Parse(number);
                if (value < 0 || value > 255)
                {
                    validRange = false;
                    return;
                }
            }
            validRange = true;
        }

        return $@"";
    }
    public static string GenerateIPnew()
    {

        Console.WriteLine("Build code with methods");
        Console.WriteLine("-----------------------");

        string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };

        foreach (string ip in ipv4Input)
        {
            if (IPAddressValidator.ValidateIPv4(ip))
            {
                Console.WriteLine($"{ip} is a valid IPv4 address");
            }
            else
            {
                Console.WriteLine($"{ip} is an invalid IPv4 address");
            }
        }

        return $@"";
    }

    public class IPAddressValidator
    {
        public static bool ValidateIPv4(string ipAddress)
        {
            if (string.IsNullOrWhiteSpace(ipAddress))
            {
                return false;
            }

            string[] parts = ipAddress.Split('.');
            if (parts.Length != 4)
            {
                return false;
            }

            foreach (string part in parts)
            {
                if (!int.TryParse(part, out int value) || value < 0 || value > 255)
                {
                    return false;
                }
            }

            return true;
        }
    }
    public static string GenerateRPG02()
    {

        Console.WriteLine("Desafío para crear un método reutilizable (RPG)");
        Console.WriteLine("-----------------------------------------------");

        Random random = new Random();
        FortuneTell(random.Next(100));

        return $@"";
    }

    public static string FortuneTell(int luck)
    {

        string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
        string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
        string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
        string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };

        Console.WriteLine("A fortune teller whispers the following words:");
        string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
        for (int i = 0; i < 4; i++)
        {
            Console.Write($"{text[i]} {fortune[i]} ");
        }

        return $@"";
    }
    public static string GenerateDiceGame()
    {

        Console.WriteLine("Desafío para agregar métodos para que el juego sea jugable");
        Console.WriteLine("----------------------------------------------------------");
        Random random = new Random();

        Console.WriteLine("Would you like to play? (Y/N)");
        if (ShouldPlay())
        {
            PlayGame();
        }

        bool ShouldPlay()
        {
            string response = Console.ReadLine();
            return response.ToLower().Equals("y");
        }

        void PlayGame()
        {
            var play = true;

            while (play)
            {
                var target = GetTarget();
                var roll = RollDice();

                Console.WriteLine($"Roll a number greater than {target} to win!");
                Console.WriteLine($"You rolled a {roll}");
                Console.WriteLine(WinOrLose(roll, target));
                Console.WriteLine("\nPlay again? (Y/N)");

                play = ShouldPlay();
            }
        }

        int GetTarget()
        {
            return random.Next(1, 6);
        }

        int RollDice()
        {
            return random.Next(1, 7);
        }

        string WinOrLose(int roll, int target)
        {
            if (roll > target)
            {
                return "You win!";
            }
            return "You lose!";
        }

        return $@"";
    }

    public static string GenerateMiniGame()
    {

        Console.WriteLine("Desafío: Crear un minijuego");
        Console.WriteLine("---------------------------");

        /*
        - The code declares the following variables:
            - Variables to determine the size of the Terminal window.
            - Variables to track the locations of the player and food.
            - Arrays `states` and `foods` to provide available player and food appearances
            - Variables to track the current player and food appearance

        - The code provides the following methods:
            - A method to determine if the Terminal window was resized.
            - A method to display a random food appearance at a random location.
            - A method that changes the player appearance to match the food consumed.
            - A method that temporarily freezes the player movement.
            - A method that moves the player according to directional input.
            - A method that sets up the initial game state.

        - The code doesn't call the methods correctly to make the game playable. The following features are missing:
            - Code to determine if the player has consumed the food displayed.
            - Code to determine if the food consumed should freeze player movement.
            - Code to determine if the food consumed should increase player movement.
            - Code to increase movement speed.
            - Code to redisplay the food after it's consumed by the player.
            - Code to terminate execution if an unsupported key is entered.
            - Code to terminate execution if the terminal was resized.
        */

        Random random = new Random();
        Console.CursorVisible = false;
        int height = Console.WindowHeight - 1;
        int width = Console.WindowWidth - 5;
        bool shouldExit = false;

        // Console position of the player
        int playerX = 0;
        int playerY = 0;

        // Console position of the food
        int foodX = 0;
        int foodY = 0;

        // Available player and food strings
        string[] states = { "(͡ ° ͜ʖ ͡ °)", "(˵ ͡° ͜ʖ ͡°˵)", "(ﾉ◕ヮ◕)" };
        string[] foods = { "@@ CHULETON @@", "$$ PASTA $$", "## GOFRES ##" };

        // Current player string displayed in the Console
        string player = states[0];

        // Index of the current food
        int food = 0;

        InitializeGame();
        while (!shouldExit)
        {
            if (TerminalResized())
            {
                Console.Clear();
                Console.Write("Console was resized. Program exiting.");
                shouldExit = true;
            }
            else
            {
                if (PlayerIsFaster())
                {
                    Move(1, false);
                }
                else if (PlayerIsSick())
                {
                    FreezePlayer();
                }
                else
                {
                    Move(otherKeysExit: false);
                }
                if (GotFood())
                {
                    ChangePlayer();
                    ShowFood();
                }
            }
        }

        // Returns true if the Terminal was resized 
        bool TerminalResized()
        {
            return height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;
        }

        // Displays random food at a random location
        void ShowFood()
        {
            // Update food to a random index
            food = random.Next(0, foods.Length);

            // Update food position to a random location
            foodX = random.Next(0, width - player.Length);
            foodY = random.Next(0, height - 1);

            // Display the food at the location
            Console.SetCursorPosition(foodX, foodY);
            Console.Write(foods[food]);
        }

        // Returns true if the player location matches the food location
        bool GotFood()
        {
            return playerY == foodY && playerX == foodX;
        }

        // Returns true if the player appearance represents a sick state
        bool PlayerIsSick()
        {
            return player.Equals(states[2]);
        }

        // Returns true if the player appearance represents a fast state
        bool PlayerIsFaster()
        {
            return player.Equals(states[1]);
        }

        // Changes the player to match the food consumed
        void ChangePlayer()
        {
            player = states[food];
            Console.SetCursorPosition(playerX, playerY);
            Console.Write(player);
        }

        // Temporarily stops the player from moving
        void FreezePlayer()
        {
            System.Threading.Thread.Sleep(1000);
            player = states[0];
        }

        // Reads directional input from the Console and moves the player
        void Move(int speed = 1, bool otherKeysExit = false)
        {
            int lastX = playerX;
            int lastY = playerY;

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.UpArrow:
                    playerY--;
                    break;
                case ConsoleKey.DownArrow:
                    playerY++;
                    break;
                case ConsoleKey.LeftArrow:
                    playerX -= speed;
                    break;
                case ConsoleKey.RightArrow:
                    playerX += speed;
                    break;
                case ConsoleKey.Escape:
                    shouldExit = true;
                    break;
                default:
                    // Exit if any other keys are pressed
                    shouldExit = otherKeysExit;
                    break;
            }

            // Clear the characters at the previous position
            Console.SetCursorPosition(lastX, lastY);
            for (int i = 0; i < player.Length; i++)
            {
                Console.Write(" ");
            }

            // Keep player position within the bounds of the Terminal window
            playerX = (playerX < 0) ? 0 : (playerX >= width ? width : playerX);
            playerY = (playerY < 0) ? 0 : (playerY >= height ? height : playerY);

            // Draw the player at the new location
            Console.SetCursorPosition(playerX, playerY);
            Console.Write(player);
        }

        // Clears the console, displays the food and player
        void InitializeGame()
        {
            Console.Clear();
            ShowFood();
            Console.SetCursorPosition(0, 0);
            Console.Write(player);
        }

        return $@"";
    }
}