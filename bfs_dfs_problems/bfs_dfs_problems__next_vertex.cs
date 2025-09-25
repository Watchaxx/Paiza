// 実行時間 190ms
using static System.Console;
using static System.Linq.Enumerable;
using Lst = System.Collections.Generic.List<int>;

internal class Program
{
    static void Main()
    {
        int[] nx = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();
        var g = new Lst[nx[0] + 1];

        foreach( int i in Range( 0, nx[0] + 1 ) ) {
            g[i] = new Lst();
        }
        foreach( int _ in Range( 0, nx[0] ) ) {
            int[] a = ReadLine().Split().Select( int.Parse ).ToArray();

            g[a[0] - 1].Add( a[1] );
            g[a[1] - 1].Add( a[0] );
        }
        WriteLine( string.Join( System.Environment.NewLine, g[nx[1]].OrderBy( x => x ) ) );
        return;
    }
}
