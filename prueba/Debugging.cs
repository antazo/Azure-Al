public class Debugging
{
    public static string GenerateDebugging()
    {
        Console.WriteLine("Debugging");
        Console.WriteLine("---------");

        /*  
        This code instantiates a value and then calls the ChangeValue method
        to update the value. The code then prints the updated value to the console.
        */
        int x = 5;

        ChangeValue(x);

        Console.WriteLine(x);

        void ChangeValue(int value)
        {
            value = 10;
        }

        return $@"";
    }
}