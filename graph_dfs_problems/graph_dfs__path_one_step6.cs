// 実行時間 20ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static List<int> l;
    static List<int>[] a;

    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        ReadLine();
        var s = new HashSet<int>( ReadLine().Split().Select( int.Parse ) );

        l = new List<int>( Range( 1, n[0] + 1 ) );
        a = new List<int>[n[0] + 1];
        foreach( int i in Range( 1, n[0] ) ) {
            ReadLine();
            a[i] = new List<int>( ReadLine().Split().Select( int.Parse ) );
        }
        foreach( int i in s ) {
            foreach( int j in a[i] ) {
                a[j].Remove( i );
            }
            a[i].Clear();
        }
        Dfs( n[1], n[2], new List<int>() { n[1] } );
        WriteLine( l.Count != n[0] + 1 ? string.Join( " ", l ) : "-1" );
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
