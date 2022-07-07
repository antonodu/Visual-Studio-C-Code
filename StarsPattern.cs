namespace StarsPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int space = 10;
            int MAX = space;

            for (i = 0; i < MAX; i++)
            {
                for (j = 0; j < space; j++)
                {
                    Console.WriteLine(" ");
                }
                {
                    for (j = 0; j <= i; j++) ;
                }
                {
                    Console.WriteLine("* ");
                }

                Console.Write("\n");
              
            }
            Console.ReadLine();
        }
    }
}

