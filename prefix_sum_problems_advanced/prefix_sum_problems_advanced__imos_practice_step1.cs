// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int o = 0;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = new int[n[0] + 1];
        int[] b = new int[n[0] + 1];

        foreach( int _ in Range( 0, n[1] ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            a[t[0] - 1]++;
            a[t[1]]--;
        }
        foreach( int i in Range( 0, n[0] ) ) {
            b[i + 1] = b[i] + a[i];
            if( b[i + 1] % 2 != 0 ) {
                o++;
            }
        }
        WriteLine( o );
        return;
    }
}
