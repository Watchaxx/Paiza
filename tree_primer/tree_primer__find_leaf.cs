// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;
using Lst = System.Collections.Generic.List<byte>;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        var g = new Lst[n];

        foreach( int i in Range( 0, n ) ) {
            g[i] = new Lst( n );
        }
        foreach( int _ in Range( 0, n - 1 ) ) {
            byte[] a = ReadLine().Split().Select( byte.Parse ).ToArray();

            g[a[0] - 1].Add( a[1] );
            g[a[1] - 1].Add( a[0] );
        }
        foreach( int i in Range( 0, n ).Where( i => g[i].Count == 1 ) ) {
            WriteLine( i + 1 );
        }
        return;
    }
}
