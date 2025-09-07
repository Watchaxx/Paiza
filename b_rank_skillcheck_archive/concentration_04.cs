// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] hwn = ReadLine().Split().Select( int.Parse ).ToArray();
        int[][] t = new int[hwn[0]][];

        foreach( int i in Range( 0, hwn[0] ) ) {
            t[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }

        int p = int.Parse( ReadLine() );
        int[] ab = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

        if( t[ab[0]][ab[1]] == t[ab[2]][ab[3]] ) {
            WriteLine( $"YES{System.Environment.NewLine}{p}" );
        } else {
            WriteLine( "NO" );
            WriteLine( hwn[2] < p + 1 ? 1 : p + 1 );
        }
        return;
    }
}
