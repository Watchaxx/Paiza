// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;
using Lst = System.Collections.Generic.List<long>;

internal class Program
{
    const long mod = 1000000007L;

    static void Main()
    {
        int n = (int)Pow( 2, int.Parse( ReadLine() ) );
        Lst l = new Lst( n );

        foreach( int _ in Range( 0, n ) ) {
            l.Add( Hash( ReadLine() ) );
        }
        while( 1 < l.Count ) {
            Lst t = new Lst( l.Count / 2 );

            foreach( int i in Range( 0, l.Count / 2 ) ) {
                t.Add( Hash( $"{l[2 * i]}{l[2 * i + 1]}" ) );
            }
            l = new Lst( t );
        }
        WriteLine( l[0] );
        return;
    }

    static long Hash( string s )
    {
        long r = 0L;

        foreach( int i in Range( 0, s.Length ) ) {
            long t = s[i] * Pow( 100000007L, i + 1 ) % mod;

            r = ( r + t ) % mod;
        }
        return r;
    }

    static long Pow( long x, int y )
    {
        long b = x % mod;
        long r = 1L;

        while( 0 < y ) {
            if( ( y & 1 ) == 1 ) {
                r = r * b % mod;
            }
            b = b * b % mod;
            y >>= 1;
        }
        return r;
    }
}
