// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        if( ReadLine().Split().Select( int.Parse ).ToArray()[0] == 0 ) {
            WriteLine( 0 );
            return;
        }
        WriteLine( new int[] { ReadLine().Split().Select( int.Parse ).Sum(), 0 }.Max() );
        return;
    }
}
