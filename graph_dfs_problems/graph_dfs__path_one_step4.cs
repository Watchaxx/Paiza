// 実行時間 20ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static int[][] a;
    static List<int> l;

    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();

        a = new int[n[0] + 1][];
        l = new List<int>( Range( 1, n[0] + 1 ) );
        foreach( int i in Range( 1, n[0] ) ) {
            ReadLine();
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        Dfs( n[1], n[2], new List<int>() { n[1] } );
        WriteLine( string.Join( " ", l ) );
        return;
    }

    static void Dfs( int v, int t, List<int> p )
    {
        if( l.Count <= p.Count ) {
            return;
        }
        foreach( int i in a[v].Where( x => p.Contains( x ) != true ) ) {
            p.Add( i );
            if( i == t ) {
                l = new List<int>( p );
            } else {
                Dfs( i, t, p );
            }
            p.RemoveAt( p.Count - 1 );
        }
        return;
    }
}
