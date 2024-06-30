namespace LogicalPrograms.StringPractice
{
    public class ParseString
    {

        [Test]
        public void ParseString_Test()
        {
            string numberString = "12345";

            // Convert string to int
            int number = int.Parse(numberString);

            Console.WriteLine("Number: " + number);
        }
    }
}