using System;

namespace Simultaneous_Equations_Solver
{
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

            if ((_equation1.Contains(" + ") && _equation2.Contains(" + ")) || (_equation1.Contains(" - ") && _equation2.Contains(" - ")))
            {
                _equation1 = _equation1.Replace("x", "");
                _equation1 = _equation1.Replace("y", "");
                _equation1 = _equation1.Replace(" ", "");
                Console.WriteLine(_equation1);
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
            Console.WriteLine("Hello welcome to Simultaneous_Equations_Solver, to use this please make sure that there are spaces betweem +,-,+. For example 2x - 3y = 5 NOT 2x-3y=5");
            Console.Write("First equation:");
            string equation1 = Console.ReadLine();
            Console.Write("Secound equation:");
            string equation2 = Console.ReadLine();

            Solve(equation1, equation2);

        }
    }
}
