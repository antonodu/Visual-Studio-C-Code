namespace StringReversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World";

            string res = string.Join(" ", str.Split(' ').Select(s => new string(s.Reverse().ToArray())));
            Console.WriteLine(res);

        }
    }
}

