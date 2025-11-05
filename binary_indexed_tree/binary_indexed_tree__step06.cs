// 実行時間 130ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int _ in Range( 0, int.Parse( ReadLine() ) ) ) {
            long t = long.Parse( ReadLine() );
            var l = new System.Collections.Generic.List<long>() { t };

            while( 0L < t ) {
                t -= Pow( 2L, Div2( t ) );
                l.Add( t );
            }
            WriteLine( string.Join( " ", l ) );
        }
        Out.Flush();
        return;
    }

    static int Div2( long i )
    {
        int k = 0;

        while( i % 2 == 0 ) {
            k++;
            i /= 2;
        }
        return k;
    }

    static long Pow( long x, int y )
    {
        const long mod = 1000000000L;
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
