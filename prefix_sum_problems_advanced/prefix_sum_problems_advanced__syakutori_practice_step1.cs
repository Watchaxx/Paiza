// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        int o = n[0] + 1;
        int r = 0;
        int s = 0;

        foreach( int l in Range( 0, n[0] ) ) {
            while( r < n[0] && s <= n[1] ) {
                s += a[r];
                r++;
            }
            if( s <= n[1] ) {
                break;
            }
            o = System.Math.Min( o, r - l );
            s -= a[l];
        }
        WriteLine( o == n[0] + 1 ? -1 : o );
        return;
    }
}
