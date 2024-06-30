namespace LogicalPrograms.CollectionsPractice
{
    public class IterateDictWithForLoop
    {

        [Test]
        public void IterateDictWithForLoop_Test()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>
        {
            { "one", 1 },
            { "two", 2 },
            { "three", 3 },
            { "four", 4 }
        };

            // Using a for loop to iterate over key-value pairs
            for (int i = 0; i < dictionary.Count; i++)
            {
                // Accessing key and value using ElementAt method
                Console.WriteLine($"Key: {dictionary.ElementAt(i).Key}, Value: {dictionary.ElementAt(i).Value}");
            }
        }
    }
}