// 実行時間 130ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int _ in Range( 0, int.Parse( ReadLine() ) ) ) {
            long[] t = ReadLine().Split().Select( long.Parse ).ToArray();
            var o = new System.Collections.Generic.List<long>() { t[1] };

            while( true ) {
                t[1] += Pow( 2L, Div2( t[1] ) );
                if( t[0] < t[1] ) {
                    o.Add( 0 );
                    break;
                }
                o.Add( t[1] );
            }
            WriteLine( o.Count );
            WriteLine( string.Join( " ", o ) );
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
        long b = x;
        long r = 1L;

        while( 0 < y ) {
            if( ( y & 1 ) != 0 ) {
                r *= b;
            }
            b *= b;
            y >>= 1;
        }
        return r;
    }
}
