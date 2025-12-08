// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] d = Repeat( -1, n[0] + 1 ).ToArray();
        int[] f = new int[n[0] + 1];
        var e = new (int, int, int)[n[1] + 1];

        d[n[2]] = 0;
        foreach( int i in Range( 0, n[1] ) ) {
            int[] a = ReadLine().Split().Select( int.Parse ).ToArray();

            e[i + 1] = (a[0], a[1], a[2]);
            if( a[0] == n[2] ) {
                d[a[1]] = a[2];
            }
        }
        d.CopyTo( f, 0 );
        foreach( var g in e.Skip( 1 ).Where( x => d[x.Item1] != -1 ) ) {
            f[g.Item2] = f[g.Item2] < 0 ? d[g.Item1] + g.Item3
                : new[] { d[g.Item1] + g.Item3, f[g.Item2] }.Min();
        }
        WriteLine( string.Join( System.Environment.NewLine,
            f.Skip( 1 ).Select( x => x != -1 ? $"{x}" : "inf" ) ) );
        return;
    }
}
