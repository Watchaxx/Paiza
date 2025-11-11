// 実行時間 110ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[][] c = Colors( n[1] );
        int[] p = ReadLine().Split().Select( int.Parse ).ToArray();
        int m = 1 << n[0];
        long[] d = Repeat( long.MaxValue / 2, m ).ToArray();

        d[0] = 0;
        foreach( int i in Range( 0, n[1] ) ) {
            int t = 0;

            foreach( int j in c[i] ) {
                t |= 1 << j;
            }
            foreach( int j in Range( 0, m ) ) {
                d[j | t] = System.Math.Min( d[j | t], d[j] + p[i] );
            }
        }
        WriteLine( d[m - 1] );
        return;
    }

    static int[][] Colors( int m )
    {
        int[][] r = new int[m][];

        foreach( int i in Range( 0, m ) ) {
            r[i] = ReadLine().Split().Skip( 1 ).Select( x => int.Parse( x ) - 1 ).ToArray();
        }
        return r;
    }
}
