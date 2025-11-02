// 実行時間 50ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        var a = StdIn( n[0], n[1] );
        var b = StdIn( n[0], n[1] );
        var c = Mul( a, b );

        foreach( int i in Range( 0, c.Count ) ) {
            foreach( int j in Range( 0, c.Count ) ) {
                WriteLine( string.Join( System.Environment.NewLine,
                    Range( 0, c[i][j].Count ).Select( x => string.Join( " ", c[i][j][x] ) ) ) );
            }
        }
        return;
    }

    static List<List<List<List<int>>>> Mul( List<List<List<List<int>>>> a, List<List<List<List<int>>>> b )
    {
        int n = a.Count;
        int m = a[0][0].Count;
        var c = new List<List<List<List<int>>>>( n );

        foreach( int i in Range( 0, n ) ) {
            var d = new List<List<List<int>>>( n );

            foreach( int j in Range( 0, n ) ) {
                var e = new List<List<int>>( m );

                foreach( int _ in Range( 0, m ) ) {
                    e.Add( new List<int>( new int[m] ) );
                }
                foreach( int k in Range( 0, n ) ) {
                    e = Plus( e, MulSub( a[i][k], b[k][j] ) );
                }
                d.Add( e );
            }
            c.Add( d );
        }
        return c;
    }

    static List<List<int>> MulSub( List<List<int>> a, List<List<int>> b )
    {
        var c = new List<List<int>>( a.Count );

        foreach( int i in Range( 0, a.Count ) ) {
            var d = new List<int>( a[0].Count );

            foreach( int j in Range( 0, b[0].Count ) ) {
                int s = 0;

                foreach( int k in Range( 0, a[0].Count ) ) {
                    s += a[i][k] * b[k][j];
                }
                d.Add( s );
            }
            c.Add( d );
        }
        return c;
    }

    static List<List<int>> Plus( List<List<int>> a, List<List<int>> b )
    {
        var c = new List<List<int>>( a.Count );

        foreach( int i in Range( 0, a.Count ) ) {
            var d = new List<int>( a.Count );

            foreach( int j in Range( 0, a.Count ) ) {
                d.Add( a[i][j] + b[i][j] );
            }
            c.Add( d );
        }
        return c;
    }

    static List<List<List<List<int>>>> StdIn( int n, int m )
    {
        var a = new List<List<List<List<int>>>>( n );

        foreach( int i in Range( 0, n ) ) {
            var b = new List<List<List<int>>>( n );

            foreach( int j in Range( 0, n ) ) {
                b.Add( StdInSub( m ) );
            }
            a.Add( b );
        }
        return a;
    }

    static List<List<int>> StdInSub( int n )
    {
        var a = new List<List<int>>( n );

        foreach( int i in Range( 0, n ) ) {
            a.Add( ReadLine().Split().Select( int.Parse ).ToList() );
        }
        return a;
    }
}
