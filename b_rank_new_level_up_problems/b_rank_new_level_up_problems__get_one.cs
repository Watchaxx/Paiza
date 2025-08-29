// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] hw = ReadLine().Split().Select( int.Parse ).ToArray();
        string[] s = new string[hw[0]];

        foreach( int i in Range( 0, hw[0] ) ) {
            s[i] = ReadLine();
        }

        int[] yx = ReadLine().Split().Select( int.Parse ).ToArray();
        char[] c = s[yx[0]].ToCharArray();

        c[yx[1]] = c[yx[1]] == '.' ? '#' : '.';
        s[yx[0]] = string.Join( "", c );
        WriteLine( string.Join( System.Environment.NewLine, s ) );
        return;
    }
}
