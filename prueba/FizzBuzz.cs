public class FizzBuzz
{
    public static string GenerateFizzBuzz()
    {
        Console.WriteLine("Desafío de FizzBuzz");
        Console.WriteLine("-------------------");

        /*
        Estas son las reglas de FizzBuzz que necesita implementar en el proyecto de código:

        Valores de salida de 1 a 100, un número por línea, dentro del bloque de código de una instrucción de iteración.
        Si el valor actual es divisible por 3, se imprime el término Fizz junto al número.
        Si el valor actual es divisible por 5, se imprime el término Buzz junto al número.
        Si el valor actual es divisible por 3 y por 5, se imprime el término FizzBuzz junto al número.
        */

        for (int i = 1; i < 101; i++)
        {
            if ((i % 3 == 0) && (i % 5 == 0))
                Console.WriteLine($"{i} - FizzBuzz");
            else if (i % 3 == 0)
                Console.WriteLine($"{i} - Fizz");
            else if (i % 5 == 0)
                Console.WriteLine($"{i} - Buzz");
            else
                Console.WriteLine($"{i}");
        }

        return $@"";
    }
}