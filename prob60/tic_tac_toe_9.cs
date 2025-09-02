// 実行時間 20ms
using static System.Console;

internal class Program
{
    static void Main()
    {
        char[] c = new char[5];
        string[] s = new string[5];

        for( int i = 0; i < 5; i++ ) {
            s[i] = ReadLine();
            if( Judge( s[i].ToCharArray() ) == true ) {
                return;
            }
        }
        for( int i = 0; i < 5; i++ ) {
            c = new char[5];
            for( int j = 0; j < 5; j++ ) {
                c[j] = s[j][i];
            }
            if( Judge( c ) == true ) {
                return;
            }
        }
        for( int i = 0; i < 5; i++ ) {
            c[i] = s[i][i];
        }
        if( Judge( c ) == true ) {
            return;
        }
        for( int i = 0; i < 5; i++ ) {
            c[i] = s[i][4 - i];
        }
        if( Judge( c ) == true ) {
            return;
        }
        WriteLine( 'D' );
        return;
    }

    static bool Judge( char[] c )
    {
        bool b = false;
        var sc = System.StringComparison.Ordinal;

        if( string.Compare( string.Join( "", c ), "OOOOO", sc ) == 0 ) {
            b = true;
            WriteLine( 'O' );
        } else if( string.Compare( string.Join( "", c ), "XXXXX", sc ) == 0 ) {
            b = true;
            WriteLine( 'X' );
        }
        return b;
    }
}
