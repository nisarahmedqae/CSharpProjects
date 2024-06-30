namespace LogicalPrograms.IntPractice
{
    public class LengthExample
    {

        [Test]
        public void LengthExample_Test()
        {
            string str = "Hello, World!";
            int strLength = str.Length;

            int[] arr = { 1, 2, 3, 4, 5 };
            int arrLength = arr.Length;

            List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            int listCount = list.Count;
        }
    }
}