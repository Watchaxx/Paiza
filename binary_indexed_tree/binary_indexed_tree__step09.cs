// 実行時間 70ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        long[] a = ReadLine().Split().Select( long.Parse ).ToArray();
        long[] s = new long[n + 1];

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Range( 0, n ) ) {
            s[i + 1] = a[i] + s[i];
        }
        foreach( int _ in Range( 0, int.Parse( ReadLine() ) ) ) {
            long[] t = ReadLine().Split().Select( long.Parse ).ToArray();
            long b = BisectLeft( s, s[t[1] - 1] + t[2] );

            WriteLine( b == n + 1 ? "No" : s[b] == s[t[1] - 1] + t[2] ? "Yes" : "No" );
        }
        Out.Flush();
        return;
    }

    static long BisectLeft( long[] a, long t )
    {
        long l = 0;
        long r = a.Length;

        while( l < r ) {
            long m = ( l + r ) / 2L;

            if( a[m] < t ) {
                l = m + 1;
            } else {
                r = m;
            }
        }
        return l;
    }
}
