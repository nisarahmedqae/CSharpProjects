namespace LogicalPrograms.CollectionsPractice
{
    public class IterateListWithForLoop
    {

        [Test]
        public void IterateListWithForLoop_Test()
        {
            List<int> list = new List<int> { 1, 2, 3, 4 };

            // Using a for loop
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}