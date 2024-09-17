// See https://aka.ms/new-console-template for more information
using System.Drawing;
using System.Text;
//using Figgle;
// Sample for the Environment.GetEnvironmentVariables method
using System;
using System.Collections;
using System.Reflection.Metadata.Ecma335;

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

// Print the value of the variable (userName), which will display the input value
Console.WriteLine(@"Hello " + EnvironmentVariableTarget.User + " ^_^\n");


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

Console.WriteLine("Cálculo del GPA final");
Console.WriteLine("---------------------");
// PROJECT PART 1

//Console.WriteLine(FiggleFonts.Slant.Render("Cálculo del GPA final"));

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
string studentName1 = "Sophia Johnson";
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

Console.WriteLine($"Student: {studentName1}\n");
Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");

for (int i=0;i<courseNames.Length;i++)
    Console.WriteLine($"{courseNames[i]}\t\t\t{courseGrades[i]}\t\t{courseCredits[i]}");

Console.WriteLine($"\nFinal GPA:\t\t\t {leadingDigit}.{firstDigit}{secondDigit}");

Console.WriteLine();
Console.WriteLine();


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

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Desafío para aplicar reglas de negocio");
Console.WriteLine("--------------------------------------");

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

do
{
    switch(daysUntilExpiration)
    {
        case 0:
            Console.WriteLine("Your subscription has expired.");
            break;
        case 1:
            Console.WriteLine("Your subscription expires within a day!");
            discountPercentage = 20;
            break;
        case 2:
        case 3:
        case 4:
        case 5:
            Console.WriteLine($"Your subscription will expire in {daysUntilExpiration} days.");
            discountPercentage = 10;
            break;
        default:
            Console.WriteLine("Your subscription will expire soon. Renew now!");
            break;
    }
    Console.WriteLine($"You have a discount of {discountPercentage}%.");
    daysUntilExpiration--;
    Console.WriteLine("Continue? (Y/n)");
    string pressKey = Console.ReadLine() ?? string.Empty;
    if (pressKey != null && pressKey.ToLower() == "n")
        break;
} while (daysUntilExpiration > 0);

Console.WriteLine();
Console.WriteLine();


Console.WriteLine("Desafío de pedido fraudulento");
Console.WriteLine("-----------------------------");

string[] fraudulentOrderIDs = [ 
    "B123",
    "C234",
    "A345",
    "C15",
    "B177",
    "G3003",
    "C235",
    "B179"
 ];

foreach (string fraudulentOrderID in fraudulentOrderIDs)
{
    if (fraudulentOrderID.StartsWith('B'))
        Console.WriteLine("The name " + fraudulentOrderID + " starts with 'B'!");
    else if (fraudulentOrderID.StartsWith('C'))
        Console.WriteLine("The name " + fraudulentOrderID + " does not start with 'B'!");
}

Console.WriteLine();
Console.WriteLine();


Console.WriteLine("");
Console.WriteLine("");

Console.WriteLine("Arrays vs Dictionaries");
Console.WriteLine("----------------------");

// Create an array of names
string[] studentNames = { "John", "Mary", "Samantha", "Amanda", "Bernard", "Kyle" };

// Create an array of array of integers
int[][] studentScores = new int[][]
{
    new int[] { 97, 92, 81, 60 },
    new int[] { 75, 84, 91, 39 },
    new int[] { 88, 94, 65, 85 },
    new int[] { 98, 93, 96, 97 },
    new int[] { 75, 59, 89, 77 },
    new int[] { 85, 55, 82, 60 }
};

var sumOfScores = 0;

// Write the names and their scores
foreach (string studentName in studentNames)
{
    int index = Array.IndexOf(studentNames, studentName);
    int[] score = studentScores[index];
    sumOfScores = score[0] + score[1] + score[2] + score[3];
    Console.WriteLine($"{studentName} scored {score[0]}, {score[1]}, {score[2]}, and {score[3]}: Total of {sumOfScores}");
    // Convert scores to letters
    int sumOfScoresAverage = sumOfScores / score.Length;
    if (sumOfScoresAverage > 97)
        Console.WriteLine($"{studentName} scored an average of {sumOfScoresAverage} and received an A+.");
    else if (sumOfScoresAverage > 93)
        Console.WriteLine($"{studentName} scored an average of {sumOfScoresAverage} and received an A.");
    else if (sumOfScoresAverage > 90)
        Console.WriteLine($"{studentName} scored an average of {sumOfScoresAverage} and received an A-.");
    else if (sumOfScoresAverage > 87)
        Console.WriteLine($"{studentName} scored an average of {sumOfScoresAverage} and received a B+.");
    else if (sumOfScoresAverage > 83)
        Console.WriteLine($"{studentName} scored an average of {sumOfScoresAverage} and received a B.");
    else if (sumOfScoresAverage > 80)
        Console.WriteLine($"{studentName} scored an average of {sumOfScoresAverage} and received a B-.");
    else if (sumOfScoresAverage > 77)
        Console.WriteLine($"{studentName} scored an average of {sumOfScoresAverage} and received a C+.");
    else if (sumOfScoresAverage > 73)
        Console.WriteLine($"{studentName} scored an average of {sumOfScoresAverage} and received a C.");
    else if (sumOfScoresAverage > 70)
        Console.WriteLine($"{studentName} scored an average of {sumOfScoresAverage} and received a C-.");
    else if (sumOfScoresAverage > 67)
        Console.WriteLine($"{studentName} scored an average of {sumOfScoresAverage} and received a D+.");
    else if (sumOfScoresAverage > 63)
        Console.WriteLine($"{studentName} scored an average of {sumOfScoresAverage} and received a D.");
    else if (sumOfScoresAverage > 60)
        Console.WriteLine($"{studentName} scored an average of {sumOfScoresAverage} and received a D-.");
    else
        Console.WriteLine($"{studentName} scored an average of {sumOfScoresAverage} and received an F.");
    
    Console.WriteLine("");
}

Console.WriteLine("");
Console.WriteLine("");


/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}


Console.WriteLine();
Console.WriteLine();


Console.WriteLine("Data Types");
Console.WriteLine("----------");

Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

Console.WriteLine();
Console.WriteLine();
