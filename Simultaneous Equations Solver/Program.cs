using System;

namespace Simultaneous_Equations_Solver
{
    static class Helper
    {
        public static string GetUntilOrEmpty(this string text, string stopAt)
        {
            if (!String.IsNullOrWhiteSpace(text))
            {
                int charLocation = text.IndexOf(stopAt, StringComparison.Ordinal);

                if (charLocation > 0)
                {
                    return text.Substring(0, charLocation);
                }
            }

            return String.Empty;
        }
    }

    class Program
    {

        string equation1;
        string equation2;

        static void Solve(string _equation1, string _equation2)
        {
            string Real1 = _equation1;
            string Real2 = _equation2;
            string part1;
            string part2;
            string part3;
            string part4;
            string part5;
            string part6;

            if ((_equation1.Contains(" + ") && _equation2.Contains(" + ")))
            {
                _equation1 = _equation1.Replace("x", "");
                _equation1 = _equation1.Replace("y", "");
                _equation1 = _equation1.Replace(" ", "");

                _equation2 = _equation2.Replace("x", "");
                _equation2 = _equation2.Replace("y", "");
                _equation2 = _equation2.Replace(" ", "");

                part1 = _equation1.GetUntilOrEmpty("+");
                Console.WriteLine(part1);

                string _part2 = _equation1.GetUntilOrEmpty("=");
                part2 = _part2.Replace(part1 + "+", "");
                Console.WriteLine(part2);
 
                part3 = _equation1.Substring(_equation1.IndexOf("="));
                part3 = part3.Replace("=", "");
                Console.WriteLine(part3);

                part4 = _equation2.GetUntilOrEmpty("+");
                Console.WriteLine(part4);

                string _part5 = _equation2.GetUntilOrEmpty("=");
                part5 = _part5.Replace(part4 + "+", "");
                Console.WriteLine(part5);

                part6 = _equation2.Substring(_equation2.IndexOf("="));
                part6 = part6.Replace("=", "");
                Console.WriteLine(part6);

                if (part1 == part4)
                {
                    double awnser = double.Parse(part5) - double.Parse(part2);
                    double awnser2 = double.Parse(part6) - double.Parse(part3);
                    if (awnser2 != 1)
                    {
                        double final = awnser / awnser2;
                        Console.WriteLine(final.ToString());
                    }
                    else
                    {
                        Console.WriteLine(_equation1.);
                    }
                }
                else if (part2 == part5)
                {
                    double awnser = double.Parse(part4) - double.Parse(part1);
                    double awnser2 = double.Parse(part6) - double.Parse(part3);
                }
                else
                {

                }
            }
            else if (_equation1.Contains(" - ") && _equation2.Contains(" - "))
            {

            }
            else if (_equation1.Contains(" - ") && _equation2.Contains(" + "))
            {

            }
            else
            {

            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello welcome to Simultaneous_Equations_Solver, to use this please make sure that there are spaces betweem +,-,+. For example 2x + 3y = 5, NOT 2x-3y=5");
            Console.Write("First equation:");
            string equation1 = Console.ReadLine();
            Console.Write("Secound equation:");
            string equation2 = Console.ReadLine();

            Solve(equation1, equation2);

        }
    }
}
