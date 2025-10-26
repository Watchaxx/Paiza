// 実行時間 210ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine().Split()[0] );
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        long[] d = new long[n + 1];

        d[0] = 1;
        foreach( int i in Range( 0, n ) ) {
            foreach( int j in a.Where( x => i + x <= n ) ) {
                d[i + j] = ( d[i + j] + d[i] ) % 10000000000;
            }
        }
        WriteLine( d[n] );
        return;
    }
}
