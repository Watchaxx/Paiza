// 実行時間 90ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        byte[] a = new byte[n];
        int[] p = new int[n];
        int o = 1;

        foreach( int i in Range( 0, n ) ) {
            a[i] = byte.Parse( ReadLine() );
        }
        p[0] = 1;
        foreach( int i in Range( 1, n - 1 ) ) {
            p[i] = a[i] <= a[i - 1] ? p[i - 1] + 1 : 1;
            o = System.Math.Max( o, p[i] );
        }
        WriteLine( o );
        return;
    }
}
