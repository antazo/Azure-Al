public class Rpg
{
    public static string GenerateRpg()
    {
        Console.WriteLine("Desafío de la batalla del juego de rol");
        Console.WriteLine("--------------------------------------");

        int heroHealth = 100;
        int heroDamage = 0;
        int monsterHealth = 100;
        int monsterDamage = 0;

        //var initiative = new Random().Next(0, 2) == 0 ? "Hero" : "Monster"; // Randomly select who attacks first
        var initiative = "Hero"; // Hero attacks first
        do
        {
            if (initiative == "Hero")
            {
                heroDamage = new Random().Next(1, 11);
                monsterHealth -= heroDamage;

                Console.WriteLine($"Monster was damaged and lost {heroDamage} health and now has {monsterHealth} health left.");

                initiative = "Monster";
            }
            else
            {
                monsterDamage = new Random().Next(1, 11);
                heroHealth -= monsterDamage;

                Console.WriteLine($"Hero was damaged and lost {monsterDamage} health and now has {heroHealth} health left.");

                initiative = "Hero";
            }

        } while (heroHealth > 0 && monsterHealth > 0);

        Console.WriteLine(heroHealth > 0 ? "Hero wins!" : "Monster wins! GAME OVER!! INSERT COIN TO CONTINUE");

        return $@"";
    }
}