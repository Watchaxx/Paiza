// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        string s = ReadLine();
        WriteLine( string.Compare( s, string.Join( "", s.Reverse() ), System.StringComparison.Ordinal ) == 0 ? "Yes" : "No" );
        return;
    }
}
