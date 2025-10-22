// 実行時間 30ms
using static System.Console;
using static System.Linq.Enumerable;
using Lst = System.Collections.Generic.List<string>;

internal class Program
{
    static void Main()
    {
        int q = int.Parse( ReadLine() );
        var h = new Lst[111];

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Range( 0, 111 ) ) {
            h[i] = new Lst();
        }
        foreach( int _ in Range( 0, q ) ) {
            string[] s = ReadLine().Split();

            if( s[0][0] == '1' ) {
                h[Hash( s[1] )].Add( s[1] );
            } else if( s[0][0] == '2' ) {
                int i = int.Parse( s[1] ) - 1;

                WriteLine( 0 < h[i].Count ? string.Join( " ", h[i] ) : "-1" );
            } else if( s[0][0] == '3' ) {
                h[Hash( s[1] )].Remove( s[1] );
            }
        }
        Out.Flush();
        return;
    }

    static int Hash( string s )
    {
        int h = 0;

        foreach( int i in Range( 0, s.Length ) ) {
            h += s[i] * (int)System.Math.Pow( 7d, i + 1d );
        }
        return h % 100;
    }
}
