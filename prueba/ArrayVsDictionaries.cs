public class ArrayVsDictionaries
{
    public static string GenerateArrayVsDictionaries()
    {
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

        return $@"";
    }
}