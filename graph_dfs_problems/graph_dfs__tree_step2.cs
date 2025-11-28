// 実行時間 20ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static int[][] a;
    static List<int[]> l = new List<int[]>();

    static void Main()
    {
        int n = int.Parse( ReadLine() );

        a = new int[n + 1][];
        foreach( int i in Range( 1, n ) ) {
            ReadLine();
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        Dfs( 1, new List<int> { 1 } );
        WriteLine( string.Join( System.Environment.NewLine, l.Select( x => string.Join( " ", x ) ) ) );
        return;
    }

    static List<int> Dfs( int v, List<int> t )
    {
        foreach( int i in a[v].Where( x => t.Contains( x ) != true ) ) {
            t.Add( i );
            l.Add( new[] { v, i } );
            Dfs( i, t );
        }
        return t;
    }
}
