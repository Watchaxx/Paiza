// 実行時間 20ms
using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int a = int.Parse( ReadLine() ) - 1;
        bool c = string.Compare( ReadLine(), "CW", System.StringComparison.Ordinal ) == 0;
        int b = int.Parse( ReadLine() );
        bool[] z = new bool[n];
        var l = new System.Collections.Generic.List<int>( n );

        z[a] = true;
        l.Add( a + 1 );
        while( true ) {
            for( int _ = 0; _ < b; ) {
                if( c == true ) {
                    a = a + 1 < n ? a + 1 : 0;
                } else {
                    a = 0 <= a - 1 ? a - 1 : n - 1;
                }
                if( z[a] != true ) {
                    _++;
                }
            }
            l.Add( a + 1 );
            z[a] = true;
            if( l.Count == n ) {
                break;
            }
        }
        WriteLine( string.Join( " ", l ) );
        return;
    }
}
