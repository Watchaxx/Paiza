// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;
using Tpl = System.Tuple<int, long>;

internal class Program
{
    const long mod = 1000000007L;

    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int h = int.Parse( ReadLine() );
        Tpl[] bh = new Tpl[n];

        foreach( int i in Range( 0, n ) ) {
            string[] s = ReadLine().Split();

            bh[i] = new Tpl( int.Parse( s[0] ), long.Parse( s[1] ) );
        }

        long hh = Hash( ReadLine().Split()[1] );

        foreach( Tpl t in bh.Reverse() ) {
            hh = $"{t.Item1}".Last() == '0' ? Hash( $"{t.Item2}{hh}" ) : Hash( $"{hh}{t.Item2}" );
        }
        WriteLine( hh == h ? "Yes" : "No" );
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
