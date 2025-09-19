// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] nkr = ReadLine().Split().Select( int.Parse ).ToArray();
        int[][] g = new int[nkr[0] + 1][];

        foreach( int i in Range( 1, nkr[0] ) ) {
            g[i] = new int[2];
        }
        foreach( int _ in Range( 0, nkr[0] - 1 ) ) {
            string[] s = ReadLine().Split();

            if( s[2][0] == 'L' ) {
                g[int.Parse( s[0] )][0] = int.Parse( s[1] );
            } else if( s[2][0] == 'R' ) {
                g[int.Parse( s[0] )][1] = int.Parse( s[1] );
            }
        }
        foreach( int _ in Range( 0, nkr[1] ) ) {
            string[] s = ReadLine().Split();
            int[] i = g[int.Parse( s[0] )];

            if( s[1][0] == 'L' ) {
                // C# 9 以降は $"" 不要
                WriteLine( i[0] != 0 ? $"{i[0]}" : "" );
            } else if( s[1][0] == 'R' ) {
                WriteLine( i[1] != 0 ? $"{i[1]}" : "" );
            }
        }
        return;
    }
}
