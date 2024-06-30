namespace LogicalPrograms.ArraysPractice
{
    public class MergeArrays
    {

        [Test]
        public void MergeArrays_Test()
        {
            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 4, 5, 6 };

            int[] mergedArray = array1.Concat(array2).ToArray();

            Console.WriteLine("Merged Array:");
            foreach (var item in mergedArray)
            {
                Console.Write(item + " ");
            }
        }
    }
}