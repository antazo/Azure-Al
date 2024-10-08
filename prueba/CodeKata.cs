using System.Xml.XPath;

public class CodeKata
{
    /*
    Estas son las reglas de FizzBuzz que necesita implementar en el proyecto de código:

    Valores de salida de 1 a 100, un número por línea, dentro del bloque de código de una instrucción de iteración.
    Si el valor actual es divisible por 3, se imprime el término Fizz junto al número.
    Si el valor actual es divisible por 5, se imprime el término Buzz junto al número.
    Si el valor actual es divisible por 3 y por 5, se imprime el término FizzBuzz junto al número.
    */
    public static string GenerateFizzBuzz()
    {
        Console.WriteLine("Desafío de CodeKata");
        Console.WriteLine("-------------------");
        string result = "";

        for (int i = 0; i < 100; i++)
        {
            if (Mod3_5(i))
            {
                result += "FizzBuzz, ";
            }
            else if (Mod3(i))
            {
                result += "Fizz, ";
            }
            else if (Mod5(i))
            {
                result += "Buzz, ";
            }
            else
            {
                result += $"{i}, ";
            }
        }

        return result;
    }
    public static bool Mod3(int i)
    {
        bool result = false;
        if (i % 3 == 0)
        {
            result = true;
        }
        return result;
    }

    public static bool Mod5(int i)
    {
        bool result = false;
        if (i % 5 == 0)
        {
            result = true;
        }
        return result;
    }

    public static bool Mod3_5(int i)
    {
        bool result = false;
        if ((i % 3 == 0) && (i % 5 == 0))
        {
            result = true;
        }
        return result;
    }
    public static bool Multi7(int i)
    {
        bool result = false;
        if (i % 7 == 0) 
        {
            result = true;
        }
        return result;
    }

    public static bool Primo(int i)
    {
        // Es numero primo?

        if (i == 0 || i == 1)
        {
            return false;
        }
        else
        {
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    return false;
                }
            }
        }
        return true;
    }
    public static string GeneratePrimos()
    {
        string result = "";
        for (int i = 0; i < 100; i++)
        {
            if (Primo(i))
            {
                result += $"{i}, ";
            }
        }
        return result;
    }
}