// 実行時間 500ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    class Bit
    {
        int N { get; set; }
        long[] Tree { get; set; }

        internal Bit( int n, long[] a )
        {
            N = n;
            Tree = new long[n + 1];
            foreach( int i in Range( 1, n ) ) {
                for( long j = i - Pow( 2L, Div2( i ) ); j < i; j++ ) {
                    Tree[i] += a[j];
                }
            }
        }

        internal void Add( long i, long b )
        {
            long c = i;

            Tree[i] += b;
            while( true ) {
                c += Pow( 2L, Div2( c ) );
                if( N < c ) {
                    break;
                }
                Tree[c] += b;
            }
            return;
        }

        private int Div2( long i )
        {
            int k = 0;

            while( i % 2 == 0 ) {
                k++;
                i /= 2;
            }
            return k;
        }

        internal long Sum( long i )
        {
            long s = 0L;

            while( 0L < i ) {
                s += Tree[i];
                i -= Pow( 2L, Div2( i ) );
            }
            return s;
        }

        private long Pow( long x, int y )
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

    static void Main()
    {
        int n = int.Parse( ReadLine() );
        long[] a = ReadLine().Split().Select( long.Parse ).ToArray();
        Bit b = new Bit( n, a );

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int _ in Range( 0, int.Parse( ReadLine() ) ) ) {
            long[] t = ReadLine().Split().Select( long.Parse ).ToArray();

            if( t[0] == 1 ) {
                b.Add( t[1], t[2] );
            } else if( t[0] == 2 ) {
                WriteLine( b.Sum( t[1] ) );
            }
        }
        Out.Flush();
        return;
    }
}
