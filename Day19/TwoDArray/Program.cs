namespace TwoDArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[2,3];
            System.Console.WriteLine(data.Length);

            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    System.Console.Write("Enter value for {i} {j} : ");
                    data[i,j] = int.Parse(Console.ReadLine());
                }
            }

            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    System.Console.Write($"{data[i,j]} ");
                }
                System.Console.WriteLine();
            }
        }
    }
}
