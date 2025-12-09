// 実行時間 40ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] d = Repeat( -1, n[0] ).ToArray();
        int[] p = Repeat( -1, n[0] ).ToArray();
        int q = n[3];
        var e = new (int, int, int)[n[1]];
        var l = new System.Collections.Generic.List<int>() { n[3] };

        d[n[2] - 1] = 0;
        p[n[2] - 1] = n[2];
        foreach( int i in Range( 0, n[1] ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            e[i] = (a[0], a[1], a[2] + 1);
        }
        foreach( int _ in Range( 0, n[0] - 1 ) ) {
            int[] t = new int[n[0]];

            d.CopyTo( t, 0 );
            foreach( var u in e.Where( x => d[x.Item1] != -1 ) ) {
                if( t[u.Item2] == -1 || d[u.Item1] + u.Item3 < t[u.Item2] ) {
                    t[u.Item2] = d[u.Item1] + u.Item3;
                    p[u.Item2] = u.Item1 + 1;
                }
            }
            t.CopyTo( d, 0 );
        }
        if( d[n[3] - 1] == -1 ) {
            WriteLine( "inf" );
            return;
        }
        while( true ) {
            q = p[q - 1];
            l.Add( q );
            if( q == n[2] ) {
                break;
            }
        }
        l.Reverse();
        WriteLine( d[n[3] - 1] );
        WriteLine( string.Join( " ", l ) );
        return;
    }
}
