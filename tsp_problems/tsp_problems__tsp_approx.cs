// 実行時間 20ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;
using Tpl = System.Tuple<double, int, int>;

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
        var r = new List<int>( n );
        var m = new List<int>[n];
        var g = new List<Tpl>();
        var u = new UnionFind( n );

        foreach( int i in Range( 0, n ) ) {
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        foreach( int i in Range( 0, n ) ) {
            m[i] = new List<int>();
        }
        foreach( int i in Range( 0, n ) ) {
            foreach( int j in Range( i + 1, n - i - 1 ) ) {
                g.Add( new Tpl( Euclidean( a[i], a[j] ), i, j ) );
            }
        }
        foreach( Tpl t in g.OrderBy( x => x.Item1 ).Where( x => u.Equal( x.Item2, x.Item3 ) != true ) ) {
            m[t.Item2].Add( t.Item3 );
            m[t.Item3].Add( t.Item2 );
            u.Unite( t.Item2, t.Item3 );
        }
        TwoApprox( -1, 0, m, r );
        WriteLine( string.Join( " ", r ) );
        return;
    }

    static double Euclidean( int[] x, int[] y )
    {
        double a = x[0] - y[0];
        double b = x[1] - y[1];
        return System.Math.Sqrt( a * a + b * b );
    }

    static void TwoApprox( int b, int c, List<int>[] m, List<int> r )
    {
        r.Add( c );
        foreach( int i in m[c].Where( x => x != b ) ) {
            TwoApprox( c, i, m, r );
        }
    }
}
