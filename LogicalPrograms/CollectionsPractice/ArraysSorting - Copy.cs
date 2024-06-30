namespace LogicalPrograms.CollectionsPractice
{
    public class ArraysSorting
    {

        [Test]
        public void ArraysSorting_Test()
        {
            // Example array of integers
            int[] numbers = { 5, 1, 3, 2 };

            // Sorting the array in descending order
            Array.Sort(numbers);
            Array.Reverse(numbers); // Reverse the sorted array to get descending order

            // Print sorted array elements in descending order
            Console.WriteLine("Sorted Array Elements (Descending):");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}