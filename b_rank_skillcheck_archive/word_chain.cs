// 実行時間 30ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] nkm = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        bool[] p = Repeat( true, nkm[0] ).ToArray();
        char l = char.MinValue;
        int c = 0;
        int o = nkm[0];
        var d = new System.Collections.Generic.List<string>( nkm[1] );

        foreach( int _ in Range( 0, nkm[1] ) ) {
            d.Add( ReadLine() );
        }
        foreach( int _ in Range( 0, nkm[2] ) ) {
            string s = ReadLine();

            while( p[c % nkm[0]] != true ) {
                c++;
            }
            c %= nkm[0];
            if( d.Contains( s ) == true && ( l == char.MinValue || l == s[0] ) && s[s.Length - 1] != 'z' ) {
                l = s[s.Length - 1];
            } else {
                l = char.MinValue;
                o--;
                p[c] = false;
            }
            if( d.Contains( s ) == true ) {
                d.Remove( s );
            }
            c++;
        }
        WriteLine( o );
        foreach( int i in Range( 0, nkm[0] ).Where( i => p[i] == true ) ) {
            WriteLine( i + 1 );
        }
        return;
    }
}
