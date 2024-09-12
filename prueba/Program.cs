// See https://aka.ms/new-console-template for more information
using System.Drawing;
using System.Text;
using Figgle;

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
var myInput = Console.ReadLine();
if (myInput == "")
    myInput = "pimpin, no me has dicho como te llamas";

// Print the value of the variable (userName), which will display the input value
Console.WriteLine(@"Hola " + myInput + " ^_^\n");

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

Console.WriteLine();
Console.WriteLine();

// PROJECT PART 1

Console.WriteLine(
    FiggleFonts.Slant.Render("Cálculo del GPA final"));

/*
Student: Sophia Johnson

Course          Grade   Credit Hours	
English 101         4       3
Algebra 101         3       3
Biology 101         3       4
Computer Science I  3       4
Psychology 101      4       3

Final GPA:          3.35
*/
string studentName = "Sophia Johnson";
string[] courseNames = {"English 101", "Algebra 101", "Biology 101", "Computer Science I", "Psychology 101"};
int[] courseCredits = {3, 3, 4, 4, 3};

int gradeA = 4;
int gradeB = 3;
int[] courseGrades = {gradeA, gradeB, gradeB, gradeB, gradeA};

int totalCreditHours = 0;
foreach (int courseCredit in courseCredits)
    totalCreditHours += courseCredit;

int totalGradePoints = 0;
for (int i=0;i<courseCredits.Length;i++)
    totalGradePoints += courseCredits[i] * courseGrades[i];

decimal gradePointAverage = (decimal) totalGradePoints/totalCreditHours;

int leadingDigit = (int) gradePointAverage;
int firstDigit = (int) (gradePointAverage * 10 ) % 10;
int secondDigit = (int) (gradePointAverage * 100 ) % 10;

Console.WriteLine($"Student: {studentName}\n");
Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");

for (int i=0;i<courseNames.Length;i++)
    Console.WriteLine($"{courseNames[i]}\t\t\t{courseGrades[i]}\t\t{courseCredits[i]}");

Console.WriteLine($"\nFinal GPA:\t\t\t {leadingDigit}.{firstDigit}{secondDigit}");

Console.WriteLine();
Console.WriteLine();