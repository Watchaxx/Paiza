// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] a = ReadLine().Trim().Split().Select( int.Parse ).ToArray();

        WriteLine( a.Sum() );
        WriteLine( a[0] * a[1] * a[2] );
        return;
    }
}
