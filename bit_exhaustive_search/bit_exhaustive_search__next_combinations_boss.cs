// 実行時間 110ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        long[] a = ReadLine().Split().Select( long.Parse ).ToArray();
        long o = 0L;
        long t = ( 1 << n[1] ) - 1;

        while( t < ( 1 << n[0] ) ) {
            o = System.Math.Max( o, XorSum( n[0], t, a ) );
            t = Combi( t );
        }
        WriteLine( o );
        return;
    }

    static long Combi( long t )
    {
        long a = t & -t;
        long b = t + a;
        long c = ( ( t & ~b ) / a ) >> 1;
        return b | c;
    }

    static long XorSum( int n, long t, long[] a )
    {
        long r = 0L;

        foreach( int i in Range( 0, n ).Where( x => ( ( t >> x ) & 1 ) != 0 ) ) {
            r ^= a[i];
        }
        return r;
    }
}
