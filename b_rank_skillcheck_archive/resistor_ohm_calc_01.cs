// 実行時間 20ms
using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );

        WriteLine( n );
        for( int _ = 0; _ < n; _++ ) {
            string[] s = ReadLine().Split();

            WriteLine( $"{s[0]} {int.Parse( s[1] )}" );
        }
        WriteLine( int.Parse( ReadLine() ) );
        WriteLine( ReadLine() );
        return;
    }
}
