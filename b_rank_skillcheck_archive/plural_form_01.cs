// 実行時間 10ms
using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );

        for( int _ = 0; _ < n; _++ ) {
            WriteLine( $"{ReadLine()}s" );
        }
        return;
    }
}
