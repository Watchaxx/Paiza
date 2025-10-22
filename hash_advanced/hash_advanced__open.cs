// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int q = int.Parse( ReadLine() );
        string[] h = new string[1010];

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int _ in Range( 0, q ) ) {
            string[] s = ReadLine().Split();

            if( s[0][0] == '1' ) {
                int i = Hash( s[1] );

                while( h[i] != null ) {
                    i = ( i + 1 ) % 1000;
                }
                h[i] = s[1];
            } else if( s[0][0] == '2' ) {
                int i = System.Array.IndexOf( h, s[1] );

                WriteLine( 0 <= i ? i + 1 : -1 );
            }
        }
        Out.Flush();
        return;
    }

    static int Hash( string s )
    {
        ulong h = 0;

        foreach( int i in Range( 0, s.Length ) ) {
            h += s[i] * (ulong)System.Math.Pow( 997d, i + 1d );
        }
        return (int)( h % 1000ul );
    }
}
