using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        decimal[] w1 = ReadLine().Split().Select( decimal.Parse ).ToArray();
        decimal[] w2 = ReadLine().Split().Select( decimal.Parse ).ToArray();
        WriteLine( w2[0] / w2[1] < w1[0] / w1[1] ? w1[1] : w2[1] );
        return;
    }
}
