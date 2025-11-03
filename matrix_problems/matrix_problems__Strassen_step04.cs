// 実行時間 70ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;
using MatrixT = System.Collections.Generic.List<System.Collections.Generic.List<int>>;
using MatrixB = System.Collections.Generic.List<System.Collections.Generic.List<System.Collections.Generic.List<System.Collections.Generic.List<int>>>>;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        MatrixT a = StdIn( n );
        MatrixT b = StdIn( n );
        MatrixT[] m = new MatrixT[7];
        MatrixB q = Quarter( a );
        MatrixB r = Quarter( b );
        MatrixB s = new MatrixB() {
            new List<MatrixT>() { null, null },
            new List<MatrixT>() { null, null } };

        m[0] = Mult( Plus( q[0][0], q[1][1] ), Plus( r[0][0], r[1][1] ) );
        m[1] = Mult( Plus( q[1][0], q[1][1] ), r[0][0] );
        m[2] = Mult( q[0][0], Mnus( r[0][1], r[1][1] ) );
        m[3] = Mult( q[1][1], Mnus( r[1][0], r[0][0] ) );
        m[4] = Mult( Plus( q[0][0], q[0][1] ), r[1][1] );
        m[5] = Mult( Mnus( q[1][0], q[0][0] ), Plus( r[0][0], r[0][1] ) );
        m[6] = Mult( Mnus( q[0][1], q[1][1] ), Plus( r[1][0], r[1][1] ) );
        s[0][0] = Plus( Mnus( Plus( m[0], m[3] ), m[4] ), m[6] );
        s[0][1] = Plus( m[2], m[4] );
        s[1][0] = Plus( m[1], m[3] );
        s[1][1] = Plus( Mnus( m[0], m[1] ), Plus( m[2], m[5] ) );
        WriteLine( string.Join( System.Environment.NewLine, Make( s ).Select( x => string.Join( " ", x ) ) ) );
        return;
    }

    static MatrixT Make( MatrixB a )
    {
        int m = a[0][0].Count;
        int n = m * 2;
        var b = new MatrixT( n );

        System.Action<int, int> Select = ( i, j ) => {
            int h = i * m;
            int w = j * m;

            foreach( int k in Rng( m ) ) {
                foreach( int l in Rng( m ) ) {
                    b[h + k][w + l] = a[i][j][k][l];
                }
            }
        };

        foreach( int _ in Rng( n ) ) {
            b.Add( Repeat( 0, n ).ToList() );
        }
        Select( 0, 0 );
        Select( 0, 1 );
        Select( 1, 0 );
        Select( 1, 1 );
        return b;
    }

    static MatrixT Mnus( MatrixT a, MatrixT b )
    {
        var c = new MatrixT( a.Count );

        foreach( int i in Rng( a.Count ) ) {
            var d = new List<int>( a.Count );

            foreach( int j in Rng( a.Count ) ) {
                d.Add( a[i][j] - b[i][j] );
            }
            c.Add( d );
        }
        return c;
    }

    static MatrixT Mult( MatrixT a, MatrixT b )
    {
        MatrixT c = new MatrixT( a.Count );

        foreach( int i in Rng( a.Count ) ) {
            var d = new List<int>( b[0].Count );

            foreach( int j in Rng( b[0].Count ) ) {
                int s = 0;

                foreach( int k in Rng( a[0].Count ) ) {
                    s += a[i][k] * b[k][j];
                }
                d.Add( s );
            }
            c.Add( d );
        }
        return c;
    }

    static MatrixT Plus( MatrixT a, MatrixT b )
    {
        var c = new MatrixT( a.Count );

        foreach( int i in Rng( a.Count ) ) {
            var d = new List<int>( a.Count );

            foreach( int j in Rng( a.Count ) ) {
                d.Add( a[i][j] + b[i][j] );
            }
            c.Add( d );
        }
        return c;
    }

    static MatrixB Quarter( MatrixT a )
    {
        int n = a.Count;
        int m = n / 2;
        var o = new MatrixB() {
            new List<MatrixT>() { null, null },
            new List<MatrixT>() { null, null } };

        System.Func<int, int, MatrixT> Select = ( h, w ) => {
            var p = new MatrixT( m );

            foreach( int i in Rng( m ) ) {
                var r = new List<int>( m );

                foreach( int j in Rng( m ) ) {
                    r.Add( a[h + i][w + j] );
                }
                p.Add( r );
            }
            return p;
        };

        o[0][0] = Select( 0, 0 );
        o[0][1] = Select( 0, m );
        o[1][0] = Select( m, 0 );
        o[1][1] = Select( m, m );
        return o;
    }

    static IEnumerable<int> Rng( int n )
    {
        return Range( 0, n );
    }

    static MatrixT StdIn( int h )
    {
        var a = new MatrixT( h );

        foreach( int i in Rng( h ) ) {
            a.Add( ReadLine().Split().Select( int.Parse ).ToList() );
        }
        return a;
    }
}
