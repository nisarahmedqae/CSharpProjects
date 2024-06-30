namespace LogicalPrograms.ArraysPractice
{
    public class MultiDimensionArray
    {

        [Test]
        public void MultiDimensionArray_Test()
        {
            // Declare and initialize a 2D array
            int[,] matrix = new int[,]
            {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
            };

            // Get the dimensions of the array
            int rows = matrix.GetLength(0);    // Number of rows
            int cols = matrix.GetLength(1);    // Number of columns

            // Iterate over the 2D array using nested loops
            Console.WriteLine("Iterating over the 2D array:");

            for (int i = 0; i < rows; i++)      // Loop through each row
            {
                for (int j = 0; j < cols; j++)  // Loop through each column in the current row
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();   // Move to the next line after each row
            }
        }
    }
}