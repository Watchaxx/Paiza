// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int k = int.Parse( ReadLine() ) - 1;
        int[] a = new int[40];

        a[0] = 1;
        a[1] = 1;
        foreach( int i in Range( 2, k - 1 ) ) {
            a[i] = a[i - 2] + a[i - 1];
        }
        WriteLine( a[k] );
        return;
    }
}
