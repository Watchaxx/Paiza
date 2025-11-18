// 実行時間 50ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        const int len = 101;
        const long mod = 1000000000L;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        long o = 0L;
        long[,,] d = new long[len, len, len];

        foreach( int i in Range( 0, n[0] ) ) {
            d[i + 1, a[i], 1] = 1L;
        }
        foreach( int i in Range( 0, n[0] ) ) {
            foreach( int j in Range( 0, len ) ) {
                foreach( int k in Range( 0, n[1] ) ) {
                    d[i + 1, j, k] += d[i, j, k];
                    d[i + 1, j, k] %= mod;
                    d[i + 1, j, k * a[i] % n[1]] += d[i, j, k];
                    d[i + 1, j, k * a[i] % n[1]] %= mod;
                }
            }
        }
        foreach( int i in Range( 1, n[0] - 1 ) ) {
            foreach( int j in Range( 0, len ) ) {
                foreach( int k in Range( 0, n[1] ).Where( x => ( j + a[i] ) % n[1] == x ) ) {
                    o += d[i, j, k];
                    o %= mod;
                }
            }
        }
        WriteLine( o );
        return;
    }
}
