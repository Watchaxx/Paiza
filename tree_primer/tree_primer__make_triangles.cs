// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;
using Lst = System.Collections.Generic.List<int>;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int t = 0;
        var g = new Lst[n];

        foreach( int i in Range( 0, n ) ) {
            g[i] = new Lst( n );
        }
        foreach( int _ in Range( 0, n - 1 ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            g[a[0]].Add( a[1] );
            g[a[1]].Add( a[0] );
        }
        foreach( Lst l in g ) {
            t += l.Count * ( l.Count - 1 ) / 2;
        }
        WriteLine( t % 2 != 0 ? "paiza" : "erik" );
        return;
    }
}
