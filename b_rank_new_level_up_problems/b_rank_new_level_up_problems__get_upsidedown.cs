// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] dx = { 0, 0, -1, 0, 1 };
        int[] dy = { -1, 1, 0, 0, 0 };
        int[] hw = ReadLine().Split().Select( int.Parse ).ToArray();
        string[] s = new string[hw[0]];

        foreach( int i in Range( 0, hw[0] ) ) {
            s[i] = ReadLine();
        }

        int[] yx = ReadLine().Split().Select( int.Parse ).ToArray();

        foreach( int i in Range( 0, 5 ) ) {
            int cx = yx[1] + dx[i];
            int cy = yx[0] + dy[i];

            if( cx < 0 || hw[1] <= cx || cy < 0 || hw[0] <= cy ) {
                continue;
            }

            char[] c = s[cy].ToCharArray();

            c[cx] = c[cx] == '.' ? '#' : '.';
            s[cy] = string.Join( "", c );
        }
        WriteLine( string.Join( System.Environment.NewLine, s ) );
        return;
    }
}
