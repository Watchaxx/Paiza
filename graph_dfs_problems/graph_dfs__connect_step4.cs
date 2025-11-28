// 実行時間 20ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static int[][] a;

    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        var s = new HashSet<int>( Range( 1, n[0] ) );

        a = new int[n[0] + 1][];
        foreach( int i in Range( 1, n[0] ) ) {
            ReadLine();
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        while( 0 < s.Count ) {
            int p = s.Last();
            var l = Dfs( p, new List<int>( p ) );

            if( n[1] < l.Count ) {
                WriteLine( "No" );
                return;
            }
            s.Remove( p );
            s = s.Except( l ).ToHashSet();
        }
        WriteLine( "Yes" );
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
