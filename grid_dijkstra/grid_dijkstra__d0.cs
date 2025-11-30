// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int h = ReadLine().Split().Select( int.Parse ).ToArray()[0];
        int[][] t = new int[h][];

        foreach( int i in Range( 0, h ) ) {
            t[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        WriteLine( t[0][0] + t[0][1] + t[1][1] + t[1][2] + t[0][2] + t[0][1] );
        return;
    }
}
