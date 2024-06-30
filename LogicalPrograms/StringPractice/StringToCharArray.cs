namespace LogicalPrograms.StringPractice
{
    public class StringToCharArray
    {

        [Test]
        public void StringToCharArray_Test()
        {
            string str = "Hello, World!";

            // Convert string to char array
            char[] charArray = str.ToCharArray();

            // Print the char array
            Console.WriteLine("Char Array:");
            foreach (var ch in charArray)
            {
                Console.Write(ch + " ");
            }
        }
    }
}