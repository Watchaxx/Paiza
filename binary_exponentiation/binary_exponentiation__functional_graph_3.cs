// 実行時間 40ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[][] a = new int[64][];

        foreach( int i in Range( 0, 64 ) ) {
            a[i] = new int[n[0]];
        }
        a[0] = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();
        foreach( int i in Range( 0, 63 ) ) {
            a[i + 1] = NextRow( n[0], a[i] );
        }
        WriteLine( string.Join( System.Environment.NewLine, Range( 0, n[0] ).Select( x => Move( x, n[1], a ) + 1 ) ) );
        return;
    }

    static int Move( int s, int k, int[][] a )
    {
        foreach( int i in Range( 0, 64 ).Where( x => ( k & ( 1L << x ) ) != 0 ) ) {
            s = a[i][s];
        }
        return s;
    }

    static int[] NextRow( int n, int[] a )
    {
        int[] r = new int[n];

        foreach( int i in Range( 0, n ) ) {
            r[i] = a[a[i]];
        }
        return r;
    }
}
