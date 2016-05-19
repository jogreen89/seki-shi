using System;
using System.Collections.Generic;
using System.Linq;

namespace CmdLn
{
    class Program
    {
        // Display the number of command line arguments:
        static void Main(string[] args)
        {
            System.Console.WriteLine(args.Length);

            // Specify the data source.
            int[] scores = new int[] { 97, 92, 81, 60 };

            // Define the query expression.
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;

            // Execute the query.
            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }
            return;
        }
    }
    // Output: 97 92 81
}
