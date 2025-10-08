// 実行時間 20ms
using static System.Console;
using static System.Convert;

internal class Program
{
    static void Main()
    {
        WriteLine( Func() );
        return;
    }

    static string Func()
    {
        int k = int.Parse( ReadLine() );
        var r = System.Linq.Enumerable.Range( 0, 26 );

        foreach( int i in r ) {
            foreach( int j in r ) {
                foreach( int l in r ) {
                    if( 26 * 26 * i + 26 * j + l == k - 1 ) {
                        return $"{ToChar( 'a' + i )}{ToChar( 'a' + j )}{ToChar( 'a' + l )}";
                    }
                }
            }
        }
        return string.Empty;
    }
}
