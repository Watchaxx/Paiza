// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int dx = 1;
        int dy = 0;
        int o = 0;
        int px = -1;
        int py = 0;
        int[] hw = ReadLine().Split().Select( int.Parse ).ToArray();
        string[] s = new string[hw[0]];

        foreach( int i in Range( 0, hw[0] ) ) {
            s[i] = ReadLine();
        }
        while( true ) {
            px += dx;
            py += dy;
            if( px < 0 || hw[1] <= px || py < 0 || hw[0] <= py ) {
                break;
            }
            o++;
            if( ( dx == 0 && dy == -1 && s[py][px] == '/' ) || ( dx == 0 && dy == 1 && s[py][px] == '\\' ) ) {
                dx = 1;
                dy = 0;
            } else if( ( dx == 0 && dy == 1 && s[py][px] == '/' ) || ( dx == 0 && dy == -1 && s[py][px] == '\\' ) ) {
                dx = -1;
                dy = 0;
            } else if( ( dx == 1 && dy == 0 && s[py][px] == '/' ) || ( dx == -1 && dy == 0 && s[py][px] == '\\' ) ) {
                dx = 0;
                dy = -1;
            } else if( ( dx == -1 && dy == 0 && s[py][px] == '/' ) || ( dx == 1 && dy == 0 && s[py][px] == '\\' ) ) {
                dx = 0;
                dy = 1;
            }
        }
        WriteLine( o );
        return;
    }
}
