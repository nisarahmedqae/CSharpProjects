namespace LogicalPrograms.CollectionsPractice
{
    public class DictionaryToList
    {

        [Test]
        public void DictionaryToList_Test()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>
        {
            { "one", 1 },
            { "two", 2 },
            { "three", 3 }
        };

            // Convert dictionary to list of KeyValuePairs
            List<KeyValuePair<string, int>> keyValueList = dict.ToList();

            // Print the list
            Console.WriteLine("List of KeyValuePairs:");
            foreach (var kvp in keyValueList)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            //To extract keys:
            List<string> keysList = dict.Keys.ToList();

            //To extract values:
            List<int> valuesList = dict.Values.ToList();
        }
    }
}