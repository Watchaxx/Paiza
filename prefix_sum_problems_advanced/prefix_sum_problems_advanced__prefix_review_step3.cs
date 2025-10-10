// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        string[] c = ReadLine().Split();
        char[] s = ReadLine().ToCharArray();
        int[] n = c.Take( 3 ).Select( int.Parse ).ToArray();
        int[] a = new int[n[0] + 1];

        foreach( int i in Range( 0, n[0] ) ) {
            a[i + 1] = s[i] == c[3][0] ? a[i] + 1 : a[i];
        }
        WriteLine( a[n[2]] - a[n[1] - 1] );
        return;
    }
}
