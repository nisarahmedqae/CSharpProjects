namespace LogicalPrograms.CollectionsPractice
{
    public class MergeDictionaries
    {

        [Test]
        public void MergeDictionaries_Test()
        {
            Dictionary<string, int> dict1 = new Dictionary<string, int>()
        {
            { "one", 1 },
            { "two", 2 },
            { "three", 3 }
        };

            Dictionary<string, int> dict2 = new Dictionary<string, int>()
        {
            { "four", 4 },
            { "five", 5 },
            { "six", 6 }
        };

            // Merge the two dictionaries
            Dictionary<string, int> mergedDict = dict1.Concat(dict2)
                                                       .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            // Display the merged dictionary
            foreach (var kvp in mergedDict)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
        }
    }
}