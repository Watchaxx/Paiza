// 実行時間 20ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static int[][] a;

    static void Main()
    {
        int e = 0;
        int n = int.Parse( ReadLine() );

        a = new int[n + 1][];
        foreach( int i in Range( 1, n ) ) {
            e += int.Parse( ReadLine() );
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        if( n - 1 < e / 2 ) {
            WriteLine( "No" );
        } else {
            WriteLine( Dfs( 1, new List<int> { 1 } ).Count == n ? "Yes" : "No" );
        }
        return;
    }

    static List<int> Dfs( int v, List<int> t )
    {
        foreach( int i in a[v].Where( x => t.Contains( x ) != true ) ) {
            t.Add( i );
            Dfs( i, t );
        }
        return t;
    }
}
