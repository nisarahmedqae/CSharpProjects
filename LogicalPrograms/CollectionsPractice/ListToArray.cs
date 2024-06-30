namespace LogicalPrograms.CollectionsPractice
{
    public class ListToArray
    {

        [Test]
        public void ListToArray_Test()
        {
            List<int> numbersList = new List<int> { 1, 2, 3, 4, 5 };

            // Convert list to array
            int[] numbersArray = numbersList.ToArray();

            // Print the array
            Console.WriteLine("Array:");
            foreach (var num in numbersArray)
            {
                Console.Write(num + " ");
            }
        }
    }
}