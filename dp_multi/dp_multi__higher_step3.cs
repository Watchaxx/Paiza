// 実行時間 1200ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        var d = new bool[51, 51, 51];
        int n = int.Parse( ReadLine() );
        int o = 0;
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();

        foreach( int i in Range( 0, n ) ) {
            d[i, i + 1, a[i]] = true;
        }
        foreach( int i in Range( 2, n - 1 ) ) {
            foreach( int j in Range( 0, n - i + 1 ) ) {
                int k = i + j;

                for( int l = j + 1; l < k; l++ ) {
                    foreach( int p in Range( 0, 51 ) ) {
                        foreach( int q in Range( 0, 51 ).Where( x => d[j, l, p] && d[l, k, x] ) ) {
                            d[j, k, System.Math.Abs( p - q )] = true;
                        }
                    }
                }
            }
        }
        foreach( int i in Range( 0, 51 ).Where( x => d[0, n, x] ) ) {
            o = i;
        }
        WriteLine( o );
        return;
    }
}
