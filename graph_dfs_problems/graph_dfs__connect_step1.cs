// 実行時間 20ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static bool b = false;
    static int[] n;
    static int[][] a;

    static void Main()
    {
        n = ReadLine().Split().Select( int.Parse ).ToArray();
        a = new int[n[0] + 1][];
        foreach( int i in Range( 1, n[0] ) ) {
            ReadLine();
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        Dfs( n[1], new List<int>() { n[1] } );
        WriteLine( b ? "Yes" : "No" );
        return;
    }

    static void Dfs( int v, List<int> t )
    {
        foreach( int i in a[v].Where( x => t.Contains( x ) != true ) ) {
            t.Add( i );
            if( i == n[2] ) {
                b = true;
                return;
            } else {
                Dfs( i, t );
            }
            t.RemoveAt( t.Count - 1 );
        }
        return;
    }
}
