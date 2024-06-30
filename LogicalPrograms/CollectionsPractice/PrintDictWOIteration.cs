namespace LogicalPrograms.CollectionsPractice
{
    public class PrintDictWOIteration
    {

        [Test]
        public void PrintDictWOIteration_Test()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>
        {
            { "one", 1 },
            { "two", 2 },
            { "three", 3 }
        };

            // Print the dictionary without iterating
            Console.WriteLine(string.Join(", ", dict.Select(kvp => $"{kvp.Key}: {kvp.Value}")));
        }
    }
}