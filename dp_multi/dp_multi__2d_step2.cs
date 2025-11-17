// 実行時間 70ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        const int len = 10001;
        const int mod = 1000000000;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] b = ReadLine().Split().Select( int.Parse ).ToArray();
        long o = 0L;
        long[,] da = new long[n[0] + 1, len];
        long[,] db = new long[n[1] + 1, len];

        da[0, 0] = 1;
        db[0, 0] = 1;
        foreach( int i in Range( 0, n[0] ) ) {
            foreach( int j in Range( 0, len ) ) {
                da[i + 1, j] += da[i, j];
                da[i + 1, j] %= mod;
                if( j + a[i] < len ) {
                    da[i + 1, j + a[i]] += da[i, j];
                    da[i + 1, j + a[i]] %= mod;
                }
            }
        }
        foreach( int i in Range( 0, n[1] ) ) {
            foreach( int j in Range( 0, len ) ) {
                db[i + 1, j] += db[i, j];
                db[i + 1, j] %= mod;
                if( j + b[i] < len ) {
                    db[i + 1, j + b[i]] += db[i, j];
                    db[i + 1, j + b[i]] %= mod;
                }
            }
        }
        foreach( int i in Range( 0, len ) ) {
            o += da[n[0], i] * db[n[1], i];
            o %= mod;
        }
        WriteLine( o );
        return;
    }
}
