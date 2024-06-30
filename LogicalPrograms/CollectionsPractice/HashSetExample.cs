namespace LogicalPrograms.CollectionsPractice
{
    public class HashSetExample
    {

        [Test]
        public void HashSetExample_Test()
        {
            // Creating a HashSet of integers
            HashSet<int> hashSet = new HashSet<int>();

            // Adding elements to the HashSet
            hashSet.Add(1);
            hashSet.Add(2);
            hashSet.Add(3);
            hashSet.Add(2); // Duplicate element, will be ignored

            // Checking if an element exists in the HashSet
            bool containsTwo = hashSet.Contains(2); // true

            // Removing an element from the HashSet
            hashSet.Remove(3);

            // Iterating over elements in the HashSet
            foreach (int num in hashSet)
            {
                Console.WriteLine(num);
            }
        }
    }
}