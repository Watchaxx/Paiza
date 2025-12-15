// 実行時間 1330ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        bool[,] g = new bool[n[0], n[0]];
        long[,] d = new long[1 << n[0], n[0]];

        foreach( int i in Range( 0, n[1] ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            g[a[0], a[1]] = true;
        }
        d[0, 0] = 1;
        foreach( int i in Range( 0, 1 << n[0] ) ) {
            foreach( int j in Range( 0, n[0] ) ) {
                foreach( int k in Range( 0, n[0] ) ) {
                    if( ( i >> k & 1 ) != 1 && g[j, k] != false && j != k ) {
                        d[i | ( 1 << k ), k] += d[i, j];
                    }
                }
            }
        }
        WriteLine( d[( 1 << n[0] ) - 1, 0] );
        return;
    }
}
