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
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();

        a = new int[n[0] + 1][];
        foreach( int i in Range( 1, n[0] ) ) {
            ReadLine();
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        Dfs( n[1], n[2], new List<int>() { n[1] } );
        WriteLine( l.Count );
        WriteLine( string.Join( System.Environment.NewLine,
            Range( 0, l.Count ).Select( x => string.Join( " ", l[x] ) ) ) );
        return;
    }

    static void Dfs( int s, int k, List<int> w )
    {
        if( k == 0 ) {
            l.Add( w.ToArray() );
            return;
        }
        foreach( int i in a[s] ) {
            w.Add( i );
            Dfs( i, k - 1, w );
            w.RemoveAt( w.Count - 1 );
        }
        return;
    }
}
