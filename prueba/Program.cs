// See https://aka.ms/new-console-template for more information
using System.Drawing;
using System.Text;

//Console.BackgroundColor = ConsoleColor.Blue;
//Console.Write("Lorem ipsum dolor sit amet consectetur adipiscing elit, in fringilla maecenas lobortis duis turpis risus, praesent porta facilisis nostra aptent nibh. Nulla massa taciti vulputate fringilla ac cursus mollis pharetra, penatibus iaculis molestie praesent arcu nibh ridiculus. Donec pharetra vulputate varius felis scelerisque phasellus per aliquam class, viverra dui iaculis urna himenaeos turpis posuere ac, curabitur auctor ultricies neque in duis vivamus habitasse.");
Console.Clear();

String terminator = """

⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⡞⢁⣴⣶⣿⣻⡷⠀⣇⣀⣀⡀⠀⢰⡇⠀⠈⢳⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⠐⠿⣷⠿⡟⠋⠀⠀⠀⠀⠀⠀⠈⠉⠁⣦⣤⣸⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣿⠀⠀⠘⠉⠁⡄⠀⠀⠀⠀⠀⠀⡄⠀⠀⢸⣿⣾⣿⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⢿⠀⠀⠀⠀⠀⢷⠀⠀⠀⠀⠀⢀⡇⠀⠀⠈⠹⢿⠺⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣸⡇⠀⠀⠀⠀⢸⣴⢳⠀⢠⢻⣼⠀⠀⠀⠀⠀⣼⢸⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⠛⠤⢀⣀⠀⡀⠿⣼⣄⣸⣼⠟⣀⣀⡀⠤⠖⠻⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⡏⣇⡀⠀⠈⠉⠙⠓⠬⠭⠭⠔⠚⠉⠁⠀⣀⣀⣠⣿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣫⣿⣭⣽⣷⣦⣤⣀⠀⠀⠀⣀⣤⣴⣶⣿⣷⣶⣷⣽⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⠻⢸⣿⣿⡺⡽⢻⣿⣿⡤⣼⣿⣿⣻⡾⣻⣿⣿⠘⢹⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⡄⢸⠙⠿⠿⠿⣿⣿⠟⣿⡏⠿⣿⣿⡿⠿⠛⢹⢠⣾⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣟⠈⠓⠒⠒⠉⠉⠀⣴⣿⣿⣄⠀⣀⡉⠉⠉⠁⢈⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣿⣶⣶⢶⣿⣿⡷⠘⢿⣿⠿⠟⠀⣿⣿⣿⣷⣶⢻⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢹⣿⣿⣿⣿⢻⡇⠰⠆⠀⠀⠶⠀⣿⣿⣿⣿⣿⢸⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣿⣿⣿⣿⣿⣶⡶⡷⢶⢾⢿⣶⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡿⣿⣽⣿⡟⢿⣽⣳⣟⣾⣯⡿⣋⣿⣟⣟⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡇⡿⣎⢿⢿⣳⣸⠉⠉⠁⣴⣼⢻⣟⣯⡞⢸⢸⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸
⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⡴⠚⣿⡿⣟⣾⣯⡿⠁⠓⠒⠒⠃⢿⣺⣿⣯⣀⣸⢸⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸
⠀⠀⠀⠀⢀⣠⠴⠛⠋⠁⠀⢸⣿⢃⣿⡿⣿⣶⡆⠀⠀⠐⡖⠒⢻⣡⡟⠀⢹⣸⡟⠓⢲⠦⣄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸
⢀⣀⣴⠚⠉⠀⠀⠀⠀⠀⣀⣼⠛⣿⣿⠇⠀⠙⣿⣟⠛⠶⡿⢶⣾⡏⢹⡀⡀⢹⡇⠀⠸⠀⡏⠉⠉⠓⠲⢦⣤⣀⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⢸

""";

Console.OutputEncoding = Encoding.UTF8;
Console.Write(terminator);

// Welcome, this is about artificial intelligence...
Console.Write("\n\n\u3088\u3046\u3053\u305d\u3001\u3053\u308c\u306f\u4eba\u5de5\u77e5\u80fd\u306b\u3064\u3044\u3066\u3067\u3059\u002e\u002e\u002e\n\t");

// Type any value
Console.WriteLine("\n\t");
Console.WriteLine(@"What is your name?");

// Create a string variable and get user input from the keyboard and store it in the variable
var anyValue = Console.ReadLine();
if (anyValue == "")
    anyValue = "pimpin, no me has dicho como te llamas";

// Print the value of the variable (userName), which will display the input value
Console.WriteLine(@"Hola " + anyValue + " ^_^");

// Convert F to C
int fahrenheit = 94;
decimal celsius = (fahrenheit-32)*(5M/9M);

Console.WriteLine("The temperature is " + celsius + " Celsius");

Console.WriteLine();
Console.WriteLine();