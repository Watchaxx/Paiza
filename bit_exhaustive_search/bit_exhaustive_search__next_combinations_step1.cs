// 実行時間 170ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        long[] a = ReadLine().Split().Select( long.Parse ).ToArray();
        long o = 0L;

        foreach( int i in Range( 0, 1 << n[0] ).Where( x => PopCnt( x ) == n[1] ) ) {
            long s = 0L;

            foreach( int j in Range( 0, n[0] ).Where( x => ( ( i >> x ) & 1 ) != 0 ) ) {
                s ^= a[j];
            }
            o = System.Math.Max( o, s );
        }
        WriteLine( o );
        return;
    }

    static int PopCnt( int i )
    {
        int r = 0;

        while( 0 < i ) {
            if( ( i & 1 ) != 0 ) {
                r++;
            }
            i >>= 1;
        }
        return r;
    }
}
