namespace LogicalPrograms.CollectionsPractice
{
    public class PrintListWOIteration
    {

        [Test]
        public void PrintListWOIteration_Test()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // Print the list without iterating
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}