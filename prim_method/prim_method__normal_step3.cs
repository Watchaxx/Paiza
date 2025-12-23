// 実行時間 270ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int c = 0;
        int n = int.Parse( ReadLine() );
        int o = 0;
        int s = 0;
        int[][] g = new int[n][];
        bool[] v = new bool[n];
        var d = new SortedDictionary<int, List<int>>();

        foreach( int i in Range( 0, n ) ) {
            g[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        d.Add( 0, new List<int>() { 0 } );
        while( 0 < d.Count && s < n ) {
            var t = d.First();
            int m = t.Key;

            c = t.Value[0];
            t.Value.RemoveAt( 0 );
            if( t.Value.Count == 0 ) {
                d.Remove( m );
            }
            if( v[c] == true ) {
                continue;
            }
            o += m;
            s++;
            v[c] = true;
            foreach( int i in Range( 0, n ).Where( x => v[x] != true && 0 < g[c][x] ) ) {
                if( d.ContainsKey( g[c][i] ) != true ) {
                    d.Add( g[c][i], new List<int>() { i } );
                } else {
                    d[g[c][i]].Add( i );
                }
            }
        }
        WriteLine( o );
        return;
    }
}
