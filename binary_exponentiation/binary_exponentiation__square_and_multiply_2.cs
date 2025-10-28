// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();

        if( 0 < n[1] ) {
            n[0] >>= n[1] - 1;
        }
        WriteLine( ( n[0] & 1 ) != 0 );
        return;
    }
}
