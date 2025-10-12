// 実行時間 20ms
using System;
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    class UnionFind
    {
        List<int> Parent;

        internal UnionFind( int i )
        {
            Parent = new List<int>( Range( 0, i ) );
        }

        internal bool Equal( int a, int b )
        {
            return GetParent( a ) == GetParent( b );
        }

        internal int GetParent( int a )
        {
            while( a != Parent[a] ) {
                a = Parent[a];
            }
            return a;
        }

        internal void Unite( int a, int b )
        {
            Parent[GetParent( b )] = GetParent( a );
            return;
        }
    }

    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[][] a = new int[n][];
        var g = new List<Tuple<double, int, int>>();
        var m = new List<Tuple<int, int>>();
        var u = new UnionFind( n );

        foreach( int i in Range( 0, n ) ) {
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        foreach( int i in Range( 0, n ) ) {
            foreach( int j in Range( i + 1, n - i - 1 ) ) {
                g.Add( Tuple.Create( Euclidean( a[i], a[j] ), i, j ) );
            }
        }
        foreach( var t in g.OrderBy( x => x.Item1 ) ) {
            if( u.Equal( t.Item2, t.Item3 ) != true ) {
                m.Add( Tuple.Create( t.Item2, t.Item3 ) );
                u.Unite( t.Item2, t.Item3 );
            }
        }
        foreach( var t in m ) {
            WriteLine( $"{t.Item1} {t.Item2}" );
        }
        return;
    }

    static double Euclidean( int[] x, int[] y )
    {
        double a = x[0] - y[0];
        double b = x[1] - y[1];
        return Math.Sqrt( a * a + b * b );
    }
}
