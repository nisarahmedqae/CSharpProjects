namespace LogicalPrograms.IntPractice
{
    public class IntToDigits
    {

        [Test]
        public void IntToDigits_Test()
        {
            int number = 123;
            char[] charArray = number.ToString().ToCharArray();
            Console.WriteLine(string.Join(", ", charArray));
        }
    }
}