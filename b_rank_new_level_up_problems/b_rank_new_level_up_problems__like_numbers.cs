// 実行時間 20ms
using static System.Console;

internal class Program
{
    static void Main()
    {
        int ld = 0;
        char[] s = ReadLine().ToCharArray();

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        for( int i = s.Length - 1; 0 <= i; i-- ) {
            if( char.IsDigit( s[i] ) == true ) {
                ld = i;
                break;
            }
        }
        for( int i = 0; i < s.Length; i++ ) {
            if( char.IsDigit( s[i] ) != true ) {
                continue;
            }
            WriteLine( s[i] );

            var l = new System.Collections.Generic.List<char>( s.Length ) { s[i] };

            for( int j = i + 1; j <= ld; j++ ) {
                l.Add( s[j] );
                if( char.IsDigit( s[j] ) == true ) {
                    WriteLine( string.Join( "", l ) );
                }
            }
        }
        Out.Flush();
        return;
    }
}
