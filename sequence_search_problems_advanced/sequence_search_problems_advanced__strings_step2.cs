// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int o = 0;
        char[] s = ReadLine().ToCharArray();
        string t = ReadLine();

        foreach( int i in Range( 0, s.Length - t.Length + 1 ) ) {
            if( string.Compare( string.Join( "", s.Skip( i ).Take( t.Length ) ), t, System.StringComparison.Ordinal ) == 0 ) {
                o++;
            }
        }
        WriteLine( o );
        return;
    }
}
