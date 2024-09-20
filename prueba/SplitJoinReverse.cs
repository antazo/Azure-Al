public class SplitJoinReverse
{
    public static string GenerateSplitJoinReverse()
    {
        Console.WriteLine("Desafío para invertir las palabras de una oración");
        Console.WriteLine("-------------------------------------------------");

        string pangram = "The quick brown fox jumps over the lazy dog";
        string[] words = pangram.Split(' ');
        foreach (string word in words)
        {
            Console.Write(String.Join("", word.ToCharArray().Reverse()) + " ");
        }

        Console.WriteLine("\nPangram: " + pangram);
        Console.WriteLine("\nReversed should be: ehT kciuq nworb xof spmuj revo eht yzal god");

        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("Desafío para analizar una cadena de pedidos, ordenar los pedidos y etiquetar posibles errores");
        Console.WriteLine("---------------------------------------------------------------------------------------------");

        string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

        string[] orders = orderStream.Split(',');
        Array.Sort(orders);
        foreach (string order in orders)
        {
            Console.Write($"{order}\t");
            if (order.Length != 4)
            {
                Console.Write($" - Error");
            }
            Console.Write($"\n");
        }

        return $@"";
    }
}