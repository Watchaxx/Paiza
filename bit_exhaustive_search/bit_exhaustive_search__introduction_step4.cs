// 実行時間 170ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] p = ReadLine().Split().Select( int.Parse ).ToArray();
        int[][] k = new int[n[1]][];
        long o = long.MaxValue;

        foreach( int i in Range( 0, n[1] ) ) {
            k[i] = ReadLine().Split().Skip( 1 ).Select( x => int.Parse( x ) - 1 ).ToArray();
        }
        foreach( int i in Range( 0, 1 << n[1] ) ) {
            int r = 0;
            long s = 0L;

            foreach( int j in Range( 0, n[1] ).Where( x => ( ( i >> x ) & 1 ) != 0 ) ) {
                s += p[j];
                foreach( int l in k[j] ) {
                    r |= 1 << l;
                }
            }
            if( r == ( 1 << n[0] ) - 1 ) {
                o = System.Math.Min( o, s );
            }
        }
        WriteLine( o != long.MaxValue ? o : -1 );
        return;
    }
}
