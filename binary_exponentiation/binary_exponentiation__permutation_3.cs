// 実行時間 40ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    class Permutation
    {
        int N;
        int[] P;

        internal Permutation( int n )
        {
            N = n;
            P = new int[N];
            foreach( int i in Range( 0, n ) ) {
                P[i] = i;
            }
        }

        public static Permutation operator *( Permutation a, Permutation b )
        {
            var r = new Permutation( a.N );

            foreach( int i in Range( 0, a.N ) ) {
                r.P[i] = a.P[b.P[i]];
            }
            return r;
        }

        internal Permutation Pow( long x )
        {
            var b = this;
            var r = new Permutation( N );

            foreach( int i in Range( 0, 64 ) ) {
                if( ( x & ( 1L << i ) ) != 0 ) {
                    r *= b;
                }
                b *= b;
            }
            return r;
        }

        internal void StdIn()
        {
            int[] a = ReadLine().Split().Select( int.Parse ).ToArray();

            foreach( int i in Range( 0, N ) ) {
                P[i] = a[i] - 1;
            }
            return;
        }

        public override string ToString()
        {
            return string.Join( " ", P.Select( x => x + 1 ) );
        }
    }

    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        var a = new Permutation( n[0] );

        a.StdIn();
        WriteLine( a.Pow( n[1] ) );
        return;
    }
}
