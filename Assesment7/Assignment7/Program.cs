namespace Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = [5, 3, -6, -4, 10, 2];
            //int[] A = [1, 2, 3];
            //int[] A = [-1, -3];

            Solution solution = new Solution();
            int min = solution.solution(A);
            Console.WriteLine("Square of Minimum Value is: " + (min * min));
        }
    }
}
