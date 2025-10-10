// 実行時間 30ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        var s = new System.Collections.Generic.Stack<int>();

        foreach( int _ in Range( 0, int.Parse( ReadLine() ) ) ) {
            s.Push( int.Parse( ReadLine() ) );
        }
        foreach( int _ in Range( 0, int.Parse( ReadLine() ) ) ) {
            string[] t = ReadLine().Split();
            var c = System.StringComparison.Ordinal;

            if( string.Compare( t[0], "rent", c ) == 0 ) {
                s.Pop();
            } else if( string.Compare( t[0], "return", c ) == 0 ) {
                s.Push( int.Parse( t[1] ) );
            }
        }
        WriteLine( string.Join( System.Environment.NewLine, s ) );
        return;
    }
}
