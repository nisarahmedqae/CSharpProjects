namespace LogicalPrograms.CollectionsPractice
{
    public class MergeList
    {

        [Test]
        public void MergeList_Test1()
        {
            List<int> list1 = new List<int> { 1, 2, 3 };
            List<int> list2 = new List<int> { 4, 5, 6 };

            list1.AddRange(list2);

            Console.WriteLine("Merged List:");
            foreach (var item in list1)
            {
                Console.Write(item + " ");
            }
        }

        [Test]
        public void MergeList_Test2()
        {
            List<int> list1 = new List<int> { 1, 2, 3 };
            List<int> list2 = new List<int> { 4, 5, 6 };

            // Merge the two lists
            List<int> mergedList = list1.Concat(list2).ToList();

            // Display the merged list
            Console.WriteLine("Merged List:");
            foreach (int num in mergedList)
            {
                Console.WriteLine(num);
            }
        }
    }
}