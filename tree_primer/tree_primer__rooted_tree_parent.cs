// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;
using Lst = System.Collections.Generic.List<int>;

internal class Program
{
    static void Main()
    {
        int[] nkr = ReadLine().Split().Select( int.Parse ).ToArray();
        var g = new Lst[nkr[0] + 1];

        foreach( int i in Range( 0, nkr[0] + 1 ) ) {
            g[i] = new Lst( nkr[0] );
        }
        foreach( int _ in Range( 0, nkr[0] - 1 ) ) {
            int[] a = ReadLine().Split().Select( int.Parse ).ToArray();

            g[a[1]].Add( a[0] );
        }
        foreach( int _ in Range( 0, nkr[1] ) ) {
            WriteLine( string.Join( " ", g[int.Parse( ReadLine() )].OrderBy( x => x ) ) );
        }
        return;
    }
}
