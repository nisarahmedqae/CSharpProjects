using System.Collections;
using System.Collections.Specialized;
using NUnit.Framework;

namespace LogicalPrograms.CollectionsPractice
{
    public class OrderedDictionaryExample
    {

        [Test]
        public void OrderedDictionary_Test()
        {
            OrderedDictionary orderedDict = new OrderedDictionary();

            // Add elements to the ordered dictionary in your desired order
            orderedDict.Add("one", 1);
            orderedDict.Add("two", 2);
            orderedDict.Add("three", 3);

            // Access elements in insertion order
            foreach (DictionaryEntry entry in orderedDict)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }
        }
    }
}