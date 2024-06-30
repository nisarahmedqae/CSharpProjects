namespace LogicalPrograms.ArraysPractice
{
    public class IterateArrayWithForLoop
    {

        [Test]
        public void IterateArrayWithForLoop_Test()
        {
            int[] array = { 1, 2, 3, 4 };

            // Using a for loop
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}