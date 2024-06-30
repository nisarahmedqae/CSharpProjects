using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    public class PrintListWOIteration
    {
        public void Execute()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // Print the list without iterating
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
