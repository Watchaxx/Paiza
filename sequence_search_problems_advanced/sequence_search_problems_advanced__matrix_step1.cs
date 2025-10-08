// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int o = 0;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();

        foreach( int _ in Range( 0, n[0] ) ) {
            o += ReadLine().Split().Select( int.Parse ).Count( x => x == n[2] );
        }
        WriteLine( o );
        return;
    }
}
