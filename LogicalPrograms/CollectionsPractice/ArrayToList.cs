namespace LogicalPrograms.CollectionsPractice
{
    public class ArrayToList
    {

        [Test]
        public void ArrayToList_Test()
        {
            int[] numbersArray = { 1, 2, 3, 4, 5 };

            // Convert array to list
            List<int> numbersList = numbersArray.ToList();

            // Print the list
            Console.WriteLine("List:");
            foreach (var num in numbersList)
            {
                Console.Write(num + " ");
            }
        }
    }
}