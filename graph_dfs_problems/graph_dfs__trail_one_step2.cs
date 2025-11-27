// 実行時間 50ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static int[] n;
    static int[][] a;
    static List<int> o = new List<int>();

    static void Main()
    {
        n = ReadLine().Split().Select( int.Parse ).ToArray();
        a = new int[n[0] + 1][];
        foreach( int i in Range( 1, n[0] ) ) {
            ReadLine();
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        Dfs( n[1], new List<int>() { n[1] }, new List<(int, int)>() );
        WriteLine( string.Join( " ", o ) );
        return;
    }

    static void Dfs( int v, List<int> t, List<(int, int)> e )
    {
        foreach( int i in a[v] ) {
            var f = (new[] { i, v }.Min(), new[] { i, v }.Max());

            if( e.Contains( f ) != true ) {
                t.Add( i );
                if( i != n[1] ) {
                    e.Add( f );
                    if( i == n[2] ) {
                        if( o.Count < t.Count ) {
                            o = new List<int>( t );
                        }
                    } else {
                        Dfs( i, t, e );
                    }
                    e.RemoveAt( e.Count - 1 );
                }
                t.RemoveAt( t.Count - 1 );
            }
        }
        return;
    }
}
