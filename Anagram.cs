namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string Sort(string s) => new string(s.OrderBy(c => c).ToArray());
            "parts,traps,arts,rats,starts,tarts,rat,art,tar,tars,stars,stray"
            .Split(',')
            .Where(x => Sort(x) == Sort("Star"));


             
            

        }
    }

}

