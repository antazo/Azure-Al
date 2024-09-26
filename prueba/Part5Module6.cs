public class Part5Module56
{
    public static string GenerateEmailAddresses()
    {
        
/*
El desafío consiste en crear un método que muestre la dirección de correo electrónico correcta de los empleados internos
 y externos. Se le proporcionan listas de nombres de empleados internos y externos. La dirección de correo electrónico de
  un empleado consta de su nombre de usuario y nombre de dominio de la empresa.

El formato del nombre de usuario está formado por los dos primeros caracteres del nombre del empleado seguido de su
 apellido. Por ejemplo, un empleado llamado "Robert Bavin" tendría el nombre de usuario "robavin". El dominio de los
  empleados internos es "contoso.com".

En este desafío, se le proporciona un código de partida. Debe decidir cómo crear y llamar a un método para mostrar
 direcciones de correo electrónico.
*/

        Console.WriteLine("Desafío para mostrar direcciones de correo electrónico");
        Console.WriteLine("------------------------------------------------------");

        string[,] corporate = 
            {
                {"Robert", "Bavin"}, {"Simon", "Bright"},
                {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
                {"Sarah", "Delucchi"}, {"Sinan", "Ali"}};

            string[,] external = 
            {
                {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
                {"Shay", "Lawrence"}, {"Daren", "Valdes"}
            };

            string externalDomain = "hayworth.com";

            for (int i = 0; i < corporate.GetLength(0); i++) 
            {
                // display internal email addresses
                DisplayEmail(first: corporate[i,0], last: corporate[i,1]);
            }

            for (int i = 0; i < external.GetLength(0); i++) 
            {
                // display external email addresses
                DisplayEmail(first: external[i,0], last: external[i,1], domain: externalDomain);
            }

            void DisplayEmail(string first, string last, string domain = "contoso.com") 
            {
                string email = first.Substring(0, 2) + last;
                email = email.ToLower();
                Console.WriteLine($"{email}@{domain}");
            }

        return $@"";
    }

}