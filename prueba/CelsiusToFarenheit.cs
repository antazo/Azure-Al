public class CelsiusToFarenheit
{
    public static string GenerateFarenheit()
    {
        Console.WriteLine("Celsius to Farenheit conversion");
        Console.WriteLine("-------------------------------");
        
        // Convert F to C
        int fahrenheit = 94;
        decimal celsius = (fahrenheit-32)*(5M/9M);

        double planck = 6.6262; //6.6262e-27 or 6,6262(local)

        Console.WriteLine($"Temperature is:\t\t\t\t\t {celsius.ToString("0.0")} Celsius"); // or Math.Round(celsius, 1)
        Console.WriteLine($"Value of PI is:\t\t\t\t\t {Math.PI}");
        Console.WriteLine($"Planck's constant is:\t\t\t\t {planck}");
        Console.WriteLine($"The rest of Planck's constant divided by PI is:\t {(planck%Math.PI)}");

        Console.Write("First 10 numbers of the Fibonacci sequence: ");
        int a = 0, b = 1, c;
        Console.Write($"\t {a}, {b}");
        for (int i = 2; i < 10; i++)
        {
            c = a + b;
            Console.Write($", {c}");
            a = b;
            b = c;
        }
return $@"

";
    }
}