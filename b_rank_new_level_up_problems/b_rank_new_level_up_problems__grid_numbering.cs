// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int c = 0;
        int x = 0;
        int y = 0;
        int[] hwd = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        int[,] m = new int[hwd[0], hwd[1]];

        while( c < hwd[0] * hwd[1] ) {
            if( 0 <= y && y < hwd[0] && 0 <= x && x < hwd[1] ) {
                m[y, x] = ++c;
            }
            switch( hwd[2] ) {
            case 1:
                y--;
                x++;
                if( y < 0 ) {
                    y = y + x + 1;
                    x = 0;
                }
                break;
            case 2:
                x++;
                if( x == hwd[1] ) {
                    y++;
                    x = 0;
                }
                break;
            case 3:
                y++;
                if( y == hwd[0] ) {
                    y = 0;
                    x++;
                }
                break;
            case 4:
                y++;
                x--;
                if( x < 0 ) {
                    x = y + x + 1;
                    y = 0;
                }
                break;
            }
        }
        foreach( int i in Range( 0, hwd[0] ) ) {
            int[] t = new int[hwd[1]];

            foreach( int j in Range( 0, hwd[1] ) ) {
                t[j] = m[i, j];
            }
            WriteLine( string.Join( " ", t ) );
        }
        return;
    }
}
