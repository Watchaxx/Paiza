// 実行時間 30ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        long[] n = ReadLine().Split().Select( long.Parse ).ToArray();
        string s = ReadLine();

        for( long i = 0L; i < Pow( 3L, (int)n[0] - 1 ); i++ ) {
            var t = new List<char>();

            foreach( int j in Range( 0, (int)n[0] ) ) {
                t.Add( s[j] );
                if( j < n[0] - 1 ) {
                    long x = i / Pow( 3L, j ) % 3L;

                    if( x == 1L ) {
                        t.Add( '+' );
                    } else if( x == 2L ) {
                        t.Add( '-' );
                    }
                }
            }
            if( Func( t ) == n[1] ) {
                WriteLine( string.Join( "", t ) );
                break;
            }
        }
        return;
    }

    static long Func( List<char> l )
    {
        long t = 0L;
        var o = new List<char>();
        var n = new List<long>();

        foreach( char c in l ) {
            if( c == '+' || c == '-' ) {
                n.Add( t );
                o.Add( c );
                t = 0L;
            } else {
                t = 10L * t + long.Parse( $"{c}" );
            }
        }
        n.Add( t );

        long r = n[0];

        foreach( int i in Range( 0, o.Count ) ) {
            if( o[i] == '+' ) {
                r += n[i + 1];
            } else if( o[i] == '-' ) {
                r -= n[i + 1];
            }
        }
        return r;
    }

    static long Pow( long x, int y )
    {
        const long mod = 10000000000;
        long b = x % mod;
        long r = 1L;

        while( 0 < y ) {
            if( ( y & 1 ) != 0 ) {
                r = r * b % mod;
            }
            b = b * b % mod;
            y >>= 1;
        }
        return r;
    }
}
