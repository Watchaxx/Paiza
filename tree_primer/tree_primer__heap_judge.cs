// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();

        foreach( int _ in Range( 0, n[0] - 1 ) ) {
            int[] a = ReadLine().Split().Select( int.Parse ).ToArray();

            if( a[0] < a[1] ) {
                WriteLine( "NO" );
                return;
            }
        }
        WriteLine( "YES" );
        return;
    }
}
