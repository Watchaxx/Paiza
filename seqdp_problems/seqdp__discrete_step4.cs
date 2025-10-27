// 実行時間 300ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] d = new int[n + 1];

        d[0] = 1;
        foreach( int i in Range( 0, n ).Where( x => ( d[x] != 0 ) && ( x + a[x] <= n ) ) ) {
            d[i + a[i]] += d[i];
        }
        WriteLine( d[n] );
        return;
    }
}
