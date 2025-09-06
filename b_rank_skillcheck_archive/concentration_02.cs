// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] hwn = ReadLine().Split().Select( int.Parse ).ToArray();

        foreach( int _ in Range( 0, hwn[0] ) ) {
            WriteLine( ReadLine() );
        }
        return;
    }
}
