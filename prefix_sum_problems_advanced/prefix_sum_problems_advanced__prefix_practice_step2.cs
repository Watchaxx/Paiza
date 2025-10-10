// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = new int[n[0]];
        int[] b = new int[n[0] + 1];
        string s = ReadLine();

        foreach( int i in Range( 0, n[0] ).Where( x => x + 2 < n[0] && s[x] == 'p' && s[x + 1] == 'i' && s[x + 2] == 'z' ) ) {
            a[i] = 1;
        }
        foreach( int i in Range( 0, n[0] ) ) {
            b[i + 1] = b[i] + a[i];
        }
        WriteLine( b[n[2] - 2] - b[n[1] - 1] );
        return;
    }
}
