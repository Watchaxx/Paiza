// 実行時間 30ms
using static System.Console;

internal class Program
{
    static void Main()
    {
        const string p = "paiza";
        char[] s = ReadLine().ToCharArray();

        if( string.Join( "", s ).Contains( p ) == true ) {
            WriteLine( p );
            return;
        }
        foreach( int i in System.Linq.Enumerable.Range( 0, s.Length ) ) {
            if( s[i] == '4' || s[i] == '@' ) {
                s[i] = 'a';
            } else if( s[i] == '1' || s[i] == '!' ) {
                s[i] = 'i';
            } else if( s[i] == '2' ) {
                s[i] = 'z';
            }
        }
        WriteLine( string.Join( "", s ).Contains( p ) ? "leet" : "nothing" );
        return;
    }
}
