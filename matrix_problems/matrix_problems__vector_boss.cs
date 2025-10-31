// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] b = ReadLine().Split().Select( int.Parse ).ToArray();

        WriteLine( a[0] * b[0] + a[1] * b[1] == 0 ? "Yes" : "No" );
        return;
    }
}
