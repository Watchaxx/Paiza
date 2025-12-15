// 実行時間 1340ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        bool[,] g = new bool[n[0], n[0]];
        int s = ( 1 << n[0] ) - 1;
        int v = 0;
        int[,] f = new int[1 << n[0], n[0]];
        long[,] d = new long[1 << n[0], n[0]];
        var l = new System.Collections.Generic.List<int>();

        foreach( int i in Range( 0, n[1] ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            g[a[0], a[1]] = true;
        }
        d[0, 0] = 1;
        foreach( int i in Range( 0, 1 << n[0] ) ) {
            foreach( int j in Range( 0, n[0] ) ) {
                foreach( int k in Range( 0, n[0] ) ) {
                    if( ( i >> k & 1 ) != 1 && g[j, k] != false && j != k && 0 < d[i, j] ) {
                        f[i | ( 1 << k ), k] = j;
                        d[i | ( 1 << k ), k] += d[i, j];
                    }
                }
            }
        }
        while( 0 < s ) {
            int u = f[s, v];

            l.Add( v + 1 );
            s ^= 1 << v;
            v = u;
        }
        l.Add( 1 );
        l.Reverse();
        WriteLine( string.Join( " ", l ) );
        return;
    }
}
