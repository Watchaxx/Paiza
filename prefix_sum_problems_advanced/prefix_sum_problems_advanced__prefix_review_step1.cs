// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] b = new int[n[0] + 1];

        foreach( int i in Range( 0, n[0] ) ) {
            b[i + 1] = b[i] + a[i];
        }
        WriteLine( b[n[2] + 1] - b[n[1]] );
        return;
    }
}
