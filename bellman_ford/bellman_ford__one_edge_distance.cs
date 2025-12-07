// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] g = Repeat( -1, n[0] + 1 ).ToArray();

        g[n[2]] = 0;
        foreach( int _ in Range( 0, n[1] ) ) {
            int[] a = ReadLine().Split().Select( int.Parse ).ToArray();

            if( a[0] == n[2] ) {
                g[a[1]] = a[2];
            }
        }
        WriteLine( string.Join( System.Environment.NewLine,
            g.Skip( 1 ).Select( x => x != -1 ? $"{x}" : "inf" ) ) );
        return;
    }
}
