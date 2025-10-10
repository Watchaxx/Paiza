// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] q = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = new int[1001];
        int[] b = new int[1001];

        foreach( int _ in Range( 0, q[0] ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            a[t[0] - 1] += t[2];
            a[t[1]] -= t[2];
        }
        foreach( int i in Range( 0, q[0] ) ) {
            b[i + 1] = b[i] + a[i];
            if( q[1] <= b[i + 1] ) {
                WriteLine( "No" );
                return;
            }
        }
        WriteLine( "Yes" );
        return;
    }
}
