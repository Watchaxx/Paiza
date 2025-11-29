// 実行時間 20ms
using System;
using static System.Linq.Enumerable;
using Lst = System.Collections.Generic.List<int>;

class Program
{
    static int n;
    static int[][] a;

    static void Main()
    {
        Lst l = new Lst();
        n = int.Parse( Console.ReadLine() );
        a = new int[n + 1][];
        foreach( int i in Range( 1, n ) ) {
            if( int.Parse( Console.ReadLine() ) == 1 ) {
                l.Add( i );
            }
            a[i] = Console.ReadLine().Split().Select( int.Parse ).ToArray();
        }
        if( 2 < l.Count ) {
        } else if( 0 < l.Count ) {
            Dfs( l[0], new Lst { l[0] } );
        } else {
            foreach( int i in Range( 1, n ) ) {
                Dfs( i, new Lst { i } );
            }
        }
        Console.WriteLine( -1 );
        return;
    }

    static void Dfs( int v, Lst t )
    {
        if( t.Count == n ) {
            Console.WriteLine( string.Join( Environment.NewLine,
                Range( 0, n - 1 ).Select( x => $"{t[x]} {t[x + 1]}" ) ) );
            Environment.Exit( 0 );
        }
        foreach( int i in a[v].Where( x => t.Contains( x ) != true ) ) {
            t.Add( i );
            Dfs( i, t );
            t.RemoveAt( t.Count - 1 );
        }
        return;
    }
}
