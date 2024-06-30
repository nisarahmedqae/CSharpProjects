namespace LogicalPrograms.CollectionsPractice
{
    public class DictionarySorting
    {

        [Test]
        public void DictionarySorting_Test()
        {
            // Example dictionary of integers and their corresponding strings
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>
        {
            { 3, "Three" },
            { 1, "One" },
            { 2, "Two" }
        };

            // Sorting the dictionary by key in descending order
            var sortedDict = keyValuePairs.OrderByDescending(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            // Print sorted dictionary elements by key in descending order
            Console.WriteLine("Sorted Dictionary Elements (by Key, Descending):");
            foreach (var kvp in sortedDict)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
        }
    }
}