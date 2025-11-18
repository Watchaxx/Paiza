// 実行時間 1640ms
using static System.Console;
using static System.Linq.Enumerable;
using static System.Math;

class Program
{
    static void Main()
    {
        int[] hwk = ReadLine().Split().Select( int.Parse ).ToArray();
        long[,,] d = new long[31, 31, 31];

        d[0, 0, 0] = 1;
        foreach( int i in Range( 0, hwk[2] ) ) {
            foreach( int j in Range( 0, hwk[0] + 1 ) ) {
                foreach( int k in Range( 0, hwk[1] + 1 ) ) {
                    for( int l = -hwk[0] + 1; l < hwk[0]; l++ ) {
                        for( int m = -hwk[1] + 1; m < hwk[1]; m++ ) {
                            if( Gcd( Abs( l ), Abs( m ) ) != 1 ) {
                                continue;
                            }
                            if( 0 <= j + l && j + l < hwk[0] && 0 <= k + m && k + m < hwk[1] ) {
                                d[i + 1, j + l, k + m] += d[i, j, k];
                                d[i + 1, j + l, k + m] %= 1000000000;
                            }
                        }
                    }
                }
            }
        }
        WriteLine( d[hwk[2], hwk[0] - 1, hwk[1] - 1] );
        return;
    }

    static int Gcd( int a, int b )
    {
        return b == 0 ? a : Gcd( b, a % b );
    }
}
