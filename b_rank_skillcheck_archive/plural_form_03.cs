// 実行時間 20ms
using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );

        for( int _ = 0; _ < n; _++ ) {
            string a = ReadLine();

            if( a.EndsWith( "f" ) ) {
                WriteLine( $"{a.Substring( 0, a.Length - 1 )}ves" );
            } else if( a.EndsWith( "fe" ) ) {
                WriteLine( $"{a.Substring( 0, a.Length - 2 )}ves" );
            } else {
                WriteLine( $"{a}s" );
            }
        }
        return;
    }
}
