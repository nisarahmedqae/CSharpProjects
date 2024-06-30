namespace LogicalPrograms.ArraysPractice
{
    public class MultiDimensionArrayDeclaration
    {

        [Test]
        public void MultiDimensionArrayDeclaration_Test()
        {
            // Declaration and initialization of a 2D array
            int[,] matrix = new int[3, 4]; // 3 rows, 4 columns

            // Initializing values
            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[0, 2] = 3;
            matrix[0, 3] = 4;
            matrix[1, 0] = 5;
            matrix[1, 1] = 6;
            matrix[1, 2] = 7;
            matrix[1, 3] = 8;
            matrix[2, 0] = 9;
            matrix[2, 1] = 10;
            matrix[2, 2] = 11;
            matrix[2, 3] = 12;

            // Accessing values
            int value = matrix[1, 2]; // Accessing the element in the second row, third column
            Console.WriteLine("Value at matrix[1, 2]: " + value);
        }
    }
}