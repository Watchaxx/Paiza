// 実行時間 1590ms
using System;
using System.Collections.Generic;
using static System.Linq.Enumerable;
using MatrixT = System.Collections.Generic.List<System.Collections.Generic.List<int>>;
using MatrixB = System.Collections.Generic.List<System.Collections.Generic.List<System.Collections.Generic.List<System.Collections.Generic.List<int>>>>;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( Console.ReadLine() );
        Console.WriteLine( string.Join( Environment.NewLine,
            Strassen( StdIn( n ), StdIn( n ) ).Select( x => string.Join( " ", x ) ) ) );
        return;
    }

    static MatrixT Make( MatrixB a )
    {
        int m = a[0][0].Count;
        int n = m * 2;
        var b = new MatrixT( n );

        Action<int, int, MatrixT> Select = ( i, j, c ) => {
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
        Select( 0, 0, b );
        Select( 0, 1, b );
        Select( 1, 0, b );
        Select( 1, 1, b );
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

        Func<int, int, MatrixT> Select = ( h, w ) => {
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
            a.Add( Console.ReadLine().Split().Select( int.Parse ).ToList() );
        }
        return a;
    }

    static MatrixT Strassen( MatrixT a, MatrixT b )
    {
        if( a.Count == 1 && b.Count == 1 ) {
            return new MatrixT() {
                new List<int>() { a[0][0] * b[0][0] } };
        }
        MatrixB c = Quarter( a );
        MatrixB d = Quarter( b );
        MatrixB e = new MatrixB() {
            new List<MatrixT>() { null, null },
            new List<MatrixT>() { null, null } };
        MatrixT[] m = new MatrixT[7];

        m[0] = Strassen( Plus( c[0][0], c[1][1] ), Plus( d[0][0], d[1][1] ) );
        m[1] = Strassen( Plus( c[1][0], c[1][1] ), d[0][0] );
        m[2] = Strassen( c[0][0], Mnus( d[0][1], d[1][1] ) );
        m[3] = Strassen( c[1][1], Mnus( d[1][0], d[0][0] ) );
        m[4] = Strassen( Plus( c[0][0], c[0][1] ), d[1][1] );
        m[5] = Strassen( Mnus( c[1][0], c[0][0] ), Plus( d[0][0], d[0][1] ) );
        m[6] = Strassen( Mnus( c[0][1], c[1][1] ), Plus( d[1][0], d[1][1] ) );
        e[0][0] = Plus( Mnus( Plus( m[0], m[3] ), m[4] ), m[6] );
        e[0][1] = Plus( m[2], m[4] );
        e[1][0] = Plus( m[1], m[3] );
        e[1][1] = Plus( Mnus( m[0], m[1] ), Plus( m[2], m[5] ) );
        return Make( e );
    }
}
