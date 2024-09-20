public class Fraudulent
{
    public static string GenerateFraudulent()
    {
        Console.WriteLine("Desafío de pedido fraudulento");
        Console.WriteLine("-----------------------------");

        string[] fraudulentOrderIDs = [ 
            "B123",
            "C234",
            "A345",
            "C15",
            "B177",
            "G3003",
            "C235",
            "B179"
        ];

        foreach (string fraudulentOrderID in fraudulentOrderIDs)
        {
            if (fraudulentOrderID.StartsWith('B'))
                Console.WriteLine("The name " + fraudulentOrderID + " starts with 'B'!");
            else if (fraudulentOrderID.StartsWith('C'))
                Console.WriteLine("The name " + fraudulentOrderID + " does not start with 'B'!");
        }

        return $@"";
    }
}