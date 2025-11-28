// 実行時間 20ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static int n;
    static int[][] a;

    static void Main()
    {
        n = int.Parse( ReadLine() );
        a = new int[n + 1][];
        foreach( int i in Range( 1, n ) ) {
            ReadLine();
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        Dfs( 1, new List<int>() { 1 } );
        WriteLine( "No" );
        return;
    }

    static void Dfs( int v, List<int> t )
    {
        if( t.Count == n ) {
            WriteLine( "Yes" );
            System.Environment.Exit( 0 );
        }
        foreach( int i in a[v].Where( x => t.Contains( x ) != true ) ) {
            t.Add( i );
            Dfs( i, t );
        }
        return;
    }
}
