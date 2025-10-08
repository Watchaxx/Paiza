// 実行時間 730ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        string[] s = new string[n];

        foreach( int i in Range( 0, n ) ) {
            s[i] = ReadLine();
        }
        WriteLine( string.Join( System.Environment.NewLine, s.OrderBy( x => x.Length ).ThenBy( x => x ) ) );
        return;
    }
}
