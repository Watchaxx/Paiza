// 実行時間 20ms
using System;
using System.Collections.Generic;
using static System.Linq.Enumerable;

class Program
{
    static int m = 0;
    static int[] n;
    static int[][] a;

    static void Main()
    {
        n = Console.ReadLine().Split().Select( int.Parse ).ToArray();
        a = new int[n[0] + 1][];
        foreach( int i in Range( 1, n[0] ) ) {
            m += int.Parse( Console.ReadLine() );
            a[i] = Console.ReadLine().Split().Select( int.Parse ).ToArray();
        }
        m /= 2;
        Dfs( n[1], new List<int> { n[1] }, new List<(int, int)>() );
        return;
    }

    static void Dfs( int v, List<int> t, List<(int, int)> e )
    {
        foreach( int i in a[v] ) {
            var f = (new[] { i, v }.Min(), new[] { i, v }.Max());

            if( e.Contains( f ) != true ) {
                t.Add( i );
                e.Add( f );
                if( i == n[1] && e.Count == m ) {
                    Console.WriteLine( string.Join( " ", t ) );
                    Environment.Exit( 0 );
                }
                Dfs( i, t, e );
                t.RemoveAt( t.Count - 1 );
                e.RemoveAt( e.Count - 1 );
            }
        }
        return;
    }
}
