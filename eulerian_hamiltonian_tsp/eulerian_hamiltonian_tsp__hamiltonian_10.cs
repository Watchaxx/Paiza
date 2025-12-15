// 実行時間 1500ms
using static System.Console;
using static System.Linq.Enumerable;
using Lst = System.Collections.Generic.List<int>;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[,] f = new int[1 << n[0], n[0]];
        long[,] d = new long[1 << n[0], n[0]];
        bool[,] g = new bool[n[0], n[0]];
        var l = new Lst();
        var p = new Lst();
        var q = new Lst();

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
        if( 0 < d[( 1 << n[0] ) - 1, 0] ) {
            int s = ( 1 << n[0] ) - 1;
            int v = 0;

            while( 0 < s ) {
                int u = f[s, v];

                l.Add( v + 1 );
                s ^= 1 << v;
                v = u;
            }
            l.Add( 1 );
        }
        foreach( int i in Range( 0, l.Count - 1 ) ) {
            p.Add( l[i] );
            q.Add( l[i] + n[0] );
            p.Add( l[i] + n[0] );
            q.Add( l[i + 1] + n[0] );
        }
        WriteLine( p.Count );
        WriteLine( string.Join( System.Environment.NewLine,
            Range( 0, p.Count ).Select( x => $"{p[x]} {q[x]}" ) ) );
        return;
    }
}
