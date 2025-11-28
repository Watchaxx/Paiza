// 実行時間 20ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static int[] n;
    static int[][] a;
    static List<int[]> o = new List<int[]>();

    static void Main()
    {
        n = ReadLine().Split().Select( int.Parse ).ToArray();
        a = new int[n[0] + 1][];
        foreach( int i in Range( 1, n[0] ) ) {
            ReadLine();
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        Dfs( n[1], new List<int>() { n[1] }, new List<(int, int)>() );
        WriteLine( o.Count );
        if( 0 < o.Count ) {
            WriteLine( string.Join( System.Environment.NewLine,
                Range( 0, o.Count ).Select( x => string.Join( " ", o[x] ) ) ) );
        }
        return;
    }

    static void Dfs( int v, List<int> t, List<(int, int)> e )
    {
        foreach( int i in a[v] ) {
            var f = (new[] { i, v }.Min(), new[] { i, v }.Max());

            if( e.Contains( f ) != true ) {
                t.Add( i );
                e.Add( f );
                if( i == n[2] && 2 <= t.Count( x => x == n[3] ) ) {
                    o.Add( t.ToArray() );
                }
                Dfs( i, t, e );
                t.RemoveAt( t.Count - 1 );
                e.RemoveAt( e.Count - 1 );
            }
        }
        return;
    }
}
