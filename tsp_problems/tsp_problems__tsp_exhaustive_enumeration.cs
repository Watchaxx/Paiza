// 実行時間 40ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        double o = double.MaxValue;
        int n = int.Parse( ReadLine() );
        int[] a = new int[n];
        int[][] p = new int[n][];
        var l = new List<int[]>();

        foreach( int i in Range( 0, n ) ) {
            p[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        Permutation( l, Range( 0, n ).ToList(), 0 );
        foreach( int[] i in l ) {
            double t = 0d;

            foreach( int j in Range( 0, n - 1 ) ) {
                t += Euclidean( p[i[j]][0], p[i[j]][1], p[i[j + 1]][0], p[i[j + 1]][1] );
            }
            t += Euclidean( p[i[n - 1]][0], p[i[n - 1]][1], p[i[0]][0], p[i[0]][1] );
            if( t < o ) {
                o = t;
                a = i;
            }
        }
        WriteLine( o );
        WriteLine( string.Join( " ", a.Select( x => x + 1 ) ) );
        return;
    }

    static double Euclidean( double x1, double y1, double x2, double y2 )
    {
        double x = x1 - x2;
        double y = y1 - y2;
        return System.Math.Sqrt( x * x + y * y );
    }

    static void Permutation( List<int[]> p, List<int> t, int s )
    {
        for( int i = s; i < t.Count; i++ ) {
            Swap( t, i, s );
            Permutation( p, t, s + 1 );
            Swap( t, i, s );
        }
        if( s == t.Count - 1 ) {
            p.Add( t.ToArray() );
        }
        return;
    }

    static void Swap( List<int> l, int i, int j )
    {
        // (l[i], l[j]) = (l[j], l[i]);
        int t = l[i];
        l[i] = l[j];
        l[j] = t;
        return;
    }
}
