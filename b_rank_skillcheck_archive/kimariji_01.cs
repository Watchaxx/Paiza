// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        string[] s = new string[n[0]];

        foreach( int i in Range( 0, n[0] ) ) {
            s[i] = ReadLine();
        }
        WriteLine( s[n[1] - 1] );
        return;
    }
}
