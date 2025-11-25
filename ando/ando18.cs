// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        string s = ReadLine();
        WriteLine( Range( 0, s.Length - 2 ).Count( x => Str( s.Skip( x ).Take( 3 ) ) ) );
        return;
    }

    static bool Str( System.Collections.Generic.IEnumerable<char> c )
    {
        return string.Compare( string.Concat( c ), "cat", System.StringComparison.Ordinal ) == 0;
    }
}
