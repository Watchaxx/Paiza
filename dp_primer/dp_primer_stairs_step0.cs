// 実行時間 40ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] a = new int[41];

        a[0] = 1;
        foreach( int i in Range( 1, n ) ) {
            a[i] = 0;
            if( 1 <= i ) {
                a[i] += a[i - 1];
            }
            if( 2 <= i ) {
                a[i] += a[i - 2];
            }
        }
        WriteLine( a[n] );
        return;
    }
}
