// 実行時間 60ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] d = Repeat( -1, n[0] ).ToArray();
        var e = new (int, int, int)[n[1]];

        d[n[2] - 1] = 0;
        foreach( int i in Range( 0, n[1] ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            e[i] = (a[0], a[1], a[2] + 1);
        }
        foreach( int _ in Range( 0, n[0] - 1 ) ) {
            int[] t = new int[n[0]];

            d.CopyTo( t, 0 );
            foreach( var p in e.Where( x => d[x.Item1] != -1 ) ) {
                t[p.Item2] = t[p.Item2] == -1 ? d[p.Item1] + p.Item3
                    : new[] { d[p.Item1] + p.Item3, t[p.Item2] }.Min();
            }
            t.CopyTo( d, 0 );
        }
        WriteLine( e.Any( x => d[x.Item1] + x.Item3 < d[x.Item2] ) ? "Yes" : "No" );
        return;
    }
}
