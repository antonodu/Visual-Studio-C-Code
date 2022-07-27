namespace PrimeatNthPosition
{
    class Program
    {
        static void Main( string[] args)
        {
            Console.WriteLine("Please enter input number:");
            int input = int.Parse( Console.ReadLine() );
            if(input <= 1)
            {
                Console.WriteLine("This is an invalid number");
            }
            else
            {
                int flag = 0;
                for (int i = 2; i < input; i++)
                {
                    if(input%i == 0)
                    {
                        Console.WriteLine(" {0} is not a prime number", input);
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    Console.WriteLine("{0} is a prime number", input);
                }
            }
        }
    }
}
            
   
