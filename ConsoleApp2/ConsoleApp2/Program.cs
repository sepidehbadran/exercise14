// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        int good = 0;
        int moderate = 0;
        int weak = 0;
        int totalStudents = 0;
        int excellent = 0;
        while (true)
        {
            Console.WriteLine("(for end enter the negative number) Please Enter The Student Grade :");
            int grade = Convert.ToInt32(Console.ReadLine());
            if (grade < 0)
            {
                break;
                switch (grade)
                {
                    case int number when number >= 18:
                        excellent++;
                        break;
                    case int number when number >= 15:
                        good++;
                        break;
                    case int number when number >= 12:
                        moderate++; break;
                        default:
                        weak++; break;
                        {
                            totalStudents++;
                            Console.WriteLine($"all of students:{totalStudents}");
                            Console.WriteLine($"the excellent student : {excellent} ({(double)excellent/totalStudents: P1})");
                            Console.WriteLine($"the good student : {good} ({(double)good / totalStudents:P1})");
                            Console.WriteLine($"the moderate student : {moderate} ({(double)moderate/ totalStudents:P1})");
                            Console.WriteLine($"the weak student : {weak} ({(double)weak /totalStudents:P1})");
                        }

                }
            }
        }
    }
}
