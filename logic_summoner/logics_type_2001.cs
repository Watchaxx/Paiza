using static System.Console;

internal class Program
{
    static void Main()
    {
        char p = 'b';
        int n = 0;
        string s = ReadLine();
        var l = new System.Collections.Generic.List<int>();

        foreach( char c in s ) {
            if( c == p ) {
                n++;
            } else {
                l.Add( n );
                n = 1;
                p = c;
            }
        }
        l.Add( n );
        WriteLine( string.Join( " ", l ) );
        return;
    }
}
