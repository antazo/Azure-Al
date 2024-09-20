public class Subscription
{
    public static string GenerateSubscription()
    {
        Console.WriteLine("Desafío para aplicar reglas de negocio");
        Console.WriteLine("--------------------------------------");

        Random random = new Random();
        int daysUntilExpiration = random.Next(12);
        int discountPercentage = 0;

        do
        {
            switch(daysUntilExpiration)
            {
                case 0:
                    Console.WriteLine("Your subscription has expired.");
                    break;
                case 1:
                    Console.WriteLine("Your subscription expires within a day!");
                    discountPercentage = 20;
                    break;
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine($"Your subscription will expire in {daysUntilExpiration} days.");
                    discountPercentage = 10;
                    break;
                default:
                    Console.WriteLine("Your subscription will expire soon. Renew now!");
                    break;
            }
            Console.WriteLine($"You have a discount of {discountPercentage}%.");
            daysUntilExpiration--;
            Console.WriteLine("Continue? (Y/n)");
            string pressKey = Console.ReadLine() ?? string.Empty;
            if (pressKey != null && pressKey.ToLower() == "n")
                break;
        } while (daysUntilExpiration > 0);

        return $@"";
    }
}