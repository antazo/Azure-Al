using System;
using System.Linq;

public class Part5
{
    public static string GenerateBooleans()
    {

        Console.WriteLine("Devolver valores booleanos de métodos");
        Console.WriteLine("-------------------------------------");

        string[] words = {"racecar" ,"talented", "deified", "tent", "tenet"};

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
                // display internal email addresses
                DisplayEmail(first: corporate[i,0], last: corporate[i,1]);
            }

            for (int i = 0; i < external.GetLength(0); i++) 
            {
                // display external email addresses
                DisplayEmail(first: external[i,0], last: external[i,1], domain: externalDomain);
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

        int[] times = {800, 1200, 1600, 2000};
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

        string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
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

        string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
        
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

        string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
        string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
        string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
        string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

        Console.WriteLine("A fortune teller whispers the following words:");
        string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
        for (int i = 0; i < 4; i++) 
        {
            Console.Write($"{text[i]} {fortune[i]} ");
        }

        return $@"";
    }
}