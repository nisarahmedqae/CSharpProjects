namespace LogicalPrograms.CollectionsPractice
{
    public class ListSorting
    {

        [Test]
        public void ListSorting_Test()
        {
            // Example list of strings
            List<string> names = new List<string> { "John", "Alice", "Bob", "Eve" };

            // Sorting the list in descending order
            names.Sort();
            names.Reverse(); // Reverse the sorted list to get descending order

            // Print sorted list elements in descending order
            Console.WriteLine("Sorted List Elements (Descending):");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}