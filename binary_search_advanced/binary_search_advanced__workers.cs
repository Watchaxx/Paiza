// 実行時間 1610ms
using static System.Console;
using static System.Linq.Enumerable;
using Tpl = System.Tuple<int, int>;

internal class Program
{
    static void Main()
    {
        string[] rl = ReadLine().Split();
        int n = int.Parse( rl[0] );
        long k = long.Parse( rl[1] );
        long l = 0;
        long r = 1L << 50;
        Tpl[] t = new Tpl[n];

        foreach( int i in Range( 0, n ) ) {
            int[] a = ReadLine().Split().Select( int.Parse ).ToArray();

            t[i] = new Tpl( a[0], a[1] );
        }
        while( 1 < r - l ) {
            long m = ( l + r ) / 2L;
            long s = 0L;

            foreach( int i in Range( 0, n ) ) {
                s += (long)System.Math.Ceiling( (decimal)( t[i].Item2 + m ) / t[i].Item1 );
            }
            if( s <= k ) {
                l = m;
            } else {
                r = m;
            }
        }
        WriteLine( l );
        return;
    }
}
