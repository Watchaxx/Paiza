// 実行時間 50ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int o = 0;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();

        foreach( int i in Range( 0, n[2] * n[0] ) ) {
            o += ReadLine().Split().Select( int.Parse ).Count( x => x == n[3] );
        }
        WriteLine( o );
        return;
    }
}
