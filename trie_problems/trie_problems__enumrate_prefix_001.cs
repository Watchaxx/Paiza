// 実行時間 40ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        string s = ReadLine();
        WriteLine( string.Join( System.Environment.NewLine,
            Range( 1, s.Length ).Select( x => s.Substring( 0, x ) ) ) );
        return;
    }
}
