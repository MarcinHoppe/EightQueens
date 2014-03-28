// Author: Marcin Hoppe <marcin.hoppe (at) gmail.com>

using System;

namespace MarcinHoppe.EightQueens
{
    class Program
    {
        static void Main(string[] args)
        {
            var problem = new EightQueensProblem();
            problem.Solve();
            problem.PrintSolution();
        }
    }
}
