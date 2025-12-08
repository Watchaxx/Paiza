// 実行時間 50ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] d = Repeat( -1, n[0] + 1 ).ToArray();
        var e = new (int, int, int)[n[1] + 1];

        d[n[2]] = 0;
        foreach( int i in Range( 1, n[1] ) ) {
            int[] a = ReadLine().Split().Select( int.Parse ).ToArray();

            e[i] = (a[0], a[1], a[2]);
        }
        foreach( int _ in Range( 0, n[0] - 1 ) ) {
            int[] t = new int[n[0] + 1];

            d.CopyTo( t, 0 );
            foreach( var g in e.Where( x => d[x.Item1] != -1 ) ) {
                t[g.Item2] = t[g.Item2] == -1 ? d[g.Item1] + g.Item3
                    : new[] { d[g.Item1] + g.Item3, t[g.Item2] }.Min();
            }
            t.CopyTo( d, 0 );
        }
        WriteLine( string.Join( System.Environment.NewLine,
            d.Skip( 1 ).Select( x => x != -1 ? $"{x}" : "inf" ) ) );
        return;
    }
}
