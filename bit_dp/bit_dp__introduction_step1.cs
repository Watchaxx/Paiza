// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int s = 0;

        foreach( int _ in Range( 0, int.Parse( ReadLine() ) ) ) {
            int[] q = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            if( q[0] == 0 ) {
                s |= 1 << q[1];
            } else if( q[0] == 1 ) {
                s -= 1 << q[1];
            }
            WriteLine( System.Convert.ToString( s, 2 ).PadLeft( 10, '0' ) );
        }
        return;
    }
}
