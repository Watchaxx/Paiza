// 実行時間 20ms
using System;
using static System.Linq.Enumerable;
using Lst = System.Collections.Generic.List<int>;

class Program
{
    static int[] n;
    static int[] s;
    static int[][] a;

    static void Main()
    {
        n = Console.ReadLine().Split().Select( int.Parse ).ToArray();
        Console.ReadLine();
        s = Console.ReadLine().Split().Select( int.Parse ).ToArray();
        a = new int[n[0] + 1][];
        foreach( int i in Range( 1, n[0] ) ) {
            Console.ReadLine();
            a[i] = Console.ReadLine().Split().Select( int.Parse ).ToArray();
        }
        Dfs( n[1], new Lst { n[1] } );
        Console.WriteLine( -1 );
        return;
    }

    static void Dfs( int v, Lst t )
    {
        foreach( int i in a[v] ) {
            if( i == n[1] && 2 < t.Count && t.All( x => !s.Contains( x ) ) ) {
                t.Add( i );
                Console.WriteLine( string.Join( " ", t ) );
                Environment.Exit( 0 );
            } else if( t.Contains( i ) != true ) {
                t.Add( i );
                Dfs( i, t );
                t.RemoveAt( t.Count - 1 );
            }
        }
        return;
    }
}
