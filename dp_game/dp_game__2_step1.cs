// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[][] s = new int[4][];

        foreach( int i in Range( 0, 4 ) ) {
            s[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        foreach( int i in Range( 0, 16 ) ) {
            if( s[i / 4][i % 4] != 1 ) {
                continue;
            }
            foreach( int j in Range( i + 1, 16 - i - 1 ) ) {
                if( s[j / 4][j % 4] != 1 ) {
                    continue;
                }
                if( ( i / 4 == j / 4 ) || ( j % 4 <= i % 4 ) ) {
                    continue;
                }
                if( ( s[i / 4][j % 4] != 1 ) || ( s[j / 4][i % 4] != 1 ) ) {
                    continue;
                }
                WriteLine( "Yes" );
                return;
            }
        }
        WriteLine( "No" );
        return;
    }
}
