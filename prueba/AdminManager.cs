public class AdminManager
{
    public static string GenerateAdminManager()
    {
        Console.WriteLine("Admin|Manager");
        Console.WriteLine("-------------");


        string permission = "Admin"; //"Admin|Manager"
        int level = 55;

        switch (permission)
        {
            case "Admin":
                Console.WriteLine( level>55 ? "Welcome, Super Admin user." : "Welcome, Admin user.");
                break;
            case "Manager":
                Console.WriteLine( level>20 ? "Contact an Admin for access." : "You do not have sufficient privileges.");
                break;
            default:
                Console.WriteLine("You do not have sufficient privileges.");
                break;
        }

        return $@"";
    }
}