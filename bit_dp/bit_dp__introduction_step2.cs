// 実行時間 120ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] c = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();
        int[] p = ReadLine().Split().Select( int.Parse ).ToArray();
        int m = 1 << n[0];
        long[] d = Repeat( long.MaxValue / 2, m ).ToArray();

        d[0] = 0L;
        foreach( int i in Range( 0, n[1] ) ) {
            foreach( int j in Range( 0, m ) ) {
                d[j | ( 1 << c[i] )] = System.Math.Min( d[j | ( 1 << c[i] )], d[j] + p[i] );
            }
        }
        WriteLine( d[m - 1] );
        return;
    }
}
