// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] s = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = new int[s[2]];

        a[0] = s[0];
        foreach( int i in Range( 1, s[2] - 1 ) ) {
            a[i] = a[i - 1] + s[1];
        }
        WriteLine( a[s[2] - 1] );
        return;
    }
}
