using System.Text;

namespace HelloWorld;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your grade for your assignement: ");
        string? userScore = Console.ReadLine();
        string letterGrade = String.Empty;
        if (Int32.TryParse(userScore, out int _score))
        {
            if (_score >= 90)
            {
                letterGrade = "A";
            }
            else if (_score >= 80)
            {
                letterGrade = "B";
            }
            else if (_score >= 70)
            {
                letterGrade = "C";
            }
            else if (_score >= 60)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }
            Console.WriteLine($"You're grade was a(n) {letterGrade}");

            switch (letterGrade)
            {
                case "A":
                    Console.WriteLine("Good job!  You did well.");
                    break;
                case "B":
                    Console.WriteLine("Not bad.");
                    break;
                case "C":
                    Console.WriteLine("Good enough to pass.");
                    break;
                case "D":
                    Console.WriteLine("You need to do better!");
                    break;
                default:
                    Console.WriteLine("Try harder!  The effort is lacking.");
                    break;
            }

        } else
        {
            Console.WriteLine("Enter a numeric score.");
        }
    }
}
