public class HeadsOrTails
{
    public static string GenerateHeadsOrTails()
    {
        Console.WriteLine("Heads or Tails");
        Console.WriteLine("--------------");

        Console.WriteLine(new Random().Next(0,2) < 1 ? "heads" : "tails");

        return $@"";
    }
}