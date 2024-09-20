public class Gpa
{
    public static string GenerateGpa()
    {
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

        return $@"";
    }
}