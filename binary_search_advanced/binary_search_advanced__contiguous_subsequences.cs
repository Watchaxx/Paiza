// 実行時間 130ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        string[] rl = ReadLine().Split();
        int l = 0;
        int n = int.Parse( rl[0] );
        int r = 1 << 24;
        int[] a = ReadLine().Split().Select( int.Parse ).Append( 0 ).ToArray();
        long k = long.Parse( rl[1] );

        while( 1 < r - l ) {
            int m = ( l + r ) / 2;
            long c = 0L;
            long s = (long)n * ( n + 1 ) / 2L;

            foreach( int i in a ) {
                if( m < i ) {
                    c++;
                } else {
                    s -= c * ( c + 1 ) / 2L;
                    c = 0L;
                }
            }
            if( s < k ) {
                l = m;
            } else {
                r = m;
            }
        }
        WriteLine( r );
        return;
    }
}
