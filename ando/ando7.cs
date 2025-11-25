// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        decimal[] d = ReadLine().Split().Select( decimal.Parse ).ToArray();
        decimal[] e = ReadLine().Split().Select( decimal.Parse ).ToArray();
        WriteLine( e[0] / e[1] < d[0] / d[1] ? 1 : 2 );
        return;
    }
}
