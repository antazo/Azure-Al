public class Part4Module5
{
    public static string GenerateSubstringIndexOf()
    {
        Console.WriteLine("IndexOf and Substring");
        Console.WriteLine("---------------------");

        string message = "Find what is (inside the parentheses)";

        int openingPosition = message.IndexOf('(');
        int closingPosition = message.IndexOf(')');

        // Console.WriteLine(openingPosition);
        // Console.WriteLine(closingPosition);

        int length = closingPosition - openingPosition;
        Console.WriteLine(message.Substring(openingPosition, length));

        return $@"";
    }
    public static string GenerateIndexOfLastIndexOf()
    {
        Console.WriteLine("IndexOf and LastIndexOf");
        Console.WriteLine("-----------------------");

        string message = "What is the value <span>between the tags</span>?";

        const string openSpan = "<span>";
        const string closeSpan = "</span>";

        int openingPosition = message.IndexOf(openSpan);
        int closingPosition = message.IndexOf(closeSpan);

        openingPosition += openSpan.Length;
        int length = closingPosition - openingPosition;
        Console.WriteLine(message.Substring(openingPosition, length));

        return $@"";
    }
    public static string GenerateRemoveReplace()
    {
        Console.WriteLine("Remove and Replace");
        Console.WriteLine("------------------");

        string message = "This--is--ex-amp-le--da-ta";
        message = message.Replace("--", " ");
        message = message.Replace("-", "");
        Console.WriteLine(message);

        return $@"";
    }
    public static string GenerateDesafio()
    {
        Console.WriteLine("Desafío para extraer, reemplazar y quitar datos de una cadena de entrada");
        Console.WriteLine("------------------------------------------------------------------------");

        const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

        string quantity = "";
        string output = "";

        // Your work here
        Console.WriteLine("Input: " + input);
        quantity = input.Substring(input.IndexOf("<span>") + 6, input.IndexOf("</span>") - input.IndexOf("<span>") - 6);
        output = input.Replace("<div>", "").Replace("</div>", "").Replace("<h2>", "").Replace("</h2>", "").Replace("<span>", "").Replace("</span>", "");

        Console.WriteLine("Quantity: " + quantity);
        Console.WriteLine("Output: " + output);

        return $@"";
    }
    public static string GenerateDesafioSolucion()
    {
        Console.WriteLine("Solución al Desafío para extraer, reemplazar y quitar datos de una cadena de entrada");
        Console.WriteLine("------------------------------------------------------------------------------------");

        const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

        string quantity = "";
        string output = "";

        // Your work here

        // Extract the "quantity"
        const string openSpan = "<span>";
        const string closeSpan = "</span>";

        int quantityStart = input.IndexOf(openSpan) + openSpan.Length; // + length of <span> so index at end of <span> tag
        int quantityEnd= input.IndexOf(closeSpan);
        int quantityLength = quantityEnd - quantityStart;
        quantity = input.Substring(quantityStart, quantityLength);
        quantity = $"Quantity: {quantity}";

        // Set output to input, replacing the trademark symbol with the registered trademark symbol
        const string tradeSymbol = "&trade;";
        const string regSymbol = "&reg;";
        output = input.Replace(tradeSymbol, regSymbol);

        // Remove the opening <div> tag
        const string openDiv = "<div>";
        int divStart = output.IndexOf(openDiv);
        output = output.Remove(divStart, openDiv.Length);

        // Remove the closing </div> tag and add "Output:" to the beginning
        const string closeDiv = "</div>";
        int divCloseStart = output.IndexOf(closeDiv);
        output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

        Console.WriteLine(quantity);
        Console.WriteLine(output);

        return $@"";
    }
}