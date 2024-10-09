namespace prueba;

public class Calculator
{
    public static string GenerateCalculator()
    {
        Console.WriteLine("Calculator");
        Console.WriteLine("----------");


        Console.WriteLine("Enter the first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Choose an operation (+, -, *, /):");
        string operation = Console.ReadLine() ?? string.Empty;

        double result = 0;

        switch (operation)
        {
            case "+":
                result = Add(num1, num2);
                break;
            case "-":
                result = Subtract(num1, num2);
                break;
            case "*":
                result = Multiply(num1, num2);
                break;
            case "/":
                result = Divide(num1, num2);
                break;
            default:
                Console.WriteLine("Invalid operation");
                return "Invalid operation";
        }

        Console.WriteLine($"The result of {num1} {operation} {num2} is: {result}");

        return $@"";
    }

    public static double Add(double a, double b)
    {
        return a + b;
    }

    public static double Subtract(double a, double b)
    {
        return a - b;
    }

    public static double Multiply(double a, double b)
    {
        return a * b;
    }

    public static double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: Division by zero");
            return double.NaN;
        }
        return a / b;
    }
}