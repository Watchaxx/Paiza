// 実行時間 100ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        var v = new List<int>();
        var w = new List<int>();

        foreach( int i in Range( 0, n[0] ) ) {
            int j = 1;
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            while( j <= t[2] ) {
                v.Add( j * t[0] );
                w.Add( j * t[1] );
                t[2] -= j;
                j *= 2;
            }
            if( 0 < t[2] ) {
                v.Add( t[0] * t[2] );
                w.Add( t[1] * t[2] );
            }
        }

        int[,] d = new int[v.Count + 1, n[1] + 1];

        foreach( int i in Range( 0, v.Count ) ) {
            foreach( int j in Range( 0, n[1] + 1 ) ) {
                d[i + 1, j] = System.Math.Max( d[i + 1, j], d[i, j] );
                if( w[i] <= j ) {
                    d[i + 1, j] = System.Math.Max( d[i + 1, j], d[i, j - w[i]] + v[i] );
                }
            }
        }
        WriteLine( d[v.Count, n[1]] );
        return;
    }
}
