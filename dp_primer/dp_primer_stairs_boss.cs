// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] nabc = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = new int[31];

        a[0] = 1;
        foreach( int i in Range( 1, nabc[0] ) ) {
            a[i] = 0;
            if( nabc[1] <= i ) {
                a[i] += a[i - nabc[1]];
            }
            if( nabc[2] <= i ) {
                a[i] += a[i - nabc[2]];
            }
            if( nabc[3] <= i ) {
                a[i] += a[i - nabc[3]];
            }
        }
        WriteLine( a[nabc[0]] );
        return;
    }
}
