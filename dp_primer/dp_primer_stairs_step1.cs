// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] nab = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = new int[41];

        a[0] = 1;
        foreach( int i in Range( 1, nab[0] ) ) {
            a[i] = 0;
            if( nab[1] <= i ) {
                a[i] += a[i - nab[1]];
            }
            if( nab[2] <= i ) {
                a[i] += a[i - nab[2]];
            }
        }
        WriteLine( a[nab[0]] );
        return;
    }
}
