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
        int k = int.Parse( ReadLine() );
        int[] s = ReadLine().Split().Select( int.Parse ).ToArray();

        a = new int[n + 1][];
        foreach( int i in Range( 1, n ) ) {
            ReadLine();
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        foreach( int i in s ) {
            foreach( int j in a[i] ) {
                a[j] = a[j].Except( new[] { i } ).ToArray();
            }
            a[i] = new int[0];
        }

        int v = Range( 1, n ).Except( s ).Min();

        Dfs( v, new List<int> { v } );
        WriteLine( l.Count == n - k - 1
            ? string.Join( System.Environment.NewLine, l.Select( x => string.Join( " ", x ) ) )
            : "-1" );
        return;
    }

    static void Dfs( int v, List<int> t )
    {
        foreach( int i in a[v].Where( x => !t.Contains( x ) ) ) {
            t.Add( i );
            l.Add( new[] { v, i } );
            Dfs( i, t );
        }
        return;
    }
}
