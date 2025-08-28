// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] x = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = new int[1000];

        a[0] = x[0];
        foreach( int i in Range( 1, x[3] - 1 ) ) {
            a[i] = i % 2 == 0 ? a[i - 1] + x[1] : a[i - 1] + x[2];
        }
        WriteLine( a[x[3] - 1] );
        return;
    }
}
