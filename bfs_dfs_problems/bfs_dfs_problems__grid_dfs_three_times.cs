// 実行時間 20ms
using static System.Console;

internal class Program
{
    static int h = 0;
    static int w = 0;

    static void Main()
    {
        int[] hwyx = System.Array.ConvertAll( ReadLine().Split(), int.Parse );

        h = hwyx[0];
        w = hwyx[1];
        Dfs( 0, hwyx[2], hwyx[3] );
        return;
    }

    static void Dfs( int i, int y, int x )
    {
        if( i == 3 ) {
            WriteLine( $"{y} {x}" );
            return;
        }
        if( 0 <= y - 1 ) {
            Dfs( i + 1, y - 1, x );
        }
        if( x + 1 < w ) {
            Dfs( i + 1, y, x + 1 );
        }
        if( y + 1 < h ) {
            Dfs( i + 1, y + 1, x );
        }
        if( 0 <= x - 1 ) {
            Dfs( i + 1, y, x - 1 );
        }
        return;
    }
}
