// 実行時間 10ms
using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        string s = ReadLine();

        if( n < s.Length ) {
            WriteLine( $"{s[n - 1]} {s[n]}" );
        }
        return;
    }
}
