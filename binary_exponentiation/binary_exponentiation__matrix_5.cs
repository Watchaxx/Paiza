// 実行時間 2370ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    class Matrix
    {
        const long Mod = 10000000L;
        internal int N;
        internal long[][] A;

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

        public static Matrix operator -( Matrix a, Matrix b )
        {
            var r = new Matrix( a.N );

            foreach( int i in Range( 0, a.N ) ) {
                foreach( int j in Range( 0, a.N ) ) {
                    r.A[i][j] = ( a.A[i][j] - b.A[i][j] + Mod ) % Mod;
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
                        r.A[i][j] = ( a.A[i][k] * b.A[k][j] + r.A[i][j] ) % Mod;
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

        internal long Sum()
        {
            long r = 0L;

            foreach( int i in Range( 0, N ) ) {
                foreach( long j in Range( 0, N ) ) {
                    r = ( r + A[i][j] ) % Mod;
                }
            }
            return r;
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
        var a = new Matrix( (int)n[0] );
        var b = new Matrix( (int)n[0] );
        var c = new Matrix( (int)n[0], true );
        a.StdIn();
        Matrix m = Concat( a, b, c, c );
        WriteLine( Ext( m.Pow( n[1] + 1 ), 2 ) - c );
        return;
    }

    static Matrix Concat( Matrix a, Matrix b, Matrix c, Matrix d )
    {
        int n = a.N * 2;
        var r = new Matrix( n );

        foreach( int i in Range( 0, n ) ) {
            foreach( int j in Range( 0, n ) ) {
                if( i < a.N ) {
                    r.A[i][j] = j < a.N ? a.A[i][j] : b.A[i][j - a.N];
                } else {
                    r.A[i][j] = j < a.N ? c.A[i - a.N][j] : d.A[i - a.N][j - a.N];
                }
            }
        }
        return r;
    }

    static Matrix Ext( Matrix a, int d )
    {
        int n = a.N / 2;
        int x = d / 2 * n;
        int y = d % 2 * n;
        var r = new Matrix( n );

        foreach( int i in Range( 0, n ) ) {
            foreach( int j in Range( 0, n ) ) {
                r.A[i][j] = a.A[x + i][y + j];
            }
        }
        return r;
    }
}
