namespace TwoSums
{
    class Program
    {
        static void Main()
        {
            var numbers = new List<int>() { 3, 1, 5, 7, 5, 9 };
            int target = 10;

            var items = numbers.Select((value, index) => new { index, value });
        }
        var hits = from a in items
                   from b in items
                   where (a.index != b.index) && (a.value + b.value == target)
                   select new { index1 = a.index, index2 = b.index};

    }
}

       
  

