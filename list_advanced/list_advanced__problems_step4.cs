// 実行時間 70ms
using static System.Console;

internal class Program
{
    static void Main()
    {
        ReadLine();
        int c = 0;
        string[] k = ReadLine().Split();
        var l = new System.Collections.Generic.List<char>();

        foreach( string s in k ) {
            switch( s ) {
            case "Left":
                c--;
                if( c < 0 ) {
                    c = 0;
                }
                break;
            case "Right":
                c++;
                if( l.Count < c ) {
                    c = l.Count;
                }
                break;
            case "Delete":
                c--;
                if( 0 <= c ) {
                    l.RemoveAt( c );
                } else {
                    c = 0;
                }
                break;
            default:
                l.Insert( c, s[0] );
                c++;
                break;
            }
        }
        WriteLine( string.Join( " ", l ) );
        return;
    }
}
