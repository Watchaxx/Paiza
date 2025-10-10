// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int o = 0;
        int r = 0;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();

        foreach( int l in Range( 0, n[0] ) ) {
            while( r < n[0] && ( l == r || a[r - 1] <= a[r] ) ) {
                r++;
            }
            o += r - l;
        }
        WriteLine( o );
        return;
    }
}
