// 実行時間 20ms
using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int o = 0;
        var d = new System.Collections.Generic.Dictionary<char, int>( n );

        for( int _ = 0; _ < n; ++ ) {
            string[] s = ReadLine().Split();

            d[s[0][0]] = int.Parse( s[1] );
        }
        ReadLine();
        foreach( string s in ReadLine().Split() ) {
            o += d[s[0]];
        }
        WriteLine( o );
        return;
    }
}
