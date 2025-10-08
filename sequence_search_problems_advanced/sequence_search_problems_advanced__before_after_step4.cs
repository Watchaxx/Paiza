// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] b = ReadLine().Split().Select( int.Parse ).ToArray();
        int o = -2;

        foreach( int i in Range( 0, n[0] - n[1] + 1 ) ) {
            bool s = true;

            foreach( int _ in Range( 0, n[1] ).Where( j => a[i + j] != b[j] ) ) {
                s = false;
                break;
            }
            if( s == true ) {
                o = i;
                break;
            }
        }
        WriteLine( o + 1 );
        return;
    }
}
