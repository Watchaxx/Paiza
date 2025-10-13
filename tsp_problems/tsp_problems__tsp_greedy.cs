// 実行時間 2180ms
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
            if( a != Parent[a] ) {
                Parent[a] = GetParent( Parent[a] );
            }
            return Parent[a];
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
        int s = -1;
        int[][] a = new int[n][];
        var o = new List<int>( n );
        var g = new List<Tpl>();
        var e = new List<int>[n];
        var u = new UnionFind( n );

        foreach( int i in Range( 0, n ) ) {
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        foreach( int i in Range( 0, n ) ) {
            foreach( int j in Range( i + 1, n - i - 1 ) ) {
                g.Add( new Tpl( Euclidean( a[i], a[j] ), i, j ) );
            }
        }
        foreach( int i in Range( 0, n ) ) {
            e[i] = new List<int>();
        }
        foreach( Tpl t in g.OrderBy( x => x.Item1 ) ) {
            if( u.Equal( t.Item2, t.Item3 ) || e[t.Item2].Count == 2 || e[t.Item3].Count == 2 ) {
                continue;
            }
            e[t.Item2].Add( t.Item3 );
            e[t.Item3].Add( t.Item2 );
            u.Unite( t.Item2, t.Item3 );
        }
        foreach( int i in Range( 0, n ).Where( x => e[x].Count == 1 ) ) {
            s = i;
            break;
        }
        o.AddRange( new int[] { s, e[s][0] } );
        foreach( int i in Range( 2, n - 2 ) ) {
            foreach( int j in e[o[i - 1]].Where( x => x != o[i - 2] ) ) {
                o.Add( j );
                break;
            }
        }
        WriteLine( string.Join( System.Environment.NewLine, o ) );
        return;
    }

    static double Euclidean( int[] x, int[] y )
    {
        double a = x[0] - y[0];
        double b = x[1] - y[1];
        return System.Math.Sqrt( a * a + b * b );
    }
}
