// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int o = 0;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        string[] s = new string[n[0]];

        foreach( int i in Range( 0, n[0] ) ) {
            s[i] = ReadLine();
        }
        foreach( int i in Range( 0, System.Math.Min( s[0].Length, s[1].Length ) ) ) {
            o++;
            if( s[0][i] != s[1][i] ) {
                break;
            }
        }
        WriteLine( s[n[1] - 1].Substring( 0, o ) );
        return;
    }
}
