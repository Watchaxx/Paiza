// 実行時間 10ms
using static System.Console;

class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        var l = new System.Collections.Generic.List<int>();

        while( 0 < n ) {
            n = ( n & 1 ) != 0 ? n - 1 : n - 2;
            n >>= 1;
            l.Add( n );
        }
        WriteLine( string.Join( " ", l ) );
        return;
    }
}
