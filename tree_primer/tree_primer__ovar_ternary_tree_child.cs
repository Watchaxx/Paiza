// 実行時間 20ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] nkr = ReadLine().Split().Select( int.Parse ).ToArray();
        var d = new Dictionary<int, List<int>>( nkr[0] );

        foreach( int _ in Range( 0, nkr[0] - 1 ) ) {
            int[] a = ReadLine().Split().Select( int.Parse ).ToArray();

            if( d.ContainsKey( a[0] ) != true ) {
                d[a[0]] = new List<int>( nkr[0] ) { a[1] };
            } else {
                d[a[0]].Add( a[1] );
            }
        }
        foreach( int _ in Range( 0, nkr[1] ) ) {
            int[] v = ReadLine().Split().Select( int.Parse ).ToArray();

            WriteLine( d[v[0]][v[1] - 1] );
        }
        return;
    }
}
