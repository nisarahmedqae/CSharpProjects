namespace LogicalPrograms.ArraysPractice
{
    public class PrintArraysWOIteration
    {

        [Test]
        public void PrintArraysWOIteration_Test()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            // Print the array without iterating
            Console.WriteLine("Array: " + string.Join(", ", numbers));
        }
    }
}