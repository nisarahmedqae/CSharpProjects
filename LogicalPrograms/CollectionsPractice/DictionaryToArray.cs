namespace LogicalPrograms.CollectionsPractice
{
    public class DictionaryToArray
    {

        [Test]
        public void DictionaryToArray_Test()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>
        {
            { "one", 1 },
            { "two", 2 },
            { "three", 3 }
        };

            // Convert dictionary to array of KeyValuePairs
            KeyValuePair<string, int>[] keyValueArray = dict.ToArray();

            // Print the array
            Console.WriteLine("Array of KeyValuePairs:");
            foreach (var kvp in keyValueArray)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            // Convert keys to array
            string[] keysArray = dict.Keys.ToArray();

            // Convert values to array
            int[] valuesArray = dict.Values.ToArray();
        }
    }
}