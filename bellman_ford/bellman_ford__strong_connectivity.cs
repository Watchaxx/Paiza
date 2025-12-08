// 実行時間 110ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] dm = Repeat( -1, n[0] ).ToArray();
        int[] ds = Repeat( -1, n[0] ).ToArray();
        var e = new (int, int)[n[1]];

        dm[0] = 0;
        ds[0] = 0;
        foreach( int i in Range( 0, n[1] ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            e[i] = (a[0], a[1]);
        }
        foreach( int _ in Range( 0, n[0] - 1 ) ) {
            int[] t = new int[n[0]];

            ds.CopyTo( t, 0 );
            foreach( var p in e.Where( x => ds[x.Item1] != -1 ) ) {
                t[p.Item2] = t[p.Item2] == -1 ? ds[p.Item1] + 1
                    : new[] { ds[p.Item1] + 1, t[p.Item2] }.Min();
            }
            t.CopyTo( ds, 0 );
            dm.CopyTo( t, 0 );
            foreach( var p in e.Where( x => dm[x.Item2] != -1 ) ) {
                t[p.Item1] = t[p.Item1] == -1 ? dm[p.Item2] + 1
                    : new[] { dm[p.Item2] + 1, t[p.Item1] }.Min();
            }
            t.CopyTo( dm, 0 );
        }
        WriteLine( ds.Union( dm ).Contains( -1 ) ? "No" : "Yes" );
        return;
    }
}
