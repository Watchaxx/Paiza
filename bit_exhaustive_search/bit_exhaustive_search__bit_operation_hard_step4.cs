// 実行時間 10ms
using static System.Console;

internal class Program
{
    static void Main()
    {
        foreach( char c in ReadLine() ) {
            Write( c == '0' ? 1 : 0 );
        }
        WriteLine();
        return;
    }
}
