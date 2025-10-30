// 実行時間 330ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    class Matrix
    {
        const long Mod = 10000000L;
        int N;
        long[][] A;

        internal Matrix( int l, bool init = false )
        {
            N = l;
            A = new long[N][];
            foreach( int i in Range( 0, N ) ) {
                A[i] = new long[N];
                if( init == true ) {
                    A[i][i] = 1;
                }
            }
        }

        public static Matrix operator +( Matrix a, Matrix b )
        {
            var r = new Matrix( a.N );

            foreach( int i in Range( 0, a.N ) ) {
                foreach( int j in Range( 0, a.N ) ) {
                    r.A[i][j] = ( a.A[i][j] + b.A[i][j] ) % Mod;
                }
            }
            return r;
        }

        public static Matrix operator *( Matrix a, Matrix b )
        {
            var r = new Matrix( a.N );

            foreach( int i in Range( 0, a.N ) ) {
                foreach( int j in Range( 0, a.N ) ) {
                    foreach( int k in Range( 0, a.N ) ) {
                        r.A[i][j] = ( r.A[i][j] + a.A[i][k] * b.A[k][j] ) % Mod;
                    }
                }
            }
            return r;
        }

        internal Matrix Pow( long x )
        {
            var b = this;
            var r = new Matrix( N, true );

            while( 0L < x ) {
                if( ( x & 1 ) != 0 ) {
                    r *= b;
                }
                b *= b;
                x >>= 1;
            }
            return r;
        }

        internal void StdIn()
        {
            foreach( int i in Range( 0, N ) ) {
                A[i] = ReadLine().Split().Select( long.Parse ).ToArray();
            }
            return;
        }

        public override string ToString()
        {
            var sb = new System.Text.StringBuilder();

            foreach( long[] l in A ) {
                sb.AppendLine( string.Join( " ", l ) );
            }
            return $"{sb}";
        }
    }

    static void Main()
    {
        long[] n = ReadLine().Split().Select( long.Parse ).ToArray();
        var m = new Matrix( (int)n[0] );

        m.StdIn();
        WriteLine( m.Pow( n[1] ) );
        return;
    }
}
