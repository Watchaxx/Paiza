// 実行時間 20ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static int[][] a;

    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int o = 0;
        var s = new HashSet<int>( Range( 1, n ) );

        a = new int[n + 1][];
        foreach( int i in Range( 1, n ) ) {
            ReadLine();
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        while( 0 < s.Count ) {
            int p = s.Last();

            s.Remove( p );
            s = s.Except( Dfs( p, new List<int>( p ) ) ).ToHashSet();
            o++;
        }
        WriteLine( o );
        return;
    }

    static IEnumerable<int> Dfs( int v, List<int> t )
    {
        foreach( int i in a[v].Where( x => t.Contains( x ) != true ) ) {
            t.Add( i );
            Dfs( i, t );
        }
        return t.Distinct();
    }
}
