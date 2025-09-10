// 実行時間 20ms
using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );

        for( int _ = 0; _ < n; _++ ) {
            string a = ReadLine();

            if( a.EndsWith( "y" ) ) {
                if( !a.EndsWith( "ay" ) && !a.EndsWith( "iy" ) && !a.EndsWith( "uy" ) && !a.EndsWith( "ey" ) && !a.EndsWith( "oy" ) ) {
                    WriteLine( $"{a.Substring( 0, a.Length - 1 )}ies" );
                } else {
                    WriteLine( $"{a}s" );
                }
            } else {
                WriteLine( $"{a}s" );
            }
        }
        return;
    }
}
