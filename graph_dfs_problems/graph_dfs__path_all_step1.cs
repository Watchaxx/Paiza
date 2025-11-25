// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();

        foreach( int i in Range( 1, n[0] ) ) {
            if( i != n[1] ) {
                ReadLine();
                ReadLine();
            } else {
                ReadLine();
                WriteLine( ReadLine() );
            }
        }
        return;
    }
}
