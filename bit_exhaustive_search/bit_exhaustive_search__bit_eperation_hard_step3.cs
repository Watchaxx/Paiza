// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        var k = ReadLine().Split().Select( int.Parse );

        foreach( int _ in Range( 0, int.Parse( ReadLine() ) ) ) {
            int[] q = ReadLine().Split().Select( int.Parse ).ToArray();

            if( q[0] == 1 ) {
                WriteLine( k.Any( x => ( ( q[1] >> x - 1 ) & 1 ) == 1 ) ? "Yes" : "No" );
            } else if( q[0] == 2 ) {
                WriteLine( k.All( x => ( ( q[1] >> x - 1 ) & 1 ) == 1 ) ? "Yes" : "No" );
            }
        }
        return;
    }
}
