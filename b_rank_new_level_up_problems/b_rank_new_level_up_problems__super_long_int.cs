// 実行時間 40ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        char[] x = ReadLine().ToCharArray();
        int h = 0;

        foreach( int i in Range( 0, 4 ) ) {
            char[] t = new char[8];

            foreach( int j in Range( 0, 8 ) ) {
                t[j] = x[8 * i + j];
            }
            h += int.Parse( string.Join( "", t ) );
        }
        WriteLine( h );
        return;
    }
}
