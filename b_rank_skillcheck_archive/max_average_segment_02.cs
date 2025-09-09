// 実行時間 160ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] b = new int[n[0] - 1];

        foreach( int i in Range( 0, n[0] - 1 ) ) {
            b[i] = a[i] + a[i + 1];
        }
        WriteLine( string.Join( " ", b ) );
        return;
    }
}
