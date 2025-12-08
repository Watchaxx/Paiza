// 実行時間 110ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] d = Repeat( -1, n[0] ).ToArray();
        var e = new System.Collections.Generic.List<(int, int)>( n[1] * 2 );

        d[0] = 0;
        foreach( int i in Range( 0, n[1] ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            e.AddRange( new[] { (a[0], a[1]), (a[1], a[0]) } );
        }
        foreach( int _ in Range( 0, n[0] - 1 ) ) {
            int[] t = new int[n[0]];

            d.CopyTo( t, 0 );
            foreach( var g in e.Where( x => d[x.Item1] != -1 ) ) {
                t[g.Item2] = t[g.Item2] == -1 ? d[g.Item1] + 1
                    : new[] { d[g.Item1] + 1, t[g.Item2] }.Min();
            }
            t.CopyTo( d, 0 );
        }
        WriteLine( d.Contains( -1 ) ? "No" : "Yes" );
        return;
    }
}
