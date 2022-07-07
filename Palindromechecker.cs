namespace palindromechecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = string.Empty;
            Console.WriteLine("Enter a string");
            a = Console.ReadLine();

            char[] temp = a.ToCharArray();
            Array.Reverse(temp);
            string b = new string(temp);

            if (a.ToLower().Equals(b.ToLower()))
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not a Palindrome");
            }
         

        }
    }
}