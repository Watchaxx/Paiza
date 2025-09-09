// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;
using static System.Math;

internal class Program
{
    static void Main()
    {
        int o = 0;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        string[] s = new string[n[0]];

        n[1]--;
        foreach( int i in Range( 0, n[0] ) ) {
            s[i] = ReadLine();
        }
        if( n[0] == 1 ) {
            WriteLine( s[0][0] );
            return;
        }
        foreach( int i in Range( 0, n[0] ) ) {
            if( i == n[1] ) {
                continue;
            }

            int t = 0;

            foreach( int j in Range( 0, Min( s[n[1]].Length, s[i].Length ) ) ) {
                t++;
                if( s[i][j] != s[n[1]][j] ) {
                    break;
                }
            }
            o = Max( o, t );
        }
        WriteLine( s[n[1]].Substring( 0, o ) );
        return;
    }
}
