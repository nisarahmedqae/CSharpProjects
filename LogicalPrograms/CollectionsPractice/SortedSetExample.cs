namespace LogicalPrograms.CollectionsPractice
{
    public class SortedSetExample
    {

        [Test]
        public void SortedSetExample_Test()
        {
            // Creating a SortedSet of integers
            SortedSet<int> sortedSet = new SortedSet<int>();

            // Adding elements to the SortedSet
            sortedSet.Add(5);
            sortedSet.Add(1);
            sortedSet.Add(3);
            sortedSet.Add(2); // Duplicate element, will be ignored

            // Checking if an element exists in the SortedSet
            bool containsThree = sortedSet.Contains(3); // true

            // Removing an element from the SortedSet
            sortedSet.Remove(1);

            // Iterating over elements in the SortedSet
            foreach (int num in sortedSet)
            {
                Console.WriteLine(num);
            }
        }
    }
}