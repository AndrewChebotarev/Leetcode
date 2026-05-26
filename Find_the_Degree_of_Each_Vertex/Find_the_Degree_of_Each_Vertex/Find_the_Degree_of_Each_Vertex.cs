namespace Find_the_Degree_of_Each_Vertex
{
    public class Find_the_Degree_of_Each_Vertex
    {
        public Find_the_Degree_of_Each_Vertex(int[][] matrix)
        {
            int coutSubResult = 0;
            int[] result = new int[matrix.Length];

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                    if (matrix[i][j] == 1) coutSubResult++;

                result[i] = coutSubResult;
                coutSubResult = 0;
            }

            foreach (int num in result) Console.Write(num + " "); 
        }
    }
}
