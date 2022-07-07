namespace SumOfDigits
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please Enter Input Number");
            int inputNum = Int32.Parse(Console.ReadLine());

            int = backupvalue = inputNum;
            int = sum = 0, remainder = 0;

            while (inputNum != 0)
            {
                remainder = inputNum % 10;
                sum = sum + remainder;
                inputNum = inputNum / 10;
            }
            Console.WriteLine("sum of {0} is {1}", backupvalue, sum); 
        }
    }
}
