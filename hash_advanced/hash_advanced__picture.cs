// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int h = 0;

        foreach( int i in Range( 1, 6 ) ) {
            char[] s = ReadLine().ToCharArray();

            foreach( int j in Range( 0, 6 ).Where( x => s[x] == '#' ) ) {
                h += i * i * ( j + 1 );
            }
        }
        WriteLine( h % 100 );
        return;
    }
}
