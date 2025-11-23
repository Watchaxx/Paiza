// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int a = 0;
        int b = 0;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();

        foreach( int _ in Range( 0, n[1] ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            if( t[0] == n[2] ) {
                a++;
            } else if( t[1] == n[2] ) {
                b++;
            }
        }
        WriteLine( $"{a} {b}" );
        return;
    }
}
