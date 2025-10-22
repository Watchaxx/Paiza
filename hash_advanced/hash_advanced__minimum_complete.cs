// 実行時間 10ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int o = 0;
        string s = ReadLine();

        foreach( int i in Range( 0, 6 ) ) {
            o += ( s[i] - 'a' ) * (int)System.Math.Pow( 6d, 5d - i );
        }
        WriteLine( o );
        return;
    }
}
