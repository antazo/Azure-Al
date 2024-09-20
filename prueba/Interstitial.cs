
using System.Text;
// See https://aka.ms/new-console-template for more information
//using Figgle;
// Sample for the Environment.GetEnvironmentVariables method
using System;
using System.Collections;
using System.Reflection.Metadata.Ecma335;

//Console.BackgroundColor = ConsoleColor.Blue;
//Console.Write("Lorem ipsum dolor sit amet consectetur adipiscing elit, in fringilla maecenas lobortis duis turpis risus, praesent porta facilisis nostra aptent nibh. Nulla massa taciti vulputate fringilla ac cursus mollis pharetra, penatibus iaculis molestie praesent arcu nibh ridiculus. Donec pharetra vulputate varius felis scelerisque phasellus per aliquam class, viverra dui iaculis urna himenaeos turpis posuere ac, curabitur auctor ultricies neque in duis vivamus habitasse.");

public class Interstitial
{
    public static string GenerateIntro()
    {
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

// Welcome, this is about artificial intelligence...
string japaneseIntro = "\n\n\u3088\u3046\u3053\u305d\u3001\u3053\u308c\u306f\u4eba\u5de5\u77e5\u80fd\u306b\u3064\u3044\u3066\u3067\u3059\u002e\u002e\u002e\n\t";

// En un lugar de la Mancha, de cuyo nombre no quiero acordarme, no ha mucho tiempo que vivía un hidalgo de los de lanza en astillero, adarga antigua, rocín flaco y galgo corredor.
string japaneseQuijote = "\u540d\u524d\u306f\u601d\u3044\u51fa\u3057\u305f\u304f\u306a\u3044\u304c\u3001\u30e9\u30fb\u30de\u30f3\u30c1\u30e3\u306e\u3042\u308b\u5834\u6240\u306b\u3001\u5c11\u3057\u524d\u307e\u3067\u3001\u69cd\u3092\u6301\u3063\u305f\u7d33\u58eb\u3001\u5e74\u8001\u3044\u305f\u30d0\u30c3\u30af\u30e9\u30fc\u3001\u3084\u305b\u305f\u5c0f\u8a00\u3001\u30ec\u30fc\u30b7\u30f3\u30b0\u30fb\u30b0\u30ec\u30a4\u30cf\u30a6\u30f3\u30c9\u3092\u6301\u3063\u305f\u7d33\u58eb\u304c\u4f4f\u3093\u3067\u3044\u305f\u3002\n\t";

return $@"
{terminator}

{japaneseIntro}

{japaneseQuijote}

Hello {EnvironmentVariableTarget.User} ^_^

";
    }
}