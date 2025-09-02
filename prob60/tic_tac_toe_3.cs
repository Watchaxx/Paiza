// 実行時間 10ms
using static System.Console;

internal class Program
{
    static void Main()
    {
        string[] s = new string[5];
        var sc = System.StringComparison.Ordinal;

        for( int i = 0; i < 5; i++ ) {
            s[i] = ReadLine();
        }
        for( int i = 0; i < 5; i++ ) {
            char[] c = new char[5];

            for( int j = 0; j < 5; j++ ) {
                c[j] = s[j][i];
            }
            if( string.Compare( string.Join( "", c ), "OOOOO", sc ) == 0 ) {
                WriteLine( 'O' );
                return;
            } else if( string.Compare( string.Join( "", c ), "XXXXX", sc ) == 0 ) {
                WriteLine( 'X' );
                return;
            }
        }
        WriteLine( 'D' );
        return;
    }
}
