// 実行時間 20ms
using static System.Console;

internal class Program
{
    static void Main()
    {
        int dx = 1;
        int dy = 0;
        int n = int.Parse( ReadLine() );

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        for( int _ = 0; _ < n; _++ ) {
            char c = ReadLine()[0];

            if( ( dx == 0 && dy == -1 && c == '/' ) || ( dx == 0 && dy == 1 && c == '\\' ) ) {
                dx = 1;
                dy = 0;
            } else if( ( dx == 0 && dy == 1 && c == '/' ) || ( dx == 0 && dy == -1 && c == '\\' ) ) {
                dx = -1;
                dy = 0;
            } else if( ( dx == 1 && dy == 0 && c == '/' ) || ( dx == -1 && dy == 0 && c == '\\' ) ) {
                dx = 0;
                dy = -1;
            } else if( ( dx == -1 && dy == 0 && c == '/' ) || ( dx == 1 && dy == 0 && c == '\\' ) ) {
                dx = 0;
                dy = 1;
            }
            WriteLine( $"{dx} {dy}" );
        }
        Out.Flush();
        return;
    }
}
