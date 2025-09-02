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
        }
        for( int i = 0; i < 5; i++ ) {
            c[i] = s[i][i];
        }
        if( Judge( c, out char r ) == true ) {
            WriteLine( r );
            return;
        }
        for( int i = 0; i < 5; i++ ) {
            c[i] = s[i][4 - i];
        }
        if( Judge( c, out r ) == true ) {
            WriteLine( r );
            return;
        }
        WriteLine( r );
        return;
    }

    static bool Judge( char[] c, out char r )
    {
        var sc = System.StringComparison.Ordinal;

        r = 'D';
        if( string.Compare( string.Join( "", c ), "OOOOO", sc ) == 0 ) {
            r = 'O';
            return true;
        } else if( string.Compare( string.Join( "", c ), "XXXXX", sc ) == 0 ) {
            r = 'X';
            return true;
        }
        return false;
    }
}
