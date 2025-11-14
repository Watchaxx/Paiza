// 実行時間 180ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int r = 0;
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        long o = long.MaxValue;
        long[] s = new long[n + 1];

        foreach( int i in Range( 0, n ) ) {
            s[i + 1] = a[i] + s[i];
        }
        foreach( int i in Range( 1, n - 1 ) ) {
            while( r < n - 1 ) {
                if( ( s[r] - s[i] ) - ( s[n] - s[r] ) < 0 && 0 <= ( s[r + 1] - s[i] ) - ( s[n] - s[r + 1] ) ) {
                    break;
                }
                r++;
            }
            o = Min( o, Max( s[i], s[r] - s[i], s[n] - s[r] ) - Min( s[i], s[r] - s[i], s[n] - s[r] ),
                Max( s[i], s[r + 1] - s[i], s[n] - s[r + 1] ) - Min( s[i], s[r + 1] - s[i], s[n] - s[r + 1] ) );
        }
        WriteLine( o );
        return;
    }

    static long Max( params long[] a )
    {
        return a.Max();
    }

    static long Min( params long[] a )
    {
        return a.Min();
    }
}
